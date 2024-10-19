using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Snake
{
    public partial class Form2 : Form
    {
        private List<Circle> snake1 = new List<Circle>();
        private List<Circle> snake2 = new List<Circle>();
        private Circle food1 = new Circle();
        private Circle food2 = new Circle();
        int score1 = 0;
        int score2 = 0;
        bool Pause1 = false;
        bool Pause2 = false;
        bool CheckIfDie1 = false, CheckIfDie2 = false;
        int minutes = 0, hours = 0, CounterP = 0, CounterQ = 0;
        double seconds = -0.5;
        string time;

        public Form2()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            GameTimer.Interval = 900 / Settings.Speed;
            GameTimer.Tick += UpdateScreens;
            GameTimer.Start();

            //Start New game
            StartGame();

            //general timer
            GeneralTimer.Interval = 1000;
            GeneralTimer_Tick(null, null);
            GeneralTimer.Tick += new EventHandler(GeneralTimer_Tick);
            GeneralTimer.Start();
        }

        private void GeneralTimer_Tick(object sender, EventArgs e)
        {
            seconds += 0.5;
            if (seconds == 60) { seconds = 0; minutes++; }
            if (minutes == 60) { minutes = 0; hours++; }
            if (hours == 10) { this.Close(); }
            string s;
            if (seconds < 10) { s = "0" + seconds; }
            else { s = "" + seconds; }
            string m;
            if (minutes < 10) { m = "0" + minutes; }
            else { m = "" + minutes; }
            string h;
            if (hours < 10) { h = "0" + hours; }
            else { h = "" + hours; }
            time = h + ":" + m + ":" + s;
            TimeLable.Text = time;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
            seconds = -1;
            minutes = 0;
            hours = 0;
            GeneralTimer.Start();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrow keys to move the first snake, and the keys: 'A','S','W','D' to move the second snake. 'H' to increase the speed, 'L' to decrease the speed, 'M' to turning back to default speed.  'Space' to restart. 'Esc' to exit. The player who has the highest score - wins.", "Game instructions");
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Ben-El, 2015 ©", "Snake - About");
        }

        private void StartGame()
        {
            Pause1 = false;
            Pause2 = false;
            score1 = 0;
            score2 = 0;
            DrawLable.Visible = false;
            canvas1.Image = null;
            canvas2.Image = null;
            canvas1.BackColor = System.Drawing.Color.LimeGreen;
            canvas2.BackColor = System.Drawing.Color.LimeGreen;
            NoticeLable1.Visible = false;
            NoticeLable2.Visible = false;
            GameOverLable1.Visible = false;
            GameOverLable2.Visible = false;
            GayLable1.Visible = false;
            GayLable2.Visible = false;
            shit1.Visible = false;
            shit2.Visible = false;
            shit1.Text = "";
            shit2.Text = "";
            IshurButton1.Visible = false;
            IshurButton2.Visible = false;
            shit1.Enabled = false;
            shit2.Enabled = false;
            IshurButton1.Enabled = false;
            IshurButton2.Enabled = false;
            InsertCodeLable1.Visible = false;
            InsertCodeLable2.Visible = false;
            seconds = -0.5;
            minutes = 0;
            hours = 0;
            GeneralTimer.Start();
            CheckIfDie1 = false;
            CheckIfDie2 = false;

            //Set settings to default
            new Settings();
            GameTimer.Interval = 800 / Settings.Speed; //Set speed to the regular speed

            //Create new player object
            snake1.Clear();
            Circle head1 = new Circle { X = 10, Y = 10 };
            snake1.Add(head1);

            snake2.Clear();
            Circle head2 = new Circle { X = 10, Y = 10 };
            snake2.Add(head2);

            //count score 

            Score1Lable.Text = Settings.Score1.ToString();
            Score2Lable.Text = Settings.Score2.ToString();
            GenerateFood1();
            GenerateFood2();

        }

        //Place random food object
        private void GenerateFood1()
        {
            int maxXPos = canvas1.Size.Width / Settings.Width;
            int maxYPos = canvas1.Size.Height / Settings.Height;
            Random random1 = new Random();
            food1 = new Circle { X = random1.Next(0, maxXPos), Y = random1.Next(0, maxYPos) };
        }

        private void GenerateFood2()
        {
            int maxXPos = canvas2.Size.Width / Settings.Width;
            int maxYPos = canvas2.Size.Height / Settings.Height;
            Random random2 = new Random();
            food2 = new Circle { X = random2.Next(0, maxXPos), Y = random2.Next(0, maxYPos) };
        }


        private void UpdateScreens(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver == false)
            {
                if (Input.KeyPressed(Keys.P) && GameOverLable1.Visible == false) // כתנאי לכך שלא יהיה ניתן להזין קוד כשהשחקן נפסל, וגם שלא יהיה ניתן לבטל את העצירה ולהמשיך לשחק false התווית של סיום המשחק שווה ל
                {
                    CounterP++;
                    Pause1 = !Pause1;// pause state is changed

                    if (InsertCodeLable1.Text != "...קוד שגוי, חתיכת שמן")
                    {
                        Thread.Sleep(90);
                    }

                    if (CounterP != 0 && CounterP % 2 == 1)//  כלומר כשהסנייק הראשון נעצר  
                    {
                        GameOverLable1.Visible = false;
                        InsertCodeLable1.Text = ":הכנס קוד";
                        InsertCodeLable1.Visible = true;
                        InsertCodeLable1.Location = new Point(726, 252);
                        shit1.Text = "";
                        shit1.Visible = true;
                        IshurButton1.Visible = true;
                        shit1.Enabled = true;
                        IshurButton1.Enabled = true;
                    }
                    if (CounterP != 0 && CounterP % 2 == 0)// (כלומר שהסנייק הראשון לא עצור (המשחק ממשיך כרגיל
                    {
                        InsertCodeLable1.Visible = false;
                        shit1.Visible = false;
                        IshurButton1.Visible = false;
                        shit1.Enabled = false;
                        IshurButton1.Enabled = false;
                    }
                }

                if (Input.KeyPressed(Keys.Q) && GameOverLable2.Visible == false) // כתנאי לכך שלא יהיה ניתן להזין קוד כשהשחקן נפסל, וגם שלא יהיה ניתן לבטל את העצירה ולהמשיך לשחק false התווית של סיום המשחק שווה ל
                {
                    CounterQ++;
                    Pause2 = !Pause2;// pause state is changed

                    if (InsertCodeLable2.Text != "...קוד שגוי, חתיכת שמן")
                    {
                        Thread.Sleep(90);
                    }

                    if (CounterQ != 0 && CounterQ % 2 == 1)//  כלומר כשהסנייק השני נעצר  
                    {
                        GameOverLable2.Visible = false;
                        InsertCodeLable2.Text = ":הכנס קוד";
                        InsertCodeLable2.Visible = true;
                        InsertCodeLable2.Location = new Point(735, 589);
                        shit2.Text = "";
                        shit2.Visible = true;
                        IshurButton2.Visible = true;
                        shit2.Enabled = true;
                        IshurButton2.Enabled = true;
                    }
                    if (CounterQ != 0 && CounterQ % 2 == 0)// (כלומר שהסנייק השני לא עצור (המשחק ממשיך כרגיל
                    {
                        InsertCodeLable2.Visible = false;
                        shit2.Visible = false;
                        IshurButton2.Visible = false;
                        shit2.Enabled = false;
                        IshurButton2.Enabled = false;
                    }
                }

                if (Pause1 == false)
                {
                    if (Input.KeyPressed(Keys.Right) && Settings.direction1 != Direction.Left)
                        Settings.direction1 = Direction.Right;
                    else if (Input.KeyPressed(Keys.Left) && Settings.direction1 != Direction.Right)
                        Settings.direction1 = Direction.Left;
                    else if (Input.KeyPressed(Keys.Up) && Settings.direction1 != Direction.Down)
                        Settings.direction1 = Direction.Up;
                    else if (Input.KeyPressed(Keys.Down) && Settings.direction1 != Direction.Up)
                        Settings.direction1 = Direction.Down;
                    MovePlayer1();
                }
                if (Pause2 == false)
                {
                    if (Input.KeyPressed(Keys.D) && Settings.direction2 != Direction.Left)
                        Settings.direction2 = Direction.Right;
                    else if (Input.KeyPressed(Keys.A) && Settings.direction2 != Direction.Right)
                        Settings.direction2 = Direction.Left;
                    else if (Input.KeyPressed(Keys.W) && Settings.direction2 != Direction.Down)
                        Settings.direction2 = Direction.Up;
                    else if (Input.KeyPressed(Keys.S) && Settings.direction2 != Direction.Up)
                        Settings.direction2 = Direction.Down;
                    MovePlayer2();
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
                if (Input.KeyPressed(Keys.Space))
                {
                    StartGame();
                    seconds = -1;
                    minutes = 0;
                    hours = 0;
                    GeneralTimer.Start();
                }

                // Secret special action for the first snake !
                if (shit1.Text == "1")
                {
                    if (Input.KeyPressed(Keys.ControlKey) && GameOverLable1.Visible == false)
                    {
                        InsertCodeLable1.Location = new Point(610, 100);
                        InsertCodeLable1.Text = "!!!פעולה סודית הופעלה";
                        Settings.Score1 += Settings.Points;
                        Score1Lable.Text = Settings.Score1.ToString();
                        snake1.Add(food1);
                        GenerateFood1();
                    }
                }

                // Secret special action for the second snake !
                if (shit2.Text == "g")
                {
                    if (Input.KeyPressed(Keys.R) && GameOverLable2.Visible == false)
                    {
                        InsertCodeLable2.Location = new Point(610, 460);
                        InsertCodeLable2.Text = "!!!פעולה סודית הופעלה";
                        Settings.Score2 += Settings.Points;
                        Score2Lable.Text = Settings.Score2.ToString();
                        snake2.Add(food2);
                        GenerateFood2();
                    }
                }


                if (CheckIfDie1 == false)
                {
                    if (score1 > 0 && Settings.Score1 % 500 == 0 && Settings.Score1 < 3100)
                    {
                        canvas1.BackColor = System.Drawing.Color.White;
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                        NoticeLable1.Text = "...הצבע משתנה באכילה הבאה\n!וכמובן לא להיפגש בגבולות המשחק";
                        ColssionWithGameBorders1();
                    }
                    else if (Settings.Score1 >= 600 && Settings.Score1 <= 900)
                    {
                        canvas1.BackColor = System.Drawing.Color.Turquoise;
                        NoticeLable1.Visible = false;
                    }
                    else if (Settings.Score1 >= 1100 && Settings.Score1 <= 1400)
                    {
                        canvas1.BackColor = System.Drawing.Color.DarkGreen;
                        NoticeLable1.Text = "!?לאן לעזאזל נעלמו שאר חלקי הגוף";
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                    }
                    else if (Settings.Score1 >= 1600 && Settings.Score1 <= 1900)
                    {
                        canvas1.BackColor = System.Drawing.Color.Transparent;
                        NoticeLable1.Text = "Wtf!?";
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                    }
                    else if (Settings.Score1 >= 2100 && Settings.Score1 <= 2400)
                    {
                        canvas1.BackColor = System.Drawing.Color.OrangeRed;
                        NoticeLable1.Text = "...אתה חושב שזה קשה? חכה למה שמחכה לך בהמשך";
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                    }
                    else if (Settings.Score1 >= 2600 && Settings.Score1 <= 2900)
                    {
                        canvas1.BackColor = System.Drawing.Color.Brown;
                        NoticeLable1.Text = ":)לא רע... נראה אותך עכשיו";
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                    }
                    else if (Settings.Score1 >= 3100 && Settings.Score1 <= 3400)
                    {
                        canvas1.BackColor = System.Drawing.Color.LimeGreen;
                        NoticeLable1.Text = ":)פשש...סוס...המשך משחק מהנה";
                        NoticeLable1.Visible = true;
                        NoticeLable1.Location = new Point(600, 157);
                    }
                    else
                    {
                        canvas1.BackColor = System.Drawing.Color.LimeGreen;
                        NoticeLable1.Visible = false;
                    }
                    if (Settings.Score1 == 10000)
                    {
                        Pause1 = true;
                        Pause2 = true;
                        snake1.Clear();
                        InsertCodeLable1.Visible = false;
                        canvas1.Image = Properties.Resources.Avihu;
                        string GameOver = "!!!בוא'נה אתה מגונדן, סיימת ת'משחק\nהניקוד שלך הוא: " + Settings.Score1 + "\n...לחץ על רווח כדי להתחיל מחדש";
                        GameOverLable1.Text = GameOver;
                        GameOverLable1.Visible = true;
                        GeneralTimer.Stop();
                    }
                }


                if (CheckIfDie2 == false)
                {
                    if (Settings.Score2 > 0 && Settings.Score2 % 500 == 0 && Settings.Score2 < 3100)
                    {
                        canvas2.BackColor = System.Drawing.Color.White;
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                        NoticeLable2.Text = "...הצבע משתנה באכילה הבאה\n!וכמובן לא להיפגש בגבולות המשחק";
                        ColssionWithGameBorders2();
                    }
                    else if (Settings.Score2 >= 600 && Settings.Score2 <= 900)
                    {
                        canvas2.BackColor = System.Drawing.Color.Turquoise;
                        NoticeLable2.Visible = false;
                    }
                    else if (Settings.Score2 >= 1100 && Settings.Score2 <= 1400)
                    {
                        canvas2.BackColor = System.Drawing.Color.DarkGreen;
                        NoticeLable2.Text = "!?לאן לעזאזל נעלמו שאר חלקי הגוף";
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                    }
                    else if (Settings.Score2 >= 1600 && Settings.Score2 <= 1900)
                    {
                        canvas2.BackColor = System.Drawing.Color.Transparent;
                        NoticeLable2.Text = "Wtf!?";
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                    }
                    else if (Settings.Score2 >= 2100 && Settings.Score2 <= 2400)
                    {
                        canvas2.BackColor = System.Drawing.Color.OrangeRed;
                        NoticeLable2.Text = "...אתה חושב שזה קשה? חכה למה שמחכה לך בהמשך";
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                    }
                    else if (Settings.Score2 >= 2600 && Settings.Score2 <= 2900)
                    {
                        canvas2.BackColor = System.Drawing.Color.Brown;
                        NoticeLable2.Text = ":)לא רע... נראה אותך עכשיו";
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                    }
                    else if (Settings.Score2 >= 3100 && Settings.Score2 <= 3400)
                    {
                        canvas2.BackColor = System.Drawing.Color.LimeGreen;
                        NoticeLable2.Text = ":)פשש...סוס...המשך משחק מהנה";
                        NoticeLable2.Visible = true;
                        NoticeLable2.Location = new Point(600, 505);
                    }
                    else
                    {
                        canvas2.BackColor = System.Drawing.Color.LimeGreen;
                        NoticeLable2.Visible = false;
                    }
                    if (Settings.Score2 == 10000)
                    {
                        Pause1 = true;
                        Pause2 = true;
                        snake2.Clear();
                        InsertCodeLable2.Visible = false;
                        canvas2.Image = Properties.Resources.Avihu;
                        string GameOver = "!!!בוא'נה אתה מגונדן, סיימת ת'משחק\nהניקוד שלך הוא: " + Settings.Score2 + "\n...לחץ על רווח כדי להתחיל מחדש";
                        GameOverLable2.Text = GameOver;
                        GameOverLable2.Visible = true;
                        GeneralTimer.Stop();
                    }
                }



                if (((seconds != 0 && seconds % 30 == 0) || (minutes > 0 && minutes % 1 == 0 && seconds == 0)) && (Pause1 == false && Pause2 == false))
                {
                    Shake(this);
                }

                if (Input.KeyPressed(Keys.Escape))
                {
                    Application.Exit();
                }
            }

            canvas1.Invalidate();
            canvas2.Invalidate();
        }


        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas1 = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < snake1.Count; i++)
                {

                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.DarkGreen;    //Rest of body

                    //Draw snake
                    canvas1.FillEllipse(snakeColour,
                        new Rectangle(snake1[i].X * Settings.Width,
                                      snake1[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas1.FillEllipse(Brushes.Red,
                        new Rectangle(food1.X * Settings.Width,
                             food1.Y * Settings.Height, Settings.Width, Settings.Height));

                    if (Settings.Score1 == 9900)
                    {
                        canvas1.FillRectangle(Brushes.Red,
                            new Rectangle(food1.X * Settings.Width,
                                 food1.Y * Settings.Height, Settings.Width, Settings.Height));

                    }
                }
            }
        }


        private void canvas2_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas2 = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int k = 0; k < snake2.Count; k++)
                {

                    Brush snakeColour;
                    if (k == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.DarkGreen;    //Rest of body

                    //Draw snake
                    canvas2.FillEllipse(snakeColour,
                        new Rectangle(snake2[k].X * Settings.Width,
                                      snake2[k].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas2.FillEllipse(Brushes.Red,
                        new Rectangle(food2.X * Settings.Width,
                             food2.Y * Settings.Height, Settings.Width, Settings.Height));

                    if (Settings.Score2 == 9900)
                    {
                        canvas2.FillRectangle(Brushes.Red,
                            new Rectangle(food2.X * Settings.Width,
                                 food2.Y * Settings.Height, Settings.Width, Settings.Height));

                    }
                }
            }
        }


        private void MovePlayer1()
        {
            for (int i = snake1.Count - 1; i >= 0; i--)
            {

                //Move head
                if (i == 0)
                {
                    switch (Settings.direction1)
                    {
                        case Direction.Right:
                            snake1[i].X++;
                            break;
                        case Direction.Left:
                            snake1[i].X--;
                            break;
                        case Direction.Up:
                            snake1[i].Y--;
                            break;
                        case Direction.Down:
                            snake1[i].Y++;
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = canvas1.Size.Width / Settings.Width;
                    int maxYPos = canvas1.Size.Height / Settings.Height;

                    if (snake1[i].X < 0)
                        snake1[i].X = maxXPos;
                    if (snake1[i].Y < 0)
                        snake1[i].Y = maxYPos;
                    if (snake1[i].X > maxXPos)
                        snake1[i].X = 0;
                    if (snake1[i].Y > maxYPos)
                        snake1[i].Y = 0;

                    //Detect collission with body
                    for (int j = 1; j < snake1.Count; j++)
                    {
                        if (snake1[i].X == snake1[j].X &&
                           snake1[i].Y == snake1[j].Y)
                        {
                            Die1();
                        }
                        if (Pause2 == true && Pause1 == true)
                        {
                            GeneralTimer.Stop();
                        }
                    }

                    //Detect collision with food pieces
                    if (snake1[0].X == food1.X && snake1[0].Y == food1.Y)
                    {
                        Eat1();
                    }
                }

                else
                {
                    //Move body
                    snake1[i].X = snake1[i - 1].X;
                    snake1[i].Y = snake1[i - 1].Y;
                }
            }
        }


        private void MovePlayer2()
        {
            for (int k = snake2.Count - 1; k >= 0; k--)
            {

                //Move head
                if (k == 0)
                {
                    switch (Settings.direction2)
                    {
                        case Direction.Right:
                            snake2[k].X++;
                            break;
                        case Direction.Left:
                            snake2[k].X--;
                            break;
                        case Direction.Up:
                            snake2[k].Y--;
                            break;
                        case Direction.Down:
                            snake2[k].Y++;
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxCPos = canvas2.Size.Width / Settings.Width;
                    int maxDPos = canvas2.Size.Height / Settings.Height;


                    if (snake2[k].X < 0)
                        snake2[k].X = maxCPos;
                    if (snake2[k].Y < 0)
                        snake2[k].Y = maxDPos;
                    if (snake2[k].X > maxCPos)
                        snake2[k].X = 0;
                    if (snake2[k].Y > maxDPos)
                        snake2[k].Y = 0;

                    //Detect collission with body
                    for (int m = 1; m < snake2.Count; m++)
                    {
                        if (snake2[k].X == snake2[m].X &&
                           snake2[k].Y == snake2[m].Y)
                        {
                            Die2();
                        }
                        if (Pause2 == true && Pause1 == true)
                        {
                            GeneralTimer.Stop();
                        }
                    }

                    //Detect collision with food pieces
                    if (snake2[0].X == food2.X && snake2[0].Y == food2.Y)
                    {
                        Eat2();
                    }
                }

                else
                {
                    //Move body
                    snake2[k].X = snake2[k - 1].X;
                    snake2[k].Y = snake2[k - 1].Y;
                }
            }
        }


        private void ColssionWithGameBorders1()
        {
            int max1XPos = canvas1.Size.Width / Settings.Width;
            int max1YPos = canvas1.Size.Height / Settings.Height;
            for (int i = snake1.Count - 1; i >= 0; i--)
            {

                //Detect collission with game borders

                if (snake1[i].X < 0 || snake1[i].Y < 0
                    || snake1[i].X >= max1XPos || snake1[i].Y >= max1YPos)
                {
                    Die1();
                }
            }
        }

        private void ColssionWithGameBorders2()
        {
            int max2XPos = canvas2.Size.Width / Settings.Width;
            int max2YPos = canvas2.Size.Height / Settings.Height;
            for (int i = snake2.Count - 1; i >= 0; i--)
            {

                //Detect collission with game borders

                if (snake2[i].X < 0 || snake2[i].Y < 0
                    || snake2[i].X >= max2XPos || snake2[i].Y >= max2YPos)
                {
                    Die2();
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat1()
        {
            //Add circle to body
            Circle Foodcircle1 = new Circle
            {
                X = snake1[snake1.Count - 1].X,
                Y = snake1[snake1.Count - 1].Y
            };
            snake1.Add(Foodcircle1);


            //Update Score
            Settings.Score1 += Settings.Points;
            score1 = Settings.Score1;
            Score1Lable.Text = Settings.Score1.ToString();
            GenerateFood1();
            CheckForLoser();
        }

        private void Eat2()
        {
            //Add circle to body
            Circle Foodcircle2 = new Circle
            {
                X = snake2[snake2.Count - 1].X,
                Y = snake2[snake2.Count - 1].Y
            };
            snake2.Add(Foodcircle2);

            //Update Score 
            Settings.Score2 += Settings.Points;
            score2 = Settings.Score2;
            Score2Lable.Text = Settings.Score2.ToString();
            GenerateFood2();
            CheckForLoser();
        }

        private void Die1()
        {
            Pause1 = true;
            CheckIfDie1 = true;
            CheckForLoser();
        }
        private void Die2()
        {
            Pause2 = true;
            CheckIfDie2 = true;
            CheckForLoser();
        }

        private void Shake(Form form)
        {
            var original = form.Location;
            Random rnd = new Random();
            const int shake_amplitude = 5;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
            }
        }

        private string cheat(string st)
        {
            st = Console.ReadLine();
            return st;
        }

        private void shit1_TextChanged(object sender, EventArgs e)
        {
            cheat(shit1.Text);
        }

        private void shit2_TextChanged(object sender, EventArgs e)
        {
            cheat(shit2.Text);
        }

        private void IshurButton1_Click(object sender, EventArgs e)
        {
            if (shit1.Text == "1")
            {
                Pause1 = false;
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Location = new Point(610, 120);
                InsertCodeLable1.Text = "!!!פעולה סודית ניתנת להפעלה";
            }
            else if (shit1.Text == "insane")
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Visible = false;
                Pause1 = false;
                GameTimer.Interval = 200 / Settings.Speed;

            }
            else if (shit1.Text == "fast")
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Visible = false;
                Pause1 = false;
                GameTimer.Interval = 550 / Settings.Speed;
            }
            else if (shit1.Text == "medium")
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Visible = false;
                Pause1 = false;
                GameTimer.Interval = 900 / Settings.Speed;
            }
            else if (shit1.Text == "low")
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Visible = false;
                Pause1 = false;
                GameTimer.Interval = 1500 / Settings.Speed;
            }
            else if (shit1.Text == "very low")
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Visible = false;
                Pause1 = false;
                GameTimer.Interval = 2100 / Settings.Speed;
            }
            else
            {
                shit1.Visible = false;
                IshurButton1.Visible = false;
                shit1.Enabled = false;
                IshurButton1.Enabled = false;
                InsertCodeLable1.Text = "...קוד שגוי, חתיכת שמן";
                InsertCodeLable1.Location = new Point(630, 252);
                Pause1 = false;
            }
        }

        private void IshurButton2_Click(object sender, EventArgs e)
        {
            if (shit2.Text == "g")
            {
                Pause2 = false;
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Location = new Point(600, 470);
                InsertCodeLable2.Text = "!!!פעולה סודית ניתנת להפעלה";
            }
            else if (shit2.Text == "insane")
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Visible = false;
                Pause2 = false;
                GameTimer.Interval = 200 / Settings.Speed;

            }
            else if (shit2.Text == "fast")
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Visible = false;
                Pause2 = false;
                GameTimer.Interval = 550 / Settings.Speed;
            }
            else if (shit2.Text == "medium")
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Visible = false;
                Pause2 = false;
                GameTimer.Interval = 900 / Settings.Speed;
            }
            else if (shit2.Text == "low")
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Visible = false;
                Pause2 = false;
                GameTimer.Interval = 1500 / Settings.Speed;
            }
            else if (shit2.Text == "very low")
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Visible = false;
                Pause2 = false;
                GameTimer.Interval = 2100 / Settings.Speed;
            }
            else
            {
                shit2.Visible = false;
                IshurButton2.Visible = false;
                shit2.Enabled = false;
                IshurButton2.Enabled = false;
                InsertCodeLable2.Text = "...קוד שגוי, חתיכת שמן";
                InsertCodeLable2.Location = new Point(600, 589);
                Pause2 = false;
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }



        private void canvas1_BackgroundImageChanged(object sender, EventArgs e)
        {
            canvas1.BackgroundImage = Properties.Resources.Avihu;
        }

        private void canvas2_BackgroundImageChanged(object sender, EventArgs e)
        {
            canvas2.Image = Properties.Resources.Avihu;

        }


        private void CheckForLoser()
        {
            if (CheckIfDie1 == false && CheckIfDie2 == true)
            {
                NoticeLable2.Visible = false;
                string GameOver = "...איזה אפס חחח נפסלת\nהניקוד שלך הוא: " + Settings.Score2 + "\n...חכה עד שהשני מסיים";
                GameOverLable2.Text = GameOver;
                GameOverLable2.Visible = true;
                if (score1 > score2)
                {
                    GayLable2.Visible = true;
                    GayLable2.Location = new Point(214, 496);
                }
            }

            if (CheckIfDie2 == false && CheckIfDie1 == true)
            {
                NoticeLable1.Visible = false;
                string GameOver = "...איזה אפס חחח נפסלת\nהניקוד שלך הוא: " + Settings.Score1 + "\n...חכה עד שהשני מסיים";
                GameOverLable1.Text = GameOver;
                GameOverLable1.Visible = true;
                if (score2 > score1)
                {
                    GayLable1.Visible = true;
                    GayLable1.Location = new Point(214, 170);
                }
            }

            if (CheckIfDie1 == true && CheckIfDie2 == true)
            {
                GeneralTimer.Stop();
                NoticeLable1.Visible = false;
                NoticeLable2.Visible = false;
                string GameOver1 = "...חחח איזה אפס נפסלת\nהניקוד שלך הוא: " + Settings.Score1 + "\n...לחץ על רווח כדי להתחיל מחדש";
                string GameOver2 = "...חחח איזה אפס נפסלת\nהניקוד שלך הוא: " + Settings.Score2 + "\n...לחץ על רווח כדי להתחיל מחדש";
                GameOverLable1.Text = GameOver1;
                GameOverLable2.Text = GameOver2;
                GameOverLable1.Visible = true;
                GameOverLable2.Visible = true;
                if (score1 > score2)
                {
                    GayLable2.Visible = true;
                }
                if (score2 > score1)
                {
                    GayLable1.Visible = true;
                }


                if ((score1 != 0 && score2 != 0) && (score1 == score2))
                {
                    DrawLable.Visible = true;
                    GayLable1.Visible = false;
                    GayLable2.Visible = false;
                    string GameOver3 = "...  :)נגמר המשחק, זה תיקו\nהניקוד שלך הוא: " + Settings.Score1 + "\n...לחץ על רווח כדי להתחיל מחדש";
                    string GameOver4 = "...  :)נגמר המשחק, זה תיקו\nהניקוד שלך הוא: " + Settings.Score2 + "\n...לחץ על רווח כדי להתחיל מחדש";
                    GameOverLable1.Text = GameOver3;
                    GameOverLable2.Text = GameOver4;
                    GameOverLable1.Visible = true;
                    GameOverLable2.Visible = true;
                }
            }
        }
    }
}