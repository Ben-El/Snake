using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {      
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        bool Pause = false;

        public Form1()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            GameTimer.Interval = 800 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            //Start New game
            StartGame();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrows to move and try to collect as many red dots as you can!", "Game instructions");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Ben-El, 2014 ©", "Snake - About");
        }

        private void StartGame()
        {
            labelGameOver.Visible = false;

            //Set settings to default
            new Settings();
            GameTimer.Interval = 800 / Settings.Speed; //Set speed to the regular speed

            //Create new player object
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);

            //count score 

            labelScore.Text = Settings.Score.ToString();
            GenerateFood();

        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = canvas.Size.Width / Settings.Width;
            int maxYPos = canvas.Size.Height / Settings.Height;
            int maxAPos = canvas.Size.Width / Settings.Width;
            int maxBPos = canvas.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Space is pressed
                if (Input.KeyPressed(Keys.Space))
                {
                    new Settings();
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.P))
                {
                    Pause = !Pause;// pause state is changed                 
                }
                if (Pause == false)
                {
                    if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                        Settings.direction = Direction.Right;
                    else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                        Settings.direction = Direction.Left;
                    else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                        Settings.direction = Direction.Up;
                    else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                        Settings.direction = Direction.Down;
                    MovePlayer();
                }
                if (Input.KeyPressed(Keys.H))
                {
                    GameTimer.Interval = 300 / Settings.Speed;//increases the speed
                }
                if (Input.KeyPressed(Keys.M))
                {
                    GameTimer.Interval = 800 / Settings.Speed;//regular speed
                }
                if (Input.KeyPressed(Keys.L))
                {
                    GameTimer.Interval = 1500 / Settings.Speed;//decreases the speed
                }
                if (Input.KeyPressed(Keys.C))//commit suicide
                {
                    Die();
                }
            }

            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
           Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {

                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.DarkGreen;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game over! \n Your final score is: " + Settings.Score + " ." + "\n Press Space to try again...";
                labelGameOver.Text = gameOver;
                labelGameOver.Visible = true;
            }    
        }


        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {

                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = canvas.Size.Width / Settings.Width;
                    int maxYPos = canvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    //if (Input.KeyPressed(Keys.S))
                    //{
                    //    if (Snake[i].X < 0 || Snake[i].Y < 0
                    //        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    //    {
                    //        Die();
                    //    }
                    //}

                  
                    if (Snake[i].X < 0)
                        Snake[i].X = maxXPos;
                    if (Snake[i].Y < 0)
                        Snake[i].Y = maxYPos;
                    if (Snake[i].X > maxXPos)
                        Snake[i].X = 0;
                    if (Snake[i].Y > maxYPos)
                        Snake[i].Y = 0;

                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                   
                    //Detect collision with food pieces
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();                      
                    }                 

                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;                
                }
            }
        }
 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);  

            //Update Score
            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();          
            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }


        private void ToOpeningScreenFromForm1_Click(object sender, EventArgs e)
        {
            OpeningScreen OpeningScreen = new OpeningScreen();
            OpeningScreen.Show();
        }
    }
}
