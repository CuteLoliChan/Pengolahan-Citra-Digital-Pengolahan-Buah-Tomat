using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image10
{
    public partial class Form1 : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap2;
        Bitmap objBitmap3;
        Bitmap objBitmap4;

        float[] gn = new float[384];
        float[,] h = new float[4,384];
        float[,] hs = new float[4,384];
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int i;
            for (i = 0; i < 384; i++) h[0,i] = 0;

            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    r = r / 2;
                    g = g / 2;
                    b = b / 2;
                    h[0,r]++;
                    h[0,128 + g]++;
                    h[0,256 + b]++;
                }

            for (i = 0; i < 384; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[0,i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = objBitmap2;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap3 = new Bitmap(openFileDialog1.FileName);
                pictureBox3.Image = objBitmap3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            int i;
            for (i = 0; i < 384; i++) h[1,i] = 0;
            for (int x = 0; x < objBitmap2.Width; x++)
                for (int y = 0; y < objBitmap2.Height; y++)
                {
                    Color w = objBitmap2.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    r = r / 2;
                    g = g / 2;
                    b = b / 2;
                    h[1,r]++;
                    h[1,128 + g]++;
                    h[1,256 + b]++;
                }
            for (i = 0; i < 384; i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, h[1,i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 384; i++) h[2,i] = 0;
            for (int x = 0; x < objBitmap3.Width; x++)
                for (int y = 0; y < objBitmap3.Height; y++)
                {
                    Color w = objBitmap3.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    r = r / 2;
                    g = g / 2;
                    b = b / 2;
                    h[2,r]++;
                    h[2,128 + g]++;
                    h[2,256 + b]++;
                }
            for (i = 0; i < 384; i++)
            {
                chart3.Series["Series1"].Points.AddXY(i, h[2,i]);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 384; i++)
            {
                gn[i] = h[0, i];
                if (h[1, i] < gn[i]) gn[i] = h[1, i];
                if (h[2, i] < gn[i]) gn[i] = h[2, i];
            }
            
            for (i = 0; i < 384; i++)
            {
                chart4.Series["Series1"].Points.AddXY(i, gn[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < 384; i++)
            {
                hs[0, i] = Math.Abs(h[0, i] - gn[i]);
            }

            for (i = 0; i < 384; i++)
            {
                chart5.Series["Series1"].Points.AddXY(i, hs[0, i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < 384; i++)
            {
                hs[1, i] = Math.Abs(h[1, i] - gn[i]);
            }

            for (i = 0; i < 384; i++)
            {
                chart6.Series["Series1"].Points.AddXY(i, hs[1, i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < 384; i++)
            {
                hs[2, i] = Math.Abs(h[2, i] - gn[i]);
            }

            for (i = 0; i < 384; i++)
            {
                chart7.Series["Series1"].Points.AddXY(i, hs[2, i]);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap4 = new Bitmap(openFileDialog1.FileName);
                pictureBox4.Image = objBitmap4;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 384; i++) h[3, i] = 0;
            for (int x = 0; x < objBitmap4.Width; x++)
                for (int y = 0; y < objBitmap4.Height; y++)
                {
                    Color w = objBitmap4.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    r = r / 2;
                    g = g / 2;
                    b = b / 2;
                    h[3, r]++;
                    h[3, 128 + g]++;
                    h[3, 256 + b]++;
                }
            for (i = 0; i < 384; i++)
            {
                chart8.Series["Series1"].Points.AddXY(i, h[3, i]);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < 384; i++)
            {
                hs[3, i] = Math.Abs(h[3, i] - gn[i]);
            }

            for (i = 0; i < 384; i++)
            {
                chart9.Series["Series1"].Points.AddXY(i, hs[3, i]);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            float[] d = new float[3];
            float di = 0;
            int i, j;

            for (i = 0; i < 3; i++)
            {
                d[i] = 0;

                for (j = 0; j < 384; j++) di = di + Math.Abs(hs[3, j] - hs[i, j]);
                di = di / 384;
                d[i] = di;
            }
            label1.Text = "0 : " + d[0].ToString();
            label2.Text = "1 : " + d[1].ToString();
            label3.Text = "2 : " + d[2].ToString();
            if ((d[0] < d[1]) && (d[0] < d[2]))
            {
                label4.Text = "HIJAU (BELUM MATANG)";
            }
            if ((d[1] < d[0]) && (d[1] < d[2]))
            {
                label4.Text = "ORANYE (AGAK MATANG)";
            }
            if ((d[2] < d[0]) && (d[2] < d[1]))
            {
                label4.Text = "MERAH (SUDAH MATANG)";
            }
        }
    }
}
