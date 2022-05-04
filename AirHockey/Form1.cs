using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace AirHockey
{
    public partial class Background : Form
    {
        Pen drawPen = new Pen(Color.Red, 10);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);


        int player1Score = 0;
        int player2Score = 0;
 
        int playerSpeed = 4;

        int scharge = 0;
        int upArrowcharge = 0;

        int friction = 0;

        float puckXSpeed = -5;
        float puckYSpeed = 5;



        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool fDown = false;
        bool pgUpDown = false;

        bool spaceDown = false;

        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        bool player1Up = false;
        bool player2Up = false;

        bool player1Right = false;
        bool player1Left = false;

        bool player2Right = false;
        bool player2Left = false;

        Rectangle puck = new Rectangle(254, 410, 20, 20);

        Rectangle player1 = new Rectangle(240, 50, 50, 10);
        Rectangle player2 = new Rectangle(240, 780, 50, 10);


        Rectangle boardFarEnd = new Rectangle(71, 0, 400, 46);
        Rectangle boardCloseEnd = new Rectangle(71, 790, 530, 61);
        Rectangle boardLeft = new Rectangle(45, 0, 55, 1048);
        Rectangle boardRight = new Rectangle(430, 0, 55, 1048);

        Rectangle topLeftCorner1 = new Rectangle(64, 50, 25, 35);
        Rectangle topLeftCorner2 = new Rectangle(80, 30, 25, 35);
        Rectangle topLeftCorner3 = new Rectangle(100, 10, 30, 35);

        Rectangle topRightCorner1 = new Rectangle(400, 10, 25, 35);
        Rectangle topRightCorner2 = new Rectangle(420, 30, 25, 35);
        Rectangle topRightCorner3 = new Rectangle(435, 50, 30, 35);

        Rectangle bottomLeftCorner1 = new Rectangle(64, 750, 25, 35);
        Rectangle bottomLeftCorner2 = new Rectangle(80, 770, 25, 35);
        Rectangle bottomLeftCorner3 = new Rectangle(100, 790, 30, 35);

        Rectangle bottomRightCorner3 = new Rectangle(435, 750, 25, 35);
        Rectangle bottomRightCorner2 = new Rectangle(420, 770, 25, 35);
        Rectangle bottomRightCorner1 = new Rectangle(400, 790, 25, 35);



        Rectangle player2Net = new Rectangle(200,797,126,42);
        Rectangle player1Net = new Rectangle(200, 0, 127, 37);

        SoundPlayer puckSmack = new SoundPlayer(Properties.Resources._582265__rocketpancake__justa_slap_smack);





        public Background()
        {
            InitializeComponent();
            Graphics e = this.CreateGraphics();
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    player1Up = true;
                    break;
                case Keys.S:
                    sDown = true;
                    player1Up = false;
                    break;
                case Keys.A:
                    aDown = true;
                    player1Left = true;
                    break;
                case Keys.D:
                    dDown = true;
                    player1Right = true;
                    break;
                case Keys.F:
                    fDown = true;
                    break;


                case Keys.Up:
                    upArrowDown = true;
                    player2Up = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    player2Up = false;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    player2Right = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    player2Left = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.PageUp:
                    pgUpDown = true;
                    break;
            }

            if (spaceDown == true)
            {
                gameTimer.Enabled = true;
                winLabel.Visible = false;
                startLabel.Visible = false;
                puckXSpeed = 5;
                puckYSpeed = -5;
                scharge = 0;
                upArrowcharge = 0;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    player1Left = false;
                    break;
                case Keys.D:
                    dDown = false;
                    player1Right = false;
                    break;
                case Keys.F:
                    fDown = false;
                    break;

                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    player2Right = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    player2Left = true;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.PageUp:
                    pgUpDown = false;
                    break;
            }

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            friction++;

            if (friction % 10 == 0 && Math.Abs(puckYSpeed) > 5)
            {
                if (puckYSpeed > 5)
                {
                    puckYSpeed--;

                }
                else if (puckYSpeed < -5)
                {
                    puckYSpeed++;

                }
            }

            

            if (fDown == true && player1powerBar.Value > 4)
            {
                if (puckYSpeed > 0)
                {
                    puckYSpeed = 10;
                    player1powerBar.Value -= 4;
                }

                else if (puckYSpeed < 0)
                {
                    puckYSpeed = -10;
                    player1powerBar.Value -=4;

                }

                if (puckXSpeed > 0)
                {
                    puckXSpeed = 10;
                }

                else if (puckXSpeed < 0)
                {
                    puckXSpeed = -10;
                }
            }
            else 
            {
                if (puckYSpeed > 0 && player1powerBar.Value != 400)
                {
                    puckYSpeed = 5;
                    player1powerBar.Value++;

                }

                else if (puckYSpeed < 0 && player1powerBar.Value != 400)
                {
                    puckYSpeed = -5;
                    player1powerBar.Value++;

                }

                if (puckXSpeed > 0 && player1powerBar.Value != 400) 
                {
                    puckXSpeed = 5;
                    player1powerBar.Value++;


                }

                else if (puckXSpeed < 0 && player1powerBar.Value != 400)
                {
                    puckXSpeed = -5;
                    player1powerBar.Value++;

                }
            }

            if (pgUpDown == true && player2powerBar.Value > 4)
            {
                if (puckYSpeed > 0)
                {
                    puckYSpeed = 10;
                    player2powerBar.Value -= 4;
                }

                else if (puckYSpeed < 0)
                {
                    puckYSpeed = -10;
                    player2powerBar.Value -= 4;

                }

                if (puckXSpeed > 0)
                {
                    puckXSpeed = 10;
                }

                else if (puckXSpeed < 0)
                {
                    puckXSpeed = -10;
                }
            }
            else
            {
                if (puckYSpeed > 0 && player2powerBar.Value != 400)
                {
                    puckYSpeed = 5;
                    player2powerBar.Value++;

                }

                else if (puckYSpeed < 0 && player2powerBar.Value != 400)
                {
                    puckYSpeed = -5;
                    player2powerBar.Value++;

                }

                if (puckXSpeed > 0 && player2powerBar.Value != 400)
                {
                    puckXSpeed = 5;
                    player2powerBar.Value++;


                }

                else if (puckXSpeed < 0 && player2powerBar.Value != 400)
                {
                    puckXSpeed = -5;
                    player2powerBar.Value++;

                }
            }

            //if (pgUpDown == true && fDown == true && player2powerBar.Value > 4 && player1powerBar.Value > 4) 
            //{ 

            //}


            puck.X += (int)puckXSpeed;
            puck.Y += (int)puckYSpeed;

            if (wDown == true && player1.Y > 38)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < 405)
            {
                player1.Y += playerSpeed;
            }

            if (aDown == true && player1.X > 90)
            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X < 384)
            {
                player1.X += playerSpeed;
            }



            //move player 2
            if (upArrowDown == true && player2.Y > 420)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < 788)
            {
                player2.Y += playerSpeed;
            }

            if (rightArrowDown == true && player2.X < 384)
            {
                player2.X += playerSpeed;
            }

            if (leftArrowDown == true && player2.X > 90)
            {
                player2.X -= playerSpeed;
            }


            //check if ball has crossed the goals
            if (puck.IntersectsWith(player2Net) && puckYSpeed > 0)
            {
                gameTimer.Enabled = false;
                startLabel.Visible = true;

                player1Score++;
                p1scoreLabel.Text = $"{player1Score}";

                puck.X = 254;
                puck.Y = 410;

                player1.Y = 50;
                player1.X = 240;
                player2.Y = 780;
                player2.X = 240;
            }
            else if (puck.IntersectsWith(player1Net) && puckYSpeed < 0)
            {
                gameTimer.Enabled = false;
                startLabel.Visible = true;

                player2Score++;
                p2scoreLabel.Text = $"{player2Score}";

                puck.X = 254;
                puck.Y = 410;

                player1.Y = 50;
                player1.X = 240;
                player2.Y = 780;
                player2.X = 240;
            }


            //check if puck hit top or bottom wall and change direction if it does
            if (puck.Y >= 788 || puck.Y <= 38)
            {
                puckYSpeed *= -1;  // or: puckYSpeed = -puckYSpeed;
            }

            if (puck.X <= 88 || puck.X >= 420)
            {
                puckXSpeed *= -1;  // or: puckYSpeed = -puckYSpeed;
            }


            //Check if puck hits corner
            if (topLeftCorner1.IntersectsWith(puck))
            {
                puckXSpeed = 8;

                if (puckYSpeed < 0)
                {
                    puckYSpeed = -2;
                }
                else
                {
                    puckYSpeed = 2;
                }
                

            }
            
            else if (topLeftCorner2.IntersectsWith(puck))
            {
                puckXSpeed = 6;


                if (puckYSpeed < 0)
                {
                    puckYSpeed = -3;
                }
                else
                {
                    puckYSpeed = 3;
                }
            }

            else if (topLeftCorner3.IntersectsWith(puck))
            {
                puckYSpeed = 8;

                if (puckXSpeed < 0)
                {
                    puckXSpeed = -2;
                }
                else
                {
                    puckXSpeed = 2;
                }
            }


            if (topRightCorner1.IntersectsWith(puck))
            {
                puckYSpeed = 8;

                if (puckXSpeed < 0)
                {
                    puckXSpeed = -2;
                }
                else
                {
                    puckXSpeed = 2;
                }


            }

            else if (topRightCorner2.IntersectsWith(puck))
            {
                puckXSpeed = -6;

                if (puckYSpeed < 0)
                {
                    puckYSpeed = -3;
                }
                else
                {
                    puckYSpeed = 3;
                }
            }

            else if (topRightCorner3.IntersectsWith(puck))
            {
                puckXSpeed = -8;

                if (puckYSpeed < 0)
                {
                    puckYSpeed = -2;
                }
                else
                {
                    puckYSpeed = 2;
                }
            }
           

            if (bottomLeftCorner1.IntersectsWith(puck))
            {
                puckXSpeed = 8;

                if (puckYSpeed < 0)
                {
                    puckYSpeed = -2;
                }
                else
                {
                    puckYSpeed = 2;
                }


            }

            else if (bottomLeftCorner2.IntersectsWith(puck))
            {
                puckXSpeed = 6;


                if (puckYSpeed < 0)
                {
                    puckYSpeed = -3;
                }
                else
                {
                    puckYSpeed = 3;
                }
            }

            else if (bottomLeftCorner3.IntersectsWith(puck))
            {
                puckYSpeed = -8;

                if (puckXSpeed < 0)
                {
                    puckXSpeed = -2;
                }
                else
                {
                    puckXSpeed = 2;
                }
            }
            

            if (bottomRightCorner1.IntersectsWith(puck))
            {
                puckYSpeed = -8;

                if (puckXSpeed < 0)
                {
                    puckXSpeed = -2;
                }
                else
                {
                    puckXSpeed = 2;
                }


            }

            else if (bottomRightCorner2.IntersectsWith(puck))
            {
                puckXSpeed = -6;


                if (puckYSpeed < 0)
                {
                    puckYSpeed = -3;
                }
                else
                {
                    puckYSpeed = 3;
                }
            }

            else if (bottomRightCorner3.IntersectsWith(puck))
            {
                puckXSpeed = -8;

                if (puckYSpeed < 0)
                {
                    puckYSpeed = -2;
                }
                else
                {
                    puckYSpeed = 2;
                }
            }

            //check if puck hits either player. If it does change the direction
            //and place the puck in front of the player hit

            if (sDown == true)
            {
                scharge++;
            }

            if (upArrowDown == true)
            {
                upArrowcharge++;
            }


            if (player1.IntersectsWith(puck) && puckYSpeed < 0)
            {
                puckSmack.Play();

                puckYSpeed *= -1;
                puck.Y = player1.Y + puck.Height;

                if (scharge > 0 && scharge < 10)
                {
                    scharge = 0;
                }

                else if (scharge > 10 && scharge < 50)
                {
                    puckYSpeed *= 2;
                    scharge = 0;
                }

                else if (scharge > 50)
                {
                    puckYSpeed *= 3;
                    scharge = 0;
                }

                else
                {
                    scharge = 0;
                }

                
            }
            else if (player1.IntersectsWith(puck) && puckYSpeed > 0)
            {
                puckSmack.Play();

                puckYSpeed = -5;
                //puckYSpeed *= -1;
                //puckYSpeed = puckYSpeed + 1;
                puck.Y = player1.Y - puck.Height - 5;
            }

            




            if (player2.IntersectsWith(puck) && puckYSpeed < 0)
            {
                puckSmack.Play();

                puckYSpeed = 5; ;
                puck.Y = player2.Y + puck.Height;
            }
            else if (player2.IntersectsWith(puck) && puckYSpeed > 0)
            {
                puckSmack.Play();


                if (upArrowcharge > 0 && upArrowcharge < 10)
                {
                    upArrowcharge = 0;
                }

                else if (upArrowcharge > 10 && upArrowcharge < 50)
                {
                    puckYSpeed *= 2;
                    upArrowcharge = 0;
                }

                else if (upArrowcharge > 50)
                {
                    puckYSpeed *= 3;
                    upArrowcharge = 0;
                }

                else
                {
                    upArrowcharge = 0;
                }

                puckYSpeed *= -1;
                //puckYSpeed = puckYSpeed + 1;
                puck.Y = player2.Y - puck.Height;
            }

           




            // check score and stop game if either player is at 3
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
                startLabel.Visible = true;
                startLabel.Text = "Press Start to Play Again";

                player1Score = 0;
                player2Score = 0;
                p1scoreLabel.Text = $"{player1Score}";
                p2scoreLabel.Text = $"{player2Score}";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
                startLabel.Visible = true;
                startLabel.Text = "Press Start to Play Again";

                player1Score = 0;
                player2Score = 0;
                p1scoreLabel.Text = $"{player1Score}";
                p2scoreLabel.Text = $"{player2Score}";
            }

            this.Text = $"{puckYSpeed}, sCharge: {scharge}, upCharge: {upArrowcharge}";
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(drawBrush, 180, 225, 30, 30);
            e.Graphics.FillRectangle(blackBrush, puck);
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);

            e.Graphics.FillRectangle(blueBrush, player1Net);
            e.Graphics.FillRectangle(redBrush, player2Net);

            //e.Graphics.DrawArc(drawPen, 82, 36, 95, 95, 180, 90);
            //e.Graphics.DrawArc(drawPen, 348, 36, 95, 95, 0, -90);

            //e.Graphics.FillRectangle(redBrush, 64, 50, 25, 35);
            //e.Graphics.FillRectangle(redBrush, 80, 30, 25, 35);
            //e.Graphics.FillRectangle(redBrush, 100, 10, 30, 35);

            //e.Graphics.FillRectangle(redBrush, topLeftCorner1);
            //e.Graphics.FillRectangle(redBrush, topLeftCorner2);
            //e.Graphics.FillRectangle(redBrush, topLeftCorner3);
            //e.Graphics.FillRectangle(redBrush, topRightCorner1);
            //e.Graphics.FillRectangle(redBrush, topRightCorner2);
            //e.Graphics.FillRectangle(redBrush, topRightCorner3);
            //e.Graphics.FillRectangle(redBrush, bottomLeftCorner1);
            //e.Graphics.FillRectangle(redBrush, bottomLeftCorner2);
            //e.Graphics.FillRectangle(redBrush, bottomLeftCorner3);
            //e.Graphics.FillRectangle(redBrush, bottomRightCorner1);
            //e.Graphics.FillRectangle(redBrush, bottomRightCorner2);
            //e.Graphics.FillRectangle(redBrush, bottomRightCorner3);




            //e.Graphics.FillRectangle(drawBrush, boardCloseEnd);
            //e.Graphics.FillRectangle(drawBrush, boardFarEnd);
            //e.Graphics.FillRectangle(drawBrush, boardLeft);
            //e.Graphics.FillRectangle(drawBrush, boardRight);
        }
    }
}
