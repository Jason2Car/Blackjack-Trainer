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


            panelDealerCards.AutoScroll = true;

        }
        public void DisplayTurn() {
            MessageBox.Show(data.Count +" "+players.Count+ " " +currentTurn+" "+playerTurn);
            txtBxAdvice.Text = GetAdvice();
            if (playerTurn <= 0)
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
            StringBuilder advice = new StringBuilder();
            Game g = new Game(null);
            List<Card> remainingDeck = new List<Card>(g.GetDeck());
            Player client = players[players.Count - 1]; // Assuming the client is the last player
            Player dealer = players[0]; // Assuming the dealer is the first player
            int clientHandValue = client.GetHand();


            foreach (Player player in players)
            {
                foreach (List<Card> hand in player.GetDeck())
                {
                    foreach (Card card in hand)
                    {
                        if (!remainingDeck.Remove(card)) 
                        {
                            remainingDeck.AddRange(g.GetDeck());
                            remainingDeck.Remove(card);
                        }
                    }
                }
            }
            // Calculate the probability of drawing a card that won't bust the client
            int safeCards = remainingDeck.Count(card => (clientHandValue + card.GetVal() <= 21));
            double safeCardProbability = (double)safeCards / remainingDeck.Count * 100;

            advice.AppendLine($"Probability of drawing a safe card: {safeCardProbability:F2}%\n");
            // Add more advice based on the game state
            if (client.GetHand() > 21) 
            {
                advice.AppendLine("You busted so there's nothing you can do");
            }
            else if (dealer.GetHand() == 21)
            {
                advice.AppendLine("The dealer has a blackjack! You should surrender to minimize your losses.");
            }
            else if (dealer.GetHand() < 21 && dealer.GetHand() >= 17) 
            {
                advice.AppendLine("The dealer has a hand greater than 17. They will stand from here on");
            }
            else
            {
                if (client.GetHand() == 21)
                {
                    advice.AppendLine("You have a blackjack! Stand and hope the dealer doesn't have one too.");
                }
                else if (dealer.GetHand() > 21)
                {
                    advice.AppendLine("The dealer has busted! You can stand to avoid busting yourself or try doubling down.");
                }
                else if (dealer.GetHand() >= client.GetHand())
                {
                    MessageBox.Show(dealer.GetHand() + " " + client.GetHand());
                    advice.AppendLine("Since the dealer has a higher or equal hand than you, the best paths are to either surredner to reduce losses or to hit to hope to win");
                }
                else if (dealer.GetHand() < 17 && client.GetHand() > 17)
                {
                    advice.AppendLine("Since the dealer has a hand less than 17, they can grow to beat you. You can choose if you want to stand, hoping their lower, or hit to be more secure, but also risking busting");
                    if (safeCardProbability > 50)
                    {
                        advice.AppendLine("Due to the probabilty of drawing a safe card, it is recommended to stand.");
                    }
                    else
                    {
                        advice.AppendLine("Due to the probabilty of drawing a safe card, it is recommended to hit.");
                    }
                }
                else 
                {
                    advice.AppendLine("Game has nothing special or important to say right now. Nothing to say yet");
                }

            }

                //go through every player's every hand to find what cards are currently out of the deck
                //then using the current deck, find what the probability of the remaining cards won't bust the client or players[players.Count-1]
            return advice.ToString();
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

        private void btnNewSettings_Click(object sender, EventArgs e)
        {
            btnNewSettings.Hide();
            Start start = new Start();
            this.Hide(); // Hide the Start form
            start.Show(); // Show the Game form
        }
    }

}
