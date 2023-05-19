using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Media;
using System.Drawing;

namespace HitBall
{
    public enum Levels
    {
        easy,
        middle,
        difficult
    }
    class Game
    {
        private Levels level; 
        private int time_interval;
        private int penalty_threshold;
        private int game_time;
        private DateTime date;
        private List<BallButton> balls;
        private Player player;
        private Rating rating;
        private bool end;
        private Color previous_color;

        public int Penalty
        {
            get { return penalty_threshold; }
        }
        public int Score
        {
            get { return player.Points; }
        }
        public string Name
        {
            get { return player.Name; }
        }
        public int Interval
        {
            get { return time_interval; }
        }
        public string Rating
        {
            get { return rating.ToString(); }
        }
        public bool Status
        {
            get { return end; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Game(string _level, string player_name)
        {
            switch(_level)
            {
                case "Легкий":
                    level = Levels.easy;
                    time_interval = 900;
                    penalty_threshold = 15;
                    break;
                case "Середній":
                    level = Levels.middle;
                    time_interval = 700;
                    penalty_threshold = 10;
                    break;
                case "Складний":
                    level = Levels.difficult;
                    time_interval = 500;
                    penalty_threshold = 5;
                    break;
            }
            game_time = 60;
            balls = new List<BallButton>();
            player = new Player(player_name);
            rating = new Rating();
            rating.LoadRatingFromFile("../../Ratings/rating.txt");
            end = false;
            previous_color = Color.White;
        }
        public List<BallButton> GameLoop()
        {
            List<BallButton> remove_list = new List<BallButton>();
            if (game_time == 0)
            {
                end = true;
            }
            game_time -= 1;
            int n = balls.Count();
            for (int i = 0; i < n; ++i)
            {
                balls[i].Period -= 1;
                if (balls[i].Period == 0)
                {
                    remove_list.Add(balls[i]);
                    if (balls[i].BackColor != Color.Black)
                    {
                        penalty_threshold -= 1;
                        if (penalty_threshold == 0)
                        {
                            end = true;
                            break;
                        }
                    }
                }
            }
            CheckBalls();
            return remove_list;
        }
        private void CheckBalls()
        {
            balls.RemoveAll(x => x.Period == 0);
        }
        public BallButton CreateBall(int x, int y, int size)
        {
            BallButton ball = new BallButton(x, y, size);
            balls.Add(ball);
            return ball;
        }
        public void HittingBall(BallButton ball)
        {
            int cost = ball.Cost;
            HittingPlay(ball.BackColor, ball.Special);
            if (ball.BackColor == previous_color)
            {
                cost *= 2;
            }
            previous_color = ball.BackColor;
            balls.Remove(ball);
            player.ChangePoints(cost);
        }
        public void SaveAttemp()
        {
            rating.AddNewAttempt(player.Name, player.Points, date);
            rating.SaveRatingToFile("../../Ratings/rating.txt");
        }
        private void HittingPlay(Color color, bool special)
        {
            if (color == Color.Black)
            {
                SoundPlayer player = new SoundPlayer("../../Sound/BlackBall.wav");
                player.Play();
            }
            else if(special)
            {
                SoundPlayer player = new SoundPlayer("../../Sound/SpecialHitt.wav");
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer("../../Sound/Hitt.wav");
                player.Play();
            }
        }
        public void RemovePlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Remove.wav");
            player.Play();
        }
        public void PausePlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Pause.wav");
            player.Play();
        }
        public void ContinuePlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Contin.wav");
            player.Play();
        }
        public void GameOverPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/GameOver.wav");
            player.Play();
        }
        public void SpecialClickPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Special.wav");
            player.Play();
        }
    }
}
