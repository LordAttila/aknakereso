using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Aknakereso
{
    public partial class JatekAblak : Form
    {
        private bool kilepesAMenube = false;
        
        //MI mezői
        private int kovetkezoMITalalat;

        public JatekAblak()
        {
            InitializeComponent();
            kovetkezoMITalalat = Adatok.VELETLEN.Next(1, Adatok.NEHEZSEGSZAZALEK);
            Adatok.PONTSZAM1 = 0;
            Adatok.PONTSZAM2 = 0;
        }

        private void MezoGeneralas()
        {
            Adatok.MEZOGOMBOK = new Button[Adatok.N, Adatok.M];
            Adatok.FEDOGOMBOK = new FedoGomb[Adatok.N, Adatok.M];

            int gombPozicioX = 0;
            int gombPozicioY = 0;
            int aknadb = 0;
            Adatok.AKNASZAM = (Adatok.N * Adatok.M) / 3;

            Adatok.AKNAKHELYE = new int[2, Adatok.AKNASZAM];

            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    gombPozicioY += 50;
                    Adatok.FEDOGOMBOK[i, j] = new FedoGomb(i, j, gombPozicioY, gombPozicioX);
                    Adatok.FEDOGOMBOK[i, j].Click += new EventHandler(fedoGombok_Click);
                    panel1.Controls.Add(Adatok.FEDOGOMBOK[i, j]);
                    Adatok.MEZOGOMBOK[i, j] = this.gombLetrehoz(gombPozicioX, gombPozicioY, Adatok.ERTEK);
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }

            while (aknadb < Adatok.AKNASZAM)
            {
                int aknaX = Adatok.VELETLEN.Next(0, Adatok.N);
                int aknaY = Adatok.VELETLEN.Next(0, Adatok.M);

                if (Adatok.MEZOGOMBOK[aknaX, aknaY].Text.Equals("0"))
                {
                    Adatok.MEZOGOMBOK[aknaX, aknaY].Text = "-1";
                    //mezoGombok[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.Akna, new Size(50, 50));
                    Adatok.AKNAKHELYE[0, aknadb] = aknaX;
                    Adatok.AKNAKHELYE[1, aknadb] = aknaY;
                    Adatok.ERTEK = -1;
                    aknadb++;
                }
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
                if (a < Adatok.N - 1 && b < Adatok.M - 2 && Adatok.MEZOGOMBOK[a + 1, b + 1].Text.Equals("-1"))
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
                }
                else
                {
                    Adatok.PONTSZAM2++;
                    Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].BackColor = Color.Red;
                    pontszam2L.BackColor = Color.Red;
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
            panel1.Width = Adatok.N * 50;
            panel1.Height = Adatok.M * 60;
            MezoGeneralas();
            AknaszamL.Text += Adatok.AKNASZAM.ToString();
        }

        private void JatekAblak_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kilepesAMenube)
            {
                Application.Exit();
            }
        }

        private void kilepesB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fedoGombok_Click(object sender, EventArgs e)
        {
            FedoGomb clickedButton = (FedoGomb)sender;
            clickedButton.Visible = false;
            pontSzamol(clickedButton);
            if (!Adatok.JATEKOS)
            {
                MI_Click();
            }
        }

        private void MI_Click()
        {
            if (kovetkezoMITalalat <= 0)
            {
                kovetkezoMITalalat = Adatok.VELETLEN.Next(1, Adatok.NEHEZSEGSZAZALEK);
                talalt();
            }
            else
            {
                kovetkezoMITalalat--;
                nemtalalt();
            }
        }

        private void talalt()
        {
            if (Adatok.PONTSZAM1 + Adatok.PONTSZAM2 != Adatok.AKNASZAM)
            {
                bool klikk = false;
                for (int i = 0; i < Adatok.AKNASZAM && !klikk; i++)
                {
                    if (Adatok.FEDOGOMBOK[Adatok.AKNAKHELYE[0, i], Adatok.AKNAKHELYE[1, i]].Visible)
                    {
                        fedoGombok_Click(Adatok.FEDOGOMBOK[Adatok.AKNAKHELYE[0, i], Adatok.AKNAKHELYE[1, i]], new EventArgs());
                        klikk = true;
                    }
                }
            }
        }

        private void nemtalalt()
        {
            bool klikk = false;
            if (Adatok.PONTSZAM1 + Adatok.PONTSZAM2 != Adatok.AKNASZAM)
            {
                while (!klikk)
                {
                    int x = Adatok.VELETLEN.Next(0, Adatok.N - 1);
                    int y = Adatok.VELETLEN.Next(0, Adatok.M - 1);
                    if (!Adatok.MEZOGOMBOK[x, y].Text.Equals("-1") && Adatok.FEDOGOMBOK[x, y].Visible)
                    {
                        fedoGombok_Click(Adatok.FEDOGOMBOK[x, y], new EventArgs());
                        klikk = true;
                    }
                }
            }
        }

        private String nyertes()
        {
            string s = "Gatulálok nyert ";
            if (Adatok.PONTSZAM1 > Adatok.PONTSZAM2)
            {
                s += "az 1-es játékos";
            }
            else
            {
                s += "a 2-es játékos";
            }
            return s;
        }

        private void KilepesMenu_Click(object sender, EventArgs e)
        {
            kilepesAMenube = true;
            (new Fomenu()).Show();
            this.Close();
        }

        public Button gombLetrehoz(int pozicioX, int pozicioY, int ertek)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = ertek.ToString();
            gomb.Location = new Point(pozicioX, pozicioY);
            panel1.Controls.Add(gomb);
            return gomb;
        }
    }
}