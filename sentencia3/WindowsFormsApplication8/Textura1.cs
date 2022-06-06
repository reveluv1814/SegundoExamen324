using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8
{
    class Textura1
    {
        public int indice;
        public Queue<int> pixelA = new Queue<int>();
        public Queue<int> pixelB = new Queue<int>();

        public Textura1()
        {

        }

        public Textura1(int indice, Queue<int> pixel1, Queue<int> pixel2)
        {
            this.indice = indice;
            this.pixelA = pixel1;
            this.pixelB = pixel2;
        }
    }
}
