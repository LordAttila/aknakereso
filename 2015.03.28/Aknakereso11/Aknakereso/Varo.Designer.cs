namespace Aknakereso
{
    partial class Varo
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
            this.kliensKeresesTimer = new System.Windows.Forms.Timer(this.components);
            this.timerKliensAdatFogad = new System.Windows.Forms.Timer(this.components);
            this.timerSzerverAdatFogad = new System.Windows.Forms.Timer(this.components);
            this.FoPanel.SuspendLayout();
            this.KliensPanel.SuspendLayout();
            this.HostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoPanel
            // 
            this.FoPanel.BackColor = System.Drawing.Color.Transparent;
            this.FoPanel.Controls.Add(this.FomenuVissza);
            this.FoPanel.Controls.Add(this.ipLabel1);
            this.FoPanel.Controls.Add(this.HostolasB);
            this.FoPanel.Controls.Add(this.CsatlakozasB);
            this.FoPanel.Location = new System.Drawing.Point(12, 12);
            this.FoPanel.Name = "FoPanel";
            this.FoPanel.Size = new System.Drawing.Size(680, 370);
            this.FoPanel.TabIndex = 2;
            // 
            // FomenuVissza
            // 
            this.FomenuVissza.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.FomenuVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FomenuVissza.Location = new System.Drawing.Point(3, 340);
            this.FomenuVissza.Name = "FomenuVissza";
            this.FomenuVissza.Size = new System.Drawing.Size(141, 27);
            this.FomenuVissza.TabIndex = 3;
            this.FomenuVissza.Text = "Vissza a főmenübe";
            this.FomenuVissza.UseVisualStyleBackColor = false;
            this.FomenuVissza.Click += new System.EventHandler(this.FomenuVissza_Click);
            // 
            // ipLabel1
            // 
            this.ipLabel1.AutoSize = true;
            this.ipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel1.ForeColor = System.Drawing.Color.White;
            this.ipLabel1.Location = new System.Drawing.Point(3, 3);
            this.ipLabel1.Name = "ipLabel1";
            this.ipLabel1.Size = new System.Drawing.Size(37, 25);
            this.ipLabel1.TabIndex = 2;
            this.ipLabel1.Text = "IP:";
            // 
            // HostolasB
            // 
            this.HostolasB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HostolasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostolasB.Location = new System.Drawing.Point(14, 150);
            this.HostolasB.Name = "HostolasB";
            this.HostolasB.Size = new System.Drawing.Size(104, 27);
            this.HostolasB.TabIndex = 1;
            this.HostolasB.Text = "Létrehozás";
            this.HostolasB.UseVisualStyleBackColor = false;
            this.HostolasB.Click += new System.EventHandler(this.HostolasB_Click);
            // 
            // CsatlakozasB
            // 
            this.CsatlakozasB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CsatlakozasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsatlakozasB.Location = new System.Drawing.Point(14, 77);
            this.CsatlakozasB.Name = "CsatlakozasB";
            this.CsatlakozasB.Size = new System.Drawing.Size(104, 27);
            this.CsatlakozasB.TabIndex = 0;
            this.CsatlakozasB.Text = "Csatlakozás";
            this.CsatlakozasB.UseVisualStyleBackColor = false;
            this.CsatlakozasB.Click += new System.EventHandler(this.CsatlakozasB_Click);
            // 
            // KliensPanel
            // 
            this.KliensPanel.BackColor = System.Drawing.Color.Transparent;
            this.KliensPanel.Controls.Add(this.label2);
            this.KliensPanel.Controls.Add(this.kliensNev);
            this.KliensPanel.Controls.Add(this.label1);
            this.KliensPanel.Controls.Add(this.tbIP);
            this.KliensPanel.Controls.Add(this.AllapotLabel);
            this.KliensPanel.Controls.Add(this.ipLabel2);
            this.KliensPanel.Controls.Add(this.KliensVissza);
            this.KliensPanel.Controls.Add(this.JoinB);
            this.KliensPanel.Location = new System.Drawing.Point(710, 12);
            this.KliensPanel.Name = "KliensPanel";
            this.KliensPanel.Size = new System.Drawing.Size(680, 370);
            this.KliensPanel.TabIndex = 3;
            this.KliensPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név:";
            // 
            // kliensNev
            // 
            this.kliensNev.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kliensNev.Location = new System.Drawing.Point(538, 43);
            this.kliensNev.MaxLength = 50;
            this.kliensNev.Name = "kliensNev";
            this.kliensNev.Size = new System.Drawing.Size(100, 20);
            this.kliensNev.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP cím:";
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbIP.Location = new System.Drawing.Point(538, 17);
            this.tbIP.MaxLength = 15;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 5;
            // 
            // AllapotLabel
            // 
            this.AllapotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllapotLabel.ForeColor = System.Drawing.Color.White;
            this.AllapotLabel.Location = new System.Drawing.Point(113, 340);
            this.AllapotLabel.Name = "AllapotLabel";
            this.AllapotLabel.Size = new System.Drawing.Size(412, 27);
            this.AllapotLabel.TabIndex = 4;
            this.AllapotLabel.Text = "Csatlakozás állapota:";
            // 
            // ipLabel2
            // 
            this.ipLabel2.AutoSize = true;
            this.ipLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel2.ForeColor = System.Drawing.Color.White;
            this.ipLabel2.Location = new System.Drawing.Point(3, 0);
            this.ipLabel2.Name = "ipLabel2";
            this.ipLabel2.Size = new System.Drawing.Size(37, 25);
            this.ipLabel2.TabIndex = 2;
            this.ipLabel2.Text = "IP:";
            // 
            // KliensVissza
            // 
            this.KliensVissza.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.KliensVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KliensVissza.Location = new System.Drawing.Point(7, 344);
            this.KliensVissza.Name = "KliensVissza";
            this.KliensVissza.Size = new System.Drawing.Size(75, 23);
            this.KliensVissza.TabIndex = 1;
            this.KliensVissza.Text = "Vissza";
            this.KliensVissza.UseVisualStyleBackColor = false;
            this.KliensVissza.Click += new System.EventHandler(this.CsatlakozasVissza_Click);
            // 
            // JoinB
            // 
            this.JoinB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.JoinB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinB.Location = new System.Drawing.Point(529, 79);
            this.JoinB.Name = "JoinB";
            this.JoinB.Size = new System.Drawing.Size(120, 30);
            this.JoinB.TabIndex = 0;
            this.JoinB.Text = "Csatlakozás";
            this.JoinB.UseVisualStyleBackColor = false;
            this.JoinB.Click += new System.EventHandler(this.JoinB_Click);
            // 
            // HostPanel
            // 
            this.HostPanel.BackColor = System.Drawing.Color.Transparent;
            this.HostPanel.Controls.Add(this.label3);
            this.HostPanel.Controls.Add(this.hostNev);
            this.HostPanel.Controls.Add(this.LetrehozasB);
            this.HostPanel.Controls.Add(this.HostVissza);
            this.HostPanel.Controls.Add(this.ipLabel3);
            this.HostPanel.Location = new System.Drawing.Point(12, 404);
            this.HostPanel.Name = "HostPanel";
            this.HostPanel.Size = new System.Drawing.Size(680, 370);
            this.HostPanel.TabIndex = 4;
            this.HostPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Név:";
            // 
            // hostNev
            // 
            this.hostNev.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.hostNev.Location = new System.Drawing.Point(561, 14);
            this.hostNev.MaxLength = 50;
            this.hostNev.Name = "hostNev";
            this.hostNev.Size = new System.Drawing.Size(100, 20);
            this.hostNev.TabIndex = 10;
            // 
            // LetrehozasB
            // 
            this.LetrehozasB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LetrehozasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetrehozasB.Location = new System.Drawing.Point(261, 330);
            this.LetrehozasB.Name = "LetrehozasB";
            this.LetrehozasB.Size = new System.Drawing.Size(216, 37);
            this.LetrehozasB.TabIndex = 2;
            this.LetrehozasB.Text = "Szoba létrehozása";
            this.LetrehozasB.UseVisualStyleBackColor = false;
            this.LetrehozasB.Click += new System.EventHandler(this.LetrehozasB_Click);
            // 
            // HostVissza
            // 
            this.HostVissza.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HostVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostVissza.Location = new System.Drawing.Point(7, 340);
            this.HostVissza.Name = "HostVissza";
            this.HostVissza.Size = new System.Drawing.Size(75, 23);
            this.HostVissza.TabIndex = 1;
            this.HostVissza.Text = "Vissza";
            this.HostVissza.UseVisualStyleBackColor = false;
            this.HostVissza.Click += new System.EventHandler(this.HostVissza_Click);
            // 
            // ipLabel3
            // 
            this.ipLabel3.AutoSize = true;
            this.ipLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel3.ForeColor = System.Drawing.Color.White;
            this.ipLabel3.Location = new System.Drawing.Point(3, 0);
            this.ipLabel3.Name = "ipLabel3";
            this.ipLabel3.Size = new System.Drawing.Size(37, 25);
            this.ipLabel3.TabIndex = 0;
            this.ipLabel3.Text = "IP:";
            // 
            // kliensKeresesTimer
            // 
            this.kliensKeresesTimer.Tick += new System.EventHandler(this.timerKliensKeres_Tick);
            // 
            // timerKliensAdatFogad
            // 
            this.timerKliensAdatFogad.Tick += new System.EventHandler(this.timerKliensAdatFogad_Tick);
            // 
            // timerSzerverAdatFogad
            // 
            this.timerSzerverAdatFogad.Tick += new System.EventHandler(this.timerSzerverAdatFogad_Tick);
            // 
            // Varo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aknakereso.Properties.Resources.Varo;
            this.ClientSize = new System.Drawing.Size(701, 393);
            this.Controls.Add(this.HostPanel);
            this.Controls.Add(this.KliensPanel);
            this.Controls.Add(this.FoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Varo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Váró";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_FormClosing);
            this.Load += new System.EventHandler(this.Lobby_Load);
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
        private System.Windows.Forms.Label ipLabel2;
        private System.Windows.Forms.Button KliensVissza;
        private System.Windows.Forms.Button JoinB;
        private System.Windows.Forms.Button LetrehozasB;
        private System.Windows.Forms.Button HostVissza;
        private System.Windows.Forms.Label ipLabel3;
        private System.Windows.Forms.Button FomenuVissza;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer kliensKeresesTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kliensNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostNev;
        private System.Windows.Forms.Timer timerKliensAdatFogad;
        private System.Windows.Forms.Timer timerSzerverAdatFogad;
    }
}