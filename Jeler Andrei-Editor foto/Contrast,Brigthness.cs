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
    public partial class Contrast_Brigthness : Form
    {
        bool deschis = false;
        Bitmap originala;
        
        public Contrast_Brigthness()
        {
            InitializeComponent();
        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
              label2.Text = br.Value.ToString();
              if (deschis)
              {
                  // System.Drawing.Image img = pictureBox1.Image;
                  Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                  float val = (float)br.Value / 255.0f;
                  ImageAttributes ia = new ImageAttributes();
                  ColorMatrix cmPicture = new ColorMatrix(new float[][]
                  {
                      new float[]{1,0, 0, 0, 0},
                      new float[]{0, 1, 0, 0, 0},
                      new float[]{0, 0, 1, 0, 0},
                      new float[]{0, 0, 0, 1, 0},
                      new float[]{val, val, val, 1, 1}
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
            br.Value = 0;
            label2.Text = "0";
            con.Value = 0;
            label3.Text = "0";
            ga.Value = 1;
            label5.Text = "1";
        }

        private void greenbar_Scroll(object sender, EventArgs e)
        {
             label3.Text = con.Value.ToString();
             if (deschis)
             {
                 // System.Drawing.Image img = pictureBox1.Image;
                 Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                 float c = 0.04f * con.Value;
                 ImageAttributes ia = new ImageAttributes();
                 ColorMatrix cmPicture = new ColorMatrix(new float[][]
                 {
                     new float[]{c,0f,0f,0f,0f},
                     new float[]{0f,c,0f,0f,0f},
                     new float[]{0f, 0f,c, 0f, 0f},
                     new float[]{0f, 0f, 0f, 1f, 0f},
                     new float[]{0.001f, 0.001f, 0.001f, 0f, 2f}
                 });
                 ia.SetColorMatrix(cmPicture);
                 Graphics g = Graphics.FromImage(bmpInverted);
                 g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                 g.Dispose();
                 ia.Dispose();
                 pictureBox1.Image = bmpInverted;
             }
             
            
        }

        private void ga_Scroll(object sender, EventArgs e)
        {
              label5.Text = ga.Value.ToString();
               float gamma = 0.04f * ga.Value;
               if (deschis)
               {
                   // System.Drawing.Image img = pictureBox1.Image;
                   Bitmap bmpInverted = new Bitmap(originala.Width, originala.Height);
                   ImageAttributes ia = new ImageAttributes();
                   ia.SetGamma(gamma);
                   Graphics g = Graphics.FromImage(bmpInverted);
                   g.DrawImage(originala, new Rectangle(0, 0, originala.Width, originala.Height), 0, 0, originala.Width, originala.Height, GraphicsUnit.Pixel, ia);
                   g.Dispose();
                   pictureBox1.Image = bmpInverted;
               }
               
        }
    }
    }
