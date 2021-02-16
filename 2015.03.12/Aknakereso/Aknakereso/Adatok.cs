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
        private static int n = 5;
        private static int m = 5;
        private static int aknaszam;
        private static int ertek;
        private static bool jatekos = true;
        private static int pontszam1;
        private static int pontszam2;
        private static int nehezsegSzazalek = 3;

        public static int N { get { return n; } set { n = value; } }
        public static int M { get { return m; } set { m = value; } }
        public static int AKNASZAM { get { return aknaszam; } set { aknaszam = value; } }
        public static int ERTEK { get { return ertek; } set { ertek = value; } }
        public static bool JATEKOS { get { return jatekos; } set { jatekos = value; } }
        public static int PONTSZAM1 { get { return pontszam1; } set { pontszam1 = value; } }
        public static int PONTSZAM2 { get { return pontszam2; } set { pontszam2 = value; } }
        public static Random VELETLEN { get { return veletlen; } set { veletlen = value; } }
        public static int NEHEZSEGSZAZALEK { get { return nehezsegSzazalek; } set { nehezsegSzazalek = value;} }

        public static Button gombLetrehoz(int pozicioX, int pozicioY, int ertek, Panel panel)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = ertek.ToString();
            gomb.Location = new Point(pozicioX, pozicioY);
            panel.Controls.Add(gomb);
            return gomb;
        }

        public void kilepes()
        {
            DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
