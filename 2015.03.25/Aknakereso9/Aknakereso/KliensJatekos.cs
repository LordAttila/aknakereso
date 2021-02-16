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
    public partial class KliensJatekos : Form
    {
        public KliensJatekos(byte[] adat)
        {
            InitializeComponent();
            AdatokFeldolgozasa(adat);
            mezoPanel.Width = Adatok.N * 50;
            mezoPanel.Height = Adatok.M * 50;
            AknaszamL.Text += Adatok.AKNASZAM.ToString();
            MezoGeneralas();
            kommunikacioTimer.Enabled = true;
            Adatok.JATEKOS = false;
        }

        private void AdatokFeldolgozasa(byte[] adat)
        {
            Adatok.N = (int)adat[0];
            Adatok.M = (int)adat[1];
            Adatok.AKNASZAM = (Adatok.N * Adatok.M) / 3;
            Adatok.AKNAKHELYE = new int[2, Adatok.AKNASZAM];
            for (int i = 0; i < Adatok.AKNASZAM; i++)
            {
                Adatok.AKNAKHELYE[0, i] = (int)adat[2 + (i * 2)];
                Adatok.AKNAKHELYE[1, i] = (int)adat[3 + (i * 2)];
            }
            //MessageBox.Show("N: " + Adatok.N + "\r\n" + "M: " + Adatok.M + "\r\n" + "Kódok: " + adat.Substring(4, adat.Length - 5));
            //játékos nevének kiolvasása itt
            List<char> jatekosnev = new List<char>();
            MessageBox.Show(adat[12 + (Adatok.AKNASZAM * 2)].ToString());
            for (int i = 0; adat[i + 2 + (Adatok.AKNASZAM * 2)] != 0; i++)
            {
                jatekosnev.Add((char)adat[i + 2 + (Adatok.AKNASZAM * 2)]);
            }
            Adatok.KETTESJATEKOSNEV = new String(jatekosnev.ToArray());
        }

        private void MezoGeneralas()
        {
            Adatok.MEZOGOMBOK = new Button[Adatok.N, Adatok.M];
            Adatok.FEDOGOMBOK = new FedoGomb[Adatok.N, Adatok.M];

            int gombPozicioX = 0;
            int gombPozicioY = 0;

            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    Adatok.FEDOGOMBOK[i, j] = new FedoGomb(i, j, gombPozicioY, gombPozicioX);
                    //Adatok.FEDOGOMBOK[i, j].Click += new EventHandler(fedoGombok_Click);
                    Adatok.FEDOGOMBOK[i, j].MouseUp += fedoGombok_MouseUp;
                    mezoPanel.Controls.Add(Adatok.FEDOGOMBOK[i, j]);
                    Adatok.MEZOGOMBOK[i, j] = this.gombLetrehoz(gombPozicioX, gombPozicioY, Adatok.ERTEK);
                    gombPozicioY += 50;
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }

            for (int i = 0; i < Adatok.AKNASZAM; i++)
            {
                Adatok.MEZOGOMBOK[Adatok.AKNAKHELYE[0, i], Adatok.AKNAKHELYE[1, i]].Text = "-1";
            }

            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
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

        public Button gombLetrehoz(int pozicioX, int pozicioY, int ertek)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = ertek.ToString();
            gomb.Location = new Point(pozicioX, pozicioY);
            mezoPanel.Controls.Add(gomb);
            return gomb;
        }

        private void uzenetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    byte[] data = new byte[256];
                    data = Encoding.UTF8.GetBytes("M#" + uzenetBox.Text);
                    Adatok.KAPCSOLAT.Send(data, data.Length, SocketFlags.None);
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

        private void kommunikacioTimer_Tick(object sender, EventArgs e)
        {
            if (Adatok.KAPCSOLAT.Available > 0)
            {
                byte[] data = new byte[256];
                int length = Adatok.KAPCSOLAT.Receive(data);// Üzenet fogadása
                string uzenet = Encoding.UTF8.GetString(data, 0, length);// Stringgé alakítás   
                if (uzenet.IndexOf("M#") == 0)
                {
                    uzenetek.Items.Add(Adatok.KETTESJATEKOSNEV + "> " + uzenet.Substring(2, uzenet.Length - 2) + "\r\n");
                }
                else if (uzenet.IndexOf("C#") == 0)
                {
                    masikKlikk(Int16.Parse(uzenet.Substring(2, 2)), Int16.Parse(uzenet.Substring(4, 2)));
                }
                //MessageBox.Show(uzenet);
            }
        }

        private void masikKlikk(int x, int y)
        {
            //MessageBox.Show(x.ToString() + " " + y.ToString());
            Adatok.FEDOGOMBOK[x, y].Visible = false;
            Adatok.JATEKOS = !Adatok.MEZOGOMBOK[x, y].Text.Equals("-1");
            if (!Adatok.JATEKOS)
            {
                Adatok.MEZOGOMBOK[x, y].BackColor = Color.Red;
            }
            //pontszám növelése stb...
        }

        private void klikkKüld(int x, int y)
        {
            byte[] data = new byte[256];
            data = Encoding.UTF8.GetBytes("C#" + x.ToString("D2") + y.ToString("D2"));
            Adatok.KAPCSOLAT.Send(data, data.Length, SocketFlags.None);
        }

        private void Kliens_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Adatok.KAPCSOLAT.Close();
        }

        private void kilepesB_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Adatok.KAPCSOLAT.Close();
        }

        private void KilepesMenu_Click(object sender, EventArgs e)
        {
            (new Fomenu()).Show();
            this.Hide();
        }

        private void fedoGombok_MouseUp(object sender, MouseEventArgs e)
        {
            FedoGomb kattintottGomb = (FedoGomb)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                kattintottGomb.Visible = false;
                pontSzamol(kattintottGomb);
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

        private void KliensJatekos_Load(object sender, EventArgs e)
        {
            player1L.Text = Adatok.JATEKOSNEV;
            player2L.Text = Adatok.KETTESJATEKOSNEV;
        }
    }
}
