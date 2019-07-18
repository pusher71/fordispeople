namespace webBro
{
    partial class webBro
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webBro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingImage = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.playPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.changeModeButton = new System.Windows.Forms.Button();
            this.goToButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.articleView = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rightChar = new System.Windows.Forms.TextBox();
            this.wikipediaButton = new System.Windows.Forms.Button();
            this.youtubeButton = new System.Windows.Forms.Button();
            this.yandexButton = new System.Windows.Forms.Button();
            this.monochromeButton = new System.Windows.Forms.Button();
            this.keyboardButton = new System.Windows.Forms.Button();
            this.keyMode = new System.Windows.Forms.CheckBox();
            this.leftChar = new System.Windows.Forms.TextBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.playPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.loadingImage);
            this.panel1.Controls.Add(this.errorPanel);
            this.panel1.Controls.Add(this.playPanel);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.changeModeButton);
            this.panel1.Controls.Add(this.goToButton);
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 78);
            this.panel1.TabIndex = 0;
            // 
            // loadingImage
            // 
            this.loadingImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingImage.Image = ((System.Drawing.Image)(resources.GetObject("loadingImage.Image")));
            this.loadingImage.Location = new System.Drawing.Point(913, 15);
            this.loadingImage.Name = "loadingImage";
            this.loadingImage.Size = new System.Drawing.Size(50, 50);
            this.loadingImage.TabIndex = 8;
            this.loadingImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPanel
            // 
            this.errorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorPanel.Controls.Add(this.errorButton);
            this.errorPanel.Controls.Add(this.errorMessageLabel);
            this.errorPanel.Location = new System.Drawing.Point(870, 5);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(135, 70);
            this.errorPanel.TabIndex = 9;
            this.errorPanel.Visible = false;
            // 
            // errorButton
            // 
            this.errorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorButton.Location = new System.Drawing.Point(8, 35);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(122, 30);
            this.errorButton.TabIndex = 2;
            this.errorButton.Text = "Просмотр";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Visible = false;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessageLabel.Location = new System.Drawing.Point(5, 5);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(125, 30);
            this.errorMessageLabel.TabIndex = 0;
            this.errorMessageLabel.Text = "Режим статьи недоступен";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playPanel
            // 
            this.playPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playPanel.Controls.Add(this.stopButton);
            this.playPanel.Controls.Add(this.playPauseButton);
            this.playPanel.Location = new System.Drawing.Point(870, 5);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(135, 70);
            this.playPanel.TabIndex = 7;
            this.playPanel.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Image = global::webBro.Properties.Resources.stop_small;
            this.stopButton.Location = new System.Drawing.Point(70, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 60);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playPauseButton.Image = global::webBro.Properties.Resources.play_small;
            this.playPauseButton.Location = new System.Drawing.Point(5, 5);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(60, 60);
            this.playPauseButton.TabIndex = 3;
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardButton.Location = new System.Drawing.Point(61, 15);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(50, 50);
            this.forwardButton.TabIndex = 4;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(5, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changeModeButton
            // 
            this.changeModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeModeButton.Enabled = false;
            this.changeModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeModeButton.Location = new System.Drawing.Point(794, 5);
            this.changeModeButton.Name = "changeModeButton";
            this.changeModeButton.Size = new System.Drawing.Size(70, 70);
            this.changeModeButton.TabIndex = 1;
            this.changeModeButton.Text = "Режим статьи";
            this.changeModeButton.UseVisualStyleBackColor = true;
            this.changeModeButton.Click += new System.EventHandler(this.changeMode_Click);
            // 
            // goToButton
            // 
            this.goToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToButton.Location = new System.Drawing.Point(718, 5);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(70, 70);
            this.goToButton.TabIndex = 0;
            this.goToButton.Text = "Вперед";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.Location = new System.Drawing.Point(117, 29);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(595, 29);
            this.pathTextBox.TabIndex = 0;
            this.pathTextBox.WordWrap = false;
            // 
            // articleView
            // 
            this.articleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleView.Location = new System.Drawing.Point(0, 0);
            this.articleView.MinimumSize = new System.Drawing.Size(20, 20);
            this.articleView.Name = "articleView";
            this.articleView.Size = new System.Drawing.Size(1008, 651);
            this.articleView.TabIndex = 1;
            this.articleView.TabStop = false;
            this.articleView.Visible = false;
            this.articleView.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.articleView_Navigating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rightChar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.wikipediaButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.youtubeButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.yandexButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.monochromeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyboardButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.keyMode, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.leftChar, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 651);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rightChar
            // 
            this.rightChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightChar.Location = new System.Drawing.Point(10, 524);
            this.rightChar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.rightChar.Name = "rightChar";
            this.rightChar.ReadOnly = true;
            this.rightChar.Size = new System.Drawing.Size(150, 62);
            this.rightChar.TabIndex = 12;
            this.rightChar.Text = "X";
            this.rightChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightChar_KeyDown);
            // 
            // wikipediaButton
            // 
            this.wikipediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wikipediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wikipediaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wikipediaButton.Location = new System.Drawing.Point(0, 320);
            this.wikipediaButton.Margin = new System.Windows.Forms.Padding(0);
            this.wikipediaButton.Name = "wikipediaButton";
            this.wikipediaButton.Size = new System.Drawing.Size(170, 80);
            this.wikipediaButton.TabIndex = 9;
            this.wikipediaButton.Text = "Википедия";
            this.wikipediaButton.UseVisualStyleBackColor = false;
            this.wikipediaButton.Click += new System.EventHandler(this.WikipediaButton_Click);
            // 
            // youtubeButton
            // 
            this.youtubeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.youtubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtubeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.youtubeButton.Location = new System.Drawing.Point(0, 240);
            this.youtubeButton.Margin = new System.Windows.Forms.Padding(0);
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.Size = new System.Drawing.Size(170, 80);
            this.youtubeButton.TabIndex = 8;
            this.youtubeButton.Text = "YouTube";
            this.youtubeButton.UseVisualStyleBackColor = false;
            this.youtubeButton.Click += new System.EventHandler(this.GoogleButton_Click);
            // 
            // yandexButton
            // 
            this.yandexButton.BackColor = System.Drawing.Color.Yellow;
            this.yandexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yandexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yandexButton.Location = new System.Drawing.Point(0, 160);
            this.yandexButton.Margin = new System.Windows.Forms.Padding(0);
            this.yandexButton.Name = "yandexButton";
            this.yandexButton.Size = new System.Drawing.Size(170, 80);
            this.yandexButton.TabIndex = 7;
            this.yandexButton.Text = "Яндекс";
            this.yandexButton.UseVisualStyleBackColor = false;
            this.yandexButton.Click += new System.EventHandler(this.YandexButton_Click);
            // 
            // monochromeButton
            // 
            this.monochromeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monochromeButton.Location = new System.Drawing.Point(0, 0);
            this.monochromeButton.Margin = new System.Windows.Forms.Padding(0);
            this.monochromeButton.Name = "monochromeButton";
            this.monochromeButton.Size = new System.Drawing.Size(170, 80);
            this.monochromeButton.TabIndex = 5;
            this.monochromeButton.Text = "Чёрно-белые\r\nизображения";
            this.monochromeButton.UseVisualStyleBackColor = true;
            this.monochromeButton.Click += new System.EventHandler(this.monochromeButton_Click);
            // 
            // keyboardButton
            // 
            this.keyboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyboardButton.Location = new System.Drawing.Point(0, 80);
            this.keyboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.keyboardButton.Name = "keyboardButton";
            this.keyboardButton.Size = new System.Drawing.Size(170, 80);
            this.keyboardButton.TabIndex = 6;
            this.keyboardButton.Text = "Экранная\r\nклавиатура";
            this.keyboardButton.UseVisualStyleBackColor = true;
            this.keyboardButton.Click += new System.EventHandler(this.KeyboardButton_Click);
            // 
            // keyMode
            // 
            this.keyMode.AutoSize = true;
            this.keyMode.Checked = true;
            this.keyMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keyMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyMode.Location = new System.Drawing.Point(0, 400);
            this.keyMode.Margin = new System.Windows.Forms.Padding(0);
            this.keyMode.Name = "keyMode";
            this.keyMode.Size = new System.Drawing.Size(170, 62);
            this.keyMode.TabIndex = 10;
            this.keyMode.Text = "Клавиши для нажатия\r\nкнопок мыши:";
            this.keyMode.UseVisualStyleBackColor = true;
            this.keyMode.CheckedChanged += new System.EventHandler(this.KeyMode_CheckedChanged);
            // 
            // leftChar
            // 
            this.leftChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftChar.Location = new System.Drawing.Point(10, 462);
            this.leftChar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.leftChar.Name = "leftChar";
            this.leftChar.ReadOnly = true;
            this.leftChar.Size = new System.Drawing.Size(150, 62);
            this.leftChar.TabIndex = 11;
            this.leftChar.Text = "Z";
            this.leftChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeftChar_KeyDown);
            // 
            // viewPanel
            // 
            this.viewPanel.AutoSize = true;
            this.viewPanel.Controls.Add(this.tableLayoutPanel1);
            this.viewPanel.Controls.Add(this.articleView);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 78);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.MinimumSize = new System.Drawing.Size(20, 20);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1008, 651);
            this.viewPanel.TabIndex = 1;
            // 
            // webBro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "webBro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "webBro ☺";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goToButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button changeModeButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Label loadingImage;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.WebBrowser articleView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button wikipediaButton;
        private System.Windows.Forms.Button youtubeButton;
        private System.Windows.Forms.Button yandexButton;
        private System.Windows.Forms.Button monochromeButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button keyboardButton;
        private System.Windows.Forms.CheckBox keyMode;
        private System.Windows.Forms.TextBox leftChar;
        private System.Windows.Forms.TextBox rightChar;
    }
}
