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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filtreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtre f = new Filtre();
            f.Show();
        }

        private void contrastBrigthnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrast_Brigthness f = new Contrast_Brigthness();
            f.Show();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paint p = new Jeler_Andrei_Editor_foto.Paint();
            p.Show();
        }

        private void redimensionareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redimensionare r = new Redimensionare();
            r.Show();
        }
    }
}
