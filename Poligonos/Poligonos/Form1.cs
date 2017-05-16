using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligonos
{
    public partial class Form1 : Form
    {
        private Bitmap bm, bmC;
        private Poligono pa, ps;
        private DataTable dt;
        private int x, y, xa, ya, r, g, b;
        private double  dX, dY;
        private bool pintar, pintarSC;

        public Form1()
        {
            InitializeComponent();
            x = -1;
            pa = ps = null;
            pintar = false;
            r = g = b = 255;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(pictureBoxSearch.Size.Width, pictureBoxSearch.Size.Height);
            Aplicacoes.LoadPicBox(bm,255,255,255);
            pictureBoxSearch.Image = bm;
            bmC = new Bitmap(pictureBoxCor.Size.Width, pictureBoxCor.Size.Height);
            Aplicacoes.LoadPicBox(bm,255,255,255);
            pictureBoxCor.Image = bm;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            Aplicacoes.LoadPicBox(bm, 255, 255, 255);
            pictureBoxSearch.Image = bm;
        }

        private void verificaRB()
        {
            xa = ya = 0;
            if(rbO.Checked)
            {
                xa = ps.MAXY[0, 0];
                ya = ps.MAXY[0, 1];
            }
            else
            if (rbC.Checked)
            {
                for (int i = 0; i < ps.linha; i++)
                {
                    xa += ps.MAXY[i, 0];
                    ya += ps.MAXY[i, 1];
                }
                xa = xa / ps.linha;
                ya = ya / ps.linha;
            }
            else
            if(rbP.Checked)
            {
                try
                { xa = Int32.Parse(txtXP.Text); }
                catch (Exception ex)
                { xa = 0; }

                try
                { ya = Int32.Parse(txtYP.Text); }
                catch (Exception ex)
                { ya = 0; }
            }
        }

        private void pictureBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pintar)
            {
                if (pa == null)
                    pa = new Poligono();
                if (x == -1)
                {
                    x = e.X;
                    y = e.Y;
                }

                Aplicacoes.BresenhamReta(x, y, e.X, e.Y, bm);
                pictureBoxSearch.Image = bm;

                pa.MOXY[pa.linha, 0] = pa.MAXY[pa.linha, 0] = e.X;
                pa.MOXY[pa.linha, 1] = pa.MAXY[pa.linha, 1] = e.Y;
                pa.linha++;

                x = e.X;
                y = e.Y;
            }
            else
            {
                Aplicacoes.FloodFill(e.X, e.Y, r, g, b, bm);

                pictureBoxSearch.Image = bm;

                pintar = false;
            }
        }

        private void btnCisalhamento_Click(object sender, EventArgs e)
        {
            try
            { x = Int32.Parse(txtX.Text); }
            catch (Exception ex)
            { x = 0; }

            try
            { y = Int32.Parse(txtY.Text); }
            catch (Exception ex)
            { y = 0; }

            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.cisalhamento(x, y, ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnFlipV_Click(object sender, EventArgs e)
        {
            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.flipV(ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnFlipH_Click(object sender, EventArgs e)
        {
            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.flipH(ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnFlipVH_Click(object sender, EventArgs e)
        {
            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.flipVH(ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnTransladar_Click(object sender, EventArgs e)
        {
            try
            { x = Int32.Parse(txtX.Text); }
            catch(Exception ex)
            { x = 0; }

            try
            { y = Int32.Parse(txtY.Text); }
            catch (Exception ex)
            { y = 0; }

            Aplicacoes.transladar(x, y, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i,0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            try
            { dX = Double.Parse(txtX.Text); }
            catch (Exception ex)
            { dX = 0.0; }

            try
            { dY = Double.Parse(txtY.Text); }
            catch (Exception ex)
            { dY = 0.0; }

            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.escalar(dX, dY, ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void btnRotacionar_Click(object sender, EventArgs e)
        {
            int ang;

            try
            { ang = Int32.Parse(txtAngulo.Text); }
            catch (Exception ex)
            { ang = 0; }

            verificaRB();

            Aplicacoes.transladar(-xa, -ya, ps);
            Aplicacoes.rotacionar(ang, ps);
            Aplicacoes.transladar(xa, ya, ps);

            btnResetar_Click(sender, e);

            foreach (Poligono p in LBPoligono.Items)
            {
                for (int i = 0; i < p.linha - 1; i++)
                    Aplicacoes.BresenhamReta(p.MAXY[i, 0], p.MAXY[i, 1], p.MAXY[i + 1, 0], p.MAXY[i + 1, 1], bm);
                Aplicacoes.BresenhamReta(p.MAXY[p.linha - 1, 0], p.MAXY[p.linha - 1, 1], p.MAXY[0, 0], p.MAXY[0, 1], bm);
            }
        }

        private void LBPoligono_SelectedIndexChanged(object sender, EventArgs e)
        {
            ps = (Poligono)LBPoligono.SelectedItem;
            DGVPontos.Rows.Clear();
            
            for (int i = 0; i < ps.linha; i++)
                DGVPontos.Rows.Add(ps.MAXY[i, 0], ps.MAXY[i, 1]);
        }

        private void pictureBoxSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LBPoligono.Items.Add(pa);
            LBPoligono.ValueMember = pa.linha.ToString();
            Aplicacoes.BresenhamReta(e.X, e.Y, pa.MAXY[0,0], pa.MAXY[0, 1], bm);
            pictureBoxSearch.Image = bm;
            pa = null;
            x = -1;
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                r = colorDialog1.Color.R;
                g = colorDialog1.Color.G;
                b = colorDialog1.Color.B;

                Aplicacoes.LoadPicBox(bmC, r, g, b);
                pictureBoxCor.Image = bmC;
            }
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            pintar = true;
        }

        private void btnPintarScan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ps.linha; i++)
            {
                xa += ps.MAXY[i, 0];
                ya += ps.MAXY[i, 1];
            }
            xa = xa / ps.linha;
            ya = ya / ps.linha;

            Aplicacoes.Scanline(ps, xa, ya, r, g, b, bm);
            pictureBoxSearch.Image = bm;
        }
    }
}
