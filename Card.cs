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
        enum Suits
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3
        }

        public int GetVal()
        {
            return val;
        }
        public int GetSuit()
        {
            return suit;
        }
        public String GetSuitString()
        {
            return Enum.GetName(typeof(Suits), suit);
        }
        public PictureBox GetPictureBox()
        {
            return pic;
        }
    }
}
