using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace NumberGame
{
    public partial class GamePlay : UserControl
    {
        private int maxScore;
        private bool isAIFirst;

        private Game game;

        public GamePlay()
        {
            InitializeComponent();
        }

        public int MaxScore { set => maxScore = value; }
        public bool IsAIFirst { set => isAIFirst = value; }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            lbl_maxScore.Text = "Max score: " + maxScore;
            gtbar_score.Maximum = maxScore;
            gtbar_score.Value = 0;
            game = new Game(maxScore);
            game.StartGame();
            for (int i = 1; i <= game.StepValue; i++)
            {
                var button = GetButton(i);
                flp_points.Controls.Add(button);
            }

            if (isAIFirst && !backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        private GunaButton GetButton(int value)
        {
            GunaButton button = new GunaButton();
            button.Image = null;
            button.TextAlign = HorizontalAlignment.Center;
            button.Radius = 10;
            button.Size = new Size(38, 38);
            button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            button.Text = "+" + value;
            button.Tag = value;
            button.Click += delegate (object sender2, EventArgs e2)
            {
                int step = Convert.ToInt32(button.Tag);
                if (game.Score + step > maxScore)
                    step = game.Score + step - maxScore;
                game.IncreaseScoreByUser(step);
                lbl_score.Text = game.Score.ToString();
                gtbar_score.Value = game.Score;
                lbl_status.Text = "You said " + button.Tag;
                if (game.IsGameFinished())
                {
                    System.Threading.Thread.Sleep(2000);
                    lbl_status.Text = "Congratulations! You won! :(";
                    FinishGame();
                }
                else if (!backgroundWorker.IsBusy)
                    backgroundWorker.RunWorkerAsync();
            };

            return button;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)(() => ChangeFLPEnabled(false)));
            System.Threading.Thread.Sleep(2000);
            Invoke((MethodInvoker)(() => IncreaseScoreByAI()));
            Invoke((MethodInvoker)(() => ChangeFLPEnabled(true)));
        }

        private void ChangeFLPEnabled(bool state)
        {
            flp_points.Enabled = state;
        }

        private void IncreaseScoreByAI()
        {
            int value = game.IncreaseScoreByAI();
            lbl_score.Text = game.Score.ToString();
            gtbar_score.Value = game.Score;
            lbl_status.Text = "AI said " + value;
            if (game.IsGameFinished())
            {
                lbl_status.Text = "Ahahah, AI won! :)";
                FinishGame();
            }
        }

        private void FinishGame()
        {
            flp_points.Visible = false;
        }
    }
}
