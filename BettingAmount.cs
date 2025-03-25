using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    public partial class BettingAmount : Form
    {
        private int totalAmount;
        public int BetAmount { get; private set; }

        public BettingAmount(int total)
        {
            InitializeComponent();
            totalAmount = total;
            hScrllBrBetting.Maximum = totalAmount;
            hScrllBrBetting.Minimum = 1;
            hScrllBrBetting.Value = 1;
            txtBxBetting.Text = "Betting: 5";
        }

        private void txtBxBetting_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBxBetting.Text, out int betAmount))
            {
                if (betAmount >= 1 && betAmount <= totalAmount)
                {
                    hScrllBrBetting.Value = betAmount;
                }
                else
                {
                    MessageBox.Show("Please enter a valid betting amount between 1 and " + totalAmount);
                }
            }
        }

        private void hScrllBrBetting_Scroll(object sender, ScrollEventArgs e)
        {
            txtBxBetting.Text = "Betting: " + hScrllBrBetting.Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BetAmount = hScrllBrBetting.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

