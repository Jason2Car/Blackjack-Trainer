namespace Blackjack_Trainer
{
    partial class GameReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameReview));
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.imgTable = new System.Windows.Forms.PictureBox();
            this.txtBxScorePlayer = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtBoxTurn = new System.Windows.Forms.TextBox();
            this.txtBxAdvice = new System.Windows.Forms.TextBox();
            this.panelDealerCards = new System.Windows.Forms.Panel();
            this.panelClientCards = new System.Windows.Forms.Panel();
            this.btnNewSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(423, 318);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(4);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(132, 22);
            this.txtExplain.TabIndex = 1;
            // 
            // imgTable
            // 
            this.imgTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTable.Image = ((System.Drawing.Image)(resources.GetObject("imgTable.Image")));
            this.imgTable.Location = new System.Drawing.Point(68, -5);
            this.imgTable.Margin = new System.Windows.Forms.Padding(4);
            this.imgTable.Name = "imgTable";
            this.imgTable.Size = new System.Drawing.Size(948, 386);
            this.imgTable.TabIndex = 5;
            this.imgTable.TabStop = false;
            // 
            // txtBxScorePlayer
            // 
            this.txtBxScorePlayer.Enabled = false;
            this.txtBxScorePlayer.Location = new System.Drawing.Point(889, 479);
            this.txtBxScorePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxScorePlayer.Name = "txtBxScorePlayer";
            this.txtBxScorePlayer.Size = new System.Drawing.Size(125, 22);
            this.txtBxScorePlayer.TabIndex = 6;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 47);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 28);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(124, 47);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtBoxTurn
            // 
            this.txtBoxTurn.Location = new System.Drawing.Point(16, 15);
            this.txtBoxTurn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTurn.Name = "txtBoxTurn";
            this.txtBoxTurn.Size = new System.Drawing.Size(132, 22);
            this.txtBoxTurn.TabIndex = 9;
            this.txtBoxTurn.Text = "Turn: ";
            // 
            // txtBxAdvice
            // 
            this.txtBxAdvice.ForeColor = System.Drawing.Color.Black;
            this.txtBxAdvice.Location = new System.Drawing.Point(173, 337);
            this.txtBxAdvice.Multiline = true;
            this.txtBxAdvice.Name = "txtBxAdvice";
            this.txtBxAdvice.ReadOnly = true;
            this.txtBxAdvice.Size = new System.Drawing.Size(605, 135);
            this.txtBxAdvice.TabIndex = 10;
            this.txtBxAdvice.Text = "hello";
            this.txtBxAdvice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDealerCards
            // 
            this.panelDealerCards.BackColor = System.Drawing.Color.Transparent;
            this.panelDealerCards.Location = new System.Drawing.Point(442, 38);
            this.panelDealerCards.Name = "panelDealerCards";
            this.panelDealerCards.Size = new System.Drawing.Size(200, 155);
            this.panelDealerCards.TabIndex = 19;
            // 
            // panelClientCards
            // 
            this.panelClientCards.BackColor = System.Drawing.Color.Transparent;
            this.panelClientCards.Location = new System.Drawing.Point(805, 317);
            this.panelClientCards.Name = "panelClientCards";
            this.panelClientCards.Size = new System.Drawing.Size(200, 155);
            this.panelClientCards.TabIndex = 14;
            // 
            // btnNewSettings
            // 
            this.btnNewSettings.Location = new System.Drawing.Point(16, 519);
            this.btnNewSettings.Name = "btnNewSettings";
            this.btnNewSettings.Size = new System.Drawing.Size(132, 23);
            this.btnNewSettings.TabIndex = 20;
            this.btnNewSettings.Text = "New Settings";
            this.btnNewSettings.UseVisualStyleBackColor = true;
            this.btnNewSettings.Click += new System.EventHandler(this.btnNewSettings_Click);
            // 
            // GameReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNewSettings);
            this.Controls.Add(this.panelClientCards);
            this.Controls.Add(this.panelDealerCards);
            this.Controls.Add(this.txtBxAdvice);
            this.Controls.Add(this.txtBoxTurn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtBxScorePlayer);
            this.Controls.Add(this.imgTable);
            this.Controls.Add(this.txtExplain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameReview";
            this.Text = "Blackjack Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.PictureBox imgTable;
        private System.Windows.Forms.TextBox txtBxScorePlayer;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtBoxTurn;
        private System.Windows.Forms.TextBox txtBxAdvice;
        private System.Windows.Forms.Panel panelDealerCards;
        private System.Windows.Forms.Panel panelClientCards;
        private System.Windows.Forms.Button btnNewSettings;
    }
}