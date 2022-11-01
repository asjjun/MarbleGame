using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MarbleGame
{
    public partial class Login : Form
    {     
        Login_Class login_class = new Login_Class();       

        public Login()
        {
            InitializeComponent();
            GAME_START.Visible = false;
        }

        private void Join_Load(object sender, EventArgs e)
        {

        }

        private void ToJoin_Click(object sender, EventArgs e)
        {
            Join newInfo = new Join();
            newInfo.Show();
            login_class.Folder_Generate();
        }

        private void LOGIN1_Click(object sender, EventArgs e)
        {
            login_class.Login_1p(textBox1, textBox2, LoginLabel1, GAME_START);
            login_class.Login_check(GAME_START);
        }

        private void LOGIN2_Click(object sender, EventArgs e)
        {
            login_class.Login_2p(textBox3, textBox4, LoginLabel2, GAME_START);
            login_class.Login_check(GAME_START);
        }

        private void GAME_START_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.PlayerText1 = login_class.P1Name;
            mainForm.PlayerText2 = login_class.P2Name;
            mainForm.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
