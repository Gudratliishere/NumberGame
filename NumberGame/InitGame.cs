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
    public partial class InitGame : UserControl
    {
        public InitGame()
        {
            InitializeComponent();
        }

        private void gbtn_continue_Click(object sender, EventArgs e)
        {
            int maxScore;
            bool result = int.TryParse(gtb_maxScore.Text, out maxScore);
            if (!result || maxScore < 1)
                MessageBox.Show("Please write score greater than 0!");
            else
            {
                ChoosePlayer player = new ChoosePlayer();
                player.maxScore = Convert.ToInt32(gtb_maxScore.Text);
                player.Dock = DockStyle.Fill;
                pnl_body.Controls.Clear();
                pnl_body.Controls.Add(player);
                Main.Instance.gbtn_restart.Visible = true;
            }
        }

        private void InitGame_Load(object sender, EventArgs e)
        {
            Main.Instance.gbtn_restart.Visible = false;
        }

        private void gtb_maxScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gbtn_continue.PerformClick();
        }
    }
}
