using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Properties;

using System.Drawing.Imaging;///add this for the jpg comparison
namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle> ();
        private Circle food = new Circle();

        int maxwidth;
        int maxheight;

        int score;
        int highscore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;



        public Form1()
        {
            InitializeComponent();
            new Setting();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up) 
            { 
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Setting.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Setting.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Setting.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Setting.directions != "up")
            {
                goDown = true;
            }
        }

        private void btn_Snap_Click(object sender, EventArgs e)
        {
             Label caption  = new Label();
            caption.Text = "I Scored:" + score + "and my Highscore" + highscore + "On the Snake GAme from Moo ICt";
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.LightBlue;
            caption.AutoSize = false;
            caption.Width = Pic_Canvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleLeft;
            Pic_Canvas.Controls.Add(caption);

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Snake Game Sanpshot Moo ICt";
            save.DefaultExt = "jpg";
            save.Filter = "JPG Image File |*.jpg";
            save.ValidateNames = true;


            if (save.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(Pic_Canvas.Width);
                int height = Convert.ToInt32(Pic_Canvas.Height);
                Bitmap bmp= new Bitmap(width, height);
                Pic_Canvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(save.FileName,ImageFormat.Jpeg);
                Pic_Canvas.Controls.Remove(caption);
            }




        }

        private void GameTimeEvent(object sender, EventArgs e)
        {
            try
            {
                // setting the directions 
                if (goLeft)
                {
                    Setting.directions = "left";
                }
                if (goRight)
                {
                    Setting.directions = "right";
                }
                if (goDown)
                {
                    Setting.directions = "down";
                }
                if (goUp)
                {
                    Setting.directions = "up";
                }
                // end of Direction
                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (Setting.directions)
                        {
                            case "left":
                                Snake[i].X--;
                                break;
                            case "right":
                                Snake[i].X++;
                                break;
                            case "down":
                                Snake[i].Y++;
                                break;
                            case "up":
                                Snake[i].Y--;
                                break;

                        }
                        if (Snake[i].X < 0)
                        {
                            Snake[i].X = maxwidth;

                        }
                        if (Snake[i].X > maxwidth)
                        {
                            Snake[i].X = 0;
                        }
                        if (Snake[i].Y < 0)
                        {
                            Snake[i].Y = maxheight;
                        }
                        if (Snake[i].Y > maxheight)
                        {
                            Snake[i].Y = 0;
                        }
                        if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                        {
                            EatFood();
                        }

                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                            {
                                GameOver();
                            }
                        }


                    }
                    else
                    {
                        Snake[i].X = Snake[i - 1].X;
                        Snake[i].Y = Snake[i - 1].Y;
                    }
                    }
                    Pic_Canvas.Invalidate();
                }
            
            catch (Exception Ex)
            {
                MessageBox.Show("Timer Event", "Aert");
            }
            

           
        }

        private void PictureGrphics(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i =0; i < Snake.Count; i++)
            {
                if(i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColor, new Rectangle
                (
                  Snake[i].X  * Setting.width,
                  Snake[i].Y *  Setting.height,
                  Setting.width, Setting.height
                ));

            }

                canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                (
                  food.X * Setting.width,
                  food.Y * Setting.height,
                  Setting.width, Setting.height
                ));

        }
        private void RestartGame()
        {
            maxwidth = Pic_Canvas.Width / Setting.width - 1;
            maxheight = Pic_Canvas.Height / Setting.height - 1;

            Snake.Clear();

            btn_start.Enabled = false;
            btn_Snap.Enabled = false;
            score = 0;
            tex_HighScore.Text = "Score:" + score;

            Circle head = new Circle { X = 10, Y = 5};
            Snake.Add(head); // Adding the head part of the snke to the list 

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);

            }
            food = new Circle { X = rand.Next(2, maxwidth), Y = rand.Next(2 , maxheight)};

            GameTimer1.Start();

        }
        private void EatFood()
        {
            score += 1;
            tex_Score.Text = "Score:" + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxwidth), Y = rand.Next(2, maxheight) };
        }
        private void GameOver()
        {
            GameTimer1.Stop();
            btn_start.Enabled = true;
            btn_Snap.Enabled = true;

            if(score > highscore)
            {
                 highscore = score;
                tex_HighScore.Text = "High Score:" + Environment.NewLine + highscore;
                tex_HighScore.ForeColor = Color.Maroon;
                tex_HighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
