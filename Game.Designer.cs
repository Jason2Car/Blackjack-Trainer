﻿namespace Blackjack_Trainer
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
            this.cardImgList.Images.SetKeyName(40, "jack_of_clubs.png");
            this.cardImgList.Images.SetKeyName(41, "jack_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(42, "jack_of_hearts.png");
            this.cardImgList.Images.SetKeyName(43, "jack_of_spades.png");
            this.cardImgList.Images.SetKeyName(44, "queen_of_clubs.png");
            this.cardImgList.Images.SetKeyName(45, "queen_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(46, "queen_of_hearts.png");
            this.cardImgList.Images.SetKeyName(47, "queen_of_spades.png");
            this.cardImgList.Images.SetKeyName(48, "king_of_clubs.png");
            this.cardImgList.Images.SetKeyName(49, "king_of_diamonds.png");
            this.cardImgList.Images.SetKeyName(50, "king_of_hearts.png");
            this.cardImgList.Images.SetKeyName(51, "king_of_spades.png");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Game";
            this.Text = "Blackjack Trainer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList cardImgList;
    }
}