using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private bool btnSelected = false;
        public Game(List<Player> p)
        {
            InitializeComponent();
            players = p;
            MessageBox.Show("" + players.Last().stillIn()+" " + players.Last().hasStood());
            //Initialize cards, add one of each suit, total 52
            cards = new List<Card>();
            for (int val = 0; val <= 12; val++)
            {
                for (int suit = 0; suit < 4; suit++) 
                {
                    cards.Add(new Card(val, suit, cardImgList.Images[val * 4 + suit]));
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
            bool newGame = false;
            do
            {
                await PlayGameAsync();
                MessageBox.Show("Player stillin: " + players.Last().stillIn() + " Player has Stood" + players.Last().hasStood());
                MessageBox.Show("Player hand: " + players.Last().getHand());
                MessageBox.Show("Game Over, Player "+findWinner()+" won");
                // when game over show results screen
                while (!btnSelected)
                {
                    await Task.Delay(100); // Avoid blocking the UI thread
                }
            } while (newGame);
        }
        public async Task PlayGameAsync()
        {
            NewDeck();
            foreach (Player cur in players) // distributing cards
            {
                if (deck.Count<=0) 
                {
                    NewDeck();
                }
                inHands.Add(cur.addCard(0, deck.Pop()));
                inHands.Add(cur.addCard(0, deck.Pop()));

            }
            DisplayPlayerHand(players.First());//dealer's first
            DisplayPlayerHand(players.Last());//client's last
            while (stillPlay())
            {
                //MessageBox.Show("another round");
                foreach (Player cur in players)
                {
                    if (!cur.getBot())
                    {
                        btnHit.Show();
                        btnStand.Show();
                        btnSplit.Show();
                    }
                    else
                    {
                        btnHit.Hide();
                        btnStand.Hide();
                        btnSplit.Hide();
                    }
                    await cur.turnAsync(this); 
                    if (!cur.getBot() || cur.getDealer()) //if player or dealer
                    {
                        HidePlayerHand(cur);//remove old hand
                        DisplayPlayerHand(cur);//display new hand
                        MessageBox.Show(""+cur.getHand());
                        await PauseAsync(2000);

                    }
                    else
                    {
                        DisplayPlayerHand(cur); //display new hand
                        HidePlayerHand(cur); //remove old hand
                        await PauseAsync(5000);
                    }

                }
            }
        }

        public bool stillPlay()
        {
            foreach (Player i in players) 
            { 
                if (i.stillIn() && !i.hasStood()) 
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
            MessageBox.Show("New deck added");
            return deck;
        }

        public Stack<Card> GetDeck()
        {
            Stack<Card> temp = new Stack<Card>(deck);
            return temp;
        }

        public int handSum() 
        {
            int sum = 0;
            foreach(Card i in inHands)
            {
                sum = sum + i.getVal();            
            }
            return sum;
        }

        public int findWinner() 
        {
            int max = 0;
            int winner = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].getHand() > max)
                {
                    max = players[i].getHand();
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
            if (player.getDealer())
            {
                xOffset = 300;
                yOffset = 100;
                //MessageBox.Show("Dealer hand size: "+player.getDeck()[0].Count);
            }
            else if (!player.getBot())
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


            foreach (List<Card> hand in player.getDeck())
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    PictureBox pic = hand[i].getPictureBox();
                    pic.Location = new Point(xOffset + (i * cardSpacing), yOffset);
                    this.Controls.Add(pic);
                    pic.BringToFront();
                }
            }
        }

        private void HidePlayerHand(Player player)
        {
            foreach (List<Card> hand in player.getDeck())
                foreach (Card card in hand)
                {

                    this.Controls.Remove(card.getPictureBox());
                    //card.getPictureBox().Dispose();
                }
        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].press(1);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].press(2);
        }


        private void btnSplit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].press(3);
        }
        public async Task PauseAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
            // Code to execute after the delay
        }
    }
}
