﻿namespace Aknakereso
{
    partial class KliensJatekos
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
            this.uzenetBox = new System.Windows.Forms.TextBox();
            this.uzenetek = new System.Windows.Forms.ListBox();
            this.KilepesMenu = new System.Windows.Forms.Button();
            this.AknaszamL = new System.Windows.Forms.Label();
            this.pontszam2L = new System.Windows.Forms.Label();
            this.player2L = new System.Windows.Forms.Label();
            this.pontszam1L = new System.Windows.Forms.Label();
            this.player1L = new System.Windows.Forms.Label();
            this.kilepesB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kommunikacioTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uzenetBox
            // 
            this.uzenetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uzenetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uzenetBox.Location = new System.Drawing.Point(773, 402);
            this.uzenetBox.Name = "uzenetBox";
            this.uzenetBox.Size = new System.Drawing.Size(298, 22);
            this.uzenetBox.TabIndex = 31;
            this.uzenetBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uzenetBox_KeyDown);
            // 
            // uzenetek
            // 
            this.uzenetek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uzenetek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uzenetek.FormattingEnabled = true;
            this.uzenetek.ItemHeight = 16;
            this.uzenetek.Location = new System.Drawing.Point(773, 216);
            this.uzenetek.Name = "uzenetek";
            this.uzenetek.Size = new System.Drawing.Size(298, 180);
            this.uzenetek.TabIndex = 30;
            // 
            // KilepesMenu
            // 
            this.KilepesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KilepesMenu.Location = new System.Drawing.Point(773, 780);
            this.KilepesMenu.Name = "KilepesMenu";
            this.KilepesMenu.Size = new System.Drawing.Size(100, 30);
            this.KilepesMenu.TabIndex = 29;
            this.KilepesMenu.Text = "Kilépés a menübe";
            this.KilepesMenu.UseVisualStyleBackColor = true;
            this.KilepesMenu.Click += new System.EventHandler(this.KilepesMenu_Click);
            // 
            // AknaszamL
            // 
            this.AknaszamL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AknaszamL.AutoSize = true;
            this.AknaszamL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AknaszamL.Location = new System.Drawing.Point(769, 80);
            this.AknaszamL.Name = "AknaszamL";
            this.AknaszamL.Size = new System.Drawing.Size(88, 20);
            this.AknaszamL.TabIndex = 28;
            this.AknaszamL.Text = "Aknaszám:";
            // 
            // pontszam2L
            // 
            this.pontszam2L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pontszam2L.AutoSize = true;
            this.pontszam2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontszam2L.Location = new System.Drawing.Point(769, 162);
            this.pontszam2L.Name = "pontszam2L";
            this.pontszam2L.Size = new System.Drawing.Size(31, 20);
            this.pontszam2L.TabIndex = 27;
            this.pontszam2L.Text = "0 p";
            // 
            // player2L
            // 
            this.player2L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2L.AutoSize = true;
            this.player2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2L.Location = new System.Drawing.Point(769, 142);
            this.player2L.Name = "player2L";
            this.player2L.Size = new System.Drawing.Size(61, 20);
            this.player2L.TabIndex = 26;
            this.player2L.Text = "Player2";
            // 
            // pontszam1L
            // 
            this.pontszam1L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pontszam1L.AutoSize = true;
            this.pontszam1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontszam1L.Location = new System.Drawing.Point(769, 31);
            this.pontszam1L.Name = "pontszam1L";
            this.pontszam1L.Size = new System.Drawing.Size(31, 20);
            this.pontszam1L.TabIndex = 25;
            this.pontszam1L.Text = "0 p";
            // 
            // player1L
            // 
            this.player1L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player1L.AutoSize = true;
            this.player1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1L.Location = new System.Drawing.Point(769, 11);
            this.player1L.Name = "player1L";
            this.player1L.Size = new System.Drawing.Size(61, 20);
            this.player1L.TabIndex = 24;
            this.player1L.Text = "Player1";
            // 
            // kilepesB
            // 
            this.kilepesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kilepesB.Location = new System.Drawing.Point(971, 778);
            this.kilepesB.Name = "kilepesB";
            this.kilepesB.Size = new System.Drawing.Size(100, 30);
            this.kilepesB.TabIndex = 23;
            this.kilepesB.Text = "Kilépés a játékból";
            this.kilepesB.UseVisualStyleBackColor = true;
            this.kilepesB.Click += new System.EventHandler(this.kilepesB_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 799);
            this.panel1.TabIndex = 22;
            // 
            // kommunikacioTimer
            // 
            this.kommunikacioTimer.Tick += new System.EventHandler(this.kommunikacioTimer_Tick);
            // 
            // KliensJatekos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1084, 821);
            this.Controls.Add(this.uzenetBox);
            this.Controls.Add(this.uzenetek);
            this.Controls.Add(this.KilepesMenu);
            this.Controls.Add(this.AknaszamL);
            this.Controls.Add(this.pontszam2L);
            this.Controls.Add(this.player2L);
            this.Controls.Add(this.pontszam1L);
            this.Controls.Add(this.player1L);
            this.Controls.Add(this.kilepesB);
            this.Controls.Add(this.panel1);
            this.Name = "KliensJatekos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KliensJatekos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kliens_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uzenetBox;
        private System.Windows.Forms.ListBox uzenetek;
        private System.Windows.Forms.Button KilepesMenu;
        private System.Windows.Forms.Label AknaszamL;
        public System.Windows.Forms.Label pontszam2L;
        private System.Windows.Forms.Label player2L;
        public System.Windows.Forms.Label pontszam1L;
        private System.Windows.Forms.Label player1L;
        private System.Windows.Forms.Button kilepesB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer kommunikacioTimer;

    }
}