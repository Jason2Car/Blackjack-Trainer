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
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.imgTable = new System.Windows.Forms.PictureBox();
            this.txtBxScorePlayer = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtBoxTurn = new System.Windows.Forms.TextBox();
            this.txtBxScoreBot = new System.Windows.Forms.TextBox();
            this.txtBxHasStood = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Location = new System.Drawing.Point(667, 415);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(95, 23);
            this.btnSeeAll.TabIndex = 0;
            this.btnSeeAll.Text = "See All Hands";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(317, 258);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(100, 20);
            this.txtExplain.TabIndex = 1;
            // 
            // imgTable
            // 
            this.imgTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTable.Image = ((System.Drawing.Image)(resources.GetObject("imgTable.Image")));
            this.imgTable.Location = new System.Drawing.Point(51, -4);
            this.imgTable.Name = "imgTable";
            this.imgTable.Size = new System.Drawing.Size(711, 314);
            this.imgTable.TabIndex = 5;
            this.imgTable.TabStop = false;
            // 
            // txtBxScorePlayer
            // 
            this.txtBxScorePlayer.Enabled = false;
            this.txtBxScorePlayer.Location = new System.Drawing.Point(667, 389);
            this.txtBxScorePlayer.Name = "txtBxScorePlayer";
            this.txtBxScorePlayer.Size = new System.Drawing.Size(95, 20);
            this.txtBxScorePlayer.TabIndex = 6;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 38);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(93, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtBoxTurn
            // 
            this.txtBoxTurn.Location = new System.Drawing.Point(12, 12);
            this.txtBoxTurn.Name = "txtBoxTurn";
            this.txtBoxTurn.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTurn.TabIndex = 9;
            this.txtBoxTurn.Text = "Turn: ";
            // 
            // txtBxScoreBot
            // 
            this.txtBxScoreBot.Enabled = false;
            this.txtBxScoreBot.Location = new System.Drawing.Point(39, 389);
            this.txtBxScoreBot.Name = "txtBxScoreBot";
            this.txtBxScoreBot.Size = new System.Drawing.Size(100, 20);
            this.txtBxScoreBot.TabIndex = 10;
            // 
            // txtBxHasStood
            // 
            this.txtBxHasStood.Location = new System.Drawing.Point(39, 415);
            this.txtBxHasStood.Name = "txtBxHasStood";
            this.txtBxHasStood.Size = new System.Drawing.Size(100, 20);
            this.txtBxHasStood.TabIndex = 11;
            this.txtBxHasStood.Text = "Has Stood: ";
            // 
            // GameReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxHasStood);
            this.Controls.Add(this.txtBxScoreBot);
            this.Controls.Add(this.txtBoxTurn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtBxScorePlayer);
            this.Controls.Add(this.imgTable);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.btnSeeAll);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameReview";
            this.Text = "Blackjack Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.PictureBox imgTable;
        private System.Windows.Forms.TextBox txtBxScorePlayer;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtBoxTurn;
        private System.Windows.Forms.TextBox txtBxScoreBot;
        private System.Windows.Forms.TextBox txtBxHasStood;
    }
}