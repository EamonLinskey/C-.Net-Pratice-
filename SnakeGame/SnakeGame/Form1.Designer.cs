namespace SnakeGame
{
    partial class snakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snakeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.highScoresButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.highScoresPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.highScoreInfo2 = new System.Windows.Forms.Label();
            this.highScoreInfoLabel = new System.Windows.Forms.Label();
            this.scoreInfoLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.highScoresbutton2 = new System.Windows.Forms.Button();
            this.quitButton2 = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.wallTop = new System.Windows.Forms.PictureBox();
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.homeButtonFromHS = new System.Windows.Forms.Button();
            this.score5Label = new System.Windows.Forms.Label();
            this.score4Label = new System.Windows.Forms.Label();
            this.score3Label = new System.Windows.Forms.Label();
            this.score2Label = new System.Windows.Forms.Label();
            this.score1Label = new System.Windows.Forms.Label();
            this.highScoresLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.highScoresPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.titleLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.titleLabel.Location = new System.Drawing.Point(318, 237);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(187, 55);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "SNAKE";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.ForestGreen;
            this.playButton.Location = new System.Drawing.Point(373, 295);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(86, 38);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // highScoresButton
            // 
            this.highScoresButton.BackColor = System.Drawing.Color.ForestGreen;
            this.highScoresButton.Location = new System.Drawing.Point(373, 339);
            this.highScoresButton.Name = "highScoresButton";
            this.highScoresButton.Size = new System.Drawing.Size(86, 38);
            this.highScoresButton.TabIndex = 3;
            this.highScoresButton.Text = "High Scores";
            this.highScoresButton.UseVisualStyleBackColor = false;
            this.highScoresButton.Click += new System.EventHandler(this.highScoresButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.ForestGreen;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.Location = new System.Drawing.Point(373, 383);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(86, 38);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.mainPanel.Controls.Add(this.highScoresPanel);
            this.mainPanel.Controls.Add(this.quitButton);
            this.mainPanel.Controls.Add(this.highScoresButton);
            this.mainPanel.Controls.Add(this.playButton);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 480);
            this.mainPanel.TabIndex = 5;
            // 
            // highScoresPanel
            // 
            this.highScoresPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.highScoresPanel.Controls.Add(this.gamePanel);
            this.highScoresPanel.Controls.Add(this.homeButtonFromHS);
            this.highScoresPanel.Controls.Add(this.score5Label);
            this.highScoresPanel.Controls.Add(this.score4Label);
            this.highScoresPanel.Controls.Add(this.score3Label);
            this.highScoresPanel.Controls.Add(this.score2Label);
            this.highScoresPanel.Controls.Add(this.score1Label);
            this.highScoresPanel.Controls.Add(this.highScoresLabel);
            this.highScoresPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highScoresPanel.Location = new System.Drawing.Point(0, 0);
            this.highScoresPanel.Name = "highScoresPanel";
            this.highScoresPanel.Size = new System.Drawing.Size(800, 480);
            this.highScoresPanel.TabIndex = 5;
            this.highScoresPanel.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.gamePanel.Controls.Add(this.gameOverPanel);
            this.gamePanel.Controls.Add(this.wallLeft);
            this.gamePanel.Controls.Add(this.wallBottom);
            this.gamePanel.Controls.Add(this.startGameButton);
            this.gamePanel.Controls.Add(this.scoreLabel);
            this.gamePanel.Controls.Add(this.wallTop);
            this.gamePanel.Controls.Add(this.wallRight);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 480);
            this.gamePanel.TabIndex = 7;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.gameOverPanel.Controls.Add(this.highScoreInfo2);
            this.gameOverPanel.Controls.Add(this.highScoreInfoLabel);
            this.gameOverPanel.Controls.Add(this.scoreInfoLabel);
            this.gameOverPanel.Controls.Add(this.submitButton);
            this.gameOverPanel.Controls.Add(this.nameTextBox);
            this.gameOverPanel.Controls.Add(this.highScoresbutton2);
            this.gameOverPanel.Controls.Add(this.quitButton2);
            this.gameOverPanel.Controls.Add(this.playAgainButton);
            this.gameOverPanel.Controls.Add(this.gameOverLabel);
            this.gameOverPanel.Location = new System.Drawing.Point(264, 44);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(312, 377);
            this.gameOverPanel.TabIndex = 11;
            this.gameOverPanel.Visible = false;
            // 
            // highScoreInfo2
            // 
            this.highScoreInfo2.AutoSize = true;
            this.highScoreInfo2.Location = new System.Drawing.Point(70, 102);
            this.highScoreInfo2.Name = "highScoreInfo2";
            this.highScoreInfo2.Size = new System.Drawing.Size(166, 13);
            this.highScoreInfo2.TabIndex = 8;
            this.highScoreInfo2.Text = "Enter your name and click submit!";
            // 
            // highScoreInfoLabel
            // 
            this.highScoreInfoLabel.AutoSize = true;
            this.highScoreInfoLabel.Location = new System.Drawing.Point(81, 89);
            this.highScoreInfoLabel.Name = "highScoreInfoLabel";
            this.highScoreInfoLabel.Size = new System.Drawing.Size(143, 13);
            this.highScoreInfoLabel.TabIndex = 7;
            this.highScoreInfoLabel.Text = "You did not get a high score.";
            // 
            // scoreInfoLabel
            // 
            this.scoreInfoLabel.AutoSize = true;
            this.scoreInfoLabel.Location = new System.Drawing.Point(95, 76);
            this.scoreInfoLabel.Name = "scoreInfoLabel";
            this.scoreInfoLabel.Size = new System.Drawing.Size(116, 13);
            this.scoreInfoLabel.TabIndex = 6;
            this.scoreInfoLabel.Text = "You scored 100 points!";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkGreen;
            this.submitButton.Location = new System.Drawing.Point(82, 145);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(142, 22);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit High Score";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Text = "Enter Your Name";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            // 
            // highScoresbutton2
            // 
            this.highScoresbutton2.BackColor = System.Drawing.Color.DarkGreen;
            this.highScoresbutton2.Location = new System.Drawing.Point(82, 236);
            this.highScoresbutton2.Name = "highScoresbutton2";
            this.highScoresbutton2.Size = new System.Drawing.Size(142, 60);
            this.highScoresbutton2.TabIndex = 3;
            this.highScoresbutton2.Text = "High Scores";
            this.highScoresbutton2.UseVisualStyleBackColor = false;
            this.highScoresbutton2.Click += new System.EventHandler(this.highScoresbutton2_Click);
            // 
            // quitButton2
            // 
            this.quitButton2.BackColor = System.Drawing.Color.DarkGreen;
            this.quitButton2.Location = new System.Drawing.Point(82, 302);
            this.quitButton2.Name = "quitButton2";
            this.quitButton2.Size = new System.Drawing.Size(142, 57);
            this.quitButton2.TabIndex = 2;
            this.quitButton2.Text = "Quit";
            this.quitButton2.UseVisualStyleBackColor = false;
            this.quitButton2.Click += new System.EventHandler(this.quitButton2_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkGreen;
            this.playAgainButton.Location = new System.Drawing.Point(82, 173);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(142, 57);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.gameOverLabel.Location = new System.Drawing.Point(7, 13);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(305, 63);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "Game Over";
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.SaddleBrown;
            this.wallLeft.Location = new System.Drawing.Point(0, 0);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(20, 480);
            this.wallLeft.TabIndex = 9;
            this.wallLeft.TabStop = false;
            // 
            // wallBottom
            // 
            this.wallBottom.BackColor = System.Drawing.Color.SaddleBrown;
            this.wallBottom.Location = new System.Drawing.Point(0, 460);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(800, 20);
            this.wallBottom.TabIndex = 8;
            this.wallBottom.TabStop = false;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.DarkGreen;
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameButton.Location = new System.Drawing.Point(303, 191);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(184, 74);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "Start!";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.scoreLabel.Location = new System.Drawing.Point(700, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(68, 20);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.SaddleBrown;
            this.wallTop.Location = new System.Drawing.Point(3, 0);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(800, 20);
            this.wallTop.TabIndex = 7;
            this.wallTop.TabStop = false;
            // 
            // wallRight
            // 
            this.wallRight.BackColor = System.Drawing.Color.SaddleBrown;
            this.wallRight.Location = new System.Drawing.Point(780, 0);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(20, 480);
            this.wallRight.TabIndex = 10;
            this.wallRight.TabStop = false;
            // 
            // homeButtonFromHS
            // 
            this.homeButtonFromHS.BackColor = System.Drawing.Color.ForestGreen;
            this.homeButtonFromHS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeButtonFromHS.Location = new System.Drawing.Point(345, 335);
            this.homeButtonFromHS.Name = "homeButtonFromHS";
            this.homeButtonFromHS.Size = new System.Drawing.Size(114, 49);
            this.homeButtonFromHS.TabIndex = 6;
            this.homeButtonFromHS.Text = "Home";
            this.homeButtonFromHS.UseVisualStyleBackColor = false;
            this.homeButtonFromHS.Click += new System.EventHandler(this.homeButtonFromHS_Click);
            // 
            // score5Label
            // 
            this.score5Label.AutoSize = true;
            this.score5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.score5Label.Location = new System.Drawing.Point(295, 268);
            this.score5Label.Name = "score5Label";
            this.score5Label.Size = new System.Drawing.Size(210, 46);
            this.score5Label.TabIndex = 5;
            this.score5Label.Text = "5. Player 0";
            // 
            // score4Label
            // 
            this.score4Label.AutoSize = true;
            this.score4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.score4Label.Location = new System.Drawing.Point(295, 222);
            this.score4Label.Name = "score4Label";
            this.score4Label.Size = new System.Drawing.Size(210, 46);
            this.score4Label.TabIndex = 4;
            this.score4Label.Text = "4. Player 0";
            // 
            // score3Label
            // 
            this.score3Label.AutoSize = true;
            this.score3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.score3Label.Location = new System.Drawing.Point(295, 176);
            this.score3Label.Name = "score3Label";
            this.score3Label.Size = new System.Drawing.Size(210, 46);
            this.score3Label.TabIndex = 3;
            this.score3Label.Text = "3. Player 0";
            // 
            // score2Label
            // 
            this.score2Label.AutoSize = true;
            this.score2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.score2Label.Location = new System.Drawing.Point(295, 130);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(210, 46);
            this.score2Label.TabIndex = 2;
            this.score2Label.Text = "2. Player 0";
            // 
            // score1Label
            // 
            this.score1Label.AutoSize = true;
            this.score1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.score1Label.Location = new System.Drawing.Point(295, 84);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(210, 46);
            this.score1Label.TabIndex = 1;
            this.score1Label.Text = "1. Player 0";
            // 
            // highScoresLabel
            // 
            this.highScoresLabel.AutoSize = true;
            this.highScoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.highScoresLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.highScoresLabel.Location = new System.Drawing.Point(254, 12);
            this.highScoresLabel.Name = "highScoresLabel";
            this.highScoresLabel.Size = new System.Drawing.Size(302, 59);
            this.highScoresLabel.TabIndex = 0;
            this.highScoresLabel.Text = "High Scores";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // snakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.mainPanel);
            this.KeyPreview = true;
            this.Name = "snakeForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snakeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.highScoresPanel.ResumeLayout(false);
            this.highScoresPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button highScoresButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel highScoresPanel;
        private System.Windows.Forms.Button homeButtonFromHS;
        private System.Windows.Forms.Label score5Label;
        private System.Windows.Forms.Label score4Label;
        private System.Windows.Forms.Label score3Label;
        private System.Windows.Forms.Label score2Label;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.Label highScoresLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox wallTop;
        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox wallLeft;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button highScoresbutton2;
        private System.Windows.Forms.Button quitButton2;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label highScoreInfoLabel;
        private System.Windows.Forms.Label scoreInfoLabel;
        private System.Windows.Forms.Label highScoreInfo2;
    }
}

