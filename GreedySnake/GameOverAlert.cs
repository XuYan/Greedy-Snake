using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedySnake
{
    public partial class GameOverAlert : Form
    {
        GameConsole mainConsole;

        public GameOverAlert(GameConsole mainConsole, String reason)
        {
            InitializeComponent();

            this.mainConsole = mainConsole;

            GameOverAlertText.Text += reason;
        }

        void play_again_button_Click(object sender, EventArgs e)
        {
            this.Close();
            mainConsole.startToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
