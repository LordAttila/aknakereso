using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Aknakereso
{
    public partial class SzerverJatekos : Form
    {
        public SzerverJatekos()
        {
            InitializeComponent();
            MezoGeneralas();
            timerKommunikacio.Enabled = true;
        }

        private void MezoGeneralas()
        {
            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    Adatok.FEDOGOMBOK[i, j].Click += new EventHandler(fedoGombok_Click);
                    panel1.Controls.Add(Adatok.FEDOGOMBOK[i, j]);
                    panel1.Controls.Add(Adatok.MEZOGOMBOK[i, j]);
                    ertekSzamol(i, j);
                }
            }
        }

        private void ertekSzamol(int a, int b)
        {
            if (!Adatok.MEZOGOMBOK[a, b].Text.Equals("-1"))
            {
                if (b < Adatok.M - 1 && Adatok.MEZOGOMBOK[a, b + 1].Text.Equals("-1"))
                { //jobbra
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && b < Adatok.M - 1 && Adatok.MEZOGOMBOK[a - 1, b + 1].Text.Equals("-1"))
                { //felette jobbra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && b > 0 && Adatok.MEZOGOMBOK[a + 1, b - 1].Text.Equals("-1"))
                { //alatta balra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && b < Adatok.M - 2 && Adatok.MEZOGOMBOK[a + 1, b + 1].Text.Equals("-1"))
                { //alatta jobbra
                    Adatok.ERTEK += 1;
                }
                if (b > 0 && Adatok.MEZOGOMBOK[a, b - 1].Text.Equals("-1"))
                { //balra
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && Adatok.MEZOGOMBOK[a - 1, b].Text.Equals("-1"))
                { //felette
                    Adatok.ERTEK += 1;
                }
                if (a > 0 && b > 0 && Adatok.MEZOGOMBOK[a - 1, b - 1].Text.Equals("-1"))
                { //felette balra
                    Adatok.ERTEK += 1;
                }
                if (a < Adatok.N - 1 && Adatok.MEZOGOMBOK[a + 1, b].Text.Equals("-1"))
                { //alatta
                    Adatok.ERTEK += 1;
                }
            }

            else
            {
                Adatok.ERTEK = -1;
            }

            Adatok.MEZOGOMBOK[a, b].Text = Adatok.ERTEK.ToString();
            Adatok.ERTEK = 0;
        }

        private void pontSzamol(FedoGomb aktualisGomb)
        {
            if (Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].Text.Equals("-1"))
            {
                if (Adatok.JATEKOS)
                {
                    Adatok.PONTSZAM1++;
                    Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].BackColor = Color.Blue;
                    pontszam1L.BackColor = Color.Blue;
                }
                else
                {
                    Adatok.PONTSZAM2++;
                    Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].BackColor = Color.Red;
                    pontszam2L.BackColor = Color.Red;
                }
            }
            else if (!Adatok.MEZOGOMBOK[aktualisGomb.INDEX_X, aktualisGomb.INDEX_Y].Text.Equals("-1"))
            {
                if (Adatok.JATEKOS)
                {
                    Adatok.JATEKOS = false;
                    pontszam1L.BackColor = Color.Transparent;
                    pontszam2L.BackColor = Color.Red;
                }
                else
                {
                    Adatok.JATEKOS = true;
                    pontszam2L.BackColor = Color.Transparent;
                    pontszam1L.BackColor = Color.Blue;
                }
            }
            pontszam1L.Text = Adatok.PONTSZAM1 + " p";
            pontszam2L.Text = Adatok.PONTSZAM2 + " p";
        }

        private void JatekAblak_Load(object sender, EventArgs e)
        {
            panel1.Width = Adatok.N * 50;
            panel1.Height = Adatok.M * 60;
            MezoGeneralas();
            AknaszamL.Text += Adatok.AKNASZAM.ToString();
        }

        private void fedoGombok_Click(object sender, EventArgs e)
        {
            if (Adatok.JATEKOS)
            {
                FedoGomb clickedButton = (FedoGomb)sender;
                clickedButton.Visible = false;
                pontSzamol(clickedButton);
                klikkKüld(clickedButton.INDEX_X, clickedButton.INDEX_Y);
            }
        }

        private void uzenetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    byte[] data = new byte[256];
                    data = Encoding.UTF8.GetBytes("M#" + uzenetBox.Text);
                    Adatok.KLIENS.Send(data, data.Length, SocketFlags.None);
                    uzenetek.Items.Add("ÉN> " + uzenetBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace.ToString());
                    uzenetek.Items.Add("Sikertelen üzenetküldés!");
                }
                uzenetBox.Text = "";
            }
        }

        private void timerKommunikacio_Tick(object sender, EventArgs e)
        {
            if (Adatok.KLIENS.Available > 0)
            {
                byte[] data = new byte[256];
                int length = Adatok.KLIENS.Receive(data);  // Üzeneet fogadása
                string uzenet = Encoding.UTF8.GetString(data, 0, length);  // Stringgé alakítás   
                if (uzenet.IndexOf("M#") == 0)
                {
                    uzenetek.Items.Add("MÁSIK> " + uzenet.Substring(2, uzenet.Length - 2) + "\r\n");
                }
                else if (uzenet.IndexOf("C#") == 0)
                {
                    masikKlikk(Int16.Parse(uzenet.Substring(2, 2)), Int16.Parse(uzenet.Substring(4, 2)));
                }
                //MessageBox.Show(uzenet);
            }
        }

        private void masikKlikk(int x, int y) {
            //MessageBox.Show(x.ToString() + " " + y.ToString());
            Adatok.FEDOGOMBOK[x, y].Visible = false;
            Adatok.JATEKOS = !Adatok.MEZOGOMBOK[x, y].Text.Equals("-1");
            if (!Adatok.JATEKOS)
            {
                Adatok.MEZOGOMBOK[x, y].BackColor = Color.Red;
            }
            //pontszám növelése stb...
        }

        private void klikkKüld(int x, int y) {
            byte[] data = new byte[256];
            data = Encoding.UTF8.GetBytes("C#" + x.ToString("D2") + y.ToString("D2"));
            Adatok.KLIENS.Send(data, data.Length, SocketFlags.None);
        }
    }
}
