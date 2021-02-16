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
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            FoPanel.Top = 10;
            FoPanel.Left = 10;
            KliensPanel.Top = 10;
            KliensPanel.Left = 10;
            HostPanel.Top = 10;
            HostPanel.Left = 10;


        }

        private void CsatlakozasB_Click(object sender, EventArgs e)
        {
            FoPanel.Visible = false;
            KliensPanel.Visible = true;
        }

        private void HostolasB_Click(object sender, EventArgs e)
        {
            FoPanel.Visible = false;
            HostPanel.Visible = true;
        }

        private void CsatlakozasVissza_Click(object sender, EventArgs e)
        {
            KliensPanel.Visible = false;
            FoPanel.Visible = true;
        }

        private void HostVissza_Click(object sender, EventArgs e)
        {
            HostPanel.Visible = false;
            FoPanel.Visible = true;
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FomenuVissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Fomenu()).Show();
        }
    }
}
