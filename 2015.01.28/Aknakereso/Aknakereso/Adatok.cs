using System;
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

        private static int n = 10;
        private static int m = 10;
        private static int aknaszam = 5;
        public int ertek = 0;

        public static int N { get { return n; } set { n = value; } }
        public static int M { get { return m; } set { m = value; } }

        public Button[,] mezoGomb;
        public Button[,] fedoGomb;

        public void MezoGeneralas(Panel panel)
        {
            //n = (int)NumericUpDown1.value;

            mezoGomb = new Button[n, m];
            fedoGomb = new Button[n, m];
            int gombPozicioX = 0;
            int gombPozicioY = 0;
            //int ertek = 0;
            int aknadb = 0;
            


            for (int i = 0; i < n; i++)
            {       
                for (int j = 0; j < m; j++)
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
                int aknaX = veletlen.Next(0, n);
                int aknaY = veletlen.Next(0, m);
                
                if (mezoGomb[aknaX, aknaY].Text.Equals("0"))
                {
                    mezoGomb[aknaX, aknaY].Text = "-1";
                    ertek = -1;
                    aknadb++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ertekSzamol(i, j);
                }
            }
        }

        public void ertekSzamol(int i, int j)
        {
            if (!mezoGomb[i, j].Text.Equals("-1"))
            {
                if (j < m - 2 && mezoGomb[i, j + 1].Text.Equals("-1"))
                { //jobbra
                    ertek += 1;
                }
                if (i > 0 && j < m - 2 && mezoGomb[i - 1, j + 1].Text.Equals("-1"))
                { //felette jobbra
                    ertek += 1;
                }
                if (i < n - 2 && j > 0 && mezoGomb[i + 1, j - 1].Text.Equals("-1"))
                { //alatta balra
                    ertek += 1;
                }
                if (i < n - 2 && j < m - 2 && mezoGomb[i + 1, j + 1].Text.Equals("-1"))
                { //alatta jobbra
                    ertek += 1;
                }
                if (j > 0 && mezoGomb[i, j - 1].Text.Equals("-1"))
                { //balra
                    ertek += 1;
                }
                if (i > 0 && mezoGomb[i - 1, j].Text.Equals("-1"))
                { //felette
                    ertek += 1;
                }
                if (i > 0 && j > 0 && mezoGomb[i - 1, j - 1].Text.Equals("-1"))
                { //felette balra
                    ertek += 1;
                }
                if (i < n - 2 && mezoGomb[i + 1, j].Text.Equals("-1"))
                { //alatta
                    ertek += 1;
                }
            }

            else
            {
                ertek = -1;
            }

            mezoGomb[i, j].Text = ertek.ToString();
            ertek = 0;
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
