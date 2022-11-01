namespace MarbleGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Exit_button = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.Player1vsPlayer2 = new System.Windows.Forms.PictureBox();
            this.P1Money = new System.Windows.Forms.Label();
            this.Space_button = new System.Windows.Forms.PictureBox();
            this.PingPong_button = new System.Windows.Forms.PictureBox();
            this.Shooting_button = new System.Windows.Forms.PictureBox();
            this.P2Money = new System.Windows.Forms.Label();
            this.DiceN6 = new System.Windows.Forms.PictureBox();
            this.DiceN3 = new System.Windows.Forms.PictureBox();
            this.DiceN5 = new System.Windows.Forms.PictureBox();
            this.DiceN4 = new System.Windows.Forms.PictureBox();
            this.DiceN2 = new System.Windows.Forms.PictureBox();
            this.DiceN1 = new System.Windows.Forms.PictureBox();
            this.DicePic = new System.Windows.Forms.PictureBox();
            this.ThanosAttack = new System.Windows.Forms.PictureBox();
            this.Turn = new System.Windows.Forms.Label();
            this.Travel_button = new System.Windows.Forms.PictureBox();
            this.Gambling_button = new System.Windows.Forms.PictureBox();
            this.Roll_button = new System.Windows.Forms.PictureBox();
            this.Player1_Name = new System.Windows.Forms.Label();
            this.Player2_Name = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Player2_Tax = new System.Windows.Forms.Label();
            this.Player1_Tax = new System.Windows.Forms.Label();
            this.Chance_Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1vsPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingPong_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooting_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThanosAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gambling_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(1280, 11);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(90, 43);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "게임종료";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(891, 591);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(74, 133);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 9;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Image = ((System.Drawing.Image)(resources.GetObject("Player2.Image")));
            this.Player2.Location = new System.Drawing.Point(762, 591);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(74, 133);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 11;
            this.Player2.TabStop = false;
            // 
            // BackGround
            // 
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(1382, 803);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround.TabIndex = 12;
            this.BackGround.TabStop = false;
            // 
            // Player1vsPlayer2
            // 
            this.Player1vsPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.Player1vsPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("Player1vsPlayer2.Image")));
            this.Player1vsPlayer2.Location = new System.Drawing.Point(20, 12);
            this.Player1vsPlayer2.Name = "Player1vsPlayer2";
            this.Player1vsPlayer2.Size = new System.Drawing.Size(198, 126);
            this.Player1vsPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1vsPlayer2.TabIndex = 13;
            this.Player1vsPlayer2.TabStop = false;
            // 
            // P1Money
            // 
            this.P1Money.BackColor = System.Drawing.Color.Transparent;
            this.P1Money.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P1Money.ForeColor = System.Drawing.Color.White;
            this.P1Money.Location = new System.Drawing.Point(12, 248);
            this.P1Money.Name = "P1Money";
            this.P1Money.Size = new System.Drawing.Size(240, 60);
            this.P1Money.TabIndex = 14;
            this.P1Money.Text = "1000만원";
            this.P1Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Space_button
            // 
            this.Space_button.BackColor = System.Drawing.Color.Transparent;
            this.Space_button.Image = ((System.Drawing.Image)(resources.GetObject("Space_button.Image")));
            this.Space_button.Location = new System.Drawing.Point(612, 441);
            this.Space_button.Name = "Space_button";
            this.Space_button.Size = new System.Drawing.Size(133, 99);
            this.Space_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Space_button.TabIndex = 15;
            this.Space_button.TabStop = false;
            this.Space_button.Click += new System.EventHandler(this.Space_button_Click);
            // 
            // PingPong_button
            // 
            this.PingPong_button.BackColor = System.Drawing.Color.Transparent;
            this.PingPong_button.Image = ((System.Drawing.Image)(resources.GetObject("PingPong_button.Image")));
            this.PingPong_button.Location = new System.Drawing.Point(612, 441);
            this.PingPong_button.Name = "PingPong_button";
            this.PingPong_button.Size = new System.Drawing.Size(133, 99);
            this.PingPong_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PingPong_button.TabIndex = 18;
            this.PingPong_button.TabStop = false;
            this.PingPong_button.Click += new System.EventHandler(this.PingPong_button_Click);
            // 
            // Shooting_button
            // 
            this.Shooting_button.BackColor = System.Drawing.Color.Transparent;
            this.Shooting_button.Image = ((System.Drawing.Image)(resources.GetObject("Shooting_button.Image")));
            this.Shooting_button.Location = new System.Drawing.Point(612, 441);
            this.Shooting_button.Name = "Shooting_button";
            this.Shooting_button.Size = new System.Drawing.Size(133, 99);
            this.Shooting_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shooting_button.TabIndex = 19;
            this.Shooting_button.TabStop = false;
            this.Shooting_button.Click += new System.EventHandler(this.Shooting_button_Click);
            // 
            // P2Money
            // 
            this.P2Money.BackColor = System.Drawing.Color.Transparent;
            this.P2Money.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.P2Money.ForeColor = System.Drawing.Color.White;
            this.P2Money.Location = new System.Drawing.Point(1088, 502);
            this.P2Money.Name = "P2Money";
            this.P2Money.Size = new System.Drawing.Size(240, 60);
            this.P2Money.TabIndex = 20;
            this.P2Money.Text = "1000만원";
            this.P2Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiceN6
            // 
            this.DiceN6.BackColor = System.Drawing.Color.Transparent;
            this.DiceN6.Image = ((System.Drawing.Image)(resources.GetObject("DiceN6.Image")));
            this.DiceN6.Location = new System.Drawing.Point(591, 295);
            this.DiceN6.Name = "DiceN6";
            this.DiceN6.Size = new System.Drawing.Size(177, 130);
            this.DiceN6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN6.TabIndex = 23;
            this.DiceN6.TabStop = false;
            // 
            // DiceN3
            // 
            this.DiceN3.BackColor = System.Drawing.Color.Transparent;
            this.DiceN3.Image = ((System.Drawing.Image)(resources.GetObject("DiceN3.Image")));
            this.DiceN3.Location = new System.Drawing.Point(591, 294);
            this.DiceN3.Name = "DiceN3";
            this.DiceN3.Size = new System.Drawing.Size(177, 131);
            this.DiceN3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN3.TabIndex = 24;
            this.DiceN3.TabStop = false;
            // 
            // DiceN5
            // 
            this.DiceN5.BackColor = System.Drawing.Color.Transparent;
            this.DiceN5.Image = ((System.Drawing.Image)(resources.GetObject("DiceN5.Image")));
            this.DiceN5.Location = new System.Drawing.Point(591, 296);
            this.DiceN5.Name = "DiceN5";
            this.DiceN5.Size = new System.Drawing.Size(177, 130);
            this.DiceN5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN5.TabIndex = 25;
            this.DiceN5.TabStop = false;
            // 
            // DiceN4
            // 
            this.DiceN4.BackColor = System.Drawing.Color.Transparent;
            this.DiceN4.Image = ((System.Drawing.Image)(resources.GetObject("DiceN4.Image")));
            this.DiceN4.Location = new System.Drawing.Point(591, 295);
            this.DiceN4.Name = "DiceN4";
            this.DiceN4.Size = new System.Drawing.Size(177, 130);
            this.DiceN4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN4.TabIndex = 26;
            this.DiceN4.TabStop = false;
            // 
            // DiceN2
            // 
            this.DiceN2.BackColor = System.Drawing.Color.Transparent;
            this.DiceN2.Image = ((System.Drawing.Image)(resources.GetObject("DiceN2.Image")));
            this.DiceN2.Location = new System.Drawing.Point(591, 294);
            this.DiceN2.Name = "DiceN2";
            this.DiceN2.Size = new System.Drawing.Size(177, 131);
            this.DiceN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN2.TabIndex = 27;
            this.DiceN2.TabStop = false;
            // 
            // DiceN1
            // 
            this.DiceN1.BackColor = System.Drawing.Color.Transparent;
            this.DiceN1.Image = ((System.Drawing.Image)(resources.GetObject("DiceN1.Image")));
            this.DiceN1.Location = new System.Drawing.Point(591, 296);
            this.DiceN1.Name = "DiceN1";
            this.DiceN1.Size = new System.Drawing.Size(177, 131);
            this.DiceN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DiceN1.TabIndex = 28;
            this.DiceN1.TabStop = false;
            // 
            // DicePic
            // 
            this.DicePic.BackColor = System.Drawing.Color.Transparent;
            this.DicePic.Image = ((System.Drawing.Image)(resources.GetObject("DicePic.Image")));
            this.DicePic.Location = new System.Drawing.Point(591, 294);
            this.DicePic.Name = "DicePic";
            this.DicePic.Size = new System.Drawing.Size(177, 131);
            this.DicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DicePic.TabIndex = 29;
            this.DicePic.TabStop = false;
            // 
            // ThanosAttack
            // 
            this.ThanosAttack.BackColor = System.Drawing.Color.Transparent;
            this.ThanosAttack.Image = ((System.Drawing.Image)(resources.GetObject("ThanosAttack.Image")));
            this.ThanosAttack.Location = new System.Drawing.Point(20, 11);
            this.ThanosAttack.Name = "ThanosAttack";
            this.ThanosAttack.Size = new System.Drawing.Size(87, 52);
            this.ThanosAttack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThanosAttack.TabIndex = 30;
            this.ThanosAttack.TabStop = false;
            this.ThanosAttack.Visible = false;
            this.ThanosAttack.Click += new System.EventHandler(this.ThanosAttack_Click);
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.BackColor = System.Drawing.Color.Transparent;
            this.Turn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Turn.ForeColor = System.Drawing.Color.White;
            this.Turn.Location = new System.Drawing.Point(568, 221);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(244, 40);
            this.Turn.TabIndex = 31;
            this.Turn.Text = "남은 턴 : 10";
            // 
            // Travel_button
            // 
            this.Travel_button.BackColor = System.Drawing.Color.Transparent;
            this.Travel_button.Image = ((System.Drawing.Image)(resources.GetObject("Travel_button.Image")));
            this.Travel_button.Location = new System.Drawing.Point(612, 441);
            this.Travel_button.Name = "Travel_button";
            this.Travel_button.Size = new System.Drawing.Size(133, 99);
            this.Travel_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Travel_button.TabIndex = 32;
            this.Travel_button.TabStop = false;
            this.Travel_button.Visible = false;
            this.Travel_button.Click += new System.EventHandler(this.Travel_button_Click);
            // 
            // Gambling_button
            // 
            this.Gambling_button.BackColor = System.Drawing.Color.Transparent;
            this.Gambling_button.Image = ((System.Drawing.Image)(resources.GetObject("Gambling_button.Image")));
            this.Gambling_button.Location = new System.Drawing.Point(612, 441);
            this.Gambling_button.Name = "Gambling_button";
            this.Gambling_button.Size = new System.Drawing.Size(133, 99);
            this.Gambling_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gambling_button.TabIndex = 33;
            this.Gambling_button.TabStop = false;
            this.Gambling_button.Visible = false;
            this.Gambling_button.Click += new System.EventHandler(this.Gambling_button_Click);
            // 
            // Roll_button
            // 
            this.Roll_button.BackColor = System.Drawing.Color.Transparent;
            this.Roll_button.Image = ((System.Drawing.Image)(resources.GetObject("Roll_button.Image")));
            this.Roll_button.Location = new System.Drawing.Point(612, 441);
            this.Roll_button.Name = "Roll_button";
            this.Roll_button.Size = new System.Drawing.Size(133, 99);
            this.Roll_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Roll_button.TabIndex = 34;
            this.Roll_button.TabStop = false;
            this.Roll_button.Click += new System.EventHandler(this.Roll_button_Click);
            // 
            // Player1_Name
            // 
            this.Player1_Name.AutoSize = true;
            this.Player1_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player1_Name.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Player1_Name.ForeColor = System.Drawing.Color.White;
            this.Player1_Name.Location = new System.Drawing.Point(67, 194);
            this.Player1_Name.Name = "Player1_Name";
            this.Player1_Name.Size = new System.Drawing.Size(160, 40);
            this.Player1_Name.TabIndex = 35;
            this.Player1_Name.Text = "Player1";
            this.Player1_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2_Name
            // 
            this.Player2_Name.AutoSize = true;
            this.Player2_Name.BackColor = System.Drawing.Color.Navy;
            this.Player2_Name.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Player2_Name.ForeColor = System.Drawing.Color.White;
            this.Player2_Name.Location = new System.Drawing.Point(1133, 447);
            this.Player2_Name.Name = "Player2_Name";
            this.Player2_Name.Size = new System.Drawing.Size(160, 40);
            this.Player2_Name.TabIndex = 36;
            this.Player2_Name.Text = "Player2";
            this.Player2_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Player2_Tax
            // 
            this.Player2_Tax.AutoSize = true;
            this.Player2_Tax.BackColor = System.Drawing.Color.Navy;
            this.Player2_Tax.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Player2_Tax.ForeColor = System.Drawing.Color.White;
            this.Player2_Tax.Location = new System.Drawing.Point(1046, 581);
            this.Player2_Tax.Name = "Player2_Tax";
            this.Player2_Tax.Size = new System.Drawing.Size(195, 40);
            this.Player2_Tax.TabIndex = 37;
            this.Player2_Tax.Text = "1000만원";
            this.Player2_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1_Tax
            // 
            this.Player1_Tax.AutoSize = true;
            this.Player1_Tax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player1_Tax.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Player1_Tax.ForeColor = System.Drawing.Color.White;
            this.Player1_Tax.Location = new System.Drawing.Point(23, 341);
            this.Player1_Tax.Name = "Player1_Tax";
            this.Player1_Tax.Size = new System.Drawing.Size(195, 40);
            this.Player1_Tax.TabIndex = 38;
            this.Player1_Tax.Text = "1000만원";
            this.Player1_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chance_Button
            // 
            this.Chance_Button.BackColor = System.Drawing.Color.Transparent;
            this.Chance_Button.Image = ((System.Drawing.Image)(resources.GetObject("Chance_Button.Image")));
            this.Chance_Button.Location = new System.Drawing.Point(612, 441);
            this.Chance_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Chance_Button.Name = "Chance_Button";
            this.Chance_Button.Size = new System.Drawing.Size(133, 99);
            this.Chance_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chance_Button.TabIndex = 41;
            this.Chance_Button.TabStop = false;
            this.Chance_Button.Visible = false;
            this.Chance_Button.Click += new System.EventHandler(this.Chance_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 803);
            this.ControlBox = false;
            this.Controls.Add(this.Chance_Button);
            this.Controls.Add(this.Player1_Tax);
            this.Controls.Add(this.Player2_Tax);
            this.Controls.Add(this.Player2_Name);
            this.Controls.Add(this.Player1_Name);
            this.Controls.Add(this.Gambling_button);
            this.Controls.Add(this.Travel_button);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.ThanosAttack);
            this.Controls.Add(this.DicePic);
            this.Controls.Add(this.DiceN1);
            this.Controls.Add(this.DiceN2);
            this.Controls.Add(this.DiceN4);
            this.Controls.Add(this.DiceN5);
            this.Controls.Add(this.DiceN3);
            this.Controls.Add(this.DiceN6);
            this.Controls.Add(this.P2Money);
            this.Controls.Add(this.Shooting_button);
            this.Controls.Add(this.PingPong_button);
            this.Controls.Add(this.Space_button);
            this.Controls.Add(this.P1Money);
            this.Controls.Add(this.Player1vsPlayer2);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Roll_button);
            this.Controls.Add(this.BackGround);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1vsPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingPong_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooting_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThanosAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gambling_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox Player2;
        public System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox Player1vsPlayer2;
        private System.Windows.Forms.Label P1Money;
        private System.Windows.Forms.PictureBox Space_button;
        private System.Windows.Forms.PictureBox PingPong_button;
        private System.Windows.Forms.PictureBox Shooting_button;
        private System.Windows.Forms.Label P2Money;
        private System.Windows.Forms.PictureBox DiceN6;
        private System.Windows.Forms.PictureBox DiceN3;
        private System.Windows.Forms.PictureBox DiceN5;
        private System.Windows.Forms.PictureBox DiceN4;
        private System.Windows.Forms.PictureBox DiceN2;
        private System.Windows.Forms.PictureBox DiceN1;
        private System.Windows.Forms.PictureBox DicePic;
        private System.Windows.Forms.PictureBox ThanosAttack;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.PictureBox Travel_button;
        private System.Windows.Forms.PictureBox Gambling_button;
        private System.Windows.Forms.PictureBox Roll_button;
        private System.Windows.Forms.Label Player1_Name;
        private System.Windows.Forms.Label Player2_Name;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Player2_Tax;
        private System.Windows.Forms.Label Player1_Tax;
        private System.Windows.Forms.PictureBox Chance_Button;
    }
}