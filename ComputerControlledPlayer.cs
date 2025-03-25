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
        public ComputerControlledPlayer(Player other)
            : base(other)
        {
            isComputerControlled = true;
            isDealer = false;
        }

        public override async Task<Data> TurnAsync(List<Card> deckUsed)
        {
            Data ret = new Data(this, null, -1);//if they bust, they basically stood, we check for stillIn() anyways before
            if (StillIn() && !HasStood())
            {
                Random rand = new Random();
                if (EvalRisk(g) + GetHand() <= 21 + GetDifficulty() * rand.NextDouble()) // if the player should hit
                {
                    Card card = deckUsed.Pop();
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
        public override int Type()
        {
            return 1;
        }
    }
}
