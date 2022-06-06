using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int pR, pG, pB;
        int sensibilidad =50;
        Queue<Textura1> textura = new Queue<Textura1>();
        int indice = 0;

        Queue<Tuple<Bitmap, Textura1>> tupleList = new Queue<Tuple<Bitmap, Textura1>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tupleList.Count == 0){
                openFileDialog1.Filter = "Todos *.*|";
                openFileDialog1.ShowDialog();
                bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            }
            else{
                bmp = tupleList.Dequeue().Item1;
                pictureBox1.Image = bmp;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            c = bmp.GetPixel(15, 15);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = new Color();
            //c = bmp.GetPixel(e.X, e.Y);
            //textBox1.Text = c.R.ToString();
            //textBox2.Text = c.G.ToString();
            //textBox3.Text = c.B.ToString();
            //pR = c.R;
            //pG = c.G;
            //pB = c.B;
            pR = 0;
            pG = 0;
            pB = 0;
            for (int ki = e.X; ki < e.X + 10; ki++)
                for (int kj = e.Y; kj < e.Y + 10; kj++)
                {
                    c = bmp.GetPixel(ki, kj);
                    pR = pR + c.R;
                    pG = pG + c.G;
                    pB = pB + c.B;
                }
            pR = pR / 100;
            pG = pG / 100;
            pB = pB / 100;
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i=0;i<bmp.Width;i++)
                for (int j = 0; j < bmp.Height; j++)
                { 
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i,j, Color.FromArgb(c.R, 0, 0));
                }
            pictureBox2.Image = bmpR;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                }
            pictureBox2.Image = bmpR;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color c = new Color();
           
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 5 <= pR && pR <= c.R + 5) && (c.G-5<=pG && pG <= c.G+5) && (c.B-5<= pB && pB <= c.B+5))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                        //bmpR.SetPixel(i, j, Color.FromArgb(ur, ug,ub));
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B) );
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int mR = 0, mG = 0, mB = 0;
            Color c = new Color();
            var ran = new Random();
            int ur = ran.Next(0,255);
            int ug = ran.Next(0,255);
            int ub = ran.Next(0,255);
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    mR = 0;
                    mG = 0;
                    mB = 0;
                    for (int ki = i; ki < i + 10; ki++)
                        for (int kj = j; kj < j + 10; kj++)
                        {
                            c = bmp.GetPixel(ki, kj);
                            mR = mR + c.R;
                            mG = mG + c.G;
                            mB = mB + c.B;
                        }
                    mR = mR / 100;
                    mG = mG / 100;
                    mB = mB / 100;

                    c = bmp.GetPixel(i, j);
                    if ((pR - sensibilidad <= mR && mR <= pR + sensibilidad) && (pG - sensibilidad <= mG && mG <= pG + sensibilidad) && (pB - sensibilidad <= mB && mB <= pB + sensibilidad))
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                                bmpR.SetPixel(ki, kj, Color.Fuchsia);//bmpR.SetPixel(i, j, Color.FromArgb(35, 155, 86));
                    }
                    else
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                            {
                                c = bmp.GetPixel(ki, kj);
                                bmpR.SetPixel(ki, kj, Color.FromArgb(c.R, c.G, c.B));
                            }

                    }
                }
            

            pictureBox2.Image = bmpR;
            Textura1 t = textura.Dequeue();
            tupleList.Enqueue(Tuple.Create(bmpR, t));
            textura.Enqueue(t);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            int mR=0, mG=0, mB=0;
            for (int i=15;i<25;i++)
                for (int j = 15; j < 25; j++)
                {
                    c = bmp.GetPixel(i,j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mB + c.B;
                }
            mR = mR / 100;
            mG = mG / 100;
            mB = mB / 100;

            textBox1.Text = mR.ToString();
            textBox2.Text = mG.ToString();
            textBox3.Text = mB.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int mR = 0, mG = 0, mB = 0;
            Queue<int> pixel1 = new Queue<int>();
            Queue<int> pixel2 = new Queue<int>();


            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width-10; i=i+10)
                for (int j = 0; j < bmp.Height-10; j=j+10)
                {
                    mR = 0;
                    mG = 0;
                    mB = 0; 
                    for (int ki = i; ki<i+10; ki++)
                        for (int kj = j; kj<j+10; kj++)
                        {
                            c = bmp.GetPixel(ki, kj);
                            mR = mR + c.R;
                            mG = mG + c.G;
                            mB = mB + c.B;
                        }
                    mR = mR / 100;
                    mG = mG / 100;
                    mB = mB / 100;

                    c = bmp.GetPixel(i, j);
                    if ((pR - sensibilidad <= mR && mR <= pR + sensibilidad) && (pG - sensibilidad <= mG && mG <= pG + sensibilidad) && (pB - sensibilidad <= mB && mB <= pB + sensibilidad))
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                            {
                                pixel1.Enqueue(ki);
                                pixel2.Enqueue(kj);
                            }
                    }
                }

            textura.Enqueue(new Textura1(indice,pixel1,pixel2));
            indice++;
            foreach (Textura1 var in textura)
            {
                for (int i = 0; i < var.pixelA.Count; i++)
                {
                    string p = "";
                    int u = var.pixelA.Dequeue();
                    int v = var.pixelB.Dequeue();
                    p = u+ ";"+v+"";
                    listBox1.Items.Add(p);
                    var.pixelA.Enqueue(u);
                    var.pixelB.Enqueue(v);
                }
            }

        }
    }
}
