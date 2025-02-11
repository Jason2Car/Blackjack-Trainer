using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Trainer
{
    public class Data
    {
        private Player player;
        private Card card;
        private String action;
        public Data() { }
        public Data(Player p, Card c, String a) 
        {
            player = p;
            card = c;
            action = a;
        }

        override
        public string ToString()
        {
            string ret = "";
            if (action.Equals("stand"))
            {
                ret = "" + player.getBot() + "Stand";
            }
            else 
            {
                ret = ""+player.getBot()+action+card.getSuit()+card.getVal();
            }
            return ret;
        }
    }
}
