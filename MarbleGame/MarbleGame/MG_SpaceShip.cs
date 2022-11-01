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
    public partial class MG_SpaceShip : Form
    {
        SpaceShip ship;
        public Random random = new Random();
        private IMyInterface itf = null;
        private int seconds;
        private int ss_money;

        public int SS_Money
        {
            get { return ss_money; }
            set { ss_money = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public MG_SpaceShip(IMyInterface itf)
        {
            InitializeComponent();
            this.itf = itf;
            ship = new SpaceShip();
        }

        private void MG_SpaceShip_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MG_SpaceShip_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void MG_SpaceShip_KeyDown(object sender, KeyEventArgs e)
        {
            int x = spaceship.Location.X;
            int y = spaceship.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (spaceship.Location.X >= ClientSize.Width - 70)
                {
                    x = x;
                }
                else
                {
                    x += 15;
                }
            }
            else if (e.KeyCode == Keys.Left && e.KeyCode == Keys.Up)
            {
                if (spaceship.Location.X <= 0)
                {
                    x = x;
                }
                else if (spaceship.Location.Y <= 0)
                {
                    y = y;
                }
                else
                {
                    x = x - 15;
                    y = y - 15;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (spaceship.Location.X <= 0)
                {
                    x = x;
                }
                else
                {
                    x -= 15;
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                if (spaceship.Location.Y <= 0)
                {
                    y = y;
                }
                else
                {
                    y -= 15;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (spaceship.Location.Y >= ClientSize.Height - 60)
                {
                    y = y;
                }
                else
                {
                    y += 15;
                }
            }
            spaceship.Location = new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Seconds++;
            TimeLabel.Text = "" + Seconds;
            int x2 = Bullet.Location.X;
            int y2 = Bullet.Location.Y;

            if (x2 >= ClientSize.Width - 50)
            {
                x2 = x2 - 80;
            }
            else if (x2 <= 0)
            {
                x2 = x2 + 50;
            }
            else
            {
                x2 = x2 + random.Next(-30, 30);
            }

            if (y2 >= ClientSize.Width - 50)
            {
                y2 = y2 - 80;
            }
            else if (y2 <= 0)
            {
                y2 = y2 + 50;
            }
            else
            {
                y2 = y2 + random.Next(-30, 30);
            }
            if (x2 > ClientSize.Width)
            {
                x2 = -x2;
            }
            if (y2 > ClientSize.Height)
            {
                y2 = -y2;
            }
            Bullet.Location = new Point(x2, y2);

            if (spaceship.Bounds.IntersectsWith(Bullet.Bounds))
            {
                timer1.Stop();
                ship.GetHitted();
                SS_Money = -300;
                itf.GetMiniMoney(SS_Money);
                this.Close();
            }
            else if (Seconds == 300)
            {
                timer1.Stop();
                MessageBox.Show("상금 300만원 획득!!");
                SS_Money = 300;
                itf.GetMiniMoney(SS_Money);
                this.Close();
            }
        }
    }
}
