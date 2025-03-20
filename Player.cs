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
        public Player(int d, float s)
        {
            deck.Add(new List<Card>());
            diff = d;
            style = s;
        }
        public Player(Player other) 
        {
            this.deck = new List<List<Card>>();
            for (int h = 0; h < other.deck.Count; h++)
            {
                this.deck.Add(new List<Card>());
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
                return g.GetDeck().Pop().GetVal();
            }
            else
            {
                try
                {
                    return (340 - g.HandSum()) / (g.GetDeck().Count);
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
            if (card.GetVal() == 1)
            {
                handVal += 1;
                handValAce += 11;
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

        public abstract Task<Data> TurnAsync(Game g);

        public abstract int Type();

        public void ClearHand() 
        {
            deck.Clear();
            deck.Add(new List<Card>());
            handVal = 0;
            handValAce = 0;
            stood = false;
        }
        public void Press(int selected) 
        {
            btnPressed = selected;
        }
    }
}
