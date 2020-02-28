using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeler_Andrei_Editor_foto
{
    public partial class Redimensionare : Form
    {
        Boolean deschis;
        Bitmap originala;
        Bitmap bmp;

        Bitmap Res(Bitmap bmp,int w,int h)
        {
            Bitmap b = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(b);
            g.DrawImage(bmp, 0, 0, w, h);
            g.Dispose();
            return b;
        }

        void Redim()
        {
            // int w = Convert.ToInt32(textBox1.Text);
            // int h = Convert.ToInt32(textBox2.Text);
            int w = Convert.ToInt32(numericUpDown1.Value);
            int h = Convert.ToInt32(numericUpDown2.Value);
            bmp = Res(bmp, w, h);
            pictureBox1.Image = bmp;
        }

        public Redimensionare()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fisier = new OpenFileDialog();
            fisier.Filter = "Images|*.png;*.bmp;*.jpg";
            if (fisier.ShowDialog() == DialogResult.OK)
            {
                originala = new Bitmap(fisier.FileName);
                pictureBox1.Image = new Bitmap(fisier.FileName);
                bmp = new Bitmap(originala);
                // textBox1.Text = originala.Width.ToString();
                //textBox2.Text = originala.Height.ToString();
                numericUpDown1.Value = originala.Width;
                numericUpDown2.Value = originala.Height;
                deschis = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originala;
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
                   // bmp.Save(sfd.FileName); 
                }
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap copia = new Bitmap(bmp);
         //   bmp = new Bitmap(originala);
            if (comboBox1.Text == "90 Y")
            { copia.RotateFlip(RotateFlipType.Rotate90FlipY); }
            else if(comboBox1.Text== "180 Y")
            { copia.RotateFlip(RotateFlipType.Rotate180FlipY); }
            else if (comboBox1.Text == "270 Y")
            { copia.RotateFlip(RotateFlipType.Rotate270FlipY); }
            else if (comboBox1.Text == "90 X")
            { copia.RotateFlip(RotateFlipType.Rotate90FlipX); }
            else if (comboBox1.Text == "180 X")
            { copia.RotateFlip(RotateFlipType.Rotate180FlipX); }
            else if (comboBox1.Text == "270 X")
            { copia.RotateFlip(RotateFlipType.Rotate270FlipX); }
            pictureBox1.Image = copia;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bmp = originala;
            if (deschis)
            { Redim(); }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bmp = originala;
            if (deschis)
            { Redim(); }
        }
    }
}
