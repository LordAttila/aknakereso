using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aknakereso
{
    class FedoGomb : Button
    {
        private int indexX, indexY;

        public int INDEX_X { get { return indexX; } set { indexX = value; } }
        public int INDEX_Y { get { return indexY; } set { indexY = value;} }

        public FedoGomb(int indexX, int indexY, int top, int left)
        {
            this.indexX = indexX;
            this.indexY = indexY;
            this.Width = 50;
            this.Height = 50;
            this.Text = "";
            this.Top = top;
            this.Left = left;
        }
    }
}
