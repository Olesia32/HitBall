using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBall
{
    class Player
    {
        string name;
        int points;
        
        public Player(string _name)
        {
            name = _name;
            points = 0;
        }
        public Player(string _name, int _score)
        {
            name = _name;
            points = _score;
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public void ChangePoints(int number)
        {
            if (number < 0 && (0 - number) >= Points)
            {
                points = 0;
            }
            else
            {
                points += number;
            }
        }
    }
}
