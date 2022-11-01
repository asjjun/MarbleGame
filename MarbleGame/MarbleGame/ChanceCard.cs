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
    public partial class ChanceCard : Form
    {
        public Random r = new Random();
        private int chance_money;
        public int num;
        private IMyInterface itf = null;
        public int locationX = 0, locationY = 0;

        public ChanceCard(IMyInterface itf)
        {
            InitializeComponent();
            this.itf = itf;
        }

        public ChanceCard()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            num = r.Next(1, 5);
            if (num == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                chance_money = -300;
                itf.GetMiniMoney(chance_money);
                MessageBox.Show("300만원을 잃었습니다");
                this.Close();
            }
            else if (num == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                chance_money = 300;
                itf.GetMiniMoney(chance_money);
                MessageBox.Show("300만원을 얻었습니다");
                this.Close();
            }
            else if (num == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                MessageBox.Show("인피니티 스톤을 휙득하러 갑니다");
                this.Close();
                locationX = 348;
                locationY = 122;
                itf.SetLocation(locationX, locationY);
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                MessageBox.Show("타노스가 부른다 따라가보자!");
                this.Close();
                locationX = 773;
                locationY = 229;
                itf.SetLocation(locationX, locationY);
            }
        }

        private void ChanceCard_Load(object sender, EventArgs e)
        {

        }
    }
}
