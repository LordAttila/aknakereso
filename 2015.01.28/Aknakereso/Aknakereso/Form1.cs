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
    public partial class Ablak1 : Form
    {
        private Adatok tabla = new Adatok();

        public Ablak1()
        {
            InitializeComponent();
            
        }

        private void Ablak1_Load(object sender, EventArgs e)
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
            tabla.MezoGeneralas(panel1);
        }

    }
}
