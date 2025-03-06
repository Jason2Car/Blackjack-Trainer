namespace Blackjack_Trainer
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.cardImgList = new System.Windows.Forms.ImageList(this.components);
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.imgTable = new System.Windows.Forms.PictureBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtBxScorePlayer = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnNewSettings = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.txtBxScoreBot = new System.Windows.Forms.TextBox();
            this.txtBxHasStood = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cardImgList
            // 
            this.cardImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImgList.ImageStream")));
            this.cardImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImgList.Images.SetKeyName(0, "ace_of_clubs.png");
            this.cardImgList.Images.SetKeyName(1, "ace_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(2, "ace_of_hearts.png");
            this.cardImgList.Images.SetKeyName(3, "ace_of_spades.png");
            this.cardImgList.Images.SetKeyName(4, "2_of_clubs.png");
            this.cardImgList.Images.SetKeyName(5, "2_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(6, "2_of_hearts.png");
            this.cardImgList.Images.SetKeyName(7, "2_of_spades.png");
            this.cardImgList.Images.SetKeyName(8, "3_of_clubs.png");
            this.cardImgList.Images.SetKeyName(9, "3_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(10, "3_of_hearts.png");
            this.cardImgList.Images.SetKeyName(11, "3_of_spades.png");
            this.cardImgList.Images.SetKeyName(12, "4_of_clubs.png");
            this.cardImgList.Images.SetKeyName(13, "4_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(14, "4_of_hearts.png");
            this.cardImgList.Images.SetKeyName(15, "4_of_spades.png");
            this.cardImgList.Images.SetKeyName(16, "5_of_clubs.png");
            this.cardImgList.Images.SetKeyName(17, "5_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(18, "5_of_hearts.png");
            this.cardImgList.Images.SetKeyName(19, "5_of_spades.png");
            this.cardImgList.Images.SetKeyName(20, "6_of_clubs.png");
            this.cardImgList.Images.SetKeyName(21, "6_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(22, "6_of_hearts.png");
            this.cardImgList.Images.SetKeyName(23, "6_of_spades.png");
            this.cardImgList.Images.SetKeyName(24, "7_of_clubs.png");
            this.cardImgList.Images.SetKeyName(25, "7_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(26, "7_of_hearts.png");
            this.cardImgList.Images.SetKeyName(27, "7_of_spades.png");
            this.cardImgList.Images.SetKeyName(28, "8_of_clubs.png");
            this.cardImgList.Images.SetKeyName(29, "8_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(30, "8_of_hearts.png");
            this.cardImgList.Images.SetKeyName(31, "8_of_spades.png");
            this.cardImgList.Images.SetKeyName(32, "9_of_clubs.png");
            this.cardImgList.Images.SetKeyName(33, "9_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(34, "9_of_hearts.png");
            this.cardImgList.Images.SetKeyName(35, "9_of_spades.png");
            this.cardImgList.Images.SetKeyName(36, "10_of_clubs.png");
            this.cardImgList.Images.SetKeyName(37, "10_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(38, "10_of_hearts.png");
            this.cardImgList.Images.SetKeyName(39, "10_of_spades.png");
            this.cardImgList.Images.SetKeyName(40, "jack_of_clubs2.png");
            this.cardImgList.Images.SetKeyName(41, "jack_of_diamonds2.png");
            this.cardImgList.Images.SetKeyName(42, "jack_of_hearts2.png");
            this.cardImgList.Images.SetKeyName(43, "jack_of_spades2.png");
            this.cardImgList.Images.SetKeyName(44, "queen_of_clubs2.png");
            this.cardImgList.Images.SetKeyName(45, "queen_of_diamonds2.png");
            this.cardImgList.Images.SetKeyName(46, "queen_of_hearts2.png");
            this.cardImgList.Images.SetKeyName(47, "queen_of_spades2.png");
            this.cardImgList.Images.SetKeyName(48, "king_of_clubs2.png");
            this.cardImgList.Images.SetKeyName(49, "king_of_diamonds2.png");
            this.cardImgList.Images.SetKeyName(50, "king_of_hearts2.png");
            this.cardImgList.Images.SetKeyName(51, "king_of_spades2.png");
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Location = new System.Drawing.Point(667, 415);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(110, 23);
            this.btnSeeAll.TabIndex = 0;
            this.btnSeeAll.Text = "See All Hands";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(249, 342);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(373, 342);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // imgTable
            // 
            this.imgTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTable.Image = ((System.Drawing.Image)(resources.GetObject("imgTable.Image")));
            this.imgTable.Location = new System.Drawing.Point(51, -4);
            this.imgTable.Name = "imgTable";
            this.imgTable.Size = new System.Drawing.Size(711, 314);
            this.imgTable.TabIndex = 4;
            this.imgTable.TabStop = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(495, 342);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtBxScorePlayer
            // 
            this.txtBxScorePlayer.Enabled = false;
            this.txtBxScorePlayer.Location = new System.Drawing.Point(667, 389);
            this.txtBxScorePlayer.Name = "txtBxScorePlayer";
            this.txtBxScorePlayer.Size = new System.Drawing.Size(100, 20);
            this.txtBxScorePlayer.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(294, 386);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnNewSettings
            // 
            this.btnNewSettings.Location = new System.Drawing.Point(454, 386);
            this.btnNewSettings.Name = "btnNewSettings";
            this.btnNewSettings.Size = new System.Drawing.Size(78, 23);
            this.btnNewSettings.TabIndex = 7;
            this.btnNewSettings.Text = "New Settings";
            this.btnNewSettings.UseVisualStyleBackColor = true;
            this.btnNewSettings.Visible = false;
            this.btnNewSettings.Click += new System.EventHandler(this.btnNewSettings_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(373, 325);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(75, 23);
            this.btnReview.TabIndex = 8;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Visible = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // txtBxScoreBot
            // 
            this.txtBxScoreBot.Enabled = false;
            this.txtBxScoreBot.Location = new System.Drawing.Point(39, 377);
            this.txtBxScoreBot.Name = "txtBxScoreBot";
            this.txtBxScoreBot.Size = new System.Drawing.Size(100, 20);
            this.txtBxScoreBot.TabIndex = 9;
            // 
            // txtBxHasStood
            // 
            this.txtBxHasStood.Location = new System.Drawing.Point(39, 403);
            this.txtBxHasStood.Name = "txtBxHasStood";
            this.txtBxHasStood.Size = new System.Drawing.Size(100, 20);
            this.txtBxHasStood.TabIndex = 10;
            this.txtBxHasStood.Text = "Has Stood: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxHasStood);
            this.Controls.Add(this.txtBxScoreBot);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnNewSettings);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtBxScorePlayer);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.imgTable);
            this.Name = "Game";
            this.Text = "Blackjack Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList cardImgList;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.PictureBox imgTable;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtBxScorePlayer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnNewSettings;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.TextBox txtBxScoreBot;
        private System.Windows.Forms.TextBox txtBxHasStood;
    }
}