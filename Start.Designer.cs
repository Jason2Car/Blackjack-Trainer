namespace Blackjack_Trainer
{
    partial class Start
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
            this.playerNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.gameReviewCB = new System.Windows.Forms.ComboBox();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.playersVSBar = new System.Windows.Forms.VScrollBar();
            this.gameStartbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumUpDown)).BeginInit();
            this.playersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNumUpDown
            // 
            this.playerNumUpDown.Location = new System.Drawing.Point(163, 152);
            this.playerNumUpDown.Name = "playerNumUpDown";
            this.playerNumUpDown.Size = new System.Drawing.Size(45, 20);
            this.playerNumUpDown.TabIndex = 0;
            // 
            // gameReviewCB
            // 
            this.gameReviewCB.FormattingEnabled = true;
            this.gameReviewCB.Location = new System.Drawing.Point(120, 241);
            this.gameReviewCB.Name = "gameReviewCB";
            this.gameReviewCB.Size = new System.Drawing.Size(121, 21);
            this.gameReviewCB.TabIndex = 1;
            // 
            // playersPanel
            // 
            this.playersPanel.Controls.Add(this.playersVSBar);
            this.playersPanel.Location = new System.Drawing.Point(465, 126);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(200, 100);
            this.playersPanel.TabIndex = 2;
            // 
            // playersVSBar
            // 
            this.playersVSBar.Location = new System.Drawing.Point(183, 11);
            this.playersVSBar.Name = "playersVSBar";
            this.playersVSBar.Size = new System.Drawing.Size(17, 80);
            this.playersVSBar.TabIndex = 0;
            // 
            // gameStartbtn
            // 
            this.gameStartbtn.Location = new System.Drawing.Point(610, 385);
            this.gameStartbtn.Name = "gameStartbtn";
            this.gameStartbtn.Size = new System.Drawing.Size(75, 23);
            this.gameStartbtn.TabIndex = 3;
            this.gameStartbtn.Text = "Start";
            this.gameStartbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameStartbtn);
            this.Controls.Add(this.playersPanel);
            this.Controls.Add(this.gameReviewCB);
            this.Controls.Add(this.playerNumUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerNumUpDown)).EndInit();
            this.playersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown playerNumUpDown;
        private System.Windows.Forms.ComboBox gameReviewCB;
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.VScrollBar playersVSBar;
        private System.Windows.Forms.Button gameStartbtn;
    }
}

