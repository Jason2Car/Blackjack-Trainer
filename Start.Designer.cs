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
            this.UpDownNumplayer = new System.Windows.Forms.NumericUpDown();
            this.CBGameReview = new System.Windows.Forms.ComboBox();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.VSBarPlayers = new System.Windows.Forms.VScrollBar();
            this.btnGameStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumplayer)).BeginInit();
            this.panelPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpDownNumplayer
            // 
            this.UpDownNumplayer.Location = new System.Drawing.Point(163, 152);
            this.UpDownNumplayer.Name = "UpDownNumplayer";
            this.UpDownNumplayer.Size = new System.Drawing.Size(45, 20);
            this.UpDownNumplayer.TabIndex = 0;
            // 
            // CBGameReview
            // 
            this.CBGameReview.FormattingEnabled = true;
            this.CBGameReview.Location = new System.Drawing.Point(120, 241);
            this.CBGameReview.Name = "CBGameReview";
            this.CBGameReview.Size = new System.Drawing.Size(121, 21);
            this.CBGameReview.TabIndex = 1;
            // 
            // panelPlayers
            // 
            this.panelPlayers.Controls.Add(this.VSBarPlayers);
            this.panelPlayers.Location = new System.Drawing.Point(465, 126);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(200, 100);
            this.panelPlayers.TabIndex = 2;
            // 
            // VSBarPlayers
            // 
            this.VSBarPlayers.Location = new System.Drawing.Point(183, 11);
            this.VSBarPlayers.Name = "VSBarPlayers";
            this.VSBarPlayers.Size = new System.Drawing.Size(17, 80);
            this.VSBarPlayers.TabIndex = 0;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(610, 385);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(75, 23);
            this.btnGameStart.TabIndex = 3;
            this.btnGameStart.Text = "Start";
            this.btnGameStart.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.CBGameReview);
            this.Controls.Add(this.UpDownNumplayer);
            this.Name = "Start";
            this.Text = "Blackjack Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumplayer)).EndInit();
            this.panelPlayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpDownNumplayer;
        private System.Windows.Forms.ComboBox CBGameReview;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.VScrollBar VSBarPlayers;
        private System.Windows.Forms.Button btnGameStart;
    }
}

