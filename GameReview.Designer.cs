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
            ((System.ComponentModel.ISupportInitialize)(this.imgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Location = new System.Drawing.Point(889, 511);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(127, 28);
            this.btnSeeAll.TabIndex = 0;
            this.btnSeeAll.Text = "See All Hands";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(423, 318);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(132, 22);
            this.txtExplain.TabIndex = 1;
            // 
            // imgTable
            // 
            this.imgTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTable.Image = ((System.Drawing.Image)(resources.GetObject("imgTable.Image")));
            this.imgTable.Location = new System.Drawing.Point(68, -5);
            this.imgTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgTable.Name = "imgTable";
            this.imgTable.Size = new System.Drawing.Size(948, 386);
            this.imgTable.TabIndex = 5;
            this.imgTable.TabStop = false;
            // 
            // txtBxScorePlayer
            // 
            this.txtBxScorePlayer.Enabled = false;
            this.txtBxScorePlayer.Location = new System.Drawing.Point(889, 479);
            this.txtBxScorePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxScorePlayer.Name = "txtBxScorePlayer";
            this.txtBxScorePlayer.Size = new System.Drawing.Size(125, 22);
            this.txtBxScorePlayer.TabIndex = 6;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 47);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtBoxTurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTurn.Name = "txtBoxTurn";
            this.txtBoxTurn.Size = new System.Drawing.Size(132, 22);
            this.txtBoxTurn.TabIndex = 9;
            this.txtBoxTurn.Text = "Turn: ";
            // 
            // GameReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBoxTurn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtBxScorePlayer);
            this.Controls.Add(this.imgTable);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.btnSeeAll);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}