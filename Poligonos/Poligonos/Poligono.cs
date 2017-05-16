using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    class Poligono
    {
        public int[,] MOXY, MAXY;
        public int linha;
        public double[,] MA;

        public Poligono()
        {
            MA = new double[3, 3];
            MOXY = new int[50, 2];
            MAXY = new int[50, 2];
            linha = 0;

            MA[0, 0] = 1;
            MA[0, 1] = 0;
            MA[0, 2] = 0;
            MA[1, 0] = 0;
            MA[1, 1] = 1;
            MA[1, 2] = 0;
            MA[2, 0] = 0;
            MA[2, 1] = 0;
            MA[2, 2] = 1;
        }
    }
}
