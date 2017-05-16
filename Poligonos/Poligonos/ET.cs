using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    class ET
    {
        public double ymax, xmin, incx;
        public ET prox;

        public ET()
        {
            ymax = xmin = incx = 0.0;
            prox = null;
        }
    }
}
