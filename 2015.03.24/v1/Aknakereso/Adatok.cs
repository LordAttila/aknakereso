using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;
using System.Net;

namespace Aknakereso
{
    class Adatok
    {
        /*------------------------------------------------------------------------------------------------------*/

        private static Random veletlen = new Random(DateTime.Now.Millisecond);
        private static int n = 5;
        private static int m = 5;
        private static int aknaszam;
        private static int ertek;
        private static bool jatekos = true;
        private static int pontszam1;
        private static int pontszam2;
        private static int nehezsegSzazalek = 3;
        private static int port = 12345;
        private static int[,] aknakHelye;
        private static String jatekosNev;
        private static Button[,] mezoGombok;
        private static FedoGomb[,] fedoGombok;
        private static Socket kliens;
        private static Socket kapcsolat;
        private static IPEndPoint vegpont;

        /*------------------------------------------------------------------------------------------------------*/

        public static int N { get { return n; } set { n = value; } }
        public static int M { get { return m; } set { m = value; } }
        public static int AKNASZAM { get { return aknaszam; } set { aknaszam = value; } }
        public static int ERTEK { get { return ertek; } set { ertek = value; } }
        public static bool JATEKOS { get { return jatekos; } set { jatekos = value; } }
        public static int PONTSZAM1 { get { return pontszam1; } set { pontszam1 = value; } }
        public static int PONTSZAM2 { get { return pontszam2; } set { pontszam2 = value; } }
        public static Random VELETLEN { get { return veletlen; } set { veletlen = value; } }
        public static int NEHEZSEGSZAZALEK { get { return nehezsegSzazalek; } set { nehezsegSzazalek = value;} }
        public static int PORT { get { return port; } }
        public static int[,] AKNAKHELYE { get { return aknakHelye; } set { aknakHelye = value;} }
        public static String JATEKOSNEV { get { return jatekosNev; } set { jatekosNev = value;} }
        public static Button[,] MEZOGOMBOK { get { return mezoGombok; } set { mezoGombok = value; } }
        public static FedoGomb[,] FEDOGOMBOK { get { return fedoGombok; } set { fedoGombok = value; } }
        public static Socket KLIENS { get { return kliens; } set { kliens = value;} }
        public static Socket KAPCSOLAT { get { return kapcsolat; } set { kapcsolat = value;} }
        public static IPEndPoint VEGPONT { get { return vegpont; } set { vegpont = value;} }

        /*------------------------------------------------------------------------------------------------------*/

        public void kilepes()
        {
            DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static Button gombLetrehoz(int pozicioX, int pozicioY, int ertek)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = ertek.ToString();
            gomb.Location = new Point(pozicioX, pozicioY);
            return gomb;
        }
    }
}
