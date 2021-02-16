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

        private static int n = 15;
        private static int m = 15;
        private static int aknaszam = 5;
        public int ertek;

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
                    mezoGomb[i, j] = gombLetrehoz(gombPozicioX, gombPozicioY, ertek, panel); //ertekSzamol(i, j) ertek helyett
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

        public int ertekSzamol(int i, int j)
        {
            // i/j + akkor < n/m, i/j - akkor > n/m
            if (mezoGomb[i, j + 1].Text == "-1" && j<m){ //jobbra
                ertek += 1;
            } 
            else if (mezoGomb[i - 1, j + 1].Text == "-1" && i>1 && j<m){ //felette jobbra
                ertek += 1;            
            }
            else if (mezoGomb[i + 1, j - 1].Text == "-1" && i<1 && j<m){ //alatta balra
                ertek += 1; 
            }
            else if(mezoGomb[i + 1, j + 1].Text == "-1" && i<n && j<m){ //alatta jobbra
                ertek += 1; 
            }
            else if(mezoGomb[i, j - 1].Text == "-1" && j>m){ //balra
                ertek += 1;
            }
            else if(mezoGomb[i - 1, j].Text == "-1" && i>n){ //fele
                ertek += 1;
            }
            else if(mezoGomb[i - 1, j - 1].Text == "-1" && i>n && j>m){ //felette balra
                ertek += 1;
            }
            else if (mezoGomb[i + 1, j].Text == "-1"){ //alatta
                ertek += 1;
            }        
            return ertek;
        }
    }
}
