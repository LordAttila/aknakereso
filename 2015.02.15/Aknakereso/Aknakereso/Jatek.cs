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

        public JatekAblak()
        {
            InitializeComponent();
        }

        private void JatekAblak_Load(object sender, EventArgs e)
        {
            Adatok.N = (int)numericUpDown1.Value;
            Adatok.M = (int)numericUpDown2.Value;
            Adatok tabla = new Adatok(pontszam1L, pontszam2L);
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
            /*DialogResult uzenet = MessageBox.Show("Bizosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo);
            if (uzenet == DialogResult.Yes)
            {
                Application.Exit();
            }*/
            Application.Exit();
        }
    }
}
