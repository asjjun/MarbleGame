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
    public partial class Gambling : Form
    {
        private IMyInterface itf = null;
        Gambling_Class Machine1 = new Gambling_Class();
        Gambling_Class Machine2 = new Gambling_Class();
        Gambling_Class Machine3 = new Gambling_Class();
        Gambling_Class Sum = new Gambling_Class();
        int check;
        int p1;
        int p2;
        int p3;
        int result_money;
        private int gamble_money;

        public int Gamble_Money
        {
            get { return gamble_money; }
            set { gamble_money = value; }
        }

        public Gambling(IMyInterface itf)
        {
            InitializeComponent();
            Iron_1.Visible = false;
            Iron_2.Visible = false;
            Iron_3.Visible = false;
            Captain_1.Visible = false;
            Captain_2.Visible = false;
            Captain_3.Visible = false;
            Thanos_1.Visible = false;
            Thanos_2.Visible = false;
            Thanos_3.Visible = false;
            info.Dock = DockStyle.Fill;
            this.itf = itf;
        }

        public void Gambling_Load(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
        }

        private void twice_Click(object sender, EventArgs e)
        {
            p1 = Machine1.each();
            p2 = Machine2.each();
            p3 = Machine3.each();
            if (p1 == 1)
            {
                Thanos_1.Visible = true;
            }
            else if (p1 == 2)
            {
                Iron_1.Visible = true;
            }
            else
            {
                Captain_1.Visible = true;
            }

            if (p2 == 1)
            {
                Thanos_2.Visible = true;
            }
            else if (p2 == 2)
            {
                Iron_2.Visible = true;
            }
            else
            {
                Captain_2.Visible = true;
            }

            if (p3 == 1)
            {
                Thanos_3.Visible = true;
            }
            else if (p3 == 2)
            {
                Iron_3.Visible = true;
            }
            else
            {
                Captain_3.Visible = true;
            }

            if (p1 == p2 && p2 == p3)
            {
                check = 3;
            }
            else
            {
                check = 0;
            }

            bool checking = Machine1.result(check);

            result_money = Sum.Re_money(checking, int.Parse(textBox1.Text), 2);

            if (checking == true)
            {
                MessageBox.Show(result_money + "를 얻었습니다", "성공");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
            else
            {
                MessageBox.Show(result_money + "로 돈이 줄었습니다", "실패");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
        }

        private void th_Click(object sender, EventArgs e)
        {
            p1 = Machine1.each();
            p2 = Machine2.each();
            p3 = Machine3.each();
            if (p1 == 1)
            {
                Thanos_1.Visible = true;
            }
            else if (p1 == 2)
            {
                Iron_1.Visible = true;
            }
            else
            {
                Captain_1.Visible = true;
            }

            if (p2 == 1)
            {
                Thanos_2.Visible = true;
            }
            else if (p2 == 2)
            {
                Iron_2.Visible = true;
            }
            else
            {
                Captain_2.Visible = true;
            }

            if (p3 == 1)
            {
                 Thanos_3.Visible = true;
            }
            else if (p3 == 2)
            {
                Iron_3.Visible = true;
            }
            else
            {
                Captain_3.Visible = true;
            }

            if (p1 == p2 && p2 == p3)
            {
                check = 3;
            }
            else
            {
                check = 0;
            }

            bool checking = Machine1.result(check);
            result_money = Sum.Re_money(checking, int.Parse(textBox1.Text), 3);
            if (checking == true)
            {
                MessageBox.Show(result_money + "를 얻었습니다", "성공");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
            else
            {
                MessageBox.Show(result_money + "로 돈이 줄었습니다", "실패");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
        }

        private void qur_Click(object sender, EventArgs e)
        {
            p1 = Machine1.each();
            p2 = Machine2.each();
            p3 = Machine3.each();
            if (p1 == 1)
            {
                Thanos_1.Visible = true;
            }
            else if (p1 == 2)
            {
                Iron_1.Visible = true;
            }
            else
            {
                Captain_1.Visible = true;
            }

            if (p2 == 1)
            {
                Thanos_2.Visible = true;
            }
            else if (p2 == 2)
            {
                Iron_2.Visible = true;
            }
            else
            {
                Captain_2.Visible = true;
            }

            if (p3 == 1)
            {
                Thanos_3.Visible = true;
            }
            else if (p3 == 2)
            {
                Iron_3.Visible = true;
            }
            else
            {
                Captain_3.Visible = true;
            }

            if (p1 == p2 && p2 == p3)
            {
                check = 3;
            }
            else
            {
                check = 0;
            }

            bool checking = Machine1.result(check);
            result_money = Sum.Re_money(checking, int.Parse(textBox1.Text), 4);
            if (checking == true)
            {
                MessageBox.Show(result_money + "를 얻었습니다", "성공");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
            else
            {
                MessageBox.Show(result_money + "로 돈이 줄었습니다", "실패");
                Gamble_Money = result_money - (int.Parse(textBox1.Text));
                itf.GetMiniMoney(Gamble_Money);
                this.Close();
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            info.Visible = false;
        }
    }
}
