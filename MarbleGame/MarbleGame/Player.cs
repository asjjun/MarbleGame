using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleGame
{
    class Player
    {
        private string userName;
        private int money;
        private int user_turn;
        private int turn_count;
        private int tax;

        public int Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        public int Turn_count
        {
            get { return turn_count; }
            set { turn_count = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int User_turn
        {
            get { return user_turn; }
            set { user_turn = value; }
        }

        public int GetMoney(int bonus)
        {
            Money = Money + bonus;
            return Money;
        }

        public int LoseMoney(int lose_money)
        {
            Money = Money - lose_money;
            return Money;
        }    

        public void Player_Move(object p)
        {
            PictureBox Player = p as PictureBox;
            if ((Player.Location.X >= 349 && Player.Location.X <= 773) && (Player.Location.Y == 446)) // 1번
            {
                int x = 106;
                x = Player.Location.X - x;
                Player.Location = new Point(x, 446);
                if (Player.Location.X == 243 && Player.Location.Y == 446)
                {
                    Player.Location = new Point(348, 446);
                }
            }
            if (Player.Location.X == 348 && (Player.Location.Y >= 14 && Player.Location.Y <= 446)) // 2번
            {
                int y = 108;
                y = Player.Location.Y - y;
                Player.Location = new Point(348, y);
                if (Player.Location.X == 348 && Player.Location.Y == -94)
                {
                    Player.Location = new Point(348, 13);
                }
            }
            if ((Player.Location.X >= 348 && Player.Location.X <= 773) && (Player.Location.Y == 13)) // 3번
            {
                int x = 106;
                x = Player.Location.X + x;
                Player.Location = new Point(x, 13);
                if (Player.Location.X == 878 && Player.Location.Y == 13)
                {
                    Player.Location = new Point(773, 13);
                }
            }
            if (Player.Location.X == 773 && (Player.Location.Y >= 13 && Player.Location.Y <= 446)) // 4번
            {
                int y = 108;
                y = Player.Location.Y + y;
                Player.Location = new Point(773, y);
                if (Player.Location.X == 773 && Player.Location.Y == 445)
                {
                    Player.Location = new Point(773, 446);
                }
            }
        }

        public void LocationSame(object p1, object p2, object p1vsp2)
        {
            PictureBox Player1 = p1 as PictureBox;
            PictureBox Player2 = p2 as PictureBox;
            PictureBox Player1vsPlayer2 = p1vsp2 as PictureBox;
            if (Player1.Location == Player2.Location)
            {
                int x = 50, y;
                x = Player1.Location.X - x;
                y = Player1.Location.Y;
                Player1vsPlayer2.Location = new Point(x, y);

                Player1vsPlayer2.Visible = true;
                Player1.Visible = false;
                Player2.Visible = false;
            }
            else
            {
                Player1vsPlayer2.Visible = false;
                Player1.Visible = true;
                Player2.Visible = true;
            }
        }

        public void ArrivalEvent(object p, object t, object mg_space, object mg_shooting, object mg_pingpong, object thanos, object world, object gamble, object roll, object Chance)
        {
            PictureBox Player = p as PictureBox;
            PictureBox Space_button = mg_space as PictureBox;
            PictureBox Shooting_button = mg_shooting as PictureBox;
            PictureBox PingPong_button = mg_pingpong as PictureBox;
            PictureBox Thanos = thanos as PictureBox;
            PictureBox World = world as PictureBox;
            PictureBox Gamble = gamble as PictureBox;
            PictureBox Roll_button = roll as PictureBox;
            PictureBox Chance_Button = Chance as PictureBox;
            Timer timer = t as Timer;

            if(Player.Location.Y == 446 && timer.Enabled == false) // 줄 1
            {
                if(Player.Location.X == 667) // 줄 1, 1번
                {
                    MessageBox.Show("우주선이 고장났어요 ㅠㅠ\n\n수리비 200만원내고 고쳐야겠어요");
                    LoseMoney(200);
                }
                if(Player.Location.X == 561) // 줄 1, 2번
                {
                    MessageBox.Show("도박 버튼을 눌러 도박을 진행하세요");
                    Gamble.Visible = true;
                    Roll_button.Enabled = false;
                }
                if (Player.Location.X == 455) // 줄 1, 3번
                {
                    MessageBox.Show("~~행운의 네잎클로버를 찾았습니다~~\n~100만원에 팔았어요~");
                    GetMoney(100);
                }
                if(Player.Location.X == 349) // 줄 1, 4번
                {
                    MessageBox.Show("우주 검문소의 통행료를 내야해요 ㅠㅠ\n\n 100만원 내야해요ㅠ");
                    LoseMoney(100);
                }
            }
            if (Player.Location.X == 348 && timer.Enabled == false) // 줄 2
            {
                if (Player.Location.Y == 338) // 줄 2, 1번
                {
                    //찬스카드
                    MessageBox.Show("찬스!");
                    Chance_Button.Visible = true;
                    Roll_button.Enabled = false;
                }
                if (Player.Location.Y == 230) // 줄 2, 2번
                {
                    //우주선게임
                    MessageBox.Show("미니게임 버튼 누르고 시작!");
                    Space_button.Visible = true;
                    Roll_button.Enabled = false;
                }
                if (Player.Location.Y == 122) // 줄 2, 3번
                {
                    //돈 받기
                    MessageBox.Show("인피니티 스톤 휙득! 500만원 ㅊㅋ");
                    GetMoney(500);
                }
                if (Player.Location.Y == 14) // 줄 2, 4번
                {
                    //슈팅게임
                    MessageBox.Show("미니게임 버튼 누르고 시작!");
                    Shooting_button.Visible = true;
                    Roll_button.Enabled = false;
                }
            }
            if (Player.Location.Y == 13 && timer.Enabled == false) // 줄 3
            {
                if (Player.Location.X == 454) // 줄 3, 1번
                {
                    //찬스카드
                    MessageBox.Show("찬스!");
                    Chance_Button.Visible = true;
                    Roll_button.Enabled = false;
                }
                if (Player.Location.X == 560) // 줄 3, 2번
                {
                    //돈 걷기
                    MessageBox.Show("100만원 세금 내세요");
                    LoseMoney(100);
                    Tax = Tax + 100;
                }
                if (Player.Location.X == 666) // 줄 3, 3번
                {
                    // 세금 모아둔것 받기
                    MessageBox.Show("세금 받아가세요");
                    GetMoney(Tax);
                    Tax = 0;
                }
                if (Player.Location.X == 772) // 줄 3, 4번
                {
                    //세계여행
                    MessageBox.Show("세계 여행!");
                    World.Visible = true;
                    Roll_button.Enabled = false;
                }
            }
            if (Player.Location.X == 773 && Player.Location.Y == 446) // 시작점
            {
                //MessageBox.Show("월급");
                GetMoney(100);
            }
            if (Player.Location.X == 773 && timer.Enabled == false) // 줄 4
            {
                if (Player.Location.Y == 121) // 줄 4, 1번
                {
                    //핑퐁게임
                    MessageBox.Show("미니게임 버튼 누르고 시작!");
                    PingPong_button.Visible = true;
                    Roll_button.Enabled = false;
                }
                if (Player.Location.Y == 229) // 줄 4, 2번
                {
                    //타노스
                    Thanos.Visible = true;
                }
                if (Player.Location.Y == 337) // 줄 4, 3번
                {
                    //찬스카드
                    MessageBox.Show("찬스!");
                    Chance_Button.Visible = true;
                    Roll_button.Enabled = false;
                }               
            }
        }

        public void ShowMoney(object l, object T_label)
        {
            Label Tax_label = T_label as Label;
            Label PMoney = l as Label;
            PMoney.Text = Money+"만원";
            Tax_label.Text = "세금 : "+Tax+"만원";
        }

        public void RemoveLabel(object l1, object l2, object l3, object l4)
        {
            Label P1Tax = l1 as Label;
            Label P2Tax = l2 as Label;
            Label P1Tax_m = l3 as Label;
            Label P2Tax_m = l4 as Label;

            P1Tax.Visible = false;
            P2Tax.Visible = false;
            P1Tax_m.Visible = false;
            P2Tax_m.Visible = false;
        }

        public void ShowLabel(object l1, object l2, object l3, object l4)
        {
            Label P1Tax = l1 as Label;
            Label P2Tax = l2 as Label;
            Label P1Tax_m = l3 as Label;
            Label P2Tax_m = l4 as Label;

            P1Tax.Visible = true;
            P2Tax.Visible = true;
            P1Tax_m.Visible = true;
            P2Tax_m.Visible = true;
        }
    }
}