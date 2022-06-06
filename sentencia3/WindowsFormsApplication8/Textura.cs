using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8
{
    class Textura
    {
        private int indice;
        private int[] pixelA;
        private int[] pixelB;

       
        public int[] PixelA { get => pixelA; set => pixelA = value; }
        public int[] PixelB { get => pixelB; set => pixelB = value; }
        public int Indice { get => indice; set => indice = value; }

        public Textura(int indice, int[] pixelA, int[] pixelB)
        {
            this.Indice = indice;
            this.PixelA = pixelA;
            this.PixelB = pixelB;
        }
        

    }
    
}
