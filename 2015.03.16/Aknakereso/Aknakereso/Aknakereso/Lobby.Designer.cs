namespace Aknakereso
{
    partial class Lobby
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
            this.FoPanel = new System.Windows.Forms.Panel();
            this.KliensPanel = new System.Windows.Forms.Panel();
            this.HostPanel = new System.Windows.Forms.Panel();
            this.CsatlakozasB = new System.Windows.Forms.Button();
            this.HostolasB = new System.Windows.Forms.Button();
            this.JoinB = new System.Windows.Forms.Button();
            this.KliensVissza = new System.Windows.Forms.Button();
            this.ipLabel2 = new System.Windows.Forms.Label();
            this.ipLabel1 = new System.Windows.Forms.Label();
            this.ipcimBox = new System.Windows.Forms.MaskedTextBox();
            this.ipLabel3 = new System.Windows.Forms.Label();
            this.AllapotLabel = new System.Windows.Forms.Label();
            this.HostVissza = new System.Windows.Forms.Button();
            this.LetrehozasB = new System.Windows.Forms.Button();
            this.FomenuVissza = new System.Windows.Forms.Button();
            this.FoPanel.SuspendLayout();
            this.KliensPanel.SuspendLayout();
            this.HostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoPanel
            // 
            this.FoPanel.Controls.Add(this.FomenuVissza);
            this.FoPanel.Controls.Add(this.ipLabel1);
            this.FoPanel.Controls.Add(this.HostolasB);
            this.FoPanel.Controls.Add(this.CsatlakozasB);
            this.FoPanel.Location = new System.Drawing.Point(12, 12);
            this.FoPanel.Name = "FoPanel";
            this.FoPanel.Size = new System.Drawing.Size(576, 158);
            this.FoPanel.TabIndex = 2;
            // 
            // KliensPanel
            // 
            this.KliensPanel.Controls.Add(this.AllapotLabel);
            this.KliensPanel.Controls.Add(this.ipcimBox);
            this.KliensPanel.Controls.Add(this.ipLabel2);
            this.KliensPanel.Controls.Add(this.KliensVissza);
            this.KliensPanel.Controls.Add(this.JoinB);
            this.KliensPanel.Location = new System.Drawing.Point(12, 176);
            this.KliensPanel.Name = "KliensPanel";
            this.KliensPanel.Size = new System.Drawing.Size(576, 158);
            this.KliensPanel.TabIndex = 3;
            this.KliensPanel.Visible = false;
            // 
            // HostPanel
            // 
            this.HostPanel.Controls.Add(this.LetrehozasB);
            this.HostPanel.Controls.Add(this.HostVissza);
            this.HostPanel.Controls.Add(this.ipLabel3);
            this.HostPanel.Location = new System.Drawing.Point(12, 346);
            this.HostPanel.Name = "HostPanel";
            this.HostPanel.Size = new System.Drawing.Size(576, 158);
            this.HostPanel.TabIndex = 4;
            this.HostPanel.Visible = false;
            // 
            // CsatlakozasB
            // 
            this.CsatlakozasB.Location = new System.Drawing.Point(235, 47);
            this.CsatlakozasB.Name = "CsatlakozasB";
            this.CsatlakozasB.Size = new System.Drawing.Size(75, 23);
            this.CsatlakozasB.TabIndex = 0;
            this.CsatlakozasB.Text = "Csatlakozás";
            this.CsatlakozasB.UseVisualStyleBackColor = true;
            this.CsatlakozasB.Click += new System.EventHandler(this.CsatlakozasB_Click);
            // 
            // HostolasB
            // 
            this.HostolasB.Location = new System.Drawing.Point(235, 89);
            this.HostolasB.Name = "HostolasB";
            this.HostolasB.Size = new System.Drawing.Size(75, 23);
            this.HostolasB.TabIndex = 1;
            this.HostolasB.Text = "Hostolás";
            this.HostolasB.UseVisualStyleBackColor = true;
            this.HostolasB.Click += new System.EventHandler(this.HostolasB_Click);
            // 
            // JoinB
            // 
            this.JoinB.Location = new System.Drawing.Point(235, 71);
            this.JoinB.Name = "JoinB";
            this.JoinB.Size = new System.Drawing.Size(75, 23);
            this.JoinB.TabIndex = 0;
            this.JoinB.Text = "Csatlakozás";
            this.JoinB.UseVisualStyleBackColor = true;
            // 
            // KliensVissza
            // 
            this.KliensVissza.Location = new System.Drawing.Point(3, 132);
            this.KliensVissza.Name = "KliensVissza";
            this.KliensVissza.Size = new System.Drawing.Size(75, 23);
            this.KliensVissza.TabIndex = 1;
            this.KliensVissza.Text = "Vissza";
            this.KliensVissza.UseVisualStyleBackColor = true;
            this.KliensVissza.Click += new System.EventHandler(this.CsatlakozasVissza_Click);
            // 
            // ipLabel2
            // 
            this.ipLabel2.AutoSize = true;
            this.ipLabel2.Location = new System.Drawing.Point(17, 16);
            this.ipLabel2.Name = "ipLabel2";
            this.ipLabel2.Size = new System.Drawing.Size(20, 13);
            this.ipLabel2.TabIndex = 2;
            this.ipLabel2.Text = "IP:";
            // 
            // ipLabel1
            // 
            this.ipLabel1.AutoSize = true;
            this.ipLabel1.Location = new System.Drawing.Point(17, 12);
            this.ipLabel1.Name = "ipLabel1";
            this.ipLabel1.Size = new System.Drawing.Size(20, 13);
            this.ipLabel1.TabIndex = 2;
            this.ipLabel1.Text = "IP:";
            // 
            // ipcimBox
            // 
            this.ipcimBox.Location = new System.Drawing.Point(226, 13);
            this.ipcimBox.Mask = "000.000.000.000";
            this.ipcimBox.Name = "ipcimBox";
            this.ipcimBox.Size = new System.Drawing.Size(100, 20);
            this.ipcimBox.TabIndex = 3;
            // 
            // ipLabel3
            // 
            this.ipLabel3.AutoSize = true;
            this.ipLabel3.Location = new System.Drawing.Point(17, 12);
            this.ipLabel3.Name = "ipLabel3";
            this.ipLabel3.Size = new System.Drawing.Size(20, 13);
            this.ipLabel3.TabIndex = 0;
            this.ipLabel3.Text = "IP:";
            // 
            // AllapotLabel
            // 
            this.AllapotLabel.Location = new System.Drawing.Point(161, 124);
            this.AllapotLabel.Name = "AllapotLabel";
            this.AllapotLabel.Size = new System.Drawing.Size(233, 27);
            this.AllapotLabel.TabIndex = 4;
            this.AllapotLabel.Text = "Csatlakozás állapota:";
            // 
            // HostVissza
            // 
            this.HostVissza.Location = new System.Drawing.Point(3, 132);
            this.HostVissza.Name = "HostVissza";
            this.HostVissza.Size = new System.Drawing.Size(75, 23);
            this.HostVissza.TabIndex = 1;
            this.HostVissza.Text = "Vissza";
            this.HostVissza.UseVisualStyleBackColor = true;
            this.HostVissza.Click += new System.EventHandler(this.HostVissza_Click);
            // 
            // LetrehozasB
            // 
            this.LetrehozasB.Location = new System.Drawing.Point(142, 31);
            this.LetrehozasB.Name = "LetrehozasB";
            this.LetrehozasB.Size = new System.Drawing.Size(252, 63);
            this.LetrehozasB.TabIndex = 2;
            this.LetrehozasB.Text = "Szoba létrehozása";
            this.LetrehozasB.UseVisualStyleBackColor = true;
            // 
            // FomenuVissza
            // 
            this.FomenuVissza.Location = new System.Drawing.Point(3, 128);
            this.FomenuVissza.Name = "FomenuVissza";
            this.FomenuVissza.Size = new System.Drawing.Size(109, 23);
            this.FomenuVissza.TabIndex = 3;
            this.FomenuVissza.Text = "Vissza a főmenübe";
            this.FomenuVissza.UseVisualStyleBackColor = true;
            this.FomenuVissza.Click += new System.EventHandler(this.FomenuVissza_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 175);
            this.Controls.Add(this.HostPanel);
            this.Controls.Add(this.KliensPanel);
            this.Controls.Add(this.FoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_FormClosing);
            this.FoPanel.ResumeLayout(false);
            this.FoPanel.PerformLayout();
            this.KliensPanel.ResumeLayout(false);
            this.KliensPanel.PerformLayout();
            this.HostPanel.ResumeLayout(false);
            this.HostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FoPanel;
        private System.Windows.Forms.Panel KliensPanel;
        private System.Windows.Forms.Panel HostPanel;
        private System.Windows.Forms.Label ipLabel1;
        private System.Windows.Forms.Button HostolasB;
        private System.Windows.Forms.Button CsatlakozasB;
        private System.Windows.Forms.Label AllapotLabel;
        private System.Windows.Forms.MaskedTextBox ipcimBox;
        private System.Windows.Forms.Label ipLabel2;
        private System.Windows.Forms.Button KliensVissza;
        private System.Windows.Forms.Button JoinB;
        private System.Windows.Forms.Button LetrehozasB;
        private System.Windows.Forms.Button HostVissza;
        private System.Windows.Forms.Label ipLabel3;
        private System.Windows.Forms.Button FomenuVissza;
    }
}