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
        private Adatok tabla;

        public Button[,] mezoGombok;
        public Button[,] fedoGombok;

        public JatekAblak()
        {
            InitializeComponent();
        }

        public void MezoGeneralas(Panel panel)
        {
            mezoGombok = new Button[Adatok.N, Adatok.M];
            fedoGombok = new Button[Adatok.N, Adatok.M];
            int gombPozicioX = 0;
            int gombPozicioY = 0;
            int aknadb = 0;
            Adatok.AKNASZAM = (Adatok.N * Adatok.M) / 3;


            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    gombPozicioY += 50;
                    fedoGombok[i, j] = Adatok.fedoGombokLetrehoz(gombPozicioX, gombPozicioY, panel);
                    mezoGombok[i, j] = Adatok.gombLetrehoz(gombPozicioX, gombPozicioY, Adatok.ERTEK, panel1);
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }

            while (aknadb + 1 < Adatok.AKNASZAM)
            {
                int aknaX = veletlen.Next(0, N);
                int aknaY = veletlen.Next(0, M);

                if (mezoGombok[aknaX, aknaY].Text.Equals("0"))
                {
                    mezoGombok[aknaX, aknaY].Text = "-1";
                    ertek = -1;
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

        public void ertekSzamol(int a, int b)
        {
            if (!mezoGombok[a, b].Text.Equals("-1"))
            {
                if (b < Adatok.M - 1 && mezoGombok[a, b + 1].Text.Equals("-1"))
                { //jobbra
                    ertek += 1;
                }
                if (a > 0 && b < Adatok.M - 1 && mezoGombok[a - 1, b + 1].Text.Equals("-1"))
                { //felette jobbra
                    ertek += 1;
                }
                if (a < Adatok.N - 1 && b > 0 && mezoGombok[a + 1, b - 1].Text.Equals("-1"))
                { //alatta balra
                    ertek += 1;
                }
                if (a < Adatok.N - 1 && b < Adatok.M - 2 && mezoGombok[a + 1, b + 1].Text.Equals("-1"))
                { //alatta jobbra
                    ertek += 1;
                }
                if (b > 0 && mezoGombok[a, b - 1].Text.Equals("-1"))
                { //balra
                    ertek += 1;
                }
                if (a > 0 && mezoGombok[a - 1, b].Text.Equals("-1"))
                { //felette
                    ertek += 1;
                }
                if (a > 0 && b > 0 && mezoGombok[a - 1, b - 1].Text.Equals("-1"))
                { //felette balra
                    ertek += 1;
                }
                if (a < Adatok.N - 1 && mezoGombok[a + 1, b].Text.Equals("-1"))
                { //alatta
                    ertek += 1;
                }
            }

            else
            {
                ertek = -1;
            }

            mezoGombok[a, b].Text = ertek.ToString();
            ertek = 0;
        }

        public void pontSzamol()
        {

            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    if (mezoGombok[i, j].Text.Equals("-1"))
                    {
                        if (jatekos)
                        {
                            if (mezoGombok[i, j].Text.Equals("-1"))
                            {
                                pontszam1++;
                                //.Text = pontszam1.ToString();
                            }

                        }
                        else if (!jatekos)
                        {
                            if (mezoGombok[i, j].Text.Equals("-1"))
                            {
                                pontszam2++;
                                //.Text = pontszam2.ToString();
                            }
                        }
                    }
                }
            }
            jatekos = !jatekos;
        }

        private void JatekAblak_Load(object sender, EventArgs e)
        {
            Adatok.N = (int)numericUpDown1.Value;
            Adatok.M = (int)numericUpDown2.Value;
            Adatok tabla = new Adatok();
            tabla.MezoGeneralas(panel1);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Adatok.N = (int)numericUpDown1.Value;
            Adatok.M = (int)numericUpDown2.Value;
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            tabla.MezoGeneralas(panel1);
            panel1.Width = Adatok.N * 50;
            panel1.Height = Adatok.M * 60;
        }

        private void JatekAblak_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kilepesB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
