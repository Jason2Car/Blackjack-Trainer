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
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Location = new System.Drawing.Point(682, 398);
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
            // GameReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.btnSeeAll);
            this.Name = "GameReview";
            this.Text = "Blackjack Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.TextBox txtExplain;
    }
}