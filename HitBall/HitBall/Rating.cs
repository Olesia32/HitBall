using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;

namespace HitBall
{
    class Rating
    {
        List<Dictionary<Player, DateTime>> rating;

        public Rating()
        {
            rating = new List<Dictionary<Player, DateTime>>();
        }
        public void SortRating()
        {
            rating.Sort((dict1, dict2) =>
            {
                Player player1 = dict1.Keys.First();
                Player player2 = dict2.Keys.First();
                return player2.Points.CompareTo(player1.Points);
            });

        }
        public void AddNewAttempt(string _name, int score, DateTime date)
        {
            Dictionary<Player, DateTime> attempt = new Dictionary<Player, DateTime>();
            Player player = new Player(_name, score);
            attempt.Add(player, date);
            rating.Add(attempt);
            SortRating();
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Рейтинг спроб");
            int i = 0;
            foreach (var dict in rating)
            {
                i += 1;
                Player player = dict.Keys.First();
                DateTime date = dict.Values.First();
                sb.AppendLine($"{i}# {player.Points},{player.Name}, {date}");
            }

            return sb.ToString();
        }
        public void SaveRatingToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(ToString());
            }
        }
        public void LoadRatingFromFile(string filePath)
        {
            rating.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != string.Empty && line != "Рейтинг спроб")
                    {
                        string[] lines = line.Split('#');
                        lines = lines[1].Split(',');
                        string playerName = lines[1];
                        int points = int.Parse(lines[0]);
                        DateTime date = DateTime.Parse(lines[2]);
                        AddNewAttempt(playerName, points, date);
                    }
                }
            }
        }
    }
}
