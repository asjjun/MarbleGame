using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    class Login_Class : Member
    {       
        public void Folder_Generate()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(FolderName_path);
            if (directoryInfo.Exists != true)
            {
                directoryInfo.Create();
            }
        }

        public void Login_1p(object id, object pw, object l, object p)
        {
            TextBox textBox_ID = id as TextBox;
            TextBox textBox_PW = pw as TextBox;
            Label LoginLabel = l as Label;
            PictureBox GAME_START = p as PictureBox;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName_path);
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".txt") == 0)
                {
                    FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                    FullFileName = File.FullName;

                    list_ID.Add(FileNameOnly);
                    list_PW.Add(System.IO.File.ReadAllText(FullFileName));

                    if (list_ID.Contains(textBox_ID.Text))
                    {
                        string textBox_ID_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//로그인폴더" + "//" + textBox_ID.Text + ".txt";
                        StreamReader sr = new StreamReader(textBox_ID_path);
                        if (sr.ReadLine() == textBox_PW.Text)
                        {
                            LoginLabel.Text = "로그인";
                            login_1p = true;
                            P1Name = textBox_ID.Text;
                        }
                    }
                }
            }
        }

        public void Login_2p(object id, object pw, object l, object p)
        {
            TextBox textBox_ID = id as TextBox;
            TextBox textBox_PW = pw as TextBox;
            Label LoginLabel = l as Label;
            PictureBox GAME_START = p as PictureBox;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName_path);
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".txt") == 0)
                {
                    FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                    FullFileName = File.FullName;

                    list_ID.Add(FileNameOnly);
                    list_PW.Add(System.IO.File.ReadAllText(FullFileName));

                    if (list_ID.Contains(textBox_ID.Text))
                    {
                        string textBox_ID_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//로그인폴더" + "//" + textBox_ID.Text + ".txt";
                        StreamReader sr = new StreamReader(textBox_ID_path);
                        if (sr.ReadLine() == textBox_PW.Text)
                        {
                            LoginLabel.Text = "로그인";
                            login_2p = true;
                            P2Name = textBox_ID.Text;
                        }
                    }
                }
            }
        }

        public void Login_check(object p)
        {
            PictureBox GAME_START = p as PictureBox;

            if (login_1p == true && login_2p == true)
            {
                GAME_START.Visible = true;
            }
        }
    }
}
