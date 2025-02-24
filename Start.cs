using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        Point diffLoc = new Point(0,0);
        Point playLoc = new Point(150,0);
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
            List<Player> playing = new List<Player>();
            Player client = new Player();
            Player dealer = new Player(-1,-1,true);
            playing.Add(dealer);
            bool misinput = false;
            foreach (Panel p in players) 
            {
                int diff=1;
                int play=1;
                foreach (Control c in p.Controls)
                {
                    if (c.Location == diffLoc)
                    {
                        switch (c.Text)
                        {
                            case "Easy":
                                diff = 1;
                                break;
                            case "Hard":
                                diff = 2;
                                break;
                            default:
                                misinput = true;
                                //MessageBox.Show("Difficulty input is somehow wrong");
                                break;
                        }
                    }
                    else if (c.Location == playLoc)
                    {
                        switch (c.Text)
                        {
                            case "Risky":
                                play = 1;
                                break;
                            case "Conservative":
                                play = 2;
                                break;
                            case "Allseeing":
                                play = 2;
                                break;
                            default:
                                misinput = true;
                                //MessageBox.Show("Playsyle input is somehow wrong");
                                break;
                        }
                    }
                }
                playing.Add(new Player(diff, play, false));
            }
            playing.Add(client);
            if (misinput)
            {
                MessageBox.Show("Input is somehow wrong");
            }
            else
            {
                Game game = new Game(playing);
                this.Hide(); // Hide the Start form
                game.Show(); // Show the Game form
            }
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
                    Panel playerSetting = new Panel();
                    ComboBox difficulty = new ComboBox();
                    difficulty.Items.Add("Easy");
                    difficulty.Items.Add("Hard");
                    difficulty.Location = diffLoc;
                    ComboBox playstyle = new ComboBox();
                    playstyle.Items.Add("Risky");
                    playstyle.Items.Add("Conservative");
                    playstyle.Items.Add("Allseeing");
                    playstyle.Location = playLoc;
                    playerSetting.Controls.Add(difficulty);
                    playerSetting.Controls.Add(playstyle);
                    playerSetting.BackColor = Color.Red;
                    //player.ForeColor = Color.Green;
                    playerSetting.Width = 400;
                    playerSetting.Height = 50;
                    playerSetting.Location = new Point(30, (original + i) * 60);
                    panelPlayers.Controls.Add(playerSetting);
                    players.Add(playerSetting);
                }
            }
            else 
            {
                for (int i = 0; i < original - numUDNumPlayer.Value; i++)
                {
                    panelPlayers.Controls.Remove(players.Last());
                    players.Remove(players.Last());
                    panelPlayers.Refresh();
                }
            }
            if (!vScrollBarPlayers.Enabled)
                vScrollBarPlayers.Enabled = true;
            original = Convert.ToInt32(numUDNumPlayer.Value);
            //MessageBox.Show(""+panelPlayers.Controls.Count+" "+players.Count);

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
