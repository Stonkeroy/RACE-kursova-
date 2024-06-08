namespace RACE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            trafic1 = new PictureBox();
            trafic2 = new PictureBox();
            labelLose = new Label();
            restartButton = new Button();
            Coin = new PictureBox();
            labelCoins = new Label();
            playButton = new Button();
            exitButton = new Button();
            GoMenuButton = new Button();
            colorButton = new Button();
            settingsButton = new Button();
            Road = new PictureBox();
            Road2 = new PictureBox();
            yesButton = new Button();
            noButton = new Button();
            exitLabel = new Label();
            exitSettingsButton = new Button();
            audioButton = new Button();
            totalCoinsLabel = new Label();
            Racelogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trafic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trafic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Racelogo).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.FromArgb(64, 64, 64);
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(426, 512);
            Player.Name = "Player";
            Player.Size = new Size(100, 100);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 1;
            Player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // trafic1
            // 
            trafic1.BackColor = Color.FromArgb(64, 64, 64);
            trafic1.Image = (Image)resources.GetObject("trafic1.Image");
            trafic1.Location = new Point(191, -130);
            trafic1.Name = "trafic1";
            trafic1.Size = new Size(100, 100);
            trafic1.SizeMode = PictureBoxSizeMode.StretchImage;
            trafic1.TabIndex = 3;
            trafic1.TabStop = false;
            // 
            // trafic2
            // 
            trafic2.BackColor = Color.FromArgb(64, 64, 64);
            trafic2.Image = (Image)resources.GetObject("trafic2.Image");
            trafic2.Location = new Point(543, -400);
            trafic2.Name = "trafic2";
            trafic2.Size = new Size(100, 100);
            trafic2.SizeMode = PictureBoxSizeMode.StretchImage;
            trafic2.TabIndex = 4;
            trafic2.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.FromArgb(192, 0, 0);
            labelLose.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelLose.ForeColor = Color.White;
            labelLose.Location = new Point(288, 226);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(293, 57);
            labelLose.TabIndex = 5;
            labelLose.Text = "Game Over";
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Red;
            restartButton.FlatStyle = FlatStyle.Popup;
            restartButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            restartButton.ForeColor = Color.White;
            restartButton.Location = new Point(369, 302);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(133, 27);
            restartButton.TabIndex = 6;
            restartButton.Text = "RESTART";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // Coin
            // 
            Coin.BackColor = Color.FromArgb(64, 64, 64);
            Coin.Image = (Image)resources.GetObject("Coin.Image");
            Coin.Location = new Point(435, -600);
            Coin.Name = "Coin";
            Coin.Size = new Size(32, 32);
            Coin.SizeMode = PictureBoxSizeMode.StretchImage;
            Coin.TabIndex = 7;
            Coin.TabStop = false;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.FromArgb(192, 0, 0);
            labelCoins.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = Color.White;
            labelCoins.Location = new Point(12, 19);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(106, 32);
            labelCoins.TabIndex = 8;
            labelCoins.Text = "Coins:";
            // 
            // playButton
            // 
            playButton.BackColor = Color.Red;
            playButton.FlatStyle = FlatStyle.Popup;
            playButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(381, 162);
            playButton.Name = "playButton";
            playButton.Size = new Size(90, 48);
            playButton.TabIndex = 9;
            playButton.Text = "PLAY!";
            playButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(381, 325);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(90, 48);
            exitButton.TabIndex = 11;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // GoMenuButton
            // 
            GoMenuButton.BackColor = Color.Red;
            GoMenuButton.FlatStyle = FlatStyle.Popup;
            GoMenuButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            GoMenuButton.ForeColor = Color.White;
            GoMenuButton.Location = new Point(369, 335);
            GoMenuButton.Name = "GoMenuButton";
            GoMenuButton.Size = new Size(133, 28);
            GoMenuButton.TabIndex = 12;
            GoMenuButton.Text = "GO TO MENU";
            GoMenuButton.UseVisualStyleBackColor = false;
            // 
            // colorButton
            // 
            colorButton.BackColor = Color.Red;
            colorButton.FlatStyle = FlatStyle.Popup;
            colorButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            colorButton.ForeColor = Color.White;
            colorButton.Location = new Point(381, 162);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(90, 48);
            colorButton.TabIndex = 13;
            colorButton.Text = "COLOR";
            colorButton.UseVisualStyleBackColor = false;
            colorButton.Click += colorButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.Red;
            settingsButton.FlatStyle = FlatStyle.Popup;
            settingsButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(381, 240);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(90, 48);
            settingsButton.TabIndex = 14;
            settingsButton.Text = "SETTINGS";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // Road
            // 
            Road.Image = (Image)resources.GetObject("Road.Image");
            Road.Location = new Point(0, 0);
            Road.Name = "Road";
            Road.Size = new Size(840, 650);
            Road.TabIndex = 15;
            Road.TabStop = false;
            // 
            // Road2
            // 
            Road2.Image = (Image)resources.GetObject("Road2.Image");
            Road2.Location = new Point(0, -650);
            Road2.Name = "Road2";
            Road2.Size = new Size(840, 650);
            Road2.TabIndex = 16;
            Road2.TabStop = false;
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.Red;
            yesButton.FlatStyle = FlatStyle.Popup;
            yesButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            yesButton.ForeColor = Color.White;
            yesButton.Location = new Point(285, 325);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(90, 48);
            yesButton.TabIndex = 17;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = false;
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.BackColor = Color.Red;
            noButton.FlatStyle = FlatStyle.Popup;
            noButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            noButton.ForeColor = Color.White;
            noButton.Location = new Point(491, 325);
            noButton.Name = "noButton";
            noButton.Size = new Size(90, 48);
            noButton.TabIndex = 18;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = false;
            noButton.Click += noButton_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.BackColor = Color.FromArgb(192, 0, 0);
            exitLabel.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(251, 213);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(388, 68);
            exitLabel.TabIndex = 19;
            exitLabel.Text = "Are you sure you want \r\nto exit the game?";
            // 
            // exitSettingsButton
            // 
            exitSettingsButton.BackColor = Color.Red;
            exitSettingsButton.FlatStyle = FlatStyle.Popup;
            exitSettingsButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exitSettingsButton.ForeColor = Color.White;
            exitSettingsButton.Location = new Point(381, 325);
            exitSettingsButton.Name = "exitSettingsButton";
            exitSettingsButton.Size = new Size(90, 48);
            exitSettingsButton.TabIndex = 20;
            exitSettingsButton.Text = "MENU";
            exitSettingsButton.UseVisualStyleBackColor = false;
            exitSettingsButton.Click += exitSettingsButton_Click;
            // 
            // audioButton
            // 
            audioButton.BackColor = Color.Red;
            audioButton.FlatStyle = FlatStyle.Popup;
            audioButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            audioButton.ForeColor = Color.White;
            audioButton.Location = new Point(381, 240);
            audioButton.Name = "audioButton";
            audioButton.Size = new Size(90, 48);
            audioButton.TabIndex = 21;
            audioButton.Text = "AUDIO";
            audioButton.UseVisualStyleBackColor = false;
            audioButton.Click += audioButton_Click;
            // 
            // totalCoinsLabel
            // 
            totalCoinsLabel.AutoSize = true;
            totalCoinsLabel.BackColor = Color.FromArgb(192, 0, 0);
            totalCoinsLabel.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalCoinsLabel.ForeColor = Color.White;
            totalCoinsLabel.Location = new Point(583, 19);
            totalCoinsLabel.Name = "totalCoinsLabel";
            totalCoinsLabel.Size = new Size(199, 32);
            totalCoinsLabel.TabIndex = 22;
            totalCoinsLabel.Text = "Total Coins:";
            // 
            // Racelogo
            // 
            Racelogo.BackColor = Color.Red;
            Racelogo.Image = (Image)resources.GetObject("Racelogo.Image");
            Racelogo.Location = new Point(240, 77);
            Racelogo.Name = "Racelogo";
            Racelogo.Size = new Size(374, 79);
            Racelogo.SizeMode = PictureBoxSizeMode.StretchImage;
            Racelogo.TabIndex = 23;
            Racelogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(840, 650);
            Controls.Add(Racelogo);
            Controls.Add(totalCoinsLabel);
            Controls.Add(audioButton);
            Controls.Add(exitSettingsButton);
            Controls.Add(GoMenuButton);
            Controls.Add(restartButton);
            Controls.Add(labelLose);
            Controls.Add(exitLabel);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(Coin);
            Controls.Add(trafic2);
            Controls.Add(trafic1);
            Controls.Add(playButton);
            Controls.Add(labelCoins);
            Controls.Add(settingsButton);
            Controls.Add(colorButton);
            Controls.Add(exitButton);
            Controls.Add(Player);
            Controls.Add(Road);
            Controls.Add(Road2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Black;
            Load += Form1_Load_1;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)trafic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trafic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Racelogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Player;
        private System.Windows.Forms.Timer timer;
        private PictureBox trafic1;
        private PictureBox trafic2;
        private Label labelLose;
        private Button restartButton;
        private PictureBox Coin;
        private Label labelCoins;
        private Button playButton;
        private Button exitButton;
        private Button GoMenuButton;
        private Button colorButton;
        private Button settingsButton;
        private PictureBox Road;
        private PictureBox Road2;
        private Button yesButton;
        private Button noButton;
        private Label exitLabel;
        private Button exitSettingsButton;
        private Button audioButton;
        private Label totalCoinsLabel;
        private PictureBox Racelogo;
    }
}