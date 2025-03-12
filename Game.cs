using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blackjack_Trainer
{
  
    public partial class Game : Form
    {
        private List<Card> cards = new List<Card>();
        public Stack<Card> deck = new Stack<Card>();
        private List<Card> inHands = new List<Card>();
        private List<Player> players = new List<Player>();
        private List<int> winings = new List<int>();
        private List<Data> data = new List<Data>();

        //private bool btnSelected = false;
        public Game(List<Player> p)
        {
            InitializeComponent();
            players = p;
            //MessageBox.Show("" + players.Last().stillIn()+" " + players.Last().hasStood());
            //Initialize cards, add one of each suit, total 52
            cards = new List<Card>();
            for (int val = 1; val <= 13; val++)
            {
                for (int suit = 0; suit < 4; suit++) 
                {
                    cards.Add(new Card(Math.Min(val, 10), suit, cardImgList.Images[(val-1) * 4 + suit]));
                }
            }
            //need to initialize players

            this.Load += async (sender, e) => await InitializeGameAsync();
        }

        private async Task InitializeGameAsync()
        {
            await StartGameAsync();
        }
        private async Task StartGameAsync()
        {
            if (players.Count == 2) 
            {
                txtBxScoreBot.Hide();
                txtBxHasStood.Hide();
            }
            await PlayGameAsync();
            //MessageBox.Show("Player stillin: " + players.Last().stillIn() + " Player has Stood" + players.Last().hasStood());
            //MessageBox.Show("Player hand: " + players.Last().getHand());
            int winner = FindWinner();
            if (winner == players.Count - 1)
            {
                MessageBox.Show("Game Over. You won");

            }
            else if (winner == 0)
            {
                MessageBox.Show("Game Over. Dealer won");
            }
            else
            {
                MessageBox.Show("Game Over. Bot " + winner + " won");

            }
            
        }
        public async Task PlayGameAsync()
        {
            NewDeck();
            //await PauseAsync(1000);
            foreach (Player cur in players) // distributing cards
            {
                if (deck.Count<=0) 
                {
                    NewDeck();
                }
                inHands.Add(cur.AddCard(0, deck.Pop()));
                inHands.Add(cur.AddCard(0, deck.Pop()));

            }
            DisplayPlayerHand(players.First());//dealer's first
            DisplayPlayerHand(players.Last());//client's last
            while (StillPlay())
            {
                txtBxScorePlayer.Text = "Score: " + players.Last().GetHand();
                //MessageBox.Show("another round");
                foreach (Player cur in players)
                {
                    DisplayPlayerHand(cur);
                    if (!cur.IsComputer())
                    {
                        btnHit.Show();
                        btnStand.Show();
                        btnSplit.Show();
                    }
                    else 
                    {
                        await PauseAsync(2000);
                    }

                    Data result = await cur.TurnAsync(this);
                    data.Add(result);

                    btnHit.Hide();
                    btnStand.Hide();
                    btnSplit.Hide();
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
            btnNewGame.Show();
            btnNewSettings.Show();
            btnReview.Show();
        }

        public bool StillPlay()
        {
            foreach (Player i in players) 
            { 
                if (i.StillIn() && !i.HasStood()) 
                { 
                    return true; 
                }
            }
            return false;
        }

        public Stack<Card> NewDeck() 
        {
            deck = new Stack<Card>();
            List<Card> tempCards = new List<Card>(cards);
            Random rand = new Random();
            while (tempCards.Count>0)
            {
                int pos = (int)(tempCards.Count * rand.NextDouble());
                deck.Push(tempCards.ElementAt(pos));
                tempCards.RemoveAt(pos);
            }
            //MessageBox.Show("New deck added");
            return deck;
        }

        public Stack<Card> GetDeck()
        {
            Stack<Card> temp = new Stack<Card>(deck);
            return temp;
        }

        public int HandSum() 
        {
            int sum = 0;
            foreach(Card i in inHands)
            {
                sum = sum + i.GetVal();            
            }
            return sum;
        }

        public int FindWinner() 
        {
            int max = 0;
            int winner = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].StillIn() && players[i].GetHand() > max) //if player ties with dealer, still dealer wins, winner doesn't update
                {
                    max = players[i].GetHand();
                    winner = i;
                }
            }
            return winner;
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
            txtBxScoreBot.Text = "Score: " ;
            txtBxHasStood.Text = "Has Stood: ";

        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(1);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(2);
        }


        private void btnSplit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(3);
        }
        public async Task PauseAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
            // Code to execute after the delay
        }

        private async void btnNewGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Hide();
            btnNewSettings.Hide();
            btnReview.Hide();
            foreach (Player i in players)
            {
                HidePlayerHand(i);
                i.ClearHand();
            }
            txtBxScorePlayer.Text = "Score: ";
            await InitializeGameAsync();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {

        }

        private void btnNewSettings_Click(object sender, EventArgs e)
        {
            btnNewSettings.Hide();
            Start start = new Start();
            this.Hide(); // Hide the Start form
            start.Show(); // Show the Game form
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

            btnReview.Hide();
            GameReview review= new GameReview(data, players.Count);
            this.Hide(); // Hide the Start form
            review.Show(); // Show the Game form
            SortWinners();
        }
        private List<Player> SortWinners()
        {

            List<Player> ret = new List<Player>(players);
            int n = players.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (ret[j].GetWinnings() > ret[maxIndex].GetWinnings())
                    {
                        maxIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                Player temp = ret[maxIndex];
                ret[maxIndex] = ret[i];
                ret[i] = temp;
            }
            return ret;
        }
    }
}
