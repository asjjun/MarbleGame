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
    public partial class MainForm : Form,IMyInterface
    {
        Random r = new Random();
        Dice dice = new Dice();
        Player player1 = new Player();
        Player player2 = new Player();

        private string playerText1;
        private string playerText2;

        public string PlayerText1
        {
            get { return playerText1; }
            set { playerText1 = value; }
        }   
        public string PlayerText2
        {
            get { return playerText2; }
            set { playerText2 = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            Player1.Location = new Point(773, 446);
            Player2.Location = new Point(773, 446);
            player1.User_turn = 1;
            player2.User_turn = 1;
            player2.Turn_count = 10;
            player1.Money = 1000;
            player2.Money = 1000;
            player1.ShowMoney(P1Money, Player1_Tax);
            player2.ShowMoney(P2Money, Player2_Tax);
            Player1vsPlayer2.Visible = false;
            Space_button.Visible = false;
            Shooting_button.Visible = false;
            PingPong_button.Visible = false;
            player1.LocationSame(Player1, Player2, Player1vsPlayer2);
            DicePic.Visible = false;
            DiceN1.Visible = false;
            DiceN2.Visible = false;
            DiceN3.Visible = false;
            DiceN4.Visible = false;
            DiceN5.Visible = false;
            DiceN6.Visible = false;
            ThanosAttack.Dock = DockStyle.Fill;   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Player1_Name.Text = PlayerText1;
            Player2_Name.Text = PlayerText2;
        }

        public void GetMiniMoney(int minimoney)
        {
            if(player1.User_turn == 2 && player2.User_turn == 2)
            {
                player1.GetMoney(minimoney);
                player1.ShowMoney(P1Money, Player1_Tax);
            }
            else if(player1.User_turn == 1 && player2.User_turn == 1)
            {
                player2.GetMoney(minimoney);
                player2.ShowMoney(P2Money, Player2_Tax);
            }
        }
        public void SetLocation(int locationX, int locationY)
        {
            if (player1.User_turn == 2 && player2.User_turn == 2)
            {
                Player1.Location = new Point(locationX, locationY);
                player1.LocationSame(Player1, Player2, Player1vsPlayer2);
                player1.ArrivalEvent(Player1, timer1, Space_button, Shooting_button, PingPong_button, ThanosAttack, Travel_button, Gambling_button, Roll_button, Chance_Button);
                if (Player1.Location.X == 773 && Player1.Location.Y == 229)
                {
                    dice.Dice_Initialization(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
                    Turn.Visible = false;
                    Roll_button.Visible = false;
                    player1.RemoveLabel(Player1_Name, Player2_Name, Player1_Tax, Player2_Tax);
                }
                player1.ShowMoney(P1Money, Player1_Tax);
            }
            else if (player1.User_turn == 1 && player2.User_turn == 1)
            {
                Player2.Location = new Point(locationX, locationY);
                player2.LocationSame(Player1, Player2, Player1vsPlayer2);
                player2.ArrivalEvent(Player2, timer2, Space_button, Shooting_button, PingPong_button, ThanosAttack, Travel_button, Gambling_button, Roll_button, Chance_Button);
                if (Player2.Location.X == 773 && Player2.Location.Y == 229)
                {
                    dice.Dice_Initialization(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
                    Turn.Visible = false;
                    Roll_button.Visible = false;
                    player2.RemoveLabel(Player1_Name, Player2_Name, Player1_Tax, Player2_Tax);
                }
                player2.ShowMoney(P2Money, Player2_Tax);
            }
        }

        private void Roll_button_Click(object sender, EventArgs e)
        {
            dice.Roll_Dice();
            if (player1.User_turn == 1)
            {
                DicePic.Visible = true;
                timer1.Enabled = true;
            }
            if (player2.User_turn == 2)
            {
                DicePic.Visible = true;
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1.Player_Move(Player1);
            dice.Count_DiceNumber();
            dice.Number_Show(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
            DicePic.Visible = false;
            player1.LocationSame(Player1, Player2, Player1vsPlayer2);
            if (dice.count1 == 1 || dice.count2 == 2 || dice.count3 == 3 || dice.count4 == 4 || dice.count5 == 5 || dice.count6 == 6)
            {
                timer1.Enabled = false;
                player1.User_turn = 2;
                player2.User_turn = 2;
                dice.Initialization_Count();
            }
            player1.ArrivalEvent(Player1, timer1, Space_button, Shooting_button, PingPong_button, ThanosAttack, Travel_button, Gambling_button, Roll_button, Chance_Button);
            if (Player1.Location.X == 773  && Player1.Location.Y == 229 && timer1.Enabled == false)
            {
                dice.Dice_Initialization(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
                Turn.Visible = false;
                Roll_button.Visible = false;
                player1.RemoveLabel(Player1_Name, Player2_Name, Player1_Tax, Player2_Tax);
            }
            if(Player1.Location.X == 666 && Player1.Location.Y == 13 && timer1.Enabled == false)
            {
                player1.GetMoney(player1.Tax + player2.Tax);
            }
            player1.ShowMoney(P1Money, Player1_Tax);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player2.Player_Move(Player2);
            dice.Count_DiceNumber();
            dice.Number_Show(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
            DicePic.Visible = false;
            player2.LocationSame(Player1, Player2, Player1vsPlayer2);
            if (dice.count1 == 1 || dice.count2 == 2 || dice.count3 == 3 || dice.count4 == 4 || dice.count5 == 5 || dice.count6 == 6)
            {
                timer2.Enabled = false;
                player1.User_turn = 1;
                player2.User_turn = 1;
                player2.Turn_count--;
                Turn.Text = "남은 턴 : " + player2.Turn_count;
                dice.Initialization_Count();
            }
            player2.ArrivalEvent(Player2, timer2, Space_button, Shooting_button, PingPong_button, ThanosAttack, Travel_button, Gambling_button, Roll_button, Chance_Button);
            if (Player2.Location.X == 773 && Player2.Location.Y == 229 && timer2.Enabled == false)
            {
                dice.Dice_Initialization(DiceN1, DiceN2, DiceN3, DiceN4, DiceN5, DiceN6);
                Turn.Visible = false;
                Roll_button.Visible = false;
                player2.RemoveLabel(Player1_Name, Player2_Name, Player1_Tax, Player2_Tax);
            }           
            player2.ShowMoney(P2Money, Player2_Tax);
        }

        private void Space_button_Click(object sender, EventArgs e)
        {
            MG_SpaceShip mG_SpaceShip = new MG_SpaceShip(this as IMyInterface);
            mG_SpaceShip.Show();
            Space_button.Visible = false;
            Roll_button.Enabled = true;
        }
        private void Shooting_button_Click(object sender, EventArgs e)
        {
            MG_ShootingGame mG_ShootingGame = new MG_ShootingGame(this as IMyInterface);
            mG_ShootingGame.Show();
            Shooting_button.Visible = false;
            Roll_button.Enabled = true;
        }
        private void PingPong_button_Click(object sender, EventArgs e)
        {
            MG_PingPong mG_PingPong = new MG_PingPong(this as IMyInterface);
            mG_PingPong.Show();
            PingPong_button.Visible = false;
            Roll_button.Enabled = true;
        }
        private void ThanosAttack_Click(object sender, EventArgs e)
        {
            ThanosAttack.Visible = false;
            Turn.Visible = true;
            Roll_button.Visible = true;
            player1.ShowLabel(Player1_Name, Player2_Name, Player1_Tax, Player2_Tax);
            MessageBox.Show("타노스한테 죽빵을 맞고 삥도 뜯겼습니다.\n\n\n            500만원 내놓으세여");
            if (player1.User_turn == 2 && player2.User_turn == 2)
            {
                player1.LoseMoney(500);
                player1.ShowMoney(P1Money, Player1_Tax);
            }
            else if (player1.User_turn == 1 && player2.User_turn == 1)
            {
                player2.LoseMoney(500);
                player2.ShowMoney(P2Money, Player1_Tax);
            }
        }
        private void Gambling_button_Click(object sender, EventArgs e)
        {
            Gambling gambling = new Gambling(this as IMyInterface);
            gambling.Show();
            Gambling_button.Visible = false;
            Roll_button.Enabled = true;
        }
        private void Travel_button_Click(object sender, EventArgs e)
        {
            WorldTravel worldTravel = new WorldTravel(this as IMyInterface);
            worldTravel.Show();
            Travel_button.Visible = false;
            Roll_button.Enabled = true;
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (player1.Money < 0 || player2.Money < 0 || player2.Turn_count == 0 )
            {
                timer3.Enabled = false;
                if (player1.Money > player2.Money)
                {
                    MessageBox.Show("플레이어1 승리");
                }
                else if (player1.Money < player2.Money)
                {
                    MessageBox.Show("플레이어2 승리");
                }
                else
                {
                    MessageBox.Show("무승부");
                }
                MessageBox.Show("게임 종료");
                Environment.Exit(0);
            }   
        }

        private void Chance_Button_Click(object sender, EventArgs e)
        {
            ChanceCard chance = new ChanceCard(this as IMyInterface);
            chance.Show();
            Chance_Button.Visible = false;
            Roll_button.Enabled = true;
        }
    }
}
