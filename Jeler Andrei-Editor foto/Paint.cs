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
    public partial class Paint : Form
    {
        Boolean deschis = false;
        Bitmap originala;
        Point current = new Point();
        Point old = new Point();
        Graphics g;
        Pen p = new Pen(Color.Black, 5);
        Pen pe = new Pen(Color.White, 5);
        int width;

        public Paint()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            pe.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fisier = new OpenFileDialog();
            fisier.Filter = "Images|*.png;*.bmp;*.jpg";
            if (fisier.ShowDialog() == DialogResult.OK)
            {
                originala = new Bitmap(fisier.FileName);
                panel1.BackgroundImage = new Bitmap(fisier.FileName);
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
                    Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    Rectangle r = panel1.RectangleToScreen(panel1.ClientRectangle);
                    gr.CopyFromScreen(r.Location, Point.Empty, panel1.Size);
                    bmp.Save(sfd.FileName);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
            else if(e.Button==MouseButtons.Right)
            {
                current = e.Location;
                g.DrawLine(pe, old, current);
                old = current;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (radioButton1.Checked)
               width = 1;
            else if (radioButton2.Checked)
                width = 5;
            else if (radioButton3.Checked)
                width = 10;
            else if (radioButton4.Checked)
                width = 15;
            else if (radioButton5.Checked)
                width = 30;
            p.Width = width;
            pe.Width = width;
        }

        private void culoare_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                p.Color = cd.Color;
                culoare.BackColor = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
