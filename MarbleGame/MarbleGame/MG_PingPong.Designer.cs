namespace MarbleGame
{
    partial class MG_PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MG_PingPong));
            this.SpiderBall = new System.Windows.Forms.PictureBox();
            this.Bar2 = new System.Windows.Forms.PictureBox();
            this.Bar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpiderBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_button)).BeginInit();
            this.SuspendLayout();
            // 
            // SpiderBall
            // 
            this.SpiderBall.Image = ((System.Drawing.Image)(resources.GetObject("SpiderBall.Image")));
            this.SpiderBall.Location = new System.Drawing.Point(336, 226);
            this.SpiderBall.Name = "SpiderBall";
            this.SpiderBall.Size = new System.Drawing.Size(50, 50);
            this.SpiderBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpiderBall.TabIndex = 7;
            this.SpiderBall.TabStop = false;
            this.SpiderBall.Click += new System.EventHandler(this.SpiderBall_Click);
            // 
            // Bar2
            // 
            this.Bar2.BackColor = System.Drawing.Color.Black;
            this.Bar2.Location = new System.Drawing.Point(721, 204);
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(22, 144);
            this.Bar2.TabIndex = 6;
            this.Bar2.TabStop = false;
            // 
            // Bar1
            // 
            this.Bar1.BackColor = System.Drawing.Color.Red;
            this.Bar1.Location = new System.Drawing.Point(11, 204);
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(23, 144);
            this.Bar1.TabIndex = 5;
            this.Bar1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(544, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(154, 38);
            this.ScoreLabel.TabIndex = 11;
            this.ScoreLabel.Text = "Score :";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(693, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(86, 38);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "000";
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.White;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_button.Image")));
            this.Exit_button.Location = new System.Drawing.Point(477, 9);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(61, 52);
            this.Exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_button.TabIndex = 13;
            this.Exit_button.TabStop = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MG_PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SpiderBall);
            this.Controls.Add(this.Bar2);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MG_PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG_PingPong";
            this.Load += new System.EventHandler(this.MG_PingPong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MG_PingPong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MG_PingPong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.SpiderBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpiderBall;
        private System.Windows.Forms.PictureBox Bar2;
        private System.Windows.Forms.PictureBox Bar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox Exit_button;
        private System.Windows.Forms.Timer timer1;
    }
}