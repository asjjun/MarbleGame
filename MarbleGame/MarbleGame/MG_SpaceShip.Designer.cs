namespace MarbleGame
{
    partial class MG_SpaceShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MG_SpaceShip));
            this.Exit_button = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.White;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_button.Image")));
            this.Exit_button.Location = new System.Drawing.Point(367, 380);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(61, 52);
            this.Exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_button.TabIndex = 13;
            this.Exit_button.TabStop = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Bullet
            // 
            this.Bullet.BackColor = System.Drawing.Color.Transparent;
            this.Bullet.Image = ((System.Drawing.Image)(resources.GetObject("Bullet.Image")));
            this.Bullet.Location = new System.Drawing.Point(338, 109);
            this.Bullet.Margin = new System.Windows.Forms.Padding(4);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(50, 50);
            this.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet.TabIndex = 15;
            this.Bullet.TabStop = false;
            // 
            // spaceship
            // 
            this.spaceship.BackColor = System.Drawing.Color.Transparent;
            this.spaceship.Image = ((System.Drawing.Image)(resources.GetObject("spaceship.Image")));
            this.spaceship.Location = new System.Drawing.Point(208, 281);
            this.spaceship.Margin = new System.Windows.Forms.Padding(4);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(70, 60);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 14;
            this.spaceship.TabStop = false;
            // 
            // Background
            // 
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(440, 444);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 16;
            this.Background.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(342, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(86, 38);
            this.TimeLabel.TabIndex = 17;
            this.TimeLabel.Text = "000";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(191, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(154, 38);
            this.ScoreLabel.TabIndex = 18;
            this.ScoreLabel.Text = "Score :";
            // 
            // MG_SpaceShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 444);
            this.ControlBox = false;
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.spaceship);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Background);
            this.Name = "MG_SpaceShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG_SpaceShip";
            this.Load += new System.EventHandler(this.MG_SpaceShip_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MG_SpaceShip_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MG_SpaceShip_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit_button;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ScoreLabel;
    }
}