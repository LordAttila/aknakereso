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
        private Adatok tabla;

        public Ablak1()
        {
            InitializeComponent();
            
        }

        private void Ablak1_Load(object sender, EventArgs e)
        {
            loadContent();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            loadContent();
        }
        private void loadContent()
        {
            Adatok.N = (int)numericUpDown1.Value;
            Adatok.M = (int)numericUpDown2.Value;
            tabla = new Adatok(label1);
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            tabla.MezoGeneralas(panel1);
        }
    }
}
