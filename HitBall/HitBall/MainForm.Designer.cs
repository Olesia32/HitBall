
namespace HitBall
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.welcome_panel = new System.Windows.Forms.Panel();
            this.level_lb = new System.Windows.Forms.Label();
            this.level_cb = new System.Windows.Forms.ComboBox();
            this.welcome_lable = new System.Windows.Forms.Label();
            this.close_bt = new System.Windows.Forms.Button();
            this.start_bt = new System.Windows.Forms.Button();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.info_panel = new System.Windows.Forms.Panel();
            this.pause_bt = new System.Windows.Forms.Button();
            this.stop_bt = new System.Windows.Forms.Button();
            this.rating_box = new System.Windows.Forms.TextBox();
            this.penalty_lb = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.player_name_lb = new System.Windows.Forms.Label();
            this.game_panel = new System.Windows.Forms.Panel();
            this.welcome_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // welcome_panel
            // 
            this.welcome_panel.Controls.Add(this.level_lb);
            this.welcome_panel.Controls.Add(this.level_cb);
            this.welcome_panel.Controls.Add(this.welcome_lable);
            this.welcome_panel.Controls.Add(this.close_bt);
            this.welcome_panel.Controls.Add(this.start_bt);
            this.welcome_panel.Controls.Add(this.name_tb);
            this.welcome_panel.Controls.Add(this.name_lb);
            this.welcome_panel.Location = new System.Drawing.Point(89, 76);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(615, 382);
            this.welcome_panel.TabIndex = 8;
            // 
            // level_lb
            // 
            this.level_lb.AutoSize = true;
            this.level_lb.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_lb.Location = new System.Drawing.Point(108, 175);
            this.level_lb.Name = "level_lb";
            this.level_lb.Size = new System.Drawing.Size(171, 22);
            this.level_lb.TabIndex = 8;
            this.level_lb.Text = "Рівень складності:";
            // 
            // level_cb
            // 
            this.level_cb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_cb.FormattingEnabled = true;
            this.level_cb.Items.AddRange(new object[] {
            "Легкий",
            "Середній",
            "Складний"});
            this.level_cb.Location = new System.Drawing.Point(321, 175);
            this.level_cb.Name = "level_cb";
            this.level_cb.Size = new System.Drawing.Size(121, 24);
            this.level_cb.TabIndex = 6;
            // 
            // welcome_lable
            // 
            this.welcome_lable.AutoSize = true;
            this.welcome_lable.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome_lable.Location = new System.Drawing.Point(118, 38);
            this.welcome_lable.Name = "welcome_lable";
            this.welcome_lable.Size = new System.Drawing.Size(375, 44);
            this.welcome_lable.TabIndex = 0;
            this.welcome_lable.Text = "Гра \"Попади в кулю\"";
            // 
            // close_bt
            // 
            this.close_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_bt.Location = new System.Drawing.Point(133, 255);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(129, 39);
            this.close_bt.TabIndex = 5;
            this.close_bt.Text = "Завершити";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // start_bt
            // 
            this.start_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_bt.Location = new System.Drawing.Point(368, 255);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(125, 39);
            this.start_bt.TabIndex = 1;
            this.start_bt.Text = "Почати";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(321, 127);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(192, 21);
            this.name_tb.TabIndex = 3;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(108, 126);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(112, 22);
            this.name_lb.TabIndex = 2;
            this.name_lb.Text = "Ім\'я гравця:";
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.pause_bt);
            this.info_panel.Controls.Add(this.stop_bt);
            this.info_panel.Controls.Add(this.rating_box);
            this.info_panel.Controls.Add(this.penalty_lb);
            this.info_panel.Controls.Add(this.score_lb);
            this.info_panel.Controls.Add(this.progressBar1);
            this.info_panel.Controls.Add(this.player_name_lb);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Enabled = false;
            this.info_panel.Location = new System.Drawing.Point(0, 0);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(798, 151);
            this.info_panel.TabIndex = 15;
            this.info_panel.Visible = false;
            // 
            // pause_bt
            // 
            this.pause_bt.Location = new System.Drawing.Point(363, 114);
            this.pause_bt.Name = "pause_bt";
            this.pause_bt.Size = new System.Drawing.Size(98, 23);
            this.pause_bt.TabIndex = 13;
            this.pause_bt.Text = "Пауза";
            this.pause_bt.UseVisualStyleBackColor = true;
            this.pause_bt.Click += new System.EventHandler(this.pause_bt_Click);
            // 
            // stop_bt
            // 
            this.stop_bt.Location = new System.Drawing.Point(547, 114);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(89, 23);
            this.stop_bt.TabIndex = 12;
            this.stop_bt.Text = "Завершення";
            this.stop_bt.UseVisualStyleBackColor = true;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // rating_box
            // 
            this.rating_box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rating_box.Dock = System.Windows.Forms.DockStyle.Left;
            this.rating_box.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_box.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rating_box.Location = new System.Drawing.Point(0, 0);
            this.rating_box.Multiline = true;
            this.rating_box.Name = "rating_box";
            this.rating_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rating_box.Size = new System.Drawing.Size(285, 151);
            this.rating_box.TabIndex = 11;
            // 
            // penalty_lb
            // 
            this.penalty_lb.AutoSize = true;
            this.penalty_lb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalty_lb.ForeColor = System.Drawing.Color.Red;
            this.penalty_lb.Location = new System.Drawing.Point(511, 76);
            this.penalty_lb.Name = "penalty_lb";
            this.penalty_lb.Size = new System.Drawing.Size(0, 16);
            this.penalty_lb.TabIndex = 10;
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.Location = new System.Drawing.Point(329, 75);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(0, 18);
            this.score_lb.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Lime;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(514, 30);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 60;
            // 
            // player_name_lb
            // 
            this.player_name_lb.AutoSize = true;
            this.player_name_lb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name_lb.Location = new System.Drawing.Point(329, 37);
            this.player_name_lb.Name = "player_name_lb";
            this.player_name_lb.Size = new System.Drawing.Size(0, 16);
            this.player_name_lb.TabIndex = 7;
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.game_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_panel.Enabled = false;
            this.game_panel.Location = new System.Drawing.Point(0, 151);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(798, 401);
            this.game_panel.TabIndex = 17;
            this.game_panel.Visible = false;
            this.game_panel.Click += new System.EventHandler(this.game_panel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 552);
            this.Controls.Add(this.welcome_panel);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.info_panel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "MainForm";
            this.Text = "Мисливець за кулями";
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel welcome_panel;
        private System.Windows.Forms.Label welcome_lable;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Label penalty_lb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label player_name_lb;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.TextBox rating_box;
        private System.Windows.Forms.Button pause_bt;
        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Label level_lb;
        private System.Windows.Forms.ComboBox level_cb;
    }
}

