using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Trainer
{
    internal class ComputerControlledPlayer : Player
    {
        public ComputerControlledPlayer(int d, float s)
            : base(d, s)
        {
            isComputerControlled = true;
            isDealer = false;
        }

        public override async Task<Data> TurnAsync(Game g)
        {
            Data ret = null;
            if (StillIn() && !HasStood())
            {
                Random rand = new Random();
                if (EvalRisk(g) + GetHand() <= 21 + GetDifficulty() * rand.NextDouble()) // if the player should hit
                {
                    Card card = g.deck.Pop();
                    ret = new Data(this, AddCard(0, card), 1);
                }
                else // if the player should stand
                {
                    ret = new Data(this, null, 2);
                    SetStood(true);
                }
            }
            return ret;
        }
    }
}
