namespace Aknakereso
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
            this.beallitasokPanel = new System.Windows.Forms.Panel();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.szelessegL = new System.Windows.Forms.Label();
            this.visszaB = new System.Windows.Forms.Button();
            this.beallitasokPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // beallitasokPanel
            // 
            this.beallitasokPanel.Controls.Add(this.visszaB);
            this.beallitasokPanel.Controls.Add(this.numericUpDownM);
            this.beallitasokPanel.Controls.Add(this.label1);
            this.beallitasokPanel.Controls.Add(this.numericUpDownN);
            this.beallitasokPanel.Controls.Add(this.szelessegL);
            this.beallitasokPanel.Location = new System.Drawing.Point(12, 12);
            this.beallitasokPanel.Name = "beallitasokPanel";
            this.beallitasokPanel.Size = new System.Drawing.Size(560, 537);
            this.beallitasokPanel.TabIndex = 0;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(210, 220);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            20,
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
            this.numericUpDownM.TabIndex = 3;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "A térkép magassága:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(210, 120);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            20,
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
            this.numericUpDownN.TabIndex = 1;
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
            this.szelessegL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szelessegL.Location = new System.Drawing.Point(190, 90);
            this.szelessegL.Name = "szelessegL";
            this.szelessegL.Size = new System.Drawing.Size(154, 16);
            this.szelessegL.TabIndex = 0;
            this.szelessegL.Text = "A térkép szélessége:";
            // 
            // visszaB
            // 
            this.visszaB.Location = new System.Drawing.Point(3, 504);
            this.visszaB.Name = "visszaB";
            this.visszaB.Size = new System.Drawing.Size(100, 30);
            this.visszaB.TabIndex = 4;
            this.visszaB.Text = "<-- Vissza";
            this.visszaB.UseVisualStyleBackColor = true;
            // 
            // Beallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.beallitasokPanel);
            this.Name = "Beallitasok";
            this.Text = "Beallitasok";
            this.beallitasokPanel.ResumeLayout(false);
            this.beallitasokPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel beallitasokPanel;
        private System.Windows.Forms.Label szelessegL;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Button visszaB;

    }
}