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
        private int style;
        private List<List<Card>> deck;
        private int handVal;
        private int handValAce;
        public Player() { }
        public Player(int d, int s) { 
            diff = d;
            style = s;
        }

        public int getDifficulty()
        {
            return diff;
        }
        public int getStyle()
        {
            return style;
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
        }
    }
}
