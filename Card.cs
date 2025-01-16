using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blackjack_Trainer
{
    internal class Card
    {
        private int val;
        private int suit;
        private Image img;
        public Card() { }
        public Card(int v, int s, Image i) { 
            val = v;
            suit = s;
            img = i;
        }

        public int getVal()
        {
            return val;
        }
        public int getSuit()
        {
            return suit;
        }
        public int getImage()
        {
            return img;
        }
    }
}
