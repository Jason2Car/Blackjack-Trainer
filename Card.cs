using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blackjack_Trainer
{
    public class Card
    {
        private int val;
        private int suit;
        private PictureBox pic;

        private string[] data = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public Card() { }
        public Card(int v, int s, Image i) { 
            val = v;
            suit = s;
            pic = new PictureBox();
            pic.Image = i;
            pic.Size = new Size(50, 72); // Adjust size as needed
            pic.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure the image fits the PictureBox
        }

        public int getVal()
        {
            return val;
        }
        public int getSuit()
        {
            return suit;
        }
        public PictureBox getPictureBox()
        {
            return pic;
        }
    }
}
