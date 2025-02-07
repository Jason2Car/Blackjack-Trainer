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
        private List<Card> cards;
        private Stack<Card> deck;
        private List<Card> inHands;
        private List<Player> players;
        private string data = "";

        private bool btnSelected = false;
        public Game()
        {
            InitializeComponent();

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


            


            bool newGame = false;
            do
            {
                playGame();
                //when game over show results screen
                while (!btnSelected) { 
                }
            } while (newGame);

        }
        public void playGame()
        {
            deck = GetDeck();
            foreach (Player cur in players) //distributing cards
            {
                cur.addCard(0, deck.Pop());
                cur.addCard(0, deck.Pop());
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

                    }
                    cur.turn(this);
                }
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
    }
}
