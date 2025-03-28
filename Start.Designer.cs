﻿namespace Blackjack_Trainer
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
            this.btnGameStart = new System.Windows.Forms.Button();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.vScrollBarPlayers = new System.Windows.Forms.VScrollBar();
            this.txtBxNumPlayerLabel = new System.Windows.Forms.TextBox();
            this.txtBxLabelPlayerSettings = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDNumPlayer
            // 
            this.numUDNumPlayer.Location = new System.Drawing.Point(76, 148);
            this.numUDNumPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDNumPlayer.Name = "numUDNumPlayer";
            this.numUDNumPlayer.Size = new System.Drawing.Size(60, 22);
            this.numUDNumPlayer.TabIndex = 0;
            this.numUDNumPlayer.ValueChanged += new System.EventHandler(this.numUDNumPlayer_ValueChanged);
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(813, 474);
            this.btnGameStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(100, 28);
            this.btnGameStart.TabIndex = 3;
            this.btnGameStart.Text = "Start";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // panelPlayers
            // 
            this.panelPlayers.Location = new System.Drawing.Point(333, 139);
            this.panelPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(536, 300);
            this.panelPlayers.TabIndex = 4;
            // 
            // vScrollBarPlayers
            // 
            this.vScrollBarPlayers.Location = new System.Drawing.Point(917, 139);
            this.vScrollBarPlayers.Name = "vScrollBarPlayers";
            this.vScrollBarPlayers.Size = new System.Drawing.Size(15, 123);
            this.vScrollBarPlayers.TabIndex = 5;
            this.vScrollBarPlayers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarPlayers_Scroll);
            // 
            // txtBxNumPlayerLabel
            // 
            this.txtBxNumPlayerLabel.Enabled = false;
            this.txtBxNumPlayerLabel.Location = new System.Drawing.Point(76, 101);
            this.txtBxNumPlayerLabel.Name = "txtBxNumPlayerLabel";
            this.txtBxNumPlayerLabel.Size = new System.Drawing.Size(122, 22);
            this.txtBxNumPlayerLabel.TabIndex = 6;
            this.txtBxNumPlayerLabel.Text = "Number of Players:";
            // 
            // txtBxLabelPlayerSettings
            // 
            this.txtBxLabelPlayerSettings.Enabled = false;
            this.txtBxLabelPlayerSettings.Location = new System.Drawing.Point(333, 101);
            this.txtBxLabelPlayerSettings.Name = "txtBxLabelPlayerSettings";
            this.txtBxLabelPlayerSettings.Size = new System.Drawing.Size(100, 22);
            this.txtBxLabelPlayerSettings.TabIndex = 7;
            this.txtBxLabelPlayerSettings.Text = "Player Settings:";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBxLabelPlayerSettings);
            this.Controls.Add(this.txtBxNumPlayerLabel);
            this.Controls.Add(this.vScrollBarPlayers);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.numUDNumPlayer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.Text = "Blackjack Trainer";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDNumPlayer;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.VScrollBar vScrollBarPlayers;
        private System.Windows.Forms.TextBox txtBxNumPlayerLabel;
        private System.Windows.Forms.TextBox txtBxLabelPlayerSettings;
    }
}

