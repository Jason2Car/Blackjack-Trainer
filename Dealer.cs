﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Trainer
{
    internal class Dealer : Player
    {
        public Dealer()
            : base(-1, -1)
        {
            isDealer = true;
            isComputerControlled = true;
        }
        public Dealer(Player other)
            : base(other)
        {
            isDealer = true;
            isComputerControlled = true;
        }

        public override async Task<Data> TurnAsync(Stack<Card> deckUsed)
        {
            Data ret = new Data(this, null, -1);//if they bust, they basically stood, we check for stillIn() anyways before
            if (StillIn() && !HasStood())
            {
                if (GetHand() < 17)
                {
                    Card card = deckUsed.Pop();
                    ret = new Data(this, AddCard(0, card), 1); // add card to dealer's hand
                }
                else
                {
                    ret = new Data(this, null, 2);
                    SetStood(true);
                }
            }
            return ret;
        }
        public override int Type()
        {
            return 0;
        }
    }
}
