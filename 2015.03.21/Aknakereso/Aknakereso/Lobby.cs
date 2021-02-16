using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Aknakereso
{
    public partial class Lobby : Form
    {
        Socket client = null;
        List<Socket> clientList = new List<Socket>();
        private Socket kapcsolat = null;
        private IPEndPoint vegpont = null;

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

        private void nevKuld()
        {
            byte[] adat = Encoding.UTF8.GetBytes(Adatok.JATEKOSNEV);
            kapcsolat.Send(adat, adat.Length, SocketFlags.None);
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

        private void JoinB_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            try
            {
                kapcsolat = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                vegpont = new IPEndPoint(ip, Adatok.PORT);
                kapcsolat.Connect(vegpont);
                AllapotLabel.Text = "Csatlakozás állapota: Sikeres csatlakozás.";
                nevKuld();
            }
            catch (Exception ex)
            {
                AllapotLabel.Text = "Csatlakozás állapota: Hiba a csatlakozáskor! ";
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            IPHostEntry host;
            IPAddress localIP = null;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip;
                    break;
                }
            }

            ipLabel1.Text += localIP;
            ipLabel2.Text += localIP;
            ipLabel3.Text += localIP;
        }

        private void LetrehozasB_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            IPAddress localIP = null;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip;
                    break;
                }
            }

            try
            {
                kapcsolat = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(localIP, Adatok.PORT);
                kapcsolat.Bind(endPoint);
                kapcsolat.Listen(1);
                timerKliensKeres.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private void palyaGeneral() {
            Adatok.MEZOGOMBOK = new Button[Adatok.N, Adatok.M];
            Adatok.FEDOGOMBOK = new FedoGomb[Adatok.N, Adatok.M];

            int gombPozicioX = 0;
            int gombPozicioY = 0;
            int aknadb = 0;
            Adatok.AKNASZAM = (Adatok.N * Adatok.M) / 3;

            Adatok.AKNAKHELYE = new int[2, Adatok.AKNASZAM];

            for (int i = 0; i < Adatok.N; i++)
            {
                for (int j = 0; j < Adatok.M; j++)
                {
                    gombPozicioY += 50;
                    Adatok.FEDOGOMBOK[i, j] = new FedoGomb(i, j, gombPozicioY, gombPozicioX);
                    Adatok.MEZOGOMBOK[i, j] = Adatok.gombLetrehoz(gombPozicioX, gombPozicioY, Adatok.ERTEK);
                }
                gombPozicioX += 50;
                gombPozicioY = 0;
            }

            while (aknadb < Adatok.AKNASZAM)
            {
                int aknaX = Adatok.VELETLEN.Next(0, Adatok.N);
                int aknaY = Adatok.VELETLEN.Next(0, Adatok.M);

                if (Adatok.MEZOGOMBOK[aknaX, aknaY].Text.Equals("0"))
                {
                    Adatok.MEZOGOMBOK[aknaX, aknaY].Text = "-1";
                    //mezoGombok[aknaX, aknaY].BackgroundImage = new Bitmap(Aknakereso.Properties.Resources.Akna, new Size(50, 50));
                    Adatok.AKNAKHELYE[0, aknadb] = aknaX;
                    Adatok.AKNAKHELYE[1, aknadb] = aknaY;
                    Adatok.ERTEK = -1;
                    aknadb++;
                }
            }
        }


        private void timerKliensKeres_Tick(object sender, EventArgs e)
        {
            if (kapcsolat.Poll(0, SelectMode.SelectRead))
            {
                client = kapcsolat.Accept();
                clientList.Add(client);
                //kliensre várakozás megállítása
                timerKliensKeres.Enabled = false;
                //ha a kliens küldi a nevét
                byte[] data = new byte[256];
                int length = client.Receive(data);
                String clientName = Encoding.UTF8.GetString(data, 0, length);
                MessageBox.Show("SIKER! " + clientName + " kapcsolódott!");
                palyaGeneral();
                //elküldeni a klinesnek a pálya adatait, az aknák helyzeteit és a nevet
                /*byte[] adat = Encoding.UTF8.GetBytes(Adatok.JATEKOSNEV);
                kapcsolat.Send(adat, adat.Length, SocketFlags.None);*/

            }
        }

        private void adatKuld(){ 
        }
    }
}