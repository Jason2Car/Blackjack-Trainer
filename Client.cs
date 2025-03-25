using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    internal class Client : Player
    {

        public Client()
            : base(-1, -1)
        {
            isComputerControlled = false;
            isDealer = false;
        }
        public Client(Player other)
            : base(other)
        {
            isComputerControlled = false;
            isDealer = false;
        }
        public override async Task<Data> TurnAsync(List<Card> deckUsed)
        {
            Data ret = new Data(this, null, -1);//if they bust, they basically stood, we check for stillIn() anyways before
            if (StillIn() && !stood)
            {
                bool decisionMade = false;
                while (!decisionMade)
                {
                    switch (btnPressed)
                    {
                        case 1:
                            Card card = deckUsed.Pop();
                            ret = new Data(this, AddCard(0, card), btnPressed);
                            decisionMade = true;
                            MessageBox.Show("Hit");
                            btnPressed = 0;
                            break;
                        case 2:
                            ret = new Data(this, null, btnPressed);
                            decisionMade = true;
                            SetStood(true);
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
            return ret;
        }

        public override int Type()
        {
            return 2;
        }
    }
}
