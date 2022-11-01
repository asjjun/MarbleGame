using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    class Dice
    {
        public int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
        public Random r = new Random();

        private int dice_number;

        public int Dice_Number
        {
            get { return dice_number; }
            set { dice_number = value; }
        }

        public void Roll_Dice()
        {
            Dice_Number = r.Next(1, 7);
        }
        public void Initialization_Count()
        {
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
            count5 = 0;
            count6 = 0;
        }
        public void Count_DiceNumber()
        {
            if (Dice_Number == 1)
            {
                count1++;
            }
            if (Dice_Number == 2)
            {
                count2++;
            }
            if (Dice_Number == 3)
            {
                count3++;
            }
            if (Dice_Number == 4)
            {
                count4++;
            }
            if (Dice_Number == 5)
            {
                count5++;
            }
            if (Dice_Number == 6)
            {
                count6++;
            }
        }

        public void Number_Show(object p1, object p2, object p3, object p4, object p5, object p6)
        {
            PictureBox DiceN1 = p1 as PictureBox;
            PictureBox DiceN2 = p2 as PictureBox;
            PictureBox DiceN3 = p3 as PictureBox;
            PictureBox DiceN4 = p4 as PictureBox;
            PictureBox DiceN5 = p5 as PictureBox;
            PictureBox DiceN6 = p6 as PictureBox;

            if (Dice_Number == 1)
            {
                DiceN1.Visible = true;
                DiceN2.Visible = false;
                DiceN3.Visible = false;
                DiceN4.Visible = false;
                DiceN5.Visible = false;
                DiceN6.Visible = false;
            }
            if (Dice_Number == 2)
            {
                DiceN1.Visible = false;
                DiceN2.Visible = true;
                DiceN3.Visible = false;
                DiceN4.Visible = false;
                DiceN5.Visible = false;
                DiceN6.Visible = false;
            }
            if (Dice_Number == 3)
            {
                DiceN1.Visible = false;
                DiceN2.Visible = false;
                DiceN3.Visible = true;
                DiceN4.Visible = false;
                DiceN5.Visible = false;
                DiceN6.Visible = false;
            }
            if (Dice_Number == 4)
            {
                DiceN1.Visible = false;
                DiceN2.Visible = false;
                DiceN3.Visible = false;
                DiceN4.Visible = true;
                DiceN5.Visible = false;
                DiceN6.Visible = false;
            }
            if (Dice_Number == 5)
            {
                DiceN1.Visible = false;
                DiceN2.Visible = false;
                DiceN3.Visible = false;
                DiceN4.Visible = false;
                DiceN5.Visible = true;
                DiceN6.Visible = false;
            }
            if (Dice_Number == 6)
            {
                DiceN1.Visible = false;
                DiceN2.Visible = false;
                DiceN3.Visible = false;
                DiceN4.Visible = false;
                DiceN5.Visible = false;
                DiceN6.Visible = true;
            }
        }

        public void Dice_Initialization(object p1, object p2, object p3, object p4, object p5, object p6)
        {
            PictureBox DiceN1 = p1 as PictureBox;
            PictureBox DiceN2 = p2 as PictureBox;
            PictureBox DiceN3 = p3 as PictureBox;
            PictureBox DiceN4 = p4 as PictureBox;
            PictureBox DiceN5 = p5 as PictureBox;
            PictureBox DiceN6 = p6 as PictureBox;
            DiceN1.Visible = false;
            DiceN2.Visible = false;
            DiceN3.Visible = false;
            DiceN4.Visible = false;
            DiceN5.Visible = false;
            DiceN6.Visible = false;
        }
    }
}
