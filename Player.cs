using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    public abstract class Player
    {

        protected int diff;
        protected float style;
        protected List<List<Card>> deck = new List<List<Card>>();
        protected int handVal = 0;
        protected int handValAce = 0;
        protected int[] decision = new int[] { 1, 2, 3, 5, 7, 11, 13 };
        protected int btnPressed = 0;
        protected int winnings = 1000;
        protected int bet = 0;
        protected bool stood = false;
        protected bool isComputerControlled = false;
        protected bool isDealer = false;
        protected List<bool> hasAce = new List<bool>();
        public Player(int d, float s)
        {
            deck.Add(new List<Card>());
            this.hasAce.Add(false);
            diff = d;
            style = s;
        }
        public Player(Player other) 
        {
            for (int h = 0; h < other.deck.Count; h++)
            {
                this.deck.Add(new List<Card>());
                this.hasAce.Add(false);
                foreach (Card c in other.deck[h])
                {
                    this.deck[h].Add(new Card(c.GetVal(), c.GetSuit(), c.GetPictureBox().Image));
                }
            }
        }
        

        public int GetDifficulty()
        {
            return diff;
        }
        public float GetStyle()
        {
            return style;
        }
        public int GetWinnings() 
        {
            return winnings;
        }
        public int GetButtonPressed() 
        {
            return btnPressed;
        }
        public bool IsComputer()
        {
            return isComputerControlled;
        }
        public bool IsDealer()
        {
            return isDealer;
        }
        public bool HasStood()
        {
            return stood;
        }
        public void SetStood(bool s)
        {
            stood = s;
        }
        public int GetHand() 
        {
            /*if (!stillIn()) //if busted
            {
                return -1;
            }*/
            return (handValAce > handVal && handValAce<=21)? handValAce: handVal;
        }


        public bool StillIn()
        {
            return (handVal <= 21 || handValAce <= 21);//either is <=21 then return true means still in, false means busted
        }
        public int EvalRisk(Game g) 
        {
            if (style == 2)
            {
                return g.CopyDeck().Pop().GetVal();
            }
            else
            {
                try
                {
                    return (340 - g.HandSum()) / (g.CopyDeck().Count);
                }
                catch (Exception e) 
                {
                    return 340/52;
                }
            }
        }

        public Card AddCard(int hand, Card card)
        {
            deck[hand].Add(card);
            if (!hasAce[hand] && card.GetVal() == 1)
            {
                handVal += 1;
                handValAce += 11;
                hasAce[hand] = true;
            }
            else 
            {
                handVal += card.GetVal();
                handValAce += card.GetVal();
            }
            //MessageBox.Show("Card added: " + card.getVal());
            return card;
        }

        public Card RemoveCard(int hand, Card card) 
        {
            deck[hand].Remove(card);
            if (card.GetVal() == 1)
            {
                handVal -= 1;
                handValAce -= 11;
            }
            else
            {
                handVal -= card.GetVal();
                handValAce -= card.GetVal();
            }
            return card;
        }

        public List<List<Card>> GetDeck() 
        {
            return deck;
        }
        public void UpdateWinnings(int update) 
        {
            winnings = update;
        }
        public abstract Task<Data> TurnAsync(Game g);

        public abstract int Type();

        public void ClearHand() 
        {
            deck.Clear();
            deck.Add(new List<Card>());
            hasAce.Clear();
            hasAce.Add(false);
            handVal = 0;
            handValAce = 0;
            stood = false;
        }
        public void Press(int selected) 
        {
            btnPressed = selected;
        }

        public void Hit(Game g)
        {

            Card card = g.deck.Peek();
            AddCard(0, card);
        }

        public void Stand(Game g)
        {
            stood = true;
        }
        public List<List<Card>> CopyDeck()
        {
            List<List<Card>> copy = new List<List<Card>>();
            copy.Add(new List<Card>());
            foreach(Card c in deck[0])//sorta given up on multiple hands
            {
                copy[0].Add(c);
            }
            return copy;
        }
        public void SetDeck(List<List<Card>> other)
        {
            deck = other;
        }
    }
}
