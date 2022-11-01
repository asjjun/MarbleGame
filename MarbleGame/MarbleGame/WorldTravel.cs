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
    public partial class WorldTravel : Form
    {
        private IMyInterface itf = null;
        public int locationX = 0, locationY = 0;

        public WorldTravel(IMyInterface itf)
        {
            InitializeComponent();
            this.itf = itf;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 667;
            locationY = 446;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 561;
            locationY = 446;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 455;
            locationY = 446;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 349;
            locationY = 446;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 348;
            locationY = 338;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 348;
            locationY = 230;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 348;
            locationY = 122;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 348;
            locationY = 14;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 454;
            locationY = 13;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 560;
            locationY = 13;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 666;
            locationY = 13;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 773;
            locationY = 121;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 773;
            locationY = 229;
            itf.SetLocation(locationX, locationY);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 773;
            locationY = 337;
            itf.SetLocation(locationX, locationY);
        }

        private void WorldTravel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
            locationX = 773;
            locationY = 446;
            itf.SetLocation(locationX, locationY);
        }
    }
}
