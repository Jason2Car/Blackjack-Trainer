namespace Blackjack_Trainer
{
    partial class BettingAmount
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.hScrllBrBetting = new System.Windows.Forms.HScrollBar();
            this.txtBxBetting = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(369, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Enter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // hScrllBrBetting
            // 
            this.hScrllBrBetting.Location = new System.Drawing.Point(201, 179);
            this.hScrllBrBetting.Name = "hScrllBrBetting";
            this.hScrllBrBetting.Size = new System.Drawing.Size(409, 33);
            this.hScrllBrBetting.TabIndex = 1;
            this.hScrllBrBetting.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrllBrBetting_Scroll);
            // 
            // txtBxBetting
            // 
            this.txtBxBetting.Location = new System.Drawing.Point(358, 154);
            this.txtBxBetting.Name = "txtBxBetting";
            this.txtBxBetting.Size = new System.Drawing.Size(100, 22);
            this.txtBxBetting.TabIndex = 2;
            this.txtBxBetting.TextChanged += new System.EventHandler(this.txtBxBetting_TextChanged);
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.Location = new System.Drawing.Point(358, 126);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(100, 22);
            this.txtBxLabel.TabIndex = 3;
            this.txtBxLabel.Text = "Betting: ";
            // 
            // BettingAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.txtBxBetting);
            this.Controls.Add(this.hScrllBrBetting);
            this.Controls.Add(this.btnSubmit);
            this.Name = "BettingAmount";
            this.Text = "BettingAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.HScrollBar hScrllBrBetting;
        private System.Windows.Forms.TextBox txtBxBetting;
        private System.Windows.Forms.TextBox txtBxLabel;
    }
}