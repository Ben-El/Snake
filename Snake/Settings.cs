using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width;//{ get; set; }
        public static int Height;// { get; set; }
        public static int Speed;//{ get; set; }
        public static int Score1;// { get; set; }
        public static int Score2;//{ get; set; }
        public static int Points;//{ get; set; }
        public static bool GameOver;//{ get; set; }
        public static Direction direction1;//{ get; set; }
        public static Direction direction2;// { get; set; }

        public Settings() // constructor
        {
            Width = 17;
            Height = 17;
            Speed = 17;
            Score1 = 0;
            Score2 = 0;
            Points = 100;
            GameOver = false;
            direction1 = Direction.Right;
            direction2 = Direction.Right;
        }
    }


}
