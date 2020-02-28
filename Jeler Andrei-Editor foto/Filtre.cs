using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace Jeler_Andrei_Editor_foto
{
    public partial class Filtre : Form
    {
        bool deschis=false;
        Bitmap originala;

        void Change_RGB()
        {
            float changered = redbar.Value * 0.1f;
            float changegreen = greenbar.Value * 0.1f;
            float changeblue = bluebar.Value * 0.1f;

            label2.Text = changered.ToString();
            label3.Text = changegreen.ToString();
            label5.Text = changeblue.ToString();

           
            if(deschis)
            {
                //Image img = originala;                             
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);   

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;


            }
        }

        public Filtre()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
               // System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]    
                {
                    new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                    new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                    new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{-1, -1, -1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fisier = new OpenFileDialog();
            fisier.Filter = "Images|*.png;*.bmp;*.jpg";
            if (fisier.ShowDialog() == DialogResult.OK)
            {
                originala = new Bitmap(fisier.FileName);
                pictureBox1.Image = new Bitmap(fisier.FileName);
                deschis = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originala;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(deschis)
            {
             //   System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);   
                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{0.33f, 0.33f, 0.33f, 0, 0},
                    new float[]{0.59f, 0.59f, 0.59f, 0, 0},
                    new float[]{0.11f, 0.11f, 0.11f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
              //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{0.393f, 0.349f, 0.272f, 0, 0},
                    new float[]{0.769f, 0.686f, 0.534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{1, 0, 0, 0, 0},
                            new float[]{0, 1, 0, 0, 0},
                            new float[]{0, 0, 1, 0, 0},
                            new float[]{0, 0, 0, 0.3f, 0},
                            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{0, 0, 1, 0, 0},
                    new float[]{0, 1, 0, 0, 0},
                    new float[]{1, 0, 0, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{1.438f, -0.062f, -0.062f, 0, 0},
                    new float[]{-0.122f, 1.378f, -0.122f, 0, 0},
                    new float[]{-0.016f, -0.016f, 1.483f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{-0.03f, 0.05f, -0.02f, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                float degrees = 45.0f;
                double r = degrees * System.Math.PI / 180;
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {(float)System.Math.Cos(r),
(float)System.Math.Sin(r),0, 0, 0},
new float[] {(float)-System.Math.Sin(r),
(float)-System.Math.Cos(r),
0, 0, 0},
new float[] {.50f, 0, 1, 0, 0},
new float[] {0, 0, 0, 1, 0},
new float[] {0, 0, 0, 0, 1} 
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                   new float[] {1, 0, 0, 0, 0},
new float[] {0, 1, 0, 0, 0},
new float[] {0, 0, 1, 0, 0},
new float[] {0, 0, 0, 1, 0},new float[] {.90f, .0f, .0f, .0f, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (deschis)
            {
                //  System.Drawing.Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void Filtre_Load(object sender, EventArgs e)
        {

        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
            Change_RGB();
        }

        private void greenbar_Scroll(object sender, EventArgs e)
        {
            Change_RGB();
        }

        private void bluebar_Scroll(object sender, EventArgs e)
        {
            Change_RGB();
        }
    }
}
