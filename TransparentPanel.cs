using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Trainer
{
    
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.Opaque, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do not paint background
        }
    }

}
