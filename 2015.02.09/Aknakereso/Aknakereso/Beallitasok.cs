﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aknakereso
{
    public partial class Beallitasok : Form
    {
        public Beallitasok()
        {
            InitializeComponent();
        }

        /*private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Adatok.N = (int)numericUpDownN.Value;
            Adatok.M = (int)numericUpDownM.Value;
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            tabla.MezoGeneralas(panel1);
            panel1.Width = Adatok.N * 50;
            panel1.Height = Adatok.M * 60;
        }*/

        private void Beallitasok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void visszaB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fomenu fomenu = new Fomenu();
            fomenu.Show();
        }
    }
}
