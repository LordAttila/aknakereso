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
        

        public Ablak1()
        {
            InitializeComponent();
            
        }

        private void Ablak1_Load(object sender, EventArgs e)
        {
            Adatok tabla = new Adatok();

            tabla.MezoGeneralas(panel1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // numericUpDown1.Value = 
        }
    }
}
