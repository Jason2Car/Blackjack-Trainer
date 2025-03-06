using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    public class Player
    {
        
        private int diff;
        private float style;
        private List<List<Card>> deck = new List<List<Card>>();
        private int handVal=0;
        private int handValAce=0;
        private int[] decision = new int[] { 1, 2, 3, 5, 7, 11, 13 };
        private bool bot;
        private bool dealer;
        private int btnPressed = 0;
        private bool stood = false;
        public Player() 
        {
            dealer = false;
            bot = false;
            deck.Add(new List<Card>());
        }
        public Player(int d, int s, bool deal) { 
            diff = d;
            style = s;
            dealer = deal;
            bot = true;
            deck.Add(new List<Card>());
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

        public bool getDealer()
        {
            return dealer;
        }
        public bool stillIn() 
        {
            return (handVal <= 21 || handValAce <= 21);//either is <=21 then return true means still in, false means busted
        }
        public int getHand() 
        {
            /*if (!stillIn()) //if busted
            {
                return -1;
            }*/
            return (handValAce > handVal && handValAce<=21)? handValAce: handVal;
        }

        public bool hasStood() 
        {
            return stood;
        }

        public int evalRisk(Game g) 
        {
            if (style == 2)
            {
                return g.GetDeck().Pop().getVal();
            }
            else
            {
                try
                {
                    return (340 - g.handSum()) / (g.GetDeck().Count);
                }
                catch (Exception e) 
                {
                    //divides by zero when there are no cards, so act like there's a full deck left
                    return 340;
                }
            }
        }

        public Card addCard(int hand, Card card)
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
                handValAce += card.getVal();
            }
            //MessageBox.Show("Card added: " + card.getVal());
            return card;
        }

        public List<List<Card>> getDeck() 
        {
            return deck;
        }

        public async Task<Data> turnAsync(Game g) 
        {
            Data ret = null;
            if (stillIn() && !stood) 
            {
                if (!bot) //if player
                {
                    bool decisionMade = false;
                    while (!decisionMade)
                    {
                        switch (btnPressed)
                        {
                            case 1:
                                Card card = g.deck.Pop();
                                ret = new Data(this, addCard(0, card), "Hit");
                                decisionMade = true;
                                MessageBox.Show("Hit");
                                btnPressed = 0;
                                break;
                            case 2:
                                ret = new Data(this, null, "Stand");
                                decisionMade = true;
                                stood = true;
                                MessageBox.Show("Stand");
                                btnPressed = 0;
                                break;
                            case 3:
                                decisionMade = true;
                                MessageBox.Show("Split");
                                btnPressed = 0;
                                break;

                        }
                        await Task.Delay(100); // Avoid blocking the UI thread
                    }
                }
                else
                {
                    Random rand = new Random();
                    if (dealer) //if dealer
                    {
                        if (handVal < 17 && handValAce < 17)
                        {
                            Card card = g.deck.Pop();
                            ret = new Data(this, addCard(0, card), "Hit"); //add card to dealer's hand
                        }
                        else
                        {
                            ret = new Data(this, null, "Stand");
                            stood = true;
                        }
                    }
                    else //if bot
                    {
                        if (evalRisk(g) + handVal <= 21 + diff * rand.NextDouble()) //if the player should hit
                        {
                            Card card = g.deck.Pop();
                            ret = new Data(this, addCard(0, card), "Hit");
                        }
                        else //if the player should stand
                        {
                            ret = new Data(this, null, "Stand");
                            stood = true;
                        }
                    }
                }
            }
            return ret;
        }

        public void clearHand() 
        {
            deck.Clear();
            deck.Add(new List<Card>());
            handVal = 0;
            handValAce = 0;
            stood = false;
        }
        public void press(int selected) 
        {
            btnPressed = selected;
        }
    }
}
