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
            this.numUDNumPlayer = new System.Windows.Forms.NumericUpDown();
            this.CBGameReview = new System.Windows.Forms.ComboBox();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.vScrollBarPlayers = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDNumPlayer
            // 
            this.numUDNumPlayer.Location = new System.Drawing.Point(163, 152);
            this.numUDNumPlayer.Name = "numUDNumPlayer";
            this.numUDNumPlayer.Size = new System.Drawing.Size(45, 20);
            this.numUDNumPlayer.TabIndex = 0;
            this.numUDNumPlayer.ValueChanged += new System.EventHandler(this.numUDNumPlayer_ValueChanged);
            // 
            // CBGameReview
            // 
            this.CBGameReview.FormattingEnabled = true;
            this.CBGameReview.Items.AddRange(new object[] {
            "After Game",
            "During Game"});
            this.CBGameReview.Location = new System.Drawing.Point(120, 241);
            this.CBGameReview.Name = "CBGameReview";
            this.CBGameReview.Size = new System.Drawing.Size(121, 21);
            this.CBGameReview.TabIndex = 1;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(610, 385);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(75, 23);
            this.btnGameStart.TabIndex = 3;
            this.btnGameStart.Text = "Start";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // panelPlayers
            // 
            this.panelPlayers.Location = new System.Drawing.Point(283, 113);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(402, 100);
            this.panelPlayers.TabIndex = 4;
            // 
            // vScrollBarPlayers
            // 
            this.vScrollBarPlayers.Location = new System.Drawing.Point(688, 113);
            this.vScrollBarPlayers.Name = "vScrollBarPlayers";
            this.vScrollBarPlayers.Size = new System.Drawing.Size(15, 100);
            this.vScrollBarPlayers.TabIndex = 5;
            this.vScrollBarPlayers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarPlayers_Scroll);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBarPlayers);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.CBGameReview);
            this.Controls.Add(this.numUDNumPlayer);
            this.Name = "Start";
            this.Text = "Blackjack Trainer";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDNumPlayer;
        private System.Windows.Forms.ComboBox CBGameReview;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.VScrollBar vScrollBarPlayers;
    }
}

