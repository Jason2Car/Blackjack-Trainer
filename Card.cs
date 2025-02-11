using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blackjack_Trainer
{
    public class Card
    {
        private int val;
        private int suit;
        private Image img;

        private string[] data = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
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
        public Image getImage()
        {
            return img;
        }
    }
}
