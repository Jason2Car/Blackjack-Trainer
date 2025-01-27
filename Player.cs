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
        public void addCard(int hand, Card card)
        {
            deck[hand].Add(card);
        }
    }
}
