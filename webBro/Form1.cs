using System;
using System.Windows.Forms;
using NReadability;
using System.Speech.Synthesis;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using EyeXFramework;
using System.Drawing;
using System.Runtime.InteropServices;

namespace webBro
{
    public partial class webBro : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(MouseEvent dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public enum MouseEvent
        {
            MOUSEEVENTF_LEFTDOWN = 0x00000002,
            MOUSEEVENTF_LEFTUP = 0x00000004,
            MOUSEEVENTF_RIGHTDOWN = 0x00000008,
            MOUSEEVENTF_RIGHTUP = 0x00000016,
        }

        EyeXHost eyeXHost;
        EyePositionDataStream position;
        GazePointDataStream stream;
        const int delta = 10;
        bool leftClose;
        bool rightClose;
        int count = 0;
        const int stepCount = 50;
        public bool monochromeMode = false;
        public bool eyeMode = false;
        public Keys leftKey = Keys.Z;
        public Keys rightKey = Keys.X;

        delegate void StringParameterDelegate(string page);
        delegate void EmptyParameterDelegate();

        string textToSpeech = "";
        string pattern = @"<style>(.|\n|\r)+</style>";
        string defaultStyle;
        string monochromeStyle;
        string style;
        string errorMessage = "";

        bool playing = false;
        bool pause = false;
        bool articleModeOn = false;

        WebTranscodingInput input;
        string content;
        NReadabilityWebTranscoder transcoder = new NReadabilityWebTranscoder();
        SpeechSynthesizer synth = new SpeechSynthesizer();
        HtmlAgilityPack.HtmlDocument doc;
        ChromiumWebBrowser siteView;
        Thread getArticle = null;
        Regex rgx;

        public webBro()
        {
            InitializeComponent();
            InitBrowser();

            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakCompleted += synth_SpeakCompleted;

            rgx = new Regex(pattern);

            try
            {
                defaultStyle = File.ReadAllText(".\\Data\\style.css");
                monochromeStyle = File.ReadAllText(".\\Data\\monochrome.css");
                style = defaultStyle;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            eyeXHost = new EyeXHost();
            eyeXHost.Start();
            stream = eyeXHost.CreateGazePointDataStream(Tobii.EyeX.Framework.GazePointDataMode.Unfiltered);
            stream.Next += (s, e) =>
            {
                setPos((int)e.X, (int)e.Y);
            };
            position = eyeXHost.CreateEyePositionDataStream();
            position.Next += (s, e) =>
            {
                leftClose = e.LeftEye.X == 0 && e.LeftEye.Y == 0;
                rightClose = e.RightEye.X == 0 && e.RightEye.Y == 0;
            };
        }

        private void setPos(int x, int y)
        {
            if (pathTextBox.InvokeRequired) pathTextBox.Invoke((Action<int, int>)setPos, x, y);
            else
            {
                Point cp = new Point(x, y);
                if (cp.X >= 0 && cp.X < Width && cp.Y >= 0 && cp.Y < Height)
                {
                    if (Math.Abs(Cursor.Position.X - cp.X) > delta && Math.Abs(Cursor.Position.Y - cp.Y) > delta)
                    {
                        Cursor.Position = cp;
                        pathTextBox.BackColor = Color.FromArgb(170, 255, 0);
                    }

                    if (eyeMode)
                    {
                        if (leftClose && !rightClose)
                        {
                            pathTextBox.BackColor = Color.FromArgb(128, 0, 255);
                            if (++count > stepCount)
                            {
                                mouse_event(MouseEvent.MOUSEEVENTF_LEFTDOWN, cp.X, cp.Y, 0, 0);
                                mouse_event(MouseEvent.MOUSEEVENTF_LEFTUP, cp.X, cp.Y, 0, 0);
                                count = 0;
                            }
                        }
                        else if (!leftClose && rightClose)
                        {
                            pathTextBox.BackColor = Color.FromArgb(255, 0, 0);
                            if (++count > stepCount)
                            {
                                mouse_event(MouseEvent.MOUSEEVENTF_RIGHTDOWN, cp.X, cp.Y, 0, 0);
                                mouse_event(MouseEvent.MOUSEEVENTF_RIGHTUP, cp.X, cp.Y, 0, 0);
                                count = 0;
                            }
                        }
                    }
                }
            }
        }

        private void InitBrowser()
        {
            if (Cef.Initialize(new CefSettings()))
            {
                siteView = new ChromiumWebBrowser("about:blank")
                {
                    Dock = DockStyle.Fill,
                    Visible = true
                };
                siteView.AddressChanged += siteView_AddressChanged;
                viewPanel.Controls.Add(siteView);
            }
            else MessageBox.Show("It is impossible to load browser");
        }

        private void siteView_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                DisableArticleModeElements();
                StopPageLoading();

                pathTextBox.Text = e.Address;

                if (getArticle != null && getArticle.IsAlive) getArticle.Abort();

                getArticle = new Thread(ExtractArticleFromSite);
                getArticle.Start(e.Address);
            }));
        }

        private void ExtractArticleFromSite(object siteUrl)
        {
            string result = "";
            string url = (string)siteUrl;

            try
            {
                Invoke(new EmptyParameterDelegate(HideErrorPanel));
                Invoke(new EmptyParameterDelegate(ShowLoadingPanel));

                if (!url.Equals("about:blank"))
                {
                    input = new WebTranscodingInput(url);
                    content = transcoder.Transcode(input).ExtractedContent;
                    result = ReplaceStylesheet(content, style);
                    Invoke(new StringParameterDelegate(DisplayArticleInWebBrowser), new object[] { result });
                }
                Invoke(new EmptyParameterDelegate(HideLoadingPanel));
            }
            catch (ThreadAbortException threadExc)
            {
                Invoke(new EmptyParameterDelegate(StopPageLoading));
                Invoke(new EmptyParameterDelegate(HideLoadingPanel));
            }
            catch (Exception exc)
            {
                Invoke(new EmptyParameterDelegate(HideLoadingPanel));
                Invoke(new StringParameterDelegate(ShowErrorPanel), new object[] { exc.Message });
            }
        }

        private string ReplaceStylesheet(string content, string style)
        {
            string result;
            int startOfStylesheet = content.IndexOf("<style>") + 7;
            int endOfStilesheet = content.IndexOf("</style>");

            result = content.Remove(startOfStylesheet, endOfStilesheet - startOfStylesheet);
            return result.Insert(startOfStylesheet, style);
        }

        private void DisplayArticleInWebBrowser(string page)
        {
            articleView.Navigate("about:blank");
            if (articleView.Document != null) articleView.Document.Write(string.Empty);
            articleView.DocumentText = page;

            doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);
            try
            {
                if (doc.DocumentNode.SelectSingleNode("//div[@id='readInner']").InnerText.Length < 200)
                    ShowErrorPanel("Length of article is less than 200 symbols");
                else
                {
                    textToSpeech = doc.DocumentNode.SelectSingleNode("//div[@id='readInner']").InnerText;
                    EnableArticleModeElements();
                }
            }
            catch (NullReferenceException e)
            {
                ShowErrorPanel(e.Message);
            }
        }

        private void StopPageLoading()
        {
            if (articleView.IsBusy) articleView.Stop();
        }

        private void EnableArticleModeElements()
        {
            changeModeButton.Enabled = true;
            playPanel.Visible = true;
        }

        private void DisableArticleModeElements()
        {
            changeModeButton.Enabled = false;
            playPanel.Visible = false;
            stopButton.PerformClick();
        }

        private void ShowLoadingPanel()
        {
            loadingImage.Visible = true;
        }

        private void HideLoadingPanel()
        {
            loadingImage.Visible = false;
        }

        private void ShowErrorPanel(string message)
        {
            errorPanel.Visible = true;
            errorMessage = message;
        }

        private void HideErrorPanel()
        {
            errorPanel.Visible = false;
            errorMessage = "";
        }

        private void skip()
        {
            if (!pathTextBox.Text.Equals(""))
            {
                DisableArticleModeElements();
                siteView.Load(pathTextBox.Text);
            }
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            skip();
        }

        private void changeMode_Click(object sender, EventArgs e)
        {
            if (articleModeOn)
            {
                changeModeButton.Text = "Режим статьи";

                articleView.Visible = false;
                siteView.Visible = true;
                pathTextBox.Enabled = true;
                goToButton.Enabled = true;
                backButton.Enabled = true;
                forwardButton.Enabled = true;

                articleModeOn = false;
            }
            else
            {
                changeModeButton.Text = "Режим сайта";

                articleView.Visible = true;
                siteView.Visible = false;
                pathTextBox.Enabled = false;
                goToButton.Enabled = false;
                backButton.Enabled = false;
                forwardButton.Enabled = false;

                articleModeOn = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Speaking || synth.State == SynthesizerState.Paused)
                synth.SpeakAsyncCancelAll();

            synth.Resume();
            stopButton.Enabled = false;
            playing = false;
            pause = false;
            playPauseButton.Image = Properties.Resources.play_small;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            siteView.Back();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            siteView.Forward();
        }

        private void articleView_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!e.Url.Equals("about:blank"))
            {
                changeModeButton.PerformClick();
                siteView.Load(e.Url.OriginalString);
                e.Cancel = true;
            }
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (!playing && !pause)
            {
                synth.SpeakAsync(textToSpeech);
                stopButton.Enabled = true;
                playing = true;
                playPauseButton.Image = Properties.Resources.pause_small;
            }
            else if (playing && !pause)
            {
                synth.Pause();
                playPauseButton.Image = Properties.Resources.play_small;
                pause = true;
            }
            else if (playing && pause)
            {
                synth.Resume();
                playPauseButton.Image = Properties.Resources.pause_small;
                pause = false;
            }
        }

        private void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            stopButton.Enabled = false;
            playing = false;
            pause = false;
            playPauseButton.Image = Properties.Resources.play_small;
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(errorMessage);
        }

        public void updateImages()
        {
            if (monochromeMode) style = monochromeStyle;
            else style = defaultStyle;

            siteView.Reload();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("webBro v0.8.1", "About");
        }

        private void YandexButton_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = "https://yandex.ru/";
            skip();
        }

        private void GoogleButton_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = "https://www.youtube.com/";
            skip();
        }

        private void WikipediaButton_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = "https://ru.wikipedia.org/";
            skip();
        }

        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\osk.exe");
        }

        private void monochromeButton_Click(object sender, EventArgs e)
        {
            monochromeMode = !monochromeMode;
            if (monochromeMode)
            {
                style = monochromeStyle;
                monochromeButton.ForeColor = Color.Lime;
            }
            else
            {
                style = defaultStyle;
                monochromeButton.ForeColor = Color.Black;
            }

            siteView.Reload();
        }

        private void KeyMode_CheckedChanged(object sender, EventArgs e)
        {
            eyeMode = !keyMode.Checked;
        }

        private void LeftChar_KeyDown(object sender, KeyEventArgs e)
        {
            leftChar.Text = e.KeyCode.ToString();
            leftKey = e.KeyCode;
        }

        private void RightChar_KeyDown(object sender, KeyEventArgs e)
        {
            rightChar.Text = e.KeyCode.ToString();
            rightKey = e.KeyCode;
        }
    }
}
