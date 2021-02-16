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
            this.components = new System.ComponentModel.Container();
            this.FoPanel = new System.Windows.Forms.Panel();
            this.FomenuVissza = new System.Windows.Forms.Button();
            this.ipLabel1 = new System.Windows.Forms.Label();
            this.HostolasB = new System.Windows.Forms.Button();
            this.CsatlakozasB = new System.Windows.Forms.Button();
            this.KliensPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kliensNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.AllapotLabel = new System.Windows.Forms.Label();
            this.ipLabel2 = new System.Windows.Forms.Label();
            this.KliensVissza = new System.Windows.Forms.Button();
            this.JoinB = new System.Windows.Forms.Button();
            this.HostPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.hostNev = new System.Windows.Forms.TextBox();
            this.LetrehozasB = new System.Windows.Forms.Button();
            this.HostVissza = new System.Windows.Forms.Button();
            this.ipLabel3 = new System.Windows.Forms.Label();
            this.rtbUzenetek = new System.Windows.Forms.RichTextBox();
            this.tbUzenet = new System.Windows.Forms.TextBox();
            this.Kuldes = new System.Windows.Forms.Button();
            this.timerKliensKeres = new System.Windows.Forms.Timer(this.components);
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
            // FomenuVissza
            // 
            this.FomenuVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FomenuVissza.Location = new System.Drawing.Point(3, 124);
            this.FomenuVissza.Name = "FomenuVissza";
            this.FomenuVissza.Size = new System.Drawing.Size(141, 27);
            this.FomenuVissza.TabIndex = 3;
            this.FomenuVissza.Text = "Vissza a főmenübe";
            this.FomenuVissza.UseVisualStyleBackColor = true;
            this.FomenuVissza.Click += new System.EventHandler(this.FomenuVissza_Click);
            // 
            // ipLabel1
            // 
            this.ipLabel1.AutoSize = true;
            this.ipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel1.Location = new System.Drawing.Point(3, 3);
            this.ipLabel1.Name = "ipLabel1";
            this.ipLabel1.Size = new System.Drawing.Size(28, 20);
            this.ipLabel1.TabIndex = 2;
            this.ipLabel1.Text = "IP:";
            // 
            // HostolasB
            // 
            this.HostolasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostolasB.Location = new System.Drawing.Point(277, 77);
            this.HostolasB.Name = "HostolasB";
            this.HostolasB.Size = new System.Drawing.Size(104, 27);
            this.HostolasB.TabIndex = 1;
            this.HostolasB.Text = "Hostolás";
            this.HostolasB.UseVisualStyleBackColor = true;
            this.HostolasB.Click += new System.EventHandler(this.HostolasB_Click);
            // 
            // CsatlakozasB
            // 
            this.CsatlakozasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsatlakozasB.Location = new System.Drawing.Point(277, 30);
            this.CsatlakozasB.Name = "CsatlakozasB";
            this.CsatlakozasB.Size = new System.Drawing.Size(104, 27);
            this.CsatlakozasB.TabIndex = 0;
            this.CsatlakozasB.Text = "Csatlakozás";
            this.CsatlakozasB.UseVisualStyleBackColor = true;
            this.CsatlakozasB.Click += new System.EventHandler(this.CsatlakozasB_Click);
            // 
            // KliensPanel
            // 
            this.KliensPanel.Controls.Add(this.label2);
            this.KliensPanel.Controls.Add(this.kliensNev);
            this.KliensPanel.Controls.Add(this.label1);
            this.KliensPanel.Controls.Add(this.tbIP);
            this.KliensPanel.Controls.Add(this.AllapotLabel);
            this.KliensPanel.Controls.Add(this.ipLabel2);
            this.KliensPanel.Controls.Add(this.KliensVissza);
            this.KliensPanel.Controls.Add(this.JoinB);
            this.KliensPanel.Location = new System.Drawing.Point(12, 176);
            this.KliensPanel.Name = "KliensPanel";
            this.KliensPanel.Size = new System.Drawing.Size(576, 158);
            this.KliensPanel.TabIndex = 3;
            this.KliensPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név:";
            // 
            // kliensNev
            // 
            this.kliensNev.Location = new System.Drawing.Point(283, 38);
            this.kliensNev.Name = "kliensNev";
            this.kliensNev.Size = new System.Drawing.Size(100, 20);
            this.kliensNev.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP cím:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(283, 12);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 5;
            // 
            // AllapotLabel
            // 
            this.AllapotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllapotLabel.Location = new System.Drawing.Point(161, 124);
            this.AllapotLabel.Name = "AllapotLabel";
            this.AllapotLabel.Size = new System.Drawing.Size(412, 27);
            this.AllapotLabel.TabIndex = 4;
            this.AllapotLabel.Text = "Csatlakozás állapota:";
            // 
            // ipLabel2
            // 
            this.ipLabel2.AutoSize = true;
            this.ipLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel2.Location = new System.Drawing.Point(3, 0);
            this.ipLabel2.Name = "ipLabel2";
            this.ipLabel2.Size = new System.Drawing.Size(28, 20);
            this.ipLabel2.TabIndex = 2;
            this.ipLabel2.Text = "IP:";
            // 
            // KliensVissza
            // 
            this.KliensVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KliensVissza.Location = new System.Drawing.Point(3, 132);
            this.KliensVissza.Name = "KliensVissza";
            this.KliensVissza.Size = new System.Drawing.Size(75, 23);
            this.KliensVissza.TabIndex = 1;
            this.KliensVissza.Text = "Vissza";
            this.KliensVissza.UseVisualStyleBackColor = true;
            this.KliensVissza.Click += new System.EventHandler(this.CsatlakozasVissza_Click);
            // 
            // JoinB
            // 
            this.JoinB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinB.Location = new System.Drawing.Point(274, 74);
            this.JoinB.Name = "JoinB";
            this.JoinB.Size = new System.Drawing.Size(120, 30);
            this.JoinB.TabIndex = 0;
            this.JoinB.Text = "Csatlakozás";
            this.JoinB.UseVisualStyleBackColor = true;
            this.JoinB.Click += new System.EventHandler(this.JoinB_Click);
            // 
            // HostPanel
            // 
            this.HostPanel.Controls.Add(this.label3);
            this.HostPanel.Controls.Add(this.hostNev);
            this.HostPanel.Controls.Add(this.LetrehozasB);
            this.HostPanel.Controls.Add(this.HostVissza);
            this.HostPanel.Controls.Add(this.ipLabel3);
            this.HostPanel.Location = new System.Drawing.Point(12, 346);
            this.HostPanel.Name = "HostPanel";
            this.HostPanel.Size = new System.Drawing.Size(576, 158);
            this.HostPanel.TabIndex = 4;
            this.HostPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Név:";
            // 
            // hostNev
            // 
            this.hostNev.Location = new System.Drawing.Point(283, 31);
            this.hostNev.Name = "hostNev";
            this.hostNev.Size = new System.Drawing.Size(100, 20);
            this.hostNev.TabIndex = 10;
            // 
            // LetrehozasB
            // 
            this.LetrehozasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetrehozasB.Location = new System.Drawing.Point(225, 92);
            this.LetrehozasB.Name = "LetrehozasB";
            this.LetrehozasB.Size = new System.Drawing.Size(216, 37);
            this.LetrehozasB.TabIndex = 2;
            this.LetrehozasB.Text = "Szoba létrehozása";
            this.LetrehozasB.UseVisualStyleBackColor = true;
            this.LetrehozasB.Click += new System.EventHandler(this.LetrehozasB_Click);
            // 
            // HostVissza
            // 
            this.HostVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostVissza.Location = new System.Drawing.Point(3, 132);
            this.HostVissza.Name = "HostVissza";
            this.HostVissza.Size = new System.Drawing.Size(75, 23);
            this.HostVissza.TabIndex = 1;
            this.HostVissza.Text = "Vissza";
            this.HostVissza.UseVisualStyleBackColor = true;
            this.HostVissza.Click += new System.EventHandler(this.HostVissza_Click);
            // 
            // ipLabel3
            // 
            this.ipLabel3.AutoSize = true;
            this.ipLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel3.Location = new System.Drawing.Point(3, 0);
            this.ipLabel3.Name = "ipLabel3";
            this.ipLabel3.Size = new System.Drawing.Size(28, 20);
            this.ipLabel3.TabIndex = 0;
            this.ipLabel3.Text = "IP:";
            // 
            // rtbUzenetek
            // 
            this.rtbUzenetek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUzenetek.Location = new System.Drawing.Point(594, 12);
            this.rtbUzenetek.Name = "rtbUzenetek";
            this.rtbUzenetek.Size = new System.Drawing.Size(288, 126);
            this.rtbUzenetek.TabIndex = 5;
            this.rtbUzenetek.Text = "";
            // 
            // tbUzenet
            // 
            this.tbUzenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUzenet.Location = new System.Drawing.Point(594, 144);
            this.tbUzenet.Name = "tbUzenet";
            this.tbUzenet.Size = new System.Drawing.Size(175, 26);
            this.tbUzenet.TabIndex = 6;
            // 
            // Kuldes
            // 
            this.Kuldes.Location = new System.Drawing.Point(775, 144);
            this.Kuldes.Name = "Kuldes";
            this.Kuldes.Size = new System.Drawing.Size(107, 26);
            this.Kuldes.TabIndex = 7;
            this.Kuldes.Text = "Üzenet küldése";
            this.Kuldes.UseVisualStyleBackColor = true;
            // 
            // timerKliensKeres
            // 
            this.timerKliensKeres.Tick += new System.EventHandler(this.timerKliensKeres_Tick);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.Controls.Add(this.Kuldes);
            this.Controls.Add(this.tbUzenet);
            this.Controls.Add(this.rtbUzenetek);
            this.Controls.Add(this.HostPanel);
            this.Controls.Add(this.KliensPanel);
            this.Controls.Add(this.FoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_FormClosing);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.FoPanel.ResumeLayout(false);
            this.FoPanel.PerformLayout();
            this.KliensPanel.ResumeLayout(false);
            this.KliensPanel.PerformLayout();
            this.HostPanel.ResumeLayout(false);
            this.HostPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FoPanel;
        private System.Windows.Forms.Panel KliensPanel;
        private System.Windows.Forms.Panel HostPanel;
        private System.Windows.Forms.Label ipLabel1;
        private System.Windows.Forms.Button HostolasB;
        private System.Windows.Forms.Button CsatlakozasB;
        private System.Windows.Forms.Label AllapotLabel;
        private System.Windows.Forms.Label ipLabel2;
        private System.Windows.Forms.Button KliensVissza;
        private System.Windows.Forms.Button JoinB;
        private System.Windows.Forms.Button LetrehozasB;
        private System.Windows.Forms.Button HostVissza;
        private System.Windows.Forms.Label ipLabel3;
        private System.Windows.Forms.Button FomenuVissza;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.RichTextBox rtbUzenetek;
        private System.Windows.Forms.TextBox tbUzenet;
        private System.Windows.Forms.Button Kuldes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerKliensKeres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kliensNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostNev;
    }
}