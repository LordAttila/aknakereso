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
        private static Random veletlen = new Random();
        private static int n;
        private static int m;
        private static int aknaszam;
        private static int ertek;
        private static bool jatekos = true;
        private static int pontszam1;
        private static int pontszam2;

        public static int N { get { return n; } set { N = value; } }
        public static int M { get { return m; } set { M = value; } }
        public static int AKNASZAM { get { return aknaszam; } set { AKNASZAM = value; } }
        public static int ERTEK { get { return ertek; } set { ERTEK = value; } }
        public static bool JATEKOS { get { return jatekos; } set { JATEKOS = value; } }
        public static int PONTSZAM1 { get { return pontszam1; } set { PONTSZAM1 = value; } }
        public static int PONTSZAM2 { get { return pontszam2; } set { PONTSZAM2 = value; } }

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

        public Button fedoGombokLetrehoz(int pozX, int pozY, Panel panel)
        {
            Button gomb = new Button();
            gomb.Width = 50;
            gomb.Height = 50;
            gomb.Text = "";
            gomb.Location = new Point(pozX, pozY);
            panel.Controls.Add(gomb);
            gomb.Click += new EventHandler(fedoGombok_Click);
            return gomb;
        }

        private void fedoGombok_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
            
            pontSzamol();
        }

        public void kilepes()
        {
            DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void kiir(int ertek)
        {
            string s = "";
            s += ertek.ToString();
        }
    }
}
