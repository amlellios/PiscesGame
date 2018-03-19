﻿namespace Pisces_Game
{
    partial class Round2
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.showZodiacLbl = new System.Windows.Forms.Label();
            this.eatPromptLbl = new System.Windows.Forms.Label();
            this.eatFishBox = new System.Windows.Forms.NumericUpDown();
            this.eatFishBtn = new System.Windows.Forms.Button();
            this.eatFishLbl = new System.Windows.Forms.Label();
            this.round1EndBtn = new System.Windows.Forms.Button();
            this.investPromptLbl = new System.Windows.Forms.Label();
            this.catchPromptLbl = new System.Windows.Forms.Label();
            this.catchFishBox = new System.Windows.Forms.NumericUpDown();
            this.catchfishBtn = new System.Windows.Forms.Button();
            this.fishCaughtLbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.investBox = new System.Windows.Forms.NumericUpDown();
            this.investBtn = new System.Windows.Forms.Button();
            this.investFishLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchFishBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(353, 9);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(270, 56);
            this.HeaderLbl.TabIndex = 2;
            this.HeaderLbl.Text = "ROUND 2";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showZodiacLbl
            // 
            this.showZodiacLbl.AutoSize = true;
            this.showZodiacLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showZodiacLbl.Location = new System.Drawing.Point(365, 97);
            this.showZodiacLbl.Name = "showZodiacLbl";
            this.showZodiacLbl.Size = new System.Drawing.Size(232, 29);
            this.showZodiacLbl.TabIndex = 3;
            this.showZodiacLbl.Text = "Here be the zodiac";
            this.showZodiacLbl.Visible = false;
            // 
            // eatPromptLbl
            // 
            this.eatPromptLbl.AutoSize = true;
            this.eatPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatPromptLbl.Location = new System.Drawing.Point(277, 298);
            this.eatPromptLbl.Name = "eatPromptLbl";
            this.eatPromptLbl.Size = new System.Drawing.Size(436, 23);
            this.eatPromptLbl.TabIndex = 4;
            this.eatPromptLbl.Text = "How many fish do you want to eat this round?";
            this.eatPromptLbl.Visible = false;
            // 
            // eatFishBox
            // 
            this.eatFishBox.Location = new System.Drawing.Point(391, 341);
            this.eatFishBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.eatFishBox.Name = "eatFishBox";
            this.eatFishBox.Size = new System.Drawing.Size(72, 20);
            this.eatFishBox.TabIndex = 10;
            this.eatFishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eatFishBox.Visible = false;
            // 
            // eatFishBtn
            // 
            this.eatFishBtn.Location = new System.Drawing.Point(469, 339);
            this.eatFishBtn.Name = "eatFishBtn";
            this.eatFishBtn.Size = new System.Drawing.Size(100, 20);
            this.eatFishBtn.TabIndex = 11;
            this.eatFishBtn.Text = "Eat";
            this.eatFishBtn.UseVisualStyleBackColor = true;
            this.eatFishBtn.Visible = false;
            this.eatFishBtn.Click += new System.EventHandler(this.eatFishBtn_Click);
            // 
            // eatFishLbl
            // 
            this.eatFishLbl.AutoSize = true;
            this.eatFishLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatFishLbl.Location = new System.Drawing.Point(318, 386);
            this.eatFishLbl.Name = "eatFishLbl";
            this.eatFishLbl.Size = new System.Drawing.Size(117, 23);
            this.eatFishLbl.TabIndex = 12;
            this.eatFishLbl.Text = "Eat the fish";
            this.eatFishLbl.Visible = false;
            // 
            // round1EndBtn
            // 
            this.round1EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1EndBtn.Location = new System.Drawing.Point(426, 680);
            this.round1EndBtn.Name = "round1EndBtn";
            this.round1EndBtn.Size = new System.Drawing.Size(171, 69);
            this.round1EndBtn.TabIndex = 13;
            this.round1EndBtn.Text = "End Round";
            this.round1EndBtn.UseVisualStyleBackColor = true;
            this.round1EndBtn.Click += new System.EventHandler(this.round1EndBtn_Click);
            // 
            // investPromptLbl
            // 
            this.investPromptLbl.AutoSize = true;
            this.investPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investPromptLbl.Location = new System.Drawing.Point(252, 439);
            this.investPromptLbl.Name = "investPromptLbl";
            this.investPromptLbl.Size = new System.Drawing.Size(485, 23);
            this.investPromptLbl.TabIndex = 14;
            this.investPromptLbl.Text = "Do you want to invest any fish into a private pond?";
            this.investPromptLbl.Visible = false;
            // 
            // catchPromptLbl
            // 
            this.catchPromptLbl.AutoSize = true;
            this.catchPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchPromptLbl.Location = new System.Drawing.Point(267, 159);
            this.catchPromptLbl.Name = "catchPromptLbl";
            this.catchPromptLbl.Size = new System.Drawing.Size(459, 23);
            this.catchPromptLbl.TabIndex = 15;
            this.catchPromptLbl.Text = "How many fish do you want to catch this round?";
            // 
            // catchFishBox
            // 
            this.catchFishBox.Location = new System.Drawing.Point(391, 210);
            this.catchFishBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.catchFishBox.Name = "catchFishBox";
            this.catchFishBox.Size = new System.Drawing.Size(72, 20);
            this.catchFishBox.TabIndex = 16;
            this.catchFishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // catchfishBtn
            // 
            this.catchfishBtn.Location = new System.Drawing.Point(469, 210);
            this.catchfishBtn.Name = "catchfishBtn";
            this.catchfishBtn.Size = new System.Drawing.Size(100, 20);
            this.catchfishBtn.TabIndex = 17;
            this.catchfishBtn.Text = "Catch";
            this.catchfishBtn.UseVisualStyleBackColor = true;
            this.catchfishBtn.Click += new System.EventHandler(this.catchfishBtn_Click);
            // 
            // fishCaughtLbl
            // 
            this.fishCaughtLbl.AutoSize = true;
            this.fishCaughtLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishCaughtLbl.Location = new System.Drawing.Point(318, 254);
            this.fishCaughtLbl.Name = "fishCaughtLbl";
            this.fishCaughtLbl.Size = new System.Drawing.Size(142, 23);
            this.fishCaughtLbl.TabIndex = 18;
            this.fishCaughtLbl.Text = "Catch the fish";
            this.fishCaughtLbl.Visible = false;
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(360, 492);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(100, 43);
            this.yesBtn.TabIndex = 19;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(523, 492);
            this.noBtn.Name = "noBtn";
            this.noBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noBtn.Size = new System.Drawing.Size(100, 43);
            this.noBtn.TabIndex = 20;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // investBox
            // 
            this.investBox.Location = new System.Drawing.Point(391, 570);
            this.investBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.investBox.Name = "investBox";
            this.investBox.Size = new System.Drawing.Size(72, 20);
            this.investBox.TabIndex = 21;
            this.investBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.investBox.Visible = false;
            // 
            // investBtn
            // 
            this.investBtn.Location = new System.Drawing.Point(469, 570);
            this.investBtn.Name = "investBtn";
            this.investBtn.Size = new System.Drawing.Size(100, 20);
            this.investBtn.TabIndex = 22;
            this.investBtn.Text = "Invest";
            this.investBtn.UseVisualStyleBackColor = true;
            this.investBtn.Visible = false;
            this.investBtn.Click += new System.EventHandler(this.investBtn_Click);
            // 
            // investFishLbl
            // 
            this.investFishLbl.AutoSize = true;
            this.investFishLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investFishLbl.Location = new System.Drawing.Point(318, 606);
            this.investFishLbl.Name = "investFishLbl";
            this.investFishLbl.Size = new System.Drawing.Size(144, 23);
            this.investFishLbl.TabIndex = 23;
            this.investFishLbl.Text = "Invest the fish";
            this.investFishLbl.Visible = false;
            // 
            // Round2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.investFishLbl);
            this.Controls.Add(this.investBtn);
            this.Controls.Add(this.investBox);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.fishCaughtLbl);
            this.Controls.Add(this.catchfishBtn);
            this.Controls.Add(this.catchFishBox);
            this.Controls.Add(this.catchPromptLbl);
            this.Controls.Add(this.investPromptLbl);
            this.Controls.Add(this.round1EndBtn);
            this.Controls.Add(this.eatFishLbl);
            this.Controls.Add(this.eatFishBtn);
            this.Controls.Add(this.eatFishBox);
            this.Controls.Add(this.eatPromptLbl);
            this.Controls.Add(this.showZodiacLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Round2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pisces Game";
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchFishBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label showZodiacLbl;
        private System.Windows.Forms.Label eatPromptLbl;
        private System.Windows.Forms.NumericUpDown eatFishBox;
        private System.Windows.Forms.Button eatFishBtn;
        private System.Windows.Forms.Label eatFishLbl;
        private System.Windows.Forms.Button round1EndBtn;
        private System.Windows.Forms.Label investPromptLbl;
        private System.Windows.Forms.Label catchPromptLbl;
        private System.Windows.Forms.NumericUpDown catchFishBox;
        private System.Windows.Forms.Button catchfishBtn;
        private System.Windows.Forms.Label fishCaughtLbl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.NumericUpDown investBox;
        private System.Windows.Forms.Button investBtn;
        private System.Windows.Forms.Label investFishLbl;
    }
}