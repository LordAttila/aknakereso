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
    public partial class Fomenu : Form
    {

        Adatok adatok;

        public Fomenu()
        {
            InitializeComponent();
        }

        private void egyjatekosB_Click(object sender, EventArgs e)
        {
            this.Hide();
            JatekAblak Jatek = new JatekAblak();
            Jatek.Show();

        }

        private void Fomenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                //Application.Exit();
                adatok.kilepes();
            }*/
            Application.Exit();
        }

        private void beallitasokB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beallitasok beallitasok = new Beallitasok();
            beallitasok.Show();
        }

        private void kilepesB_Click(object sender, EventArgs e)
        {
            /*DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                Application.Exit();
            }*/
            //adatok.kilepes();
            Application.Exit();
        }
    }
}
