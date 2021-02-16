﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Aknakereso
{
    class Adatok
    {
        private static Random veletlen = new Random(DateTime.Now.Millisecond);

        private Label debugText;
        private static int n;
        private static int m;
        private static int aknaszam = 5;
        public int ertek = 0;
        private bool actJatekos = true;

        public static int N { get { return n; } set { n = value; } }
        public static int M { get { return m; } set { m = value; } }

        public Button[,] mezoGomb;
        public Button[,] fedoGomb;

        public Adatok(Label l) {
            this.debugText = l;
            debugText.Text = "";
        }

        public void MezoGeneralas(Panel panel)
        {
            mezoGomb = new Button[Adatok.N, Adatok.M];
            fedoGomb = new Button[Adatok.N, Adatok.M];
            int gombPozicioX = 0;
            int gombPozicioY = 0;
            int aknadb = 0;



            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    gombPozicioY += 50;
                    //fedoGomb[i, j] = fedoGombLetrehoz(gombPozicioX, gombPozicioY, panel);
                    mezoGomb[i, j] = gombLetrehoz(gombPozicioX, gombPozicioY, ertek, panel);
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }
            


            while (aknadb < aknaszam)
            {
                int aknaX = veletlen.Next(0, Adatok.N);
                int aknaY = veletlen.Next(0, Adatok.M);
                
                if (mezoGomb[aknaX, aknaY].Text.Equals("0"))
                {
                    mezoGomb[aknaX, aknaY].Text = "-1";
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

        public void ertekSzamol(int i, int j)
        {
            ertek = 0;
            if (!mezoGomb[i, j].Text.Equals("-1"))
            {
                debugText.Text += "i: " + i + ", j: " + j + ", ertekek: ";
                if (j < Adatok.M - 1 && mezoGomb[i, j + 1].Text.Equals("-1"))
                { //jobbra
                    ertek += 1;
                    debugText.Text += "1" + "-";
                }
                if (i > 0 && j < Adatok.M - 1 && mezoGomb[i - 1, j + 1].Text.Equals("-1"))
                { //felette jobbra
                    debugText.Text += "2" + "-";
                    ertek += 1;
                }
                if (i < Adatok.N - 1 && j > 0 && mezoGomb[i + 1, j - 1].Text.Equals("-1"))
                { //alatta balra
                    debugText.Text += "3" + "-";
                    ertek += 1;
                }
                if (i < Adatok.N - 1 && j < Adatok.M - 1 && mezoGomb[i + 1, j + 1].Text.Equals("-1"))
                { //alatta jobbra
                    debugText.Text += "4" + "-";
                    ertek += 1;
                }
                if (j > 0 && mezoGomb[i, j - 1].Text.Equals("-1"))
                { //balra
                    debugText.Text += "5" + "-";
                    ertek += 1;
                }
                if (i > 0 && mezoGomb[i - 1, j].Text.Equals("-1"))
                { //felette
                    debugText.Text += "6" + "-";
                    ertek += 1;
                }
                if (i > 0 && j > 0 && mezoGomb[i - 1, j - 1].Text.Equals("-1"))
                { //felette balra
                    debugText.Text += "7" + "-";
                    ertek += 1;
                }
                if (i < Adatok.N - 1 && mezoGomb[i + 1, j].Text.Equals("-1"))
                { //alatta
                    debugText.Text += "8" + "-";
                    ertek += 1;
                }
            }
            else
            {
                ertek = -1;
            }
            debugText.Text += "\r\n";
            mezoGomb[i, j].Text = ertek.ToString();
        }

        public Button gombLetrehoz(int pozicioX, int pozicioY, int ertek, Panel panel)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = ertek.ToString();
            gomb.Location = new Point(pozicioX, pozicioY);
            panel.Controls.Add(gomb);
            return gomb;
        }

        public Button fedoGombLetrehoz(int pozX, int pozY, Panel panel)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = "";
            gomb.Location = new Point(pozX, pozY);
            panel.Controls.Add(gomb);
            gomb.Click += new EventHandler(fedoGomb_Click);
            return gomb;
        }

        private void fedoGomb_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
        }
    }
}
