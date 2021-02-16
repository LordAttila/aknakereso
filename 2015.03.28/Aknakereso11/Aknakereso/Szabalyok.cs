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
    public partial class Szabalyok : Form
    {
        public Szabalyok()
        {
            InitializeComponent();
        }

        private void visszaB_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Fomenu()).Show();
        }
    }
}
