namespace AirHockey
{
    partial class Background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.p1scoreLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.player1powerBar = new System.Windows.Forms.ProgressBar();
            this.player2powerBar = new System.Windows.Forms.ProgressBar();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(368, 848);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // startLabel
            // 
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(91, 287);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(348, 69);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Press Space To Start";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p1scoreLabel
            // 
            this.p1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p1scoreLabel.Location = new System.Drawing.Point(58, 352);
            this.p1scoreLabel.Name = "p1scoreLabel";
            this.p1scoreLabel.Size = new System.Drawing.Size(42, 23);
            this.p1scoreLabel.TabIndex = 3;
            this.p1scoreLabel.Text = "0";
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2scoreLabel.Location = new System.Drawing.Point(58, 458);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(42, 23);
            this.p2scoreLabel.TabIndex = 4;
            this.p2scoreLabel.Text = "0";
            // 
            // player1powerBar
            // 
            this.player1powerBar.Location = new System.Drawing.Point(175, 0);
            this.player1powerBar.Maximum = 400;
            this.player1powerBar.Name = "player1powerBar";
            this.player1powerBar.Size = new System.Drawing.Size(174, 29);
            this.player1powerBar.TabIndex = 5;
            this.player1powerBar.Value = 400;
            // 
            // player2powerBar
            // 
            this.player2powerBar.Location = new System.Drawing.Point(175, 810);
            this.player2powerBar.Maximum = 400;
            this.player2powerBar.Name = "player2powerBar";
            this.player2powerBar.Size = new System.Drawing.Size(174, 29);
            this.player2powerBar.TabIndex = 6;
            this.player2powerBar.Value = 400;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(133, 475);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(281, 82);
            this.winLabel.TabIndex = 7;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(524, 840);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2powerBar);
            this.Controls.Add(this.player1powerBar);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.p1scoreLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Background";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label p1scoreLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.ProgressBar player1powerBar;
        private System.Windows.Forms.ProgressBar player2powerBar;
        private System.Windows.Forms.Label winLabel;
    }
}

