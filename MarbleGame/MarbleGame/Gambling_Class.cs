using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleGame
{
    class Gambling_Class
    {
        static Random r = new Random();
        public int Random_Picture;

        public int each()
        {
            Random_Picture = r.Next(1, 4);
            return Random_Picture;
        }

        public bool result(int same_count)
        {
            if (same_count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Re_money(bool check, int inp, int multipul)
        {
            if (check == true)
            {
                return inp * multipul;
            }
            else
            {
                return inp / multipul;
            }
        }
    }
}
