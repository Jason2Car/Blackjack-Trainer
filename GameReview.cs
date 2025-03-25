using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    public partial class GameReview : Form
    {
        List<Data> data;
        List<Player> players;
        int playerTurn = 0;// where the player wants to go
        int currentTurn = 0; // this represents the last turn displayed
        public GameReview(List<Data> d, List<Player> p)
        {
            InitializeComponent();
            data = d;
            players = p;
            DisplayTurn();

            panelClientCards.AutoScroll = true;


            panelPlayersCards.AutoScroll = true;


            panelDealerCards.AutoScroll = true;

        }
        public void DisplayTurn() {
            MessageBox.Show(data.Count +" "+players.Count+ " " +currentTurn+" "+playerTurn);
            txtBxAdvice.Text = data[playerTurn * players.Count].GetAdvice();
            if (playerTurn <= 1)
            {
                btnPrev.Hide();
            }
            else 
            {
                btnPrev.Show();
            }
            if (playerTurn >= (data.Count / players.Count)-1)
            {
                btnNext.Hide();
            }
            else 
            {
                btnNext.Show();
            }
            if (playerTurn >= currentTurn)
            {
                for (int t = currentTurn; t < playerTurn; t++) //go through the turns
                {
                    for (int curPlayer = 0; curPlayer < players.Count; curPlayer++) //go through players in each turn
                    {
                        Data cur = data[t * players.Count + curPlayer];
                        switch (cur.GetAction())
                        {
                            case 1://hit
                                players[curPlayer].AddCard(0, cur.GetCard());
                                break;
                            case 2://stand
                                break;
                            case 3://split
                                break;//need to implement
                            default:
                                MessageBox.Show("Error in data");
                                break;
                        }

                    }
                }
            }
            else
            {
                for (int t = currentTurn; t < playerTurn; t--) //start at higher and go to lower turn
                {
                    for (int curPlayer = players.Count-1; curPlayer >= 0; curPlayer--) //go through players in each turn
                    {
                        Data cur = data[t * players.Count + curPlayer];
                        switch (cur.GetAction())
                        {
                            case 1://hit
                                players[curPlayer].RemoveCard(0, cur.GetCard());
                                break;
                            case 2://stand
                                break;
                            case 3://split
                                break;//need to implement
                            default:
                                MessageBox.Show("Error in data");
                                break;
                        }

                    }
                }

            }
            currentTurn = playerTurn;
            txtBoxTurn.Text = "Turn: " + (currentTurn + 1);
            DisplayState();
            MessageBox.Show("state displayed");
        }
        public string GetAdvice() 
        {
            String ret = "";
            //go through every player's every hand to find what cards are currently out of the deck
            //then using the current deck, find what the probability of the remaining cards won't bust the client or players[players.Count-1]
            return ret;
        }
        public void DisplayState() 
        {
            HidePlayerHand(players[players.Count - 1]);
            DisplayPlayerHand(players[players.Count - 1]);//want the client
            HidePlayerHand(players[0]);//want the dealer
            DisplayPlayerHand(players[0]);//want the dealer
        }
        private void DisplayPlayerHand(Player player)
        {
            //if time, use directory to preload image boxes and can use card
            //values to get which image to show, then no need to hold images in cards
            // Display current hand

            int xOffset; // Starting X position
            int yOffset;  // Starting Y position
            int cardSpacing = 75; // Space between cards
            Panel cur = null;
            if (player.IsDealer())
            {
                cur = panelDealerCards;
            }
            else if (!player.IsComputer())
            {
                cur = panelClientCards;
            }
            else
            {
                cur = panelPlayersCards;
            }
            //if the bot, then use this to show cards

            foreach (List<Card> hand in player.GetDeck())
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    PictureBox pic = hand[i].GetPictureBox();
                    pic.Location = new Point(10 + (i * cardSpacing), 30);
                    cur.Controls.Add(pic);
                }
            }
            if (player.IsComputer() && !player.IsDealer())
            {
                txtBxScoreBot.Text = "Score: " + player.GetHand();
                txtBxHasStood.Text = "Has Stood: " + player.HasStood();
                //await PauseAsync(1000);
            }

        }
        private void HidePlayerHand(Player player)
        {
            foreach (List<Card> hand in player.GetDeck())
                foreach (Card card in hand)
                {

                    this.Controls.Remove(card.GetPictureBox());
                    //card.getPictureBox().Dispose();
                }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++playerTurn;
            DisplayTurn();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            --playerTurn;
            DisplayTurn();
        }
        public async Task PauseAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
            // Code to execute after the delay
        }
    }

}
