using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    public partial class MG_PingPong : Form
    {
        private IMyInterface itf = null;

        protected bool goup;
        protected bool godown;
        public int speed = 1;
        public int Sballx = 13;
        public int Sbally = 13;
        private int seconds = 0;
        private int pp_money;

        public int PP_Money
        {
            get { return pp_money; }
            set { pp_money = value; }
        }

        public MG_PingPong(IMyInterface itf)
        {
            InitializeComponent();
            this.itf = itf;
        }

        private void MG_PingPong_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpiderBall_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeLabel.Text = "" + seconds;
            SpiderBall.Top -= Sbally;
            SpiderBall.Left -= Sballx;

            Bar2.Top += speed;

            if (Bar2.Top < 0 || Bar2.Top > 455)
            {
                speed = -speed;
            }
            else
            {
                Bar2.Top = SpiderBall.Top + 13;
            }

            if (SpiderBall.Left < 0)
            {
                timer1.Stop();
                MessageBox.Show("패배하셨습니다. 100만원 잃으셨어요");
                PP_Money = -100;
                itf.GetMiniMoney(PP_Money);
                this.Close();
            }

            if (SpiderBall.Top < 0 || SpiderBall.Top + SpiderBall.Height > ClientSize.Height)
            {
                Sbally = -Sbally;
            }
            if (SpiderBall.Bounds.IntersectsWith(Bar1.Bounds) || SpiderBall.Bounds.IntersectsWith(Bar2.Bounds))//바와 스파이더맨이 교차하는 순간 스피드를 전환//
            {
                Sballx = -Sballx;
            }

            if (goup == true && Bar1.Top > 0)
            {
                Bar1.Top -= 8;
            }
            if (godown == true && Bar1.Top < 497)
            {
                Bar1.Top += 8;
            }
            if (seconds == 500)
            {
                timer1.Stop();
                MessageBox.Show("이겼습니다!! 500만원 ㅊㅋ");
                PP_Money = 500;
                itf.GetMiniMoney(PP_Money);
                this.Close();
            }
        }

        private void MG_PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void MG_PingPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
    }
}
