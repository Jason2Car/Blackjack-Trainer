using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blackjack_Trainer
{
    public partial class Game : Form
    {
        private List<Card> cards;
        private Stack<Card> deck;
        private ArrayList<Player> players;
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

            //Now that deck is created, shuffle into deck
            deck = new Stack<Card>();
            Random rand = new Random();
            for (int i = 0; i < 52; i++) 
            {
                int pos =(int) (cardImgList.Images.Count * rand.NextDouble());
                deck.Push(cards.ElementAt(pos));
                cards.RemoveAt(pos);
            }
            
        }
    }
}
