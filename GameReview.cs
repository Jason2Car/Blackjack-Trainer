﻿using System;
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
    public partial class GameReview : Form
    {
        List<Data> data;
        int players;
        public GameReview(List<Data> d, int p)
        {
            InitializeComponent();
            data = d;
            players = p;
        }

        public void Review()
        {
            
        }
        public void DisplayData(int turn) {
            foreach (Data d in data)
            {
                listBoxData.Items.Add(d.ToString());
            }
        }
    }
}
