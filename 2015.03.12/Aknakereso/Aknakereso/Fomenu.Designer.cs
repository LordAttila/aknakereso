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
            this.SuspendLayout();
            // 
            // kilepesB
            // 
            this.kilepesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilepesB.Location = new System.Drawing.Point(192, 365);
            this.kilepesB.Name = "kilepesB";
            this.kilepesB.Size = new System.Drawing.Size(200, 40);
            this.kilepesB.TabIndex = 7;
            this.kilepesB.Text = "Kilépés";
            this.kilepesB.UseVisualStyleBackColor = true;
            this.kilepesB.Click += new System.EventHandler(this.kilepesB_Click);
            // 
            // beallitasokB
            // 
            this.beallitasokB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beallitasokB.Location = new System.Drawing.Point(192, 295);
            this.beallitasokB.Name = "beallitasokB";
            this.beallitasokB.Size = new System.Drawing.Size(200, 40);
            this.beallitasokB.TabIndex = 6;
            this.beallitasokB.Text = "Beállítások";
            this.beallitasokB.UseVisualStyleBackColor = true;
            this.beallitasokB.Click += new System.EventHandler(this.beallitasokB_Click);
            // 
            // tobbjatekosB
            // 
            this.tobbjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobbjatekosB.Location = new System.Drawing.Point(192, 225);
            this.tobbjatekosB.Name = "tobbjatekosB";
            this.tobbjatekosB.Size = new System.Drawing.Size(200, 40);
            this.tobbjatekosB.TabIndex = 5;
            this.tobbjatekosB.Text = "Többjátékos";
            this.tobbjatekosB.UseVisualStyleBackColor = true;
            // 
            // egyjatekosB
            // 
            this.egyjatekosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egyjatekosB.Location = new System.Drawing.Point(192, 155);
            this.egyjatekosB.Name = "egyjatekosB";
            this.egyjatekosB.Size = new System.Drawing.Size(200, 40);
            this.egyjatekosB.TabIndex = 4;
            this.egyjatekosB.Text = "Egyjátékos";
            this.egyjatekosB.UseVisualStyleBackColor = true;
            this.egyjatekosB.Click += new System.EventHandler(this.egyjatekosB_Click);
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.kilepesB);
            this.Controls.Add(this.beallitasokB);
            this.Controls.Add(this.tobbjatekosB);
            this.Controls.Add(this.egyjatekosB);
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fomenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kilepesB;
        private System.Windows.Forms.Button beallitasokB;
        private System.Windows.Forms.Button tobbjatekosB;
        private System.Windows.Forms.Button egyjatekosB;


    }
}