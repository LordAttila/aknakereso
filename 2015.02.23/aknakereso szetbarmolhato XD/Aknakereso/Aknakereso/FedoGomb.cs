using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aknakereso
{
    class FedoGomb : Button
    {
        private int pozicioX, pozicioY;
        private int szelesseg, magassag = 50;

        public FedoGomb(int pozicioX, int pozicioY)
        {
            this.pozicioX = pozicioX;
            this.pozicioY = pozicioY;
        }
    }
}
