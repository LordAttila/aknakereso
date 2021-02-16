using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Aknakereso
{
    public partial class SzerverJatekos : Form
    {
        public SzerverJatekos()
        {
            InitializeComponent();
            MezoGeneralas();
            this.AknaszamL.Text += Adatok.AKNASZAM.ToString();
            kommunikacioTimer.Enabled = true;
            this.Width = mezoPanel.Width + 350;
            megtalaltAknakL.Text = "Meg nem talált aknák száma: " + (Adatok.AKNASZAM - (Adatok.PONTSZAM1 + Adatok.PONTSZAM2)).ToString("D2");
        }

        private void MezoGeneralas()
        {
            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    Adatok.FEDOGOMBOK[i, j].MouseUp += fedoGombok_MouseUp;
                    mezoPanel.Controls.Add(Adatok.FEDOGOMBOK[i, j]);
                    mezoPanel.Controls.Add(Adatok.MEZOGOMBOK[i, j]);
                    ertekSzamol(i, j);
                }
            }
        }

        private void ertekSzamol(int a, int b)
        {
            if (!Adatok.MEZOGOMBOK[a, b].Text.Equals("-1"))
            {
                if (b < Adatok.M - 1 && Adatok.MEZOGOMBOK[a, b + 1].Text.Equals("-1"))
                { //jobbra
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && b < Adatok.M - 1 && Adatok.MEZOGOMBOK[a - 1, b + 1].Text.Equals("-1"))
                { //felette jobbra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && b > 0 && Adatok.MEZOGOMBOK[a + 1, b - 1].Text.Equals("-1"))
                { //alatta balra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && b < Adatok.M - 1 && Adatok.MEZOGOMBOK[a + 1, b + 1].Text.Equals("-1"))
                { //alatta jobbra
                    Adatok.ERTEK += 1;
                }
                if (b > 0 && Adatok.MEZOGOMBOK[a, b - 1].Text.Equals("-1"))
                { //balra
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && Adatok.MEZOGOMBOK[a - 1, b].Text.Equals("-1"))
                { //felette
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && b > 0 && Adatok.MEZOGOMBOK[a - 1, b - 1].Text.Equals("-1"))
                { //felette balra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && Adatok.MEZOGOMBOK[a + 1, b].Text.Equals("-1"))
                { //alatta
                    Adatok.ERTEK += 1;
                }
            }

            else
            {
                Adatok.ERTEK = -1;
            }

            Adatok.MEZOGOMBOK[a, b].Text = Adatok.ERTEK.ToString();
            Adatok.ERTEK = 0;
        }

        private void pontSzamol(FedoGomb aktualisGomb)
        {
            if (Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].Text.Equals("-1"))
            {
                if (Adatok.JATEKOS)
                {
                    Adatok.PONTSZAM1++;
                    Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].BackColor = Color.Blue;
                    pontszam1L.BackColor = Color.Blue;
                    pontszam2L.BackColor = Color.Transparent;
                }
                else
                {
                    Adatok.PONTSZAM2++;
                    Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].BackColor = Color.Red;
                    pontszam2L.BackColor = Color.Red;
                    pontszam1L.BackColor = Color.Transparent;
                }
            }
            else if (!Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].Text.Equals("-1"))
            {
                if (Adatok.JATEKOS)
                {
                    Adatok.JATEKOS = false;
                    pontszam1L.BackColor = Color.Transparent;
                    pontszam2L.BackColor = Color.Red;
                }
                else
                {
                    Adatok.JATEKOS = true;
                    pontszam2L.BackColor = Color.Transparent;
                    pontszam1L.BackColor = Color.Blue;
                }
            }
            pontszam1L.Text = Adatok.PONTSZAM1 + " p";
            pontszam2L.Text = Adatok.PONTSZAM2 + " p";
        }

        private void JatekAblak_Load(object sender, EventArgs e)
        {
            mezoPanel.Width = Adatok.N * 50;
            mezoPanel.Height = Adatok.M * 50;
            MezoGeneralas();
            AknaszamL.Text += Adatok.AKNASZAM.ToString();
        }

        private void fedoGombok_Click(object sender, EventArgs e)
        {
            if (Adatok.JATEKOS)
            {
                FedoGomb clickedButton = (FedoGomb)sender;
                clickedButton.Visible = false;
                pontSzamol(clickedButton);
                klikkKüld(clickedButton.INDEX_X, clickedButton.INDEX_Y);
            }
        }

        private void uzenetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    byte[] data = new byte[256];
                    data = Encoding.UTF8.GetBytes("M#" + uzenetBox.Text);
                    Adatok.KLIENS.Send(data, data.Length, SocketFlags.None);
                    uzenetek.Items.Add(Adatok.JATEKOSNEV + "> " + uzenetBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace.ToString());
                    uzenetek.Items.Add("Sikertelen üzenetküldés!");
                }
                uzenetBox.Text = "";
            }
        }

        private void timerKommunikacio_Tick(object sender, EventArgs e)
        {
            if (Adatok.KLIENS.Available > 0)
            {
                byte[] data = new byte[256];
                int length = Adatok.KLIENS.Receive(data);
                string uzenet = Encoding.UTF8.GetString(data, 0, length);  
                if (uzenet.IndexOf("M#") == 0)
                {
                    uzenetek.Items.Add(Adatok.KETTESJATEKOSNEV + "> " + uzenet.Substring(2, uzenet.Length - 2) + "\r\n");
                }
                else if (uzenet.IndexOf("C#") == 0)
                {
                    //MessageBox.Show(uzenet);
                    masikKlikk(Int16.Parse(uzenet.Substring(2, 2)), Int16.Parse(uzenet.Substring(4, 2)));
                }
            }
        }

        private void masikKlikk(int x, int y) {
            Adatok.FEDOGOMBOK[x, y].Visible = false;
            Adatok.JATEKOS = !Adatok.MEZOGOMBOK[x, y].Text.Equals("-1");
            //pontszám növelése stb...
            if (Adatok.MEZOGOMBOK[x, y].Text.Equals("-1"))
            {
                Adatok.MEZOGOMBOK[x, y].BackColor = Color.Red;
                Adatok.PONTSZAM2++;
                this.pontszam1L.BackColor = Color.Transparent;
                this.pontszam2L.BackColor = Color.Red;
            }
            else
            {
                this.pontszam1L.BackColor = Color.Blue;
                this.pontszam2L.BackColor = Color.Transparent;
            }
            this.pontszam1L.Text = Adatok.PONTSZAM1.ToString() + " p";
            this.pontszam2L.Text = Adatok.PONTSZAM2.ToString() + " p";
            megtalaltAknakL.Text = "Meg nem talált aknák száma: " + (Adatok.AKNASZAM - (Adatok.PONTSZAM1 + Adatok.PONTSZAM2)).ToString("D2");
            jatekVege();
        }

        private void klikkKüld(int x, int y) {
            byte[] data = new byte[256];
            data = Encoding.UTF8.GetBytes("C#" + x.ToString("D2") + y.ToString("D2"));
            Adatok.KLIENS.Send(data, data.Length, SocketFlags.None);
        }

        private void KilepesMenu_Click(object sender, EventArgs e)
        {
            (new Fomenu()).Show();
            this.Hide();
            Adatok.KAPCSOLAT.Close();
        }

        private void kilepesB_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Adatok.KAPCSOLAT.Close();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Adatok.KAPCSOLAT.Close();
        }

        private void SzerverJatekos_Load(object sender, EventArgs e)
        {
            player1L.Text = Adatok.JATEKOSNEV;
            player2L.Text = Adatok.KETTESJATEKOSNEV;
        }

        private void fedoGombok_MouseUp(object sender, MouseEventArgs e)
        {
            FedoGomb kattintottGomb = (FedoGomb)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if(Adatok.JATEKOS){
                    kattintottGomb.Visible = false;
                    pontSzamol(kattintottGomb);
                    klikkKüld(kattintottGomb.INDEX_X, kattintottGomb.INDEX_Y);
                    megtalaltAknakL.Text = "Meg nem talált aknák száma: " + (Adatok.AKNASZAM - (Adatok.PONTSZAM1 + Adatok.PONTSZAM2)).ToString("D2");
                }
            }

            else if (e.Button == System.Windows.Forms.MouseButtons.Right && kattintottGomb.Text.Equals(""))
            {
                kattintottGomb.Text = "X";
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right && kattintottGomb.Text.Equals("X"))
            {
                kattintottGomb.Text = "";
            }
        }

        private void jatekVege()
        {
            if (Adatok.PONTSZAM1 + Adatok.PONTSZAM2 == Adatok.AKNASZAM)
            {
                string s = "";
                if (Adatok.PONTSZAM1 > Adatok.PONTSZAM2)
                {
                    s += "Nyert az 1-es játékos.";
                }
                else if (Adatok.PONTSZAM1 < Adatok.PONTSZAM2)
                {
                    s += "Nyert a 2-es játékos.";
                }
                else
                {
                    s += "A meccs döntetlenre végződött.";
                }
                this.mezoPanel.Enabled = false;
                MessageBox.Show(s);
            }
        }
    }
}
