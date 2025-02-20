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
        private string data = "";

        private bool btnSelected = false;
        public Game(List<Player> p)
        {
            InitializeComponent();
            MessageBox.Show("Made it to the new world");
            players = p;
            //Initialize cards, add one of each suit, total 52
            cards = new List<Card>();
            for (int val = 0; val < 13; val++)
            {
                for (int suit = 0; suit < 4; suit++) 
                {
                    cards.Add(new Card(val, suit, cardImgList.Images[val * 4+ suit]));
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
                // when game over show results screen
                while (!btnSelected)
                {
                    await Task.Delay(100); // Avoid blocking the UI thread
                }
            } while (newGame);
        }
        public async Task PlayGameAsync()
        {
            deck = GetDeck();
            foreach (Player cur in players) // distributing cards
            {
                inHands.Add(cur.addCard(0, deck.Pop()));
                inHands.Add(cur.addCard(0, deck.Pop()));
            }
            while (stillPlay())
            {
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
                        DisplayPlayerHand(cur);
                    }
                    await cur.turnAsync(this); // Assuming turn method is also made async
                    if (cur.getBot())
                    {
                        await PauseAsync(5000);
                        HidePlayerHand(cur);

                    }
                    
                }
            }
        }

        private void DisplayPlayerHand(Player player)
        {
            //if time, use directory to preload image boxes and can use card
            //values to get which image to show, then no need to hold images in cards
            // Display current hand
            if (player.getBot())
            {
                //if the bot, then use this to show cards
                int xOffset = 100; // Starting X position
                int yOffset = 300; // Starting Y position
                int cardSpacing = 100; // Space between cards

            }
            else 
            {
                //if the client, then use this to update cards. There cards will always be displayed
                int xOffset = 500; // Starting X position
                int yOffset = 300; // Starting Y position
                int cardSpacing = 100; // Space between cards
            }

            foreach (List<Card> hand in player.getDeck())
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    PictureBox pic = hand[i].getPictureBox();
                    pic.Location = new Point(xOffset + (i * cardSpacing), yOffset);
                    pic.BringToFront();
                    this.Controls.Add(pic);
                }
            }
        }

        private void HidePlayerHand(Player player)
        {
            foreach (List<Card> hand in player.getDeck())
                foreach (Card card in hand)
                {

                    this.Controls.Remove(card.getPictureBox());
                    card.getPictureBox().Dispose();
                }
        }
        public bool stillPlay()
        {
            bool cont = false;
            foreach (Player i in players) 
            { 
                if (i.stillIn()) 
                { 
                    cont = true; 
                }
            }
            return cont;
        }

        public Stack<Card> NewDeck() 
        {
            deck = new Stack<Card>();
            List<Card> tempCards = new List<Card>(cards);
            Random rand = new Random();
            for (int i = 0; i < 52; i++)
            {
                int pos = (int)(tempCards.Count * rand.NextDouble());
                deck.Push(tempCards.ElementAt(pos));
                tempCards.RemoveAt(pos);
            }
            return deck;
        }

        public Stack<Card> GetDeck()
        {
            Stack<Card> temp = new Stack<Card>(cards);
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
