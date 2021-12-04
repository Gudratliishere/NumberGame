using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class ChoosePlayer : UserControl
    {
        public int maxScore;

        public ChoosePlayer()
        {
            InitializeComponent();
        }

        private void gbtn_user_Click(object sender, EventArgs e)
        {
            StartGame(false);
        }

        private void StartGame (bool isAIFirst)
        {
            GamePlay game = new GamePlay();
            game.MaxScore = maxScore;
            game.IsAIFirst = isAIFirst;
            game.Dock = DockStyle.Fill;
            Main.Instance.pnl_body.Controls.Clear();
            Main.Instance.pnl_body.Controls.Add(game);
        }

        private void gbtn_ai_Click(object sender, EventArgs e)
        {
            StartGame(true);
        }
    }
}
