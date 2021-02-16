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
    public partial class Varo : Form
    {
        List<Socket> clientList = new List<Socket>();

        public Varo()
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
            byte[] adat = Encoding.UTF8.GetBytes("" + Adatok.JATEKOSNEV + " ");
            Adatok.KAPCSOLAT.Send(adat, adat.Length, SocketFlags.None);
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
                Adatok.JATEKOSNEV = kliensNev.Text;
                MessageBox.Show("A választott név: " + Adatok.JATEKOSNEV);
                Adatok.KAPCSOLAT = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Adatok.VEGPONT = new IPEndPoint(ip, Adatok.PORT);
                Adatok.KAPCSOLAT.Connect(Adatok.VEGPONT);
                AllapotLabel.Text = "Csatlakozás állapota: Sikeres csatlakozás.";
                nevKuld();
                timerSzerverAdatFogad.Enabled = true;
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
            Adatok.JATEKOSNEV = hostNev.Text;
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
                Adatok.KAPCSOLAT = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(localIP, Adatok.PORT);
                Adatok.KAPCSOLAT.Bind(endPoint);
                Adatok.KAPCSOLAT.Listen(1);
                MessageBox.Show("Szerver elindult!");
                kliensKeresesTimer.Enabled = true;
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
            if (Adatok.KAPCSOLAT.Poll(0, SelectMode.SelectRead))
            {
                Adatok.KLIENS = Adatok.KAPCSOLAT.Accept();
                clientList.Add(Adatok.KLIENS);
                //kliensre várakozás megállítása
                kliensKeresesTimer.Enabled = false;
                timerKliensAdatFogad.Enabled = true;
            }
        }

        private void adatKuld(){ 
        }

        private void timerKliensAdatFogad_Tick(object sender, EventArgs e)
        {
            if (Adatok.KLIENS.Available > 0)  //Ha valaki küldött üzenetet
            {
                //ha a kliens küldi a nevét
                byte[] adat = new byte[256];
                int length = Adatok.KLIENS.Receive(adat);
                Adatok.KETTESJATEKOSNEV = Encoding.UTF8.GetString(adat, 0, length);
                MessageBox.Show("SIKER! " + Adatok.KETTESJATEKOSNEV + " kapcsolódott!");
                timerKliensAdatFogad.Enabled = false;
                palyaGeneral();
                //elküldeni a klinesnek a pálya adatait, az aknák helyzeteit és a nevet
                palyaElkuld();
                //átlépés a játékba, minden változó átadása
                (new SzerverJatekos()).Show();
                this.Hide();
            }
        }

        private void palyaElkuld()
        {
            List<byte> adatLista = new List<byte>();
            adatLista.Add((byte)Adatok.N);
            adatLista.Add((byte)Adatok.M);
            for (int i = 0; i < Adatok.AKNASZAM; i++)
            {
                adatLista.Add((byte)Adatok.AKNAKHELYE[0, i]);
                adatLista.Add((byte)Adatok.AKNAKHELYE[1, i]);
            }
            for (int i = 0; i < Adatok.JATEKOSNEV.Length; i++)
            {
                adatLista.Add((byte)Adatok.JATEKOSNEV[i]);
            }
            byte[] adat = adatLista.ToArray();
            Adatok.KLIENS.Send(adat, adat.Length, SocketFlags.None);
        }

        private void timerSzerverAdatFogad_Tick(object sender, EventArgs e)
        {
            if (Adatok.KAPCSOLAT.Available > 0)  //Ha valaki küldött üzenetet
            {
                byte[] adat = new byte[256];
                Adatok.KAPCSOLAT.Receive(adat);  //Üzenet fogadása
                //MessageBox.Show(uzenet);
                //átlápés a játékba :D
                timerSzerverAdatFogad.Enabled = false;
                (new KliensJatekos(adat)).Show();
                this.Hide();
            }
        }
    }
}