﻿namespace Aknakereso
{
    partial class Beallitasok
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
            this.label2 = new System.Windows.Forms.Label();
            this.visszaB = new System.Windows.Forms.Button();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.szelessegL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beállítások";
            // 
            // visszaB
            // 
            this.visszaB.BackColor = System.Drawing.Color.DarkKhaki;
            this.visszaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visszaB.Location = new System.Drawing.Point(12, 356);
            this.visszaB.Name = "visszaB";
            this.visszaB.Size = new System.Drawing.Size(112, 30);
            this.visszaB.TabIndex = 10;
            this.visszaB.Text = "<-- Vissza";
            this.visszaB.UseVisualStyleBackColor = false;
            this.visszaB.Click += new System.EventHandler(this.visszaB_Click);
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.BackColor = System.Drawing.Color.DarkKhaki;
            this.numericUpDownM.Location = new System.Drawing.Point(39, 245);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownM.TabIndex = 9;
            this.numericUpDownM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "A térkép magassága:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.BackColor = System.Drawing.Color.DarkKhaki;
            this.numericUpDownN.Location = new System.Drawing.Point(39, 145);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownN.TabIndex = 7;
            this.numericUpDownN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // szelessegL
            // 
            this.szelessegL.AutoSize = true;
            this.szelessegL.BackColor = System.Drawing.Color.Transparent;
            this.szelessegL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szelessegL.Location = new System.Drawing.Point(35, 118);
            this.szelessegL.Name = "szelessegL";
            this.szelessegL.Size = new System.Drawing.Size(205, 24);
            this.szelessegL.TabIndex = 6;
            this.szelessegL.Text = "A térkép szélessége:";
            // 
            // Beallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aknakereso.Properties.Resources.Kereso;
            this.ClientSize = new System.Drawing.Size(640, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visszaB);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.szelessegL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Beallitasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beállítások";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Beallitasok_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button visszaB;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label szelessegL;



    }
}