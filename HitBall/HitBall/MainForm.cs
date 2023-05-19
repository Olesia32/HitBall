using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Media;
using System.Drawing.Drawing2D;

namespace HitBall
{
    public partial class MainForm : Form
    {
        private Game game;
        private bool pause = false;
        private Random rand;
        private string name;
        public MainForm()
        {
            InitializeComponent();
            Welcome();
        }

        private void InitializeGame(string _name)
        {
            game = new Game(level_cb.Text, _name);
            timer1.Interval = game.Interval;
            timer1.Start();
            rand = new Random();
            penalty_lb.Text = $"Залишилось життів: {game.Penalty}";
            score_lb.Text = $"Рахунок: {game.Score}";
            progressBar1.Value = 0;
            game.Date = DateTime.Now;
        }

        private void Welcome()
        {
            welcome_panel.Visible = true;
            welcome_panel.Enabled = true;
            level_cb.SelectedItem = level_cb.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = name_tb.Text;
            if (name == string.Empty)
            {
                MessageBox.Show($"Введіть ім'я гравця!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StartPlay();
                InitializeGame(name);
                game_panel.Controls.Clear();
                player_name_lb.Text = $"Гравець: {game.Name}";
                name_tb.Clear();
                welcome_panel.Visible = false;
                welcome_panel.Enabled = false;
                info_panel.Visible = true;
                info_panel.Enabled = true;
                game_panel.Enabled = true;
                game_panel.Visible = true;
                rating_box.Text = game.Rating;
            }

        }
        private void close_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateScore()
        {
            score_lb.Text = $"Рахунок: {game.Score}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<BallButton> remove_list = game.GameLoop();
            penalty_lb.Text = $"Залишилось життів: {game.Penalty}";
            if (game.Status)
            {
                GameOver();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
                int size = rand.Next(15, 50);
                int x = rand.Next(0, game_panel.Width - size);
                int y = rand.Next(0, game_panel.Height - size);
                BallButton ball = game.CreateBall(x, y, size);
                game_panel.Controls.Add(ball);
                ball.Show();
                ball.Click += ball_Click;
                foreach (BallButton i in remove_list)
                {
                    game_panel.Controls.Remove(i);
                    game.RemovePlay();
                    i.Dispose();
                }
            }
        }
        private void ball_Click(object sender, EventArgs e)
        {
            BallButton ball = (BallButton)sender;
            if (ball.Special && ball.Special_Click)
            {
                HittBall(ball);
                ball.Special_Click = false;

            }
            else if (ball.Special && !ball.Special_Click)
            {
                ball.Special_Click = true;
                game.SpecialClickPlay();
                ball.BackColor = ControlPaint.Dark(ball.BackColor, 0.2f);
            }
            else
            {
                HittBall(ball);
            }
        }
        private void HittBall(BallButton ball)
        {
            game.HittingBall(ball);
            game_panel.Controls.Remove(ball);
            ball.Dispose();
            UpdateScore();
        }
        private void GameOver()
        {
            game.GameOverPlay();
            timer1.Stop();
            MessageBox.Show($"Гру завершено!\nВаш рахунок: {game.Score}", "Гру завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            game.SaveAttemp();
            info_panel.Visible = false;
            game_panel.Visible = false;
            info_panel.Enabled = false;
            game_panel.Enabled = false;
            Welcome();
        }

        private void stop_bt_Click(object sender, EventArgs e)
        {
            GameOver();
        }

        private void pause_bt_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                game.PausePlay();
                timer1.Stop();
                pause = true;
                pause_bt.Text = "Продовжити";
                game_panel.Enabled = false;
            }
            else
            {
                game.ContinuePlay();
                timer1.Start();
                pause = false;
                pause_bt.Text = "Пауза";
                game_panel.Enabled = true;
            }
        }
        private void StartPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Start.wav");
            player.Play();
        }
        private void FaildPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Sound/Faild.wav");
            player.Play();
        }

        private void game_panel_Click(object sender, EventArgs e)
        {
            FaildPlay();
        }
    }
    class BallButton : Button
    {
        private Ball ball;
        private bool special_click;
        public int Period
        {
            get { return ball.Period; }
            set { ball.Period = value; }
        }
        public int Cost
        {
            get { return ball.Cost; }
        }
        public bool Special
        {
            get { return ball.Special; }
        }
        public bool Special_Click
        {
            get { return special_click; }
            set { special_click = value; }
        }
        public BallButton(int x, int y, int size)
        {
            ball = new Ball();
            this.Width = size;
            this.Height = size;
            this.Location = new Point(x, y);
            this.BackColor = ball.Color;
            this.FlatStyle = FlatStyle.Flat;
            if (ball.Special)
            {
                this.Image = global::HitBall.Properties.Resources._18427__1_;
            }
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphics);
            this.FlatAppearance.BorderSize = 0;
            special_click = false;
        }
    }
}
