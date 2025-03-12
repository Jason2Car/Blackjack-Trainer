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
        List<Player> players = new List<Player>();
        int currentTurn = 0;
        public GameReview(List<Data> d, List<Player> p)
        {
            InitializeComponent();
            data = d; 
            for(int i = 0; i < p.Count; i++)
            {
                players.Add(new Dealer()); //doesn't matter what type since just data storage
            }
            this.Load += async (sender, e) => await InitializeReviewAsync();

        }


        private async Task InitializeReviewAsync()
        {
            await StartReviewAsync();
        }

        private async Task StartReviewAsync()
        {
            txtBoxTurn.Text = "Turn: " + (currentTurn + 1);
            DisplayTurn(currentTurn);
        }
        public async void DisplayTurn(int turn) {
            for (int t = 0; t < currentTurn; t++) 
            {
                for (int curPlayer = 0; curPlayer < players.Count; curPlayer++) {
                    Player cur = players[curPlayer];
                    DisplayPlayerHand(cur);
                    
                    await PauseAsync(2000);


                    if (!cur.IsComputer() || cur.IsDealer()) //if player or dealer
                    {
                        //txtBxScore.Text = "Score: " + cur.getHand();
                        HidePlayerHand(cur);//remove old hand
                        DisplayPlayerHand(cur);//display new hand
                        //MessageBox.Show(cur.getBot()+" Hand: "+cur.getHand());
                        await PauseAsync(1000);

                    }
                    else
                    {
                        DisplayPlayerHand(cur); //display new hand
                        await PauseAsync(2000);
                        HidePlayerHand(cur); //remove old hand
                    }
                }
            }
        }
        private void DisplayPlayerHand(Player player)
        {
            //if time, use directory to preload image boxes and can use card
            //values to get which image to show, then no need to hold images in cards
            // Display current hand

            int xOffset; // Starting X position
            int yOffset;  // Starting Y position
            int cardSpacing = 75; // Space between cards
            if (player.IsDealer())
            {
                xOffset = 300;
                yOffset = 100;
                //MessageBox.Show("Dealer hand size: "+player.getDeck()[0].Count);
            }
            else if (!player.IsComputer())
            {
                xOffset = 500;
                yOffset = 300;
            }
            else
            {
                xOffset = 100;
                yOffset = 300;
            }
            //if the bot, then use this to show cards

            if (player.IsComputer() && !player.IsDealer())
            {
                txtBxScoreBot.Text = "Score: " + player.GetHand();
                txtBxHasStood.Text = "Has Stood: " + player.HasStood();
                //await PauseAsync(1000);
            }

            foreach (List<Card> hand in player.GetDeck())
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    PictureBox pic = hand[i].GetPictureBox();
                    pic.Location = new Point(xOffset + (i * cardSpacing), yOffset);
                    this.Controls.Add(pic);
                    pic.BringToFront();
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
            txtBxScoreBot.Text = "Score: ";
            txtBxHasStood.Text = "Has Stood: ";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
        public async Task PauseAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
            // Code to execute after the delay
        }
    }

}
