using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleGame
{
    class Member
    {
        public string ID_path;
        public string FolderName_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//로그인폴더";
        public string FullFileName;
        public string FileNameOnly;
        public List<string> list_ID = new List<string>();
        public List<string> list_PW = new List<string>();
        public bool login_1p = false, login_2p = false;
        private string p1name;
        private string p2name;

        public string P1Name
        {
            get { return p1name; }
            set { p1name = value; }
        }
        public string P2Name
        {
            get { return p2name; }
            set { p2name = value; }
        }
    }
}
