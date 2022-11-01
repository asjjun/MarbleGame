using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    class Join_Class : Member
    {
        Member member = new Member();

        public void Join(object t1, object t2)
        {
            TextBox ID = t1 as TextBox;
            TextBox PW = t2 as TextBox;

            ID_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//로그인폴더" + "//" + ID.Text + ".txt"; 
            StreamWriter sw = new StreamWriter(ID_path);
            sw.Write(PW.Text);
            sw.Close();
            ID.Text = "";
            PW.Text = "";
        }

        public void Check_ID(object t1, object l)
        {
            TextBox textBox1 = t1 as TextBox;
            Label label = l as Label;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName_path);
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".txt") == 0)
                {
                    FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                    FullFileName = File.FullName;
                    list_ID.Add(FileNameOnly);
                }
                list_PW.Add(System.IO.File.ReadAllText(FullFileName));
            }

            if (list_ID.Contains(textBox1.Text))
            {
                label.Text = "사용 불가능한 아이디 입니다.";
            }
            else
            {
                label.Text = "사용 가능한 아이디 입니다.";
            }
        }
    }
}
