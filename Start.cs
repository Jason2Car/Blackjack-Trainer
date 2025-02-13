using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blackjack_Trainer
{
    public partial class Start : Form
    {
        int original;
        List<Panel> players;
        public Start()
        {
            InitializeComponent();
            original = Convert.ToInt32(numUDNumPlayer.Value);
            players = new List<Panel>();
            vScrollBarPlayers.Value = panelPlayers.VerticalScroll.Value;
            vScrollBarPlayers.Minimum = panelPlayers.VerticalScroll.Minimum;
            vScrollBarPlayers.Maximum = panelPlayers.VerticalScroll.Maximum;
            vScrollBarPlayers.Scroll += vScrollBarPlayers_Scroll;
            vScrollBarPlayers.Enabled = false;

            panelPlayers.ControlAdded += panelPlayers_ControlAdded;
            panelPlayers.ControlRemoved += panelPlayers_ControlRemoved;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            int numPlayers = Convert.ToInt32(numUDNumPlayer.Value);
            Game game = new Game();
            this.Close();
            game.Show();
            Application.Run();
        }

        private void vScrollBarPlayers_Scroll(object sender, ScrollEventArgs e)
        {
            panelPlayers.VerticalScroll.Value = vScrollBarPlayers.Value;
        }

        private void numUDNumPlayer_ValueChanged(object sender, EventArgs e)
        {
            if (original < numUDNumPlayer.Value)
            {
                for (int i = 0; i < numUDNumPlayer.Value - original; i++)
                {

                    Panel player = new Panel();
                    ComboBox difficulty = new ComboBox();
                    difficulty.Location = new Point(0, 0);
                    ComboBox playstyle = new ComboBox();
                    playstyle.Location = new Point(200, 0);
                    player.Controls.Add(difficulty);
                    player.Controls.Add(playstyle);
                    player.BackColor = Color.Red;
                    //player.ForeColor = Color.Green;
                    player.Width = 400;
                    player.Height = 50;
                    player.Location = new Point(30, (original + i) * 100);
                    panelPlayers.Controls.Add(player);
                    players.Append(player);
                }
            }
            else 
            {
                for (int i = 0; i < original - numUDNumPlayer.Value; i++)
                {
                    if (players.Count != 0)
                    {
                        panelPlayers.Controls.RemoveAt(original--);
                        players.Remove(players.Last());

                    }
                }
            }
            if (!vScrollBarPlayers.Enabled)
                vScrollBarPlayers.Enabled = true;
            original = Convert.ToInt32(numUDNumPlayer.Value);
        }

        void panelPlayers_ControlRemoved(object sender, ControlEventArgs e)
        {
            vScrollBarPlayers.Minimum = panelPlayers.VerticalScroll.Minimum;
        }

        void panelPlayers_ControlAdded(object sender, ControlEventArgs e)
        {
            vScrollBarPlayers.Minimum = panelPlayers.VerticalScroll.Minimum;
        }
    }
}
