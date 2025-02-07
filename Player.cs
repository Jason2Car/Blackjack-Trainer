using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Trainer
{
    internal class Player
    {
        
        private int diff;
        private float style;
        private List<List<Card>> deck;
        private int handVal;
        private int handValAce;
        private int[] decision = new int[] { 1, 2, 3, 5, 7, 11, 13 };
        private bool bot;
        private bool dealer;
        private int btnPressed = 0;
        public Player() { }
        public Player(int d, int s) { 
            diff = d;
            style = s;
        }

        public int getDifficulty()
        {
            return diff;
        }
        public float getStyle()
        {
            return style;
        }
        public bool getBot()
        {
            return bot;
        }
        public bool stillIn() 
        {
            return (handVal <= 21 || handValAce <= 21);
        }

        public int evalRisk(Game g) 
        {
            if (style == 2)
            {
                return g.GetDeck().Pop().getVal();
            }
            else
            {
                return (340 - g.handSum())/(52-g.GetDeck().Count);
            }
        }

        public void addCard(int hand, Card card)
        {
            deck[hand].Add(card);
            if (card.getVal() == 1)
            {
                handVal += 1;
                handValAce += 11;
            }
            else
            {
                handVal += card.getVal();
            }
        }

        public String turn(Game g) 
        {
            String ret = "";
            if (stillIn()) 
            {
                if (!bot)
                {
                    while (btnPressed==0)
                    {

                    }
                    
                }
                else {
                    Random rand = new Random();
                    if (dealer) 
                    {
                    
                    }
                    else if (style * evalRisk(g) + handVal > 21 + diff * rand.NextDouble()) 
                    {
                        
                    }
                }
            }
            return ret;
        }
    }
}
