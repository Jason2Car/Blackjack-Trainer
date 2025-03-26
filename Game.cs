using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Blackjack_Trainer
{
  
    public partial class Game : Form
    {
        private List<Card> cards = new List<Card>();
        public Stack<Card> deck = new Stack<Card>();
        private List<Card> inHands = new List<Card>();
        private List<Player> players = new List<Player>();
        private List<Player> copyOfPlayers = new List<Player>();
        //private List<int> winings = new List<int>();
        private List<Data> data = new List<Data>();
        private int clientBet;
        private Stack<Stack<Card>> cardsUsed = new Stack<Stack<Card>>();

        //private bool btnSelected = false;
        public Game(List<Player> p)
        {
            InitializeComponent();
            InitializeChart();
            chartWinnings.Hide();
            players = p;
            panelDealerCards.Controls.Clear();
            txtBxRanking.BringToFront();
            //MessageBox.Show("" + players.Last().stillIn()+" " + players.Last().hasStood());
            //Initialize cards, add one of each suit, total 52
            cards = NewCards();
            panelClientCards.AutoScroll = true;
            panelPlayersCards.AutoScroll = true;
            panelDealerCards.AutoScroll = true;


            // Show the BettingAmount form to get the client's bet
            using (BettingAmount bettingForm = new BettingAmount(players.Last().GetWinnings()))
            {
                if (bettingForm.ShowDialog() == DialogResult.OK)
                {
                    clientBet = bettingForm.BetAmount;
                }
                else
                {
                    // Handle the case where the user cancels the betting form
                    MessageBox.Show("Betting was canceled. Exiting the game.");
                    this.Close();
                    return;
                }
            }

            //need to initialize players
            this.Load += async (sender, e) => await InitializeGameAsync();
        }
        private string GetPlayerRankings()
        {
            // Remove the dealer (first player) from the list
            List<Player> playersWithoutDealer = players.Skip(1).ToList();

            // Sort players based on their winnings in descending order
            List<Player> sortedPlayers = playersWithoutDealer.OrderByDescending(p => p.GetWinnings()).ToList();

            // Build the ranking string
            StringBuilder ranking = new StringBuilder();
            ranking.AppendLine("Rankings:");

            for (int i = 0; i < sortedPlayers.Count; i++)
            {
                Player player = sortedPlayers[i];
                string playerLabel = (players.IndexOf(player) == players.Count - 1) ? "You" : $"Player {players.IndexOf(player) + 1}";
                ranking.AppendLine($"{i + 1}. {playerLabel} - Winnings: {player.GetWinnings()}");
            }

            return ranking.ToString();
        }


        private async Task InitializeGameAsync()
        {
            data = new List<Data>();//reset after every game since I'm not sure how to implement
            await StartGameAsync();
        }
        private int GameSimulation(Player replacement)
        {
            //create the teams to be used
            List<Player> simulatedPlayers = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                if (i == players.Count - 1) //client
                {
                    simulatedPlayers.Add(replacement);
                }
                else
                {
                    simulatedPlayers.Add(players[i]);
                }
            }
            Stack<Stack<Card>> simulatedDecks = DeepCopyStack(cardsUsed);
            Stack<Card> simulatedDeck = simulatedDecks.Pop();
            while(StillPlay(simulatedPlayers))
            {
                for (int i = 0; i < simulatedPlayers.Count; i++)
                {
                    if(simulatedDeck.Count == 0)//if current deck is empty
                    {
                        if(simulatedDecks.Count != 0)//if there're cards to draw from
                        {
                            simulatedDeck = simulatedDecks.Pop();
                        }
                        else//no cards from past so now need to make up some
                        {
                            simulatedDeck = NewDeck();
                        }
                    }
                    Player cur = simulatedPlayers[i];
                    if (cur.StillIn() && !cur.HasStood())
                    {
                        cur.TurnAsync(simulatedDeck);//should go through all turns without wait
                    }
                }
            }
            FindWinner(simulatedPlayers);//should update all the players with their winnings
            return simulatedPlayers.Last().GetWinnings(); //return the winnings of the simulated client
        }
        private async Task StartGameAsync()
        {
            if (players.Count == 2) 
            {
                txtBxScoreBot.Hide();
                txtBxHasStood.Hide();
                panelPlayersCards.Hide();
            }
            await PlayGameAsync();
            //MessageBox.Show("Player stillin: " + players.Last().stillIn() + " Player has Stood" + players.Last().hasStood());
            //MessageBox.Show("Player hand: " + players.Last().getHand());
            txtBxRanking.Visible = true;

            int winner = FindWinner(players);
            UpdateChartWithWinnings();
            chartWinnings.Show();
            txtBxRanking.Text = GetPlayerRankings();
            if (winner == players.Count - 1)
            {
                MessageBox.Show("Game Over. You won");

            }
            else if (winner == 0)
            {
                MessageBox.Show("Game Over. Dealer won");
            }
            else
            {
                MessageBox.Show("Game Over. Bot " + winner + " won");

            }
            
        }
        public async Task PlayGameAsync()
        {
            deck = NewDeck();
            cardsUsed.Push(CopyDeck());
            //MessageBox.Show(""+cardsUsed.Count);
            //await PauseAsync(1000);
            foreach (Player cur in players) // distributing cards
            {
                if (deck.Count<=0) 
                {
                    deck = NewDeck();
                    cardsUsed.Push(CopyDeck());
                }
                Card added = cur.AddCard(0, deck.Pop());
                inHands.Add(added);
                
                added = cur.AddCard(0, deck.Pop());
                inHands.Add(added);


                Player copy = null;
                switch (cur.Type())
                {
                    case 0:
                        copy = new Dealer();
                        break;
                    case 1:
                        copy = new ComputerControlledPlayer(cur.GetDifficulty(),cur.GetStyle());
                        break;
                    case 2:
                        copy = new Client();
                        break;
                }

                foreach (List<Card> hand in cur.GetDeck())
                {
                    foreach (Card card in hand)
                    {
                        copy.AddCard(0, card);
                    }
                }
                copyOfPlayers.Add(copy);
            }


            DisplayPlayerHand(players.First());//dealer's first
            DisplayPlayerHand(players.Last());//client's last
            while (StillPlay(players))
            {
                txtBxScorePlayer.Text = "Score: " + players.Last().GetHand();
                //MessageBox.Show("another round");
                for (int i = 0; i<players.Count; i++)
                {
                    Player cur = players[i];
                    if (!cur.IsDealer() && cur.IsComputer())
                    {
                        txtBxCurrentPlayer.Text = "Bot " + players.IndexOf(cur) + "is deciding";
                        txtBxCurrentPlayer.Show();
                    }
                    DisplayPlayerHand(cur);
                    if (!cur.IsComputer())//if client
                    {
                        btnHit.Show();
                        btnStand.Show();
                        btnSplit.Show();
                    }
                    else 
                    {
                        await PauseAsync(2000);
                    }

                    //now i could simulate a whole game with the client replaced by a computer controlled player but that's not possible in this timeframe
                    
                    List<List<Card>> temp = cur.CopyDeck();
                    Data result = await cur.TurnAsync(deck);
                    data.Add(result);
                    btnHit.Hide();
                    btnStand.Hide();
                    btnSplit.Hide();
                    if (!cur.IsComputer() || cur.IsDealer()) //if player or dealer
                    {
                        //txtBxScore.Text = "Score: " + cur.getHand();
                        HidePlayerHand(cur);//remove old hand
                        DisplayPlayerHand(cur);//display new hand
                        //MessageBox.Show(cur.getBot()+" Hand: "+cur.getHand());
                        await PauseAsync(1000);

                    }
                    else
                    {
                        DisplayPlayerHand(cur); //display new hand
                        await PauseAsync(2000);
                        HidePlayerHand(cur); //remove old hand
                        panelPlayersCards.Controls.Clear();
                    }


                    txtBxCurrentPlayer.Text = "";
                    txtBxCurrentPlayer.Hide();
                }
            }
            txtBxScorePlayer.Text = "Score: " + players.Last().GetHand();
            
            btnNewGame.Show();
            btnNewSettings.Show();
            btnReview.Show();
        }

        public bool StillPlay(List<Player> play)
        {
            foreach (Player i in play) 
            { 
                if (i.StillIn() && !i.HasStood()) 
                { 
                    return true; 
                }
            }
            return false;
        }

        public Stack<Card> NewDeck() 
        {
            Stack<Card> temp = new Stack<Card>();
            List<Card> tempCards = new List<Card>(NewCards());
            Random rand = new Random();
            while (tempCards.Count>0)
            {
                int pos = (int)(tempCards.Count * rand.NextDouble());
                temp.Push(tempCards[pos]);
                tempCards.RemoveAt(pos);
            }
            //MessageBox.Show("New deck added");
            return temp;
        }

        public Stack<Card> CopyDeck()
        {
            Stack<Card> copy = new Stack<Card>();
            foreach (Card card in deck) 
            {
                copy.Push(card); //copy the deck
            }
            return copy;//this copy should be unassociated or independent with deck
        }

        public int HandSum() 
        {
            int sum = 0;
            foreach(Card i in inHands)
            {
                sum = sum + i.GetVal();            
            }
            return sum;
        }

        public int FindWinner(List<Player> played)
        {
            int max = 0;
            int winner = 0;

            for (int i = 0; i < players.Count; i++)
            {
                Player cur = played[i];
                if (cur.StillIn() && cur.GetHand() > max) //if player ties with dealer, still dealer wins, winner doesn't update
                {
                    max = cur.GetHand();
                    winner = i;
                }

                cur.UpdateWinnings(cur.GetWinnings()+GiveWinnings(cur) * (Won(cur) ? 1 : -1));
            }


            //UpdateChartWithWinnings();
            //MessageBox.Show(""+players.Last().GetWinnings());

            return winner;
        }
        public bool Won(Player p) 
        {
            Player dealer = players[0];
            if (dealer.StillIn())
            {
                if (p.StillIn())
                {
                    return p.GetHand()>dealer.GetHand();//returns true if player has higher hand
                }
                else
                {
                    return false;//player busted
                }
            }
            else 
            {
                if (p.StillIn())
                {
                    return true;//dealer busted and player hasn't
                }
                else 
                {
                    return false;//player busted
                }
            }
            
        }

        public int GiveWinnings(Player p) 
        {
            int w = 0;
            if(p.IsDealer())//dealer
            {
                w = 0;//dealers don't need to earn
            }
            else if(p.IsComputer())
            {
                Random rand = new Random();
                switch (p.GetStyle())
                { 
                    case 0://conservative
                        w = (100 + (int)(200 * rand.NextDouble())) ;
                        break;
                    case 1://risky
                        w = (300 + (int)(400 * rand.NextDouble()));
                        break;
                    case 2://allseeing
                        w = p.GetWinnings() * (Won(p) ? 1 : 0);//can't lose, if win all in
                        break;
                }
            }
            else
            {
                w = clientBet;
                //MessageBox.Show("you winning"+w);
                
            }
            return w;
        }

        private void UpdateChartWithWinnings()
        {
            Series series = chartWinnings.Series["You"];
            //series.Points.Clear();
            series.Points.AddXY(series.Points.Count, players.Last().GetWinnings());
            //MessageBox.Show("You" + players.Last().GetWinnings());

            series = chartWinnings.Series["Conservative"];
            int outcome = GameSimulation(new ComputerControlledPlayer(1, 0));
            series.Points.AddXY(series.Points.Count, outcome);
            //MessageBox.Show("risky"+outcome);
            
            series = chartWinnings.Series["Risky"];
            outcome = GameSimulation(new ComputerControlledPlayer(1, 1));
            series.Points.AddXY(series.Points.Count, outcome);
            //MessageBox.Show("cons" + outcome);


        }
        private void DisplayPlayerHand(Player player)
        {
            //if time, use directory to preload image boxes and can use card
            //values to get which image to show, then no need to hold images in cards
            
            // Display current hand
            int cardSpacing = 75; // Space between cards
            Panel cur = null;
            if (player.IsDealer())
            {
                cur = panelDealerCards;
            }
            else if (!player.IsComputer())
            {
                cur = panelClientCards;
            }
            else
            {
                cur = panelPlayersCards;
            }
            //if the bot, then use this to show cards

            foreach (List<Card> hand in player.GetDeck())
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    PictureBox pic = hand[i].GetPictureBox();
                    pic.Location = new Point(10 + (i * cardSpacing), 30);
                    cur.Controls.Add(pic);
                }
            }
            if (player.IsComputer() && !player.IsDealer())
            {
                txtBxScoreBot.Text = "Score: " + player.GetHand();
                txtBxHasStood.Text = "Has Stood: " + player.HasStood();
                //await PauseAsync(1000);
            }

        }

        private void HidePlayerHand(Player player)
        {
            foreach (List<Card> hand in player.GetDeck())
                foreach (Card card in hand)
                {

                    this.Controls.Remove(card.GetPictureBox());
                    //card.getPictureBox().Dispose();
                }
            txtBxScoreBot.Text = "Score: " ;
            txtBxHasStood.Text = "Has Stood: ";

        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(1);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(2);
        }


        private void btnSplit_Click(object sender, EventArgs e)
        {
            players[players.Count - 1].Press(3);
        }
        public async Task PauseAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
            // Code to execute after the delay
        }

        private async void btnNewGame_Click(object sender, EventArgs e)
        {
            if(players.Last().GetWinnings() <= 0)
            {
                MessageBox.Show("You have no more money. Can't continue.");
            }
            else
            {

                btnNewGame.Hide();
                btnNewSettings.Hide();
                btnReview.Hide();
                foreach (Player i in players)
                {
                    i.ClearHand();
                }
                panelClientCards.Controls.Clear();
                panelDealerCards.Controls.Clear();
                panelPlayersCards.Controls.Clear();
                chartWinnings.Hide();
                txtBxRanking.Hide();
                txtBxScoreBot.Text = "Score: ";
                txtBxScorePlayer.Text = "Score: ";
                // Show the BettingAmount form to get the client's bet
                using (BettingAmount bettingForm = new BettingAmount(players.Last().GetWinnings()))
                {
                    if (bettingForm.ShowDialog() == DialogResult.OK)
                    {
                        clientBet = bettingForm.BetAmount;
                    }
                    else
                    {
                        // Handle the case where the user cancels the betting form
                        MessageBox.Show("Betting was canceled. Exiting the game.");
                        this.Close();
                        return;
                    }
                }
                txtBxCurrentPlayer.Text = "";
                await InitializeGameAsync();

            }
        }

        private void btnNewSettings_Click(object sender, EventArgs e)
        {
            btnNewSettings.Hide();
            Start start = new Start();
            this.Hide(); // Hide the Start form
            start.Show(); // Show the Game form
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

            btnReview.Hide();
            GameReview review= new GameReview(this, data, copyOfPlayers);
            this.Hide(); // Hide the Start form
            review.Show(); // Show the Game form
            SortWinners();
        }
        private List<Player> SortWinners()
        {

            List<Player> ret = new List<Player>(players);
            int n = players.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (ret[j].GetWinnings() > ret[maxIndex].GetWinnings())
                    {
                        maxIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                Player temp = ret[maxIndex];
                ret[maxIndex] = ret[i];
                ret[i] = temp;
            }
            return ret;
        }
        private void InitializeChart()
        {
            chartWinnings.Series.Clear();
            chartWinnings.ChartAreas.Clear();

            // Create a new chart area
            ChartArea chartArea = new ChartArea();
            chartWinnings.ChartAreas.Add(chartArea);

            chartArea.AxisX.Minimum = 0;

            // Create a new series
            Series normal = new Series
            {
                Name = "You",
                Color = Color.Green,
                ChartType = SeriesChartType.Line
            };
            Series risky = new Series
            {
                Name = "Risky",
                Color = Color.Red,
                ChartType = SeriesChartType.Line
            };
            Series conservative = new Series
            {
                Name = "Conservative",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line
            };
            normal.Points.AddXY(0, 1000);
            risky.Points.AddXY(0,1000);
            conservative.Points.AddXY(0,1000);
            chartWinnings.Series.Add(normal);
            chartWinnings.Series.Add(risky);
            chartWinnings.Series.Add(conservative);
        }
        public List<Card> NewCards()
        {
            List<Card> ret = new List<Card>();
            for (int val = 1; val <= 13; val++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    ret.Add(new Card(Math.Min(val, 10), suit, cardImgList.Images[(val - 1) * 4 + suit]));
                }
            }
            return ret;
        }
        private Stack<Stack<Card>> DeepCopyStack(Stack<Stack<Card>> original)
        {
            Stack<Stack<Card>> copy = new Stack<Stack<Card>>(original.Count);
            foreach (var stack in original)
            {
                Stack<Card> newStack = new Stack<Card>(stack.ToArray()); // Create a new stack with the same elements
                copy.Push(newStack);
            }
            return copy; // Return the copy directly
        }

    }
}
