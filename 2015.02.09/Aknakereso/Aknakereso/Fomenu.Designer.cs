﻿namespace Aknakereso
{
    partial class Fomenu
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
            this.fomenuPanel = new System.Windows.Forms.Panel();
            this.kilepesB = new System.Windows.Forms.Button();
            this.beallitasokB = new System.Windows.Forms.Button();
            this.tobbjatekosB = new System.Windows.Forms.Button();
            this.egyjatekosB = new System.Windows.Forms.Button();
            this.fomenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fomenuPanel
            // 
            this.fomenuPanel.Controls.Add(this.kilepesB);
            this.fomenuPanel.Controls.Add(this.beallitasokB);
            this.fomenuPanel.Controls.Add(this.tobbjatekosB);
            this.fomenuPanel.Controls.Add(this.egyjatekosB);
            this.fomenuPanel.Location = new System.Drawing.Point(12, 12);
            this.fomenuPanel.Name = "fomenuPanel";
            this.fomenuPanel.Size = new System.Drawing.Size(560, 537);
            this.fomenuPanel.TabIndex = 0;
            // 
            // kilepesB
            // 
            this.kilepesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilepesB.Location = new System.Drawing.Point(175, 320);
            this.kilepesB.Name = "kilepesB";
            this.kilepesB.Size = new System.Drawing.Size(200, 40);
            this.kilepesB.TabIndex = 3;
            this.kilepesB.Text = "Kilépés";
            this.kilepesB.UseVisualStyleBackColor = true;
            this.kilepesB.Click += new System.EventHandler(this.kilepesB_Click);
            // 
            // beallitasokB
            // 
            this.beallitasokB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beallitasokB.Location = new System.Drawing.Point(175, 250);
            this.beallitasokB.Name = "beallitasokB";
            this.beallitasokB.Size = new System.Drawing.Size(200, 40);
            this.beallitasokB.TabIndex = 2;
            this.beallitasokB.Text = "Beállítások";
            this.beallitasokB.UseVisualStyleBackColor = true;
            this.beallitasokB.Click += new System.EventHandler(this.beallitasokB_Click);
            // 
            // tobbjatekosB
            // 
            this.tobbjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobbjatekosB.Location = new System.Drawing.Point(175, 180);
            this.tobbjatekosB.Name = "tobbjatekosB";
            this.tobbjatekosB.Size = new System.Drawing.Size(200, 40);
            this.tobbjatekosB.TabIndex = 1;
            this.tobbjatekosB.Text = "Többjátékos";
            this.tobbjatekosB.UseVisualStyleBackColor = true;
            // 
            // egyjatekosB
            // 
            this.egyjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egyjatekosB.Location = new System.Drawing.Point(175, 110);
            this.egyjatekosB.Name = "egyjatekosB";
            this.egyjatekosB.Size = new System.Drawing.Size(200, 40);
            this.egyjatekosB.TabIndex = 0;
            this.egyjatekosB.Text = "Egyjátékos";
            this.egyjatekosB.UseVisualStyleBackColor = true;
            this.egyjatekosB.Click += new System.EventHandler(this.egyjatekosB_Click);
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.fomenuPanel);
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fomenu_FormClosing);
            this.fomenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fomenuPanel;
        private System.Windows.Forms.Button kilepesB;
        private System.Windows.Forms.Button beallitasokB;
        private System.Windows.Forms.Button tobbjatekosB;
        private System.Windows.Forms.Button egyjatekosB;

    }
}