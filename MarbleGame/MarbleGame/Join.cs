using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    public partial class Join : Form
    {
        Join_Class join= new Join_Class();

        public Join()
        {
            InitializeComponent();
        }

        private void NewInfo_Load(object sender, EventArgs e)
        {

        }

        private void Join_button_Click(object sender, EventArgs e)
        {
            join.Join(textBox1, textBox2);
            this.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            join.Check_ID(textBox1, label1);
        }
    }
}
