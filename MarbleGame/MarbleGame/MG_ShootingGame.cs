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
    public partial class MG_ShootingGame : Form
    {
        private IMyInterface itf = null;

        Random random = new Random();
        int count = 0;
        int chance = 10;

        private int sg_money;

        public int SG_Money
        {
            get { return sg_money; }
            set { sg_money = value; }
        }

        public MG_ShootingGame(IMyInterface itf)
        {
            InitializeComponent();
            this.itf = itf;
        }

        private void MG_ShootingGame_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Enemy1.Location.X;
            int y = Enemy1.Location.Y;
            x = random.Next(1, ClientSize.Width);
            y = random.Next(1, ClientSize.Height);
            Enemy1.Location = new Point(x, y);


            int x1 = Enemy2.Location.X;
            int y1 = Enemy2.Location.Y;
            x1 = random.Next(1, ClientSize.Width);
            y1 = random.Next(1, ClientSize.Height);
            Enemy2.Location = new Point(x1, y1);

            if (x < x1 + 50 && x > x1 - 50 && y < y1 + 50 && y > y1 - 50)
            {
                x = random.Next(1, ClientSize.Width);
                y = random.Next(1, ClientSize.Height);
                Enemy1.Location = new Point(x, y);
            }
            Enemy1.Visible = true;
            Enemy2.Visible = true;
            if (count == 5)
            {
                timer1.Stop();
            }
        }

        private void Enemy1_Click(object sender, EventArgs e)
        {
            Enemy1.Visible = false;
            if (chance > 0)
            {
                count++;
                chance--;
                if (count == 5)
                {
                    label1.Text = "" + count;
                    label2.Text = "" + chance;
                    MessageBox.Show("***********성공***********\n\n상금 100만원");
                    SG_Money = 100;
                    itf.GetMiniMoney(SG_Money);
                    this.Close();
                }
                else
                {
                    label1.Text = "" + count;
                    label2.Text = "" + chance;
                }
            }
        }

        private void Enemy2_Click(object sender, EventArgs e)
        {
            Enemy2.Visible = false;
            if (chance > 0)
            {
                count++;
                chance--;
                if (count == 5)
                {
                    label1.Text = "" + count;
                    label2.Text = "" + chance;
                    MessageBox.Show("***********성공***********\n\n상금 100만원");
                    SG_Money = 100;
                    itf.GetMiniMoney(SG_Money);
                    this.Close();
                }
                else
                {
                    label1.Text = "" + count;
                    label2.Text = "" + chance;
                }
            }
        }

        private void MG_ShootingGame_Click(object sender, EventArgs e)
        {

        }

        private void BackGround_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursor.Current;
            chance--;
            if (chance > 0)
            {
                label2.Text = "" + chance;
            }
            else
            {
                label2.Text = "" + chance;
                MessageBox.Show("ㅠㅠㅠㅠㅠ실패ㅠㅠㅠㅠㅠ\n\n500만원 잃었습니다ㅠㅠ");
                SG_Money = - 500;
                itf.GetMiniMoney(SG_Money);
                this.Close();
            }
        }
    }
}
