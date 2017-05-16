using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    class Aplicacoes
    {
        private double[,] matriz;
        private static ET[] et;
        private static ET aet;

        public static void LoadPicBox(Bitmap imageBitmapSrc, int r, int g, int b)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        *(src++) = (byte)b;
                        *(src++) = (byte)g;
                        *(src++) = (byte)r;
                    }
                    src += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
        }

        public static void BresenhamReta(int x1, int y1, int x2, int y2, Bitmap imageBitmapSrc)
        {
            int declive = 1;
            int dx, dy, incE, incNE, d, x, y;
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;


            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {


                dx = x2 - x1;
                dy = y2 - y1;

                if (Math.Abs(dx) > Math.Abs(dy))
                {
                    if (x2 < x1)
                    {
                        int a, b;
                        a = x1;
                        b = y1;

                        x1 = x2;
                        y1 = y2;

                        x2 = a;
                        y2 = b;

                        dx = x2 - x1;
                        dy = y2 - y1;

                        /*BresenhamReta(x2, y2, x1, y1, imageBitmapSrc);
                        return;*/
                    }

                    if (y2 < y1)
                    {
                        dy = -dy;
                        declive = -1;
                    }
                    //declive = (dy > 0) ? 1 : -1;

                    byte* src;

                    // Constante de Bresenham 
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx;
                    d = 2 * dy - dx;
                    y = y1;



                    for (x = x1; x <= x2; x++)
                    {
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        if (y >= 0 && y < height && x >= 0 && x < width)
                        {
                            src += y * (width * 3 + padding) + x * 3;
                            *(src++) = (byte)0;
                            *(src++) = (byte)0;
                            *(src++) = (byte)0;
                        }

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
                else
                {
                    if (y2 < y1)
                    {
                        int a, b;
                        a = x1;
                        b = y1;

                        x1 = x2;
                        y1 = y2;

                        x2 = a;
                        y2 = b;

                        dx = x2 - x1;
                        dy = y2 - y1;

                        /*BresenhamReta(x2, y2, x1, y1, imageBitmapSrc);
                        return;*/
                    }

                    if (x2 < x1)
                    {
                        dx = -dx;
                        declive = -1;
                    }

                    byte* src;

                    // Constante de Bresenham 
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = x1;



                    for (y = y1; y <= y2; y++)
                    {
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        if (y >= 0 && y < height && x >= 0 && x < width)
                        {
                            src += y * (width * 3 + padding) + x * 3;
                            *(src++) = (byte)0;
                            *(src++) = (byte)0;
                            *(src++) = (byte)0;
                        }

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }

                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }
        }

        private static double[,] multiplicaMatriz(double[,] ma1, double[,] ma2)
        {
            double[,] mr = new double[3,3];

             for (int i = 0; i < 3; i++)
                 for (int j = 0; j < 3; j++)
                     for (int k = 0; k < 3; k++)
                         mr[i, j] += ma1[i, k] * ma2[k, j];

            return mr;
        } 

        public static void transladar(int x, int y, Poligono p)
        {
            double[,] maT = new double[3,3];

            maT[0, 0] = 1;
            maT[0, 1] = 0;
            maT[0, 2] = x;
            maT[1, 0] = 0;
            maT[1, 1] = 1;
            maT[1, 2] = y;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int) Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int) Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void escalar(double x, double y, Poligono p)
        {
            double[,] maT = new double[3, 3];

            maT[0, 0] = x;
            maT[0, 1] = 0;
            maT[0, 2] = 0;
            maT[1, 0] = 0;
            maT[1, 1] = y;
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void rotacionar(int ang, Poligono p)
        {
            double[,] maT = new double[3, 3];

            maT[0, 0] = Math.Cos(ang);
            maT[0, 1] = -Math.Sin(ang);
            maT[0, 2] = 0;
            maT[1, 0] = Math.Sin(ang);
            maT[1, 1] = Math.Cos(ang);
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void cisalhamento(int x, int y, Poligono p)
        {
            double[,] maT = new double[3, 3];

            maT[0, 0] = 1;
            maT[0, 1] = 0;
            maT[0, 2] = 0;
            maT[1, 0] = x;
            maT[1, 1] = 1;
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }

            maT[0, 0] = 1;
            maT[0, 1] = y;
            maT[0, 2] = 0;
            maT[1, 0] = 0;
            maT[1, 1] = 1;
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void flipV(Poligono p)
        {
            double[,] maT = new double[3, 3];

            maT[0, 0] = 1;
            maT[0, 1] = 0;
            maT[0, 2] = 0;
            maT[1, 0] = 0;
            maT[1, 1] = -1;
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void flipH(Poligono p)
        {
            double[,] maT = new double[3, 3];

            maT[0, 0] = -1;
            maT[0, 1] = 0;
            maT[0, 2] = 0;
            maT[1, 0] = 0;
            maT[1, 1] = 1;
            maT[1, 2] = 0;
            maT[2, 0] = 0;
            maT[2, 1] = 0;
            maT[2, 2] = 1;

            p.MA = multiplicaMatriz(maT, p.MA);

            for (int i = 0; i < p.linha; i++)
            {
                p.MAXY[i, 0] = (int)Math.Round(p.MA[0, 0] * p.MOXY[i, 0] + p.MA[0, 1] * p.MOXY[i, 1] + p.MA[0, 2]);
                p.MAXY[i, 1] = (int)Math.Round(p.MA[1, 0] * p.MOXY[i, 0] + p.MA[1, 1] * p.MOXY[i, 1] + p.MA[1, 2]);
            }
        }

        public static void flipVH(Poligono p)
        {
            flipV(p);
            flipH(p);
        }

        public static void FloodFill(int x, int y, int nr, int ng, int nb, Bitmap imageBitmapSrc)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b, or, og, ob;
            Stack<int> px = new Stack<int>();
            Stack<int> py = new Stack<int>();

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                src += y * (width * 3 + padding) + x * 3;
                ob = *(src++);
                og = *(src++);
                or = *(src++);
                px.Push(x);
                py.Push(y);
                Point p = new Point();

                

                while(px.Count > 0)
                {
                    x = px.Pop();
                    y = py.Pop();

                    if (y < height && y > -1 && x > -1 && x < width)
                    {
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += y * (width * 3 + padding) + x * 3;
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);

                        if (r == or && g == og && b == ob)
                        {
                            src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                            src += y * (width * 3 + padding) + x * 3;
                            *(src++) = (byte)nb;
                            *(src++) = (byte)ng;
                            *(src++) = (byte)nr;

                            px.Push(x + 1);
                            py.Push(y);

                            px.Push(x);
                            py.Push(y + 1);

                            px.Push(x - 1);
                            py.Push(y);

                            px.Push(x);
                            py.Push(y - 1);
                        }
                    }
                }

                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }
        }

        private static int buscaMaxY(Poligono p)
        {
            int max = 0;

            for (int i = 0; i < p.linha; i++)
                if (p.MAXY[i, 1] > max)
                    max = p.MAXY[i, 1];
            return max;
        }

        private static void criaET(Poligono p)
        {
            ET caixa;
            et = new ET[buscaMaxY(p)];

            for (int i = 0; i < p.linha - 2; i++)
            {
                caixa = new ET();
                caixa.xmin = p.MAXY[i, 0];
                caixa.ymax = p.MAXY[i + 1, 1];
                try
                {
                    caixa.incx = (p.MAXY[i + 1, 0] - p.MAXY[i, 0]) / (p.MAXY[i + 1, 1] - p.MAXY[i, 1]);
                }
                catch (Exception ex)
                {
                    caixa.incx = 0;
                }
                caixa.prox = et[p.MAXY[i, 1]];
                et[p.MAXY[i, 1]] = caixa;
            }
            caixa = new ET();
            caixa.xmin = p.MAXY[p.linha - 1, 0];
            caixa.ymax = p.MAXY[0, 1];
            caixa.incx = (p.MAXY[0, 0] - p.MAXY[p.linha - 1, 0]) / (p.MAXY[0, 1] - p.MAXY[p.linha - 1, 1]);
            caixa.prox = et[p.MAXY[p.linha - 1, 1]-1];
            et[p.MAXY[p.linha - 1, 1]] = caixa;
        }

        private static void insereAET(int y)
        {
            ET aux, caixa, auxET = et[y], ant, ini;

            if (auxET != null)
            {
                caixa = new ET();
                caixa.ymax = auxET.ymax;
                caixa.xmin = auxET.xmin;
                caixa.incx = auxET.incx;
                ini = ant = caixa;
                auxET = auxET.prox;

                while (auxET != null)
                {
                    caixa = new ET();
                    caixa.ymax = auxET.ymax;
                    caixa.xmin = auxET.xmin;
                    caixa.incx = auxET.incx;
                    ant.prox = caixa;

                    auxET = auxET.prox;
                }

                if (aet == null)
                    aet = ini;
                else
                {
                    aux = aet;
                    while (aux.prox != null)
                        aux = aux.prox;
                    aux.prox = ini;
                }
            }
        }

        private static void excluiAET(int y)
        {
            ET ant = aet, aux = aet;

            while(aux != null)
            {
                if(aux.ymax == y)
                {
                    if(aux == aet)
                    {
                        aet = aet.prox;
                        ant = aux = aet;
                    }
                    else
                    {
                        ant.prox = aux.prox;
                        aux = aux.prox;
                    }
                }
                else
                {
                    ant = aux;
                    aux = aux.prox;
                }
            }
        }

        private static int calculaTL_AET()
        {
            ET aux = aet;
            int tl = 0;

            while(aux != null)
            {
                tl++;
                aux = aux.prox;
            }

            return tl;
        }

        public static void ordenaAET()
        {
            if (aet != null)
            {
                ET ant = aet, prox = aet.prox, aux = new ET();
                int j, tl = calculaTL_AET();

                while (tl > 0)
                {
                    prox = aet;
                    j = 0;
                    while (j < tl - 1)
                    {
                        if (prox.xmin > prox.prox.xmin)
                        {
                            aux.ymax = prox.ymax;
                            aux.xmin = prox.xmin;
                            aux.incx = prox.incx;

                            prox.ymax = prox.prox.ymax;
                            prox.xmin = prox.prox.xmin;
                            prox.incx = prox.prox.incx;

                            prox.prox.ymax = aux.ymax;
                            prox.prox.xmin = aux.xmin;
                            prox.prox.incx = aux.incx;
                        }
                        prox = prox.prox;
                        j++;
                    }
                    tl--;
                }
            }
        }

        private static void desenhaLinha(int cx, int cy, int y, int r, int g, int b, Bitmap imageBitmapSrc)
        {
            if (aet != null)
            {
                int width = imageBitmapSrc.Width;
                int height = imageBitmapSrc.Height;
                int x = (int)Math.Floor(aet.xmin);
                ET caixa1 = aet, caixa2 = aet.prox;
                bool flag = true;

                //lock dados bitmap origem
                BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapDataSrc.Stride - (width * 3);

                unsafe
                {
                    byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + y) * (width * 3 + padding) + (cx + x) * 3);
                    *(src++) = (byte)b;
                    *(src++) = (byte)g;
                    *(src++) = (byte)r;

                    while (flag)
                    {
                        for (x = (int)Math.Floor(caixa1.xmin); x < Math.Ceiling(caixa2.xmin); x++)
                        {
                            src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                            src += (int)((cy + y) * (width * 3 + padding) + (cx + x) * 3);
                            *(src++) = (byte)b;
                            *(src++) = (byte)g;
                            *(src++) = (byte)r;
                        }

                        if (caixa2.prox != null)
                        {
                            caixa1 = caixa2.prox;
                            caixa2 = caixa1.prox;
                        }
                        else
                            flag = false;
                    }
                }
                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }
        }

        private static void atualizaXmin()
        {
            ET aux = aet;

            while (aux != null)
            {
                aux.xmin += aux.incx;
                aux = aux.prox;
            }
        }

        public static void Scanline(Poligono p, int cx, int cy, int r, int g, int b, Bitmap imageBitmapSrc)
        {
            int y;
            criaET(p);
            aet = null;

            for (y = 0; et[y] != null; y++)
            { }
            //aet = et[y];

            do
            {
                insereAET(y);
                excluiAET(y);
                ordenaAET();
                desenhaLinha(cx, cy, y,r,g,b,imageBitmapSrc);
                atualizaXmin();
                y++;
            }while (aet != null);
        }
    }
}
