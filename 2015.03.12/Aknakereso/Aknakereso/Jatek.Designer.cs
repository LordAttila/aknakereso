namespace Aknakereso
{
    partial class JatekAblak
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kilepesB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pontszam1L = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pontszam2L = new System.Windows.Forms.Label();
            this.AknaszamL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 799);
            this.panel1.TabIndex = 2;
            // 
            // kilepesB
            // 
            this.kilepesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kilepesB.Location = new System.Drawing.Point(804, 781);
            this.kilepesB.Name = "kilepesB";
            this.kilepesB.Size = new System.Drawing.Size(90, 30);
            this.kilepesB.TabIndex = 3;
            this.kilepesB.Text = "Kilépés";
            this.kilepesB.UseVisualStyleBackColor = true;
            this.kilepesB.Click += new System.EventHandler(this.kilepesB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(770, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Játékos pontszáma:";
            // 
            // pontszam1L
            // 
            this.pontszam1L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pontszam1L.AutoSize = true;
            this.pontszam1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontszam1L.Location = new System.Drawing.Point(821, 136);
            this.pontszam1L.Name = "pontszam1L";
            this.pontszam1L.Size = new System.Drawing.Size(26, 16);
            this.pontszam1L.TabIndex = 5;
            this.pontszam1L.Text = "0 p";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(770, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ellenfél pontszáma:";
            // 
            // pontszam2L
            // 
            this.pontszam2L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pontszam2L.AutoSize = true;
            this.pontszam2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontszam2L.Location = new System.Drawing.Point(821, 259);
            this.pontszam2L.Name = "pontszam2L";
            this.pontszam2L.Size = new System.Drawing.Size(26, 16);
            this.pontszam2L.TabIndex = 7;
            this.pontszam2L.Text = "0 p";
            // 
            // AknaszamL
            // 
            this.AknaszamL.AutoSize = true;
            this.AknaszamL.Location = new System.Drawing.Point(801, 387);
            this.AknaszamL.Name = "AknaszamL";
            this.AknaszamL.Size = new System.Drawing.Size(59, 13);
            this.AknaszamL.TabIndex = 8;
            this.AknaszamL.Text = "Aknaszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tesztelési tipp";
            // 
            // JatekAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 823);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AknaszamL);
            this.Controls.Add(this.pontszam2L);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pontszam1L);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilepesB);
            this.Controls.Add(this.panel1);
            this.Name = "JatekAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aknakereső";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JatekAblak_FormClosing);
            this.Load += new System.EventHandler(this.JatekAblak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kilepesB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label pontszam1L;
        public System.Windows.Forms.Label pontszam2L;
        private System.Windows.Forms.Label AknaszamL;
        private System.Windows.Forms.Label label3;


    }
}

