using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Main : Form
    {
        public static Main Instance;

        public Main()
        {
            InitializeComponent();

            Instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitGame init = new InitGame();
            init.Dock = DockStyle.Fill;
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(init);
        }

        private void gbtn_restart_Click(object sender, EventArgs e)
        {
            InitGame game = new InitGame();
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(game);
        }
    }
}
