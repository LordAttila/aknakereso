namespace Aknakereso
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
            this.kilepesB = new System.Windows.Forms.Button();
            this.beallitasokB = new System.Windows.Forms.Button();
            this.tobbjatekosB = new System.Windows.Forms.Button();
            this.egyjatekosB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kilepesB
            // 
            this.kilepesB.BackColor = System.Drawing.Color.DarkKhaki;
            this.kilepesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilepesB.Location = new System.Drawing.Point(52, 312);
            this.kilepesB.Name = "kilepesB";
            this.kilepesB.Size = new System.Drawing.Size(200, 40);
            this.kilepesB.TabIndex = 7;
            this.kilepesB.Text = "Kilépés";
            this.kilepesB.UseVisualStyleBackColor = false;
            this.kilepesB.Click += new System.EventHandler(this.kilepesB_Click);
            // 
            // beallitasokB
            // 
            this.beallitasokB.BackColor = System.Drawing.Color.DarkKhaki;
            this.beallitasokB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beallitasokB.Location = new System.Drawing.Point(52, 242);
            this.beallitasokB.Name = "beallitasokB";
            this.beallitasokB.Size = new System.Drawing.Size(200, 40);
            this.beallitasokB.TabIndex = 6;
            this.beallitasokB.Text = "Beállítások";
            this.beallitasokB.UseVisualStyleBackColor = false;
            this.beallitasokB.Click += new System.EventHandler(this.beallitasokB_Click);
            // 
            // tobbjatekosB
            // 
            this.tobbjatekosB.BackColor = System.Drawing.Color.DarkKhaki;
            this.tobbjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobbjatekosB.Location = new System.Drawing.Point(52, 172);
            this.tobbjatekosB.Name = "tobbjatekosB";
            this.tobbjatekosB.Size = new System.Drawing.Size(200, 40);
            this.tobbjatekosB.TabIndex = 5;
            this.tobbjatekosB.Text = "Többjátékos";
            this.tobbjatekosB.UseVisualStyleBackColor = false;
            this.tobbjatekosB.Click += new System.EventHandler(this.tobbjatekosB_Click);
            // 
            // egyjatekosB
            // 
            this.egyjatekosB.BackColor = System.Drawing.Color.DarkKhaki;
            this.egyjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egyjatekosB.Location = new System.Drawing.Point(52, 102);
            this.egyjatekosB.Name = "egyjatekosB";
            this.egyjatekosB.Size = new System.Drawing.Size(200, 40);
            this.egyjatekosB.TabIndex = 4;
            this.egyjatekosB.Text = "Egyjátékos";
            this.egyjatekosB.UseVisualStyleBackColor = false;
            this.egyjatekosB.Click += new System.EventHandler(this.egyjatekosB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aknakereső";
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Aknakereso.Properties.Resources.Kereso;
            this.ClientSize = new System.Drawing.Size(640, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilepesB);
            this.Controls.Add(this.beallitasokB);
            this.Controls.Add(this.tobbjatekosB);
            this.Controls.Add(this.egyjatekosB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fomenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kilepesB;
        private System.Windows.Forms.Button beallitasokB;
        private System.Windows.Forms.Button tobbjatekosB;
        private System.Windows.Forms.Button egyjatekosB;
        private System.Windows.Forms.Label label1;


    }
}