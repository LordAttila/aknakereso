using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                    Adatok.FEDOGOMBOK[i, j] = new FedoGomb(i, j, gombPozicioY, gombPozicioX);
                    Adatok.FEDOGOMBOK[i, j].MouseUp += fedoGombok_MouseUp;

                    mezoPanel.Controls.Add(Adatok.FEDOGOMBOK[i, j]);
                    Adatok.MEZOGOMBOK[i, j] = this.gombLetrehoz(gombPozicioX, gombPozicioY, Adatok.ERTEK);
                    gombPozicioY += 50;
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }

            this.Width = mezoPanel.Width + 200;
            this.Height = mezoPanel.Height + 100;

            while (aknadb < Adatok.AKNASZAM)
            {
                int aknaX = Adatok.VELETLEN.Next(0, Adatok.N);
                int aknaY = Adatok.VELETLEN.Next(0, Adatok.M);

                if (Adatok.MEZOGOMBOK[aknaX, aknaY].Text.Equals("0"))
                {
                    Adatok.MEZOGOMBOK[aknaX, aknaY].Text = "-1";
                    switch(Adatok.VELETLEN.Next(3)){
                        case 0:
                            Adatok.MEZOGOMBOK[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.AntiTankMine2, new Size(50, 50));
                            break;
                        case 1:
                            Adatok.MEZOGOMBOK[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.AntiPersonalMine, new Size(50, 50));
                            break;
                        case 2:
                            Adatok.MEZOGOMBOK[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.NavalMine, new Size(50, 50));
                            break;
                        default:
                            Adatok.MEZOGOMBOK[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.NavalMine, new Size(50, 50));
                            break;
                    }
                    Adatok.AKNAKHELYE[0, aknadb] = aknaX;
                    Adatok.AKNAKHELYE[1, aknadb] = aknaY;
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
            jatekVege();
        }

        private void JatekAblak_Load(object sender, EventArgs e)
        {
            mezoPanel.Width = Adatok.N * 50;
            mezoPanel.Height = Adatok.M * 50;
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

        private void fedoGombok_MouseUp(object sender, MouseEventArgs e)
        {
            FedoGomb kattintottGomb = (FedoGomb)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left && Adatok.JATEKOS)
            {
                kattintottGomb.Visible = false;
                pontSzamol(kattintottGomb);
                if (!Adatok.JATEKOS)
                {
                    MI_Click();
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

        private void MI_Click()
        {
            if(this.mezoPanel.Enabled){
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

        private bool vanMegUres() {
            bool vanUres = false;
            for (int i = 0; i < Adatok.N && !vanUres; i++)
            {
                for (int j = 0; j < Adatok.M && !vanUres; j++)
                {
                    vanUres = Adatok.FEDOGOMBOK[i, j].Visible && !Adatok.MEZOGOMBOK[i, j].Text.Equals("-1");
                }
            }
            return vanUres;
        }

        private void nemtalalt()
        {
            if (vanMegUres())
            {
                bool klikk = false;
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
            else {
                talalt();
            }
        }

        private void jatekVege()
        {
            if (Adatok.PONTSZAM1 + Adatok.PONTSZAM2 == Adatok.AKNASZAM){
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
            mezoPanel.Controls.Add(gomb);
            return gomb;
        }

        private void ujJatek_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Új játékot idnítasz?", "Kilépés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                kilepesAMenube = true;
                Adatok.JATEKOS = true;
                (new JatekAblak()).Show();
                this.Close();
            }
        }
    }
}