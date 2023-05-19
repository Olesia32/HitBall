using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime;

namespace HitBall
{
    class Ball
    {
        private bool special_ball;
        private int period;
        private int cost;
        private Color color;

        private static readonly Dictionary<Color, List<int>> ball_colors;

        static Ball()
        {
            ball_colors = new Dictionary<Color, List<int>>()
            {
                { Color.Red, new List<int> {30, 10 } },
                { Color.Green, new List<int> {18, 15 }  },
                { Color.Blue, new List<int> {16, 15 } },
                { Color.Yellow, new List<int> {40, 5 }  },
                { Color.Lime, new List<int> {50, 5 }  },
                { Color.Fuchsia, new List<int> {28, 10 } },
                { Color.Aqua, new List<int> {18, 15 }  },
                { Color.Coral, new List<int> {16, 20 }  },
                { Color.Black, new List<int> {16, -20} }
            };
        }
        public int Period
        {
            get { return period; }
            set { period = value; }
        }
        public int Cost
        {
            get { return cost; }
        }
        public Color Color
        {
            get { return color; }
        }
        public bool Special
        {
            get { return special_ball; }
        }
        public Ball()
        {
            Random rand = new Random();
            color = ball_colors.ElementAt(rand.Next(0, ball_colors.Count)).Key;
            period = ball_colors[Color].First();
            special_ball = rand.Next(0, 8) == 1 && Color != Color.Black;
            cost = special_ball ? ball_colors[Color].Last() * 3 : ball_colors[Color].Last();
        }
    }

}


