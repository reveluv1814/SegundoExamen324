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
        Queue<Textura> textura = new Queue<Textura>();
        int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos *.*|";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
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
            
            
            /*Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            

            // Color c = new Color();
            //Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    c = bmp.GetPixel(i, j);
                    var rand = new Random();
                    int randomR = rand.Next(256);
                    int randomG = rand.Next(256);
                    int randomB = rand.Next(256);
                    //for para iterar las texturas
                    foreach (Textura textu in textura)
                    {
                        //for para recorrer los pixeles de una textura
                        for (int vec = 0; vec < textu.PixelA.Length; vec++)
                        {
                            
                            //bmpR.SetPixel(i, j, Color.Fuchsia);
                            for (int ki = i; ki < i + 10; ki++)
                                for (int kj = j; kj < j + 10; kj++)
                                {
                                    if (textu.PixelA[vec] == ki && textu.PixelB[vec] == kj)
                                    {
                                        bmpR.SetPixel(ki, kj, Color.FromArgb(randomR, randomG, randomB));
                                    }
                                    else
                                    {
                                        //bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                                        /*for (int ki = i; ki < i + 10; ki++)
                                            for (int kj = j; kj < j + 10; kj++)
                                            {*/
                                      /*  c = bmp.GetPixel(ki, kj);
                                        bmpR.SetPixel(ki, kj, Color.FromArgb(c.R, c.G, c.B));
                                        //}
                                    }


                                }
                            
                            
                        }

                    }
                }*/
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
                    if ((pR - 5 <= mR && mR <= pR + 5) && (pG - 5 <= mG && mG <= pG + 5) && (pB - 5 <= mB && mB <= pB + 5))
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                            {
                                bmpR.SetPixel(ki, kj, Color.Fuchsia);
                               
                            }
                               
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
            pictureBox1.Image = bmpR;
            
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
                    if ((pR - 5 <= mR && mR <= pR + 5) && (pG - 5 <= mG && mG <= pG + 5) && (pB - 5 <= mB && mB <= pB + 5))
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                            {
                                //bmpR.SetPixel(ki, kj, Color.Fuchsia);
                                pixel1.Enqueue(ki);
                                pixel2.Enqueue(kj);
                            }
                               
                    }
                    /*else
                    {
                        for (int ki = i; ki < i + 10; ki++)
                            for (int kj = j; kj < j + 10; kj++)
                            {
                                c = bmp.GetPixel(ki, kj);
                                bmpR.SetPixel(ki, kj, Color.FromArgb(c.R, c.G, c.B));
                            }
                        
                    }*/
                }
            int[] pixelA = new int[pixel1.Count];
            int[] pixelB = new int[pixel2.Count];
            int px = 0;
           
            foreach (int i in pixel1)
            {
                pixelA[px] = i;
                px++;
            }
            px = 0;
            foreach (int i in pixel2)
            {
                pixelB[px] = i;
                px++;
            }

           //ListBox t = new ListBox();
            /*for (int i = 0; i < pixelA.Length; i++)
            {
                string p = "";
                p = pixelA[i] + ";"+pixelB[i]+"";
                listBox1.Items.Add(p);
            }*/
            

            textura.Enqueue(new Textura(indice, pixelA, pixelB));
            indice++;
            foreach (Textura var in textura)
            {
                for (int i = 0; i < var.PixelA.Length; i++)
                {
                    string p = "";
                    p = var.PixelA[i] + ";"+var.PixelB[i]+"";
                    listBox1.Items.Add(p);
                }
            }


            // pictureBox2.Image = bmpR;
        }
    }
}
