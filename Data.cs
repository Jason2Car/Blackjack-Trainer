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
        private int action; //hit, stand, split
        public Data() { }
        public Data(Player p, Card c, int a) 
        {
            player = p;
            card = c;
            action = a;
        }
        public Player GetPlayer()
        {
            return player;
        }
        public Card GetCard()
        {
            return card;
        }
        public int GetAction()
        {
            return action;
        }   
        override
        public string ToString()
        {
            string ret = "";
            switch (action)
            {
                case 0:
                    ret = "Stand";
                    break;
                case 1:
                    ret = "Hit " + card.GetSuit() +" "+ card.GetVal();
                    break;
                case 2:
                    ret = "Split";
                    break;
                case 3:
                    ret = "Draw";
                    break;
                default:
                    ret = "Error";
                    break;
            }
            return ret;
        }
    }
}
