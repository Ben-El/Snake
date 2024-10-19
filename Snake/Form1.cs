using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        bool Pause = false;
        int Score = 0;
        int minutes = 0, hours = 0, CounterQ = 0;
        double seconds = -0.5;
        string time;

        public Form1()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            GameTimer.Interval = 900 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
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
            TimeLable1.Text = time;
        }


        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
            seconds = -1;
            minutes = 0;
            hours = 0;
            GeneralTimer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrow keys to move. 'H' to increase the speed, 'L' to decrease the speed, 'M' to turning back to default speed.  'Space' to restart. 'Esc' to exit. Try to collect as many red dots as you can!", "Game instructions");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Ben-El, 2015 ©", "Snake - About");
        }

        private void StartGame()
        {
            Pause = false;
            Score = 0;
            canvas.Image = null;
            canvas.BackColor = System.Drawing.Color.LimeGreen;
            NoticeLable.Visible = false;
            GameOverLable.Visible = false;
            GayLable.Visible = false;
            shit.Visible = false;
            shit.Text = "";
            IshurButton.Visible = false;
            shit.Enabled = false;
            IshurButton.Enabled = false;
            InsertCodeLable.Visible = false;
            seconds = -0.5;
            minutes = 0;
            hours = 0;
            GeneralTimer.Start();


            //Set settings to default
            new Settings();
            GameTimer.Interval = 900 / Settings.Speed; //Set speed to the regular speed

            //Create new player object
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);

            //count score 

            ScoreLable.Text = Settings.Score1.ToString();
            GenerateFood();
        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = canvas.Size.Width / Settings.Width;
            int maxYPos = canvas.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
            //:או
            //food.X = random.Next(0, maxXpos);
            //food.Y = random.Next(0, maxYpos);
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (!Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Q) && GameOverLable.Visible == false) // כתנאי לכך שלא יהיה ניתן להזין קוד כשהשחקן נפסל, וגם שלא יהיה ניתן לבטל את העצירה ולהמשיך לשחק false התווית של סיום המשחק שווה ל
                {
                    CounterQ++;
                    if (InsertCodeLable.Text != "...קוד שגוי, חתיכת שמן")
                    {
                        Thread.Sleep(90);
                    }
                    Pause = !Pause;// pause state is changed
                    if (CounterQ != 0 && CounterQ % 2 == 1)//  כלומר כשהשחקן הראשון נעצר  
                    {
                        Pause = true;
                        GameOverLable.Visible = false;
                        InsertCodeLable.Text = ":הכנס קוד";
                        InsertCodeLable.Visible = true;
                        shit.Text = "";
                        shit.Visible = true;
                        IshurButton.Visible = true;
                        shit.Enabled = true;
                        IshurButton.Enabled = true;
                        InsertCodeLable.Location = new Point(700, 45);
                    }
                    if (CounterQ != 0 && CounterQ % 2 == 0)// (כלומר שהשחקן הראשון לא עצור (ממשיך כרגיל
                    {
                        Pause = false;
                        InsertCodeLable.Visible = false;
                        shit.Visible = false;
                        IshurButton.Visible = false;
                        shit.Enabled = false;
                        IshurButton.Enabled = false;
                    }
                }
                if (Pause == false)
                {
                    if (Input.KeyPressed(Keys.Right) && Settings.direction1 != Direction.Left)
                        Settings.direction1 = Direction.Right;
                    else if (Input.KeyPressed(Keys.Left) && Settings.direction1 != Direction.Right)
                        Settings.direction1 = Direction.Left;
                    else if (Input.KeyPressed(Keys.Up) && Settings.direction1 != Direction.Down)
                        Settings.direction1 = Direction.Up;
                    else if (Input.KeyPressed(Keys.Down) && Settings.direction1 != Direction.Up)
                        Settings.direction1 = Direction.Down;
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

                // Secret special action !
                if (shit.Text == "gandon")
                {
                    if (Input.KeyPressed(Keys.R) && GameOverLable.Visible == false)
                    {
                        InsertCodeLable.Location = new Point(610, 50);
                        InsertCodeLable.Text = "!!!פעולה סודית הופעלה";
                        Settings.Score1 += Settings.Points;
                        ScoreLable.Text = Settings.Score1.ToString();
                        Snake.Add(food);
                        GenerateFood();
                    }
                }

                if (Input.KeyPressed(Keys.Space))
                {
                    StartGame();
                    seconds = -1;
                    minutes = 0;
                    hours = 0;
                    GeneralTimer.Start();
                }

                if (Settings.Score1 != 0 && Settings.Score1 % 500 == 0 && Settings.Score1 < 3100)
                {
                    canvas.BackColor = System.Drawing.Color.White;
                    if (Pause == false)
                    {
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(20, 505);
                        NoticeLable.Text = "...הצבע משתנה באכילה הבאה\n!וכמובן לא להיפגש בגבולות המשחק";
                    }
                    ColssionWithGameBorders();
                }
                else if (Settings.Score1 >= 600 && Settings.Score1 <= 900)
                {
                    canvas.BackColor = System.Drawing.Color.Turquoise;
                    NoticeLable.Visible = false;
                }
                else if (Settings.Score1 >= 1100 && Settings.Score1 <= 1400)
                {
                    canvas.BackColor = System.Drawing.Color.DarkGreen;
                    NoticeLable.Visible = false;
                    if (Pause == false)
                    {
                        NoticeLable.Text = "!?לאן לעזאזל נעלמו שאר חלקי הגוף";
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(20, 505);
                    }
                }
                else if (Settings.Score1 >= 1600 && Settings.Score1 <= 1900)
                {
                    canvas.BackColor = System.Drawing.Color.Transparent;
                    NoticeLable.Visible = false;
                    if (Pause == false)
                    {
                        NoticeLable.Text = "Wtf!?";
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(185, 505);
                    }
                }
                else if (Settings.Score1 >= 2100 && Settings.Score1 <= 2400)
                {
                    canvas.BackColor = System.Drawing.Color.OrangeRed;
                    NoticeLable.Visible = false;
                    if (Pause == false)
                    {
                        NoticeLable.Text = "...אתה חושב שזה קשה? חכה למה שמחכה לך בהמשך";
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(20, 505);
                    }
                }
                else if (Settings.Score1 >= 2600 && Settings.Score1 <= 2900)
                {
                    canvas.BackColor = System.Drawing.Color.Brown;
                    NoticeLable.Visible = false;
                    if (Pause == false)
                    {
                        NoticeLable.Text = ":)לא רע... נראה אותך עכשיו";
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(50, 505);
                    }
                }
                else if (Settings.Score1 >= 3100 && Settings.Score1 <= 3400)
                {
                    canvas.BackColor = System.Drawing.Color.LimeGreen;
                    NoticeLable.Visible = false;
                    if (Pause == false)
                    {
                        NoticeLable.Text = ":)פשש...סוס...המשך משחק מהנה";
                        NoticeLable.Visible = true;
                        NoticeLable.Location = new Point(20, 505);
                    }
                }
                else
                {
                    canvas.BackColor = System.Drawing.Color.LimeGreen;
                    NoticeLable.Visible = false;
                }
                if (Settings.Score1 == 10000)
                {
                    Pause = true;
                    Snake.Clear();
                    InsertCodeLable.Visible = false;
                    NoticeLable.Text = "!כל הכבוד גנדון!!! סיימת ת'משחק";
                    NoticeLable.Visible = true;
                    NoticeLable.Location = new Point(20, 505);
                    canvas.Image = Properties.Resources.Avihu;
                    string GameOver = "!!!בוא'נה אתה מגונדן\nהניקוד שלך הוא: " + Settings.Score1 + "\n...לחץ על רווח כדי להתחיל מחדש";
                    GameOverLable.Text = GameOver;
                    GameOverLable.Visible = true;
                    GeneralTimer.Stop();
                }
                if (((seconds != 0 && seconds % 30 == 0) || (minutes > 0 && minutes % 1 == 0 && seconds == 0)) && Pause == false)
                {
                    Shake(this);
                }

                if (Input.KeyPressed(Keys.Escape))
                {
                    Application.Exit();
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
                    if (Settings.Score1 <= 9800)
                    {
                        canvas.FillEllipse(Brushes.Red,
                            new Rectangle(food.X * Settings.Width,
                                 food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }

                    if (Settings.Score1 == 9900)
                    {
                        canvas.FillRectangle(Brushes.Red,
                            new Rectangle(food.X * Settings.Width,
                                 food.Y * Settings.Height, Settings.Width, Settings.Height));

                    }
                }
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {

                //Move head
                if (i == 0)
                {
                    switch (Settings.direction1)
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

        private void ColssionWithGameBorders()
        {
            int maxXPos = canvas.Size.Width / Settings.Width;
            int maxYPos = canvas.Size.Height / Settings.Height;
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Detect collission with game borders
                if (Snake[i].X < 0 || Snake[i].Y < 0
                    || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                {
                    Die();
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
            Circle Foodcircle = new Circle  //כשחתיכת האוכל נמצאת במיקום של ראש הנחש, היא נוספת לנחש
            {
                X = Snake[Snake.Count - 1].X, // (הוספת עיגול אוכל - כך שימוקם כאיבר האחרון בנחש (זנב הנחש
                Y = Snake[Snake.Count - 1].Y // (הוספת עיגול אוכל - כך שימוקם כאיבר האחרון בנחש (זנב הנחש
                // סנייק קאונט מינוס אחד מפני שהספירה מתחילה מהאיבר האפס, כלומר מראש הנחש
            };
            Snake.Add(Foodcircle);

            //Update Score
            Settings.Score1 += Settings.Points;
            Score = Settings.Score1;
            ScoreLable.Text = Settings.Score1.ToString();

            GenerateFood();
        }


        private void Shake(Form form)
        {
            var original = form.Location;
            Random rnd = new Random();
            const int shake_amplitude = 5;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude),
                    original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
            }
        }

        private string cheat(string st)
        {
            st = Console.ReadLine();
            return st;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cheat(shit.Text);
        }

        private void IshurButton_Click_1(object sender, EventArgs e)
        {
            if (shit.Text == "gandon")
            {
                Pause = false;
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Location = new Point(610, 50);
                InsertCodeLable.Text = "!!!פעולה סודית ניתנת להפעלה";
            }
            else if (shit.Text == "insane")
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Visible = false;
                Pause = false;
                GameTimer.Interval = 200 / Settings.Speed;

            }
            else if (shit.Text == "fast")
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Visible = false;
                Pause = false;
                GameTimer.Interval = 550 / Settings.Speed;
            }
            else if (shit.Text == "medium")
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Visible = false;
                Pause = false;
                GameTimer.Interval = 900 / Settings.Speed;
            }
            else if (shit.Text == "low")
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Visible = false;
                Pause = false;
                GameTimer.Interval = 1500 / Settings.Speed;
            }
            else if (shit.Text == "very low")
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Visible = false;
                Pause = false;
                GameTimer.Interval = 2100 / Settings.Speed;
            }
            else
            {
                shit.Visible = false;
                IshurButton.Visible = false;
                shit.Enabled = false;
                IshurButton.Enabled = false;
                InsertCodeLable.Text = "...קוד שגוי, חתיכת שמן";
                InsertCodeLable.Location = new Point(600, 50);
                Pause = false;
            }
        }

        private void Die()
        {
            Pause = true;
            NoticeLable.Visible = false;
            GayLable.Visible = true;
            GayLable.Location = new Point(155, 505);
            GeneralTimer.Stop();
            string GameOver = "...איזה אפס חחח נפסלת\nהניקוד שלך הוא: " + Settings.Score1 + "\n...לחץ על רווח כדי להתחיל מחדש";
            GameOverLable.Text = GameOver;
            GameOverLable.Visible = true;
        }

        private void canvas_BackgroundImageChanged(object sender, EventArgs e)
        {
            canvas.BackgroundImage = Properties.Resources.Avihu;
        }
    }
}