namespace Jeler_Andrei_Editor_foto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redimensionareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastBrigthnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem,
            this.redimensionareToolStripMenuItem,
            this.filtreToolStripMenuItem,
            this.contrastBrigthnessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // redimensionareToolStripMenuItem
            // 
            this.redimensionareToolStripMenuItem.Name = "redimensionareToolStripMenuItem";
            this.redimensionareToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.redimensionareToolStripMenuItem.Text = "Redimensionare";
            this.redimensionareToolStripMenuItem.Click += new System.EventHandler(this.redimensionareToolStripMenuItem_Click);
            // 
            // filtreToolStripMenuItem
            // 
            this.filtreToolStripMenuItem.Name = "filtreToolStripMenuItem";
            this.filtreToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filtreToolStripMenuItem.Text = "Filtre";
            this.filtreToolStripMenuItem.Click += new System.EventHandler(this.filtreToolStripMenuItem_Click);
            // 
            // contrastBrigthnessToolStripMenuItem
            // 
            this.contrastBrigthnessToolStripMenuItem.Name = "contrastBrigthnessToolStripMenuItem";
            this.contrastBrigthnessToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.contrastBrigthnessToolStripMenuItem.Text = "Contrast,Brigthness";
            this.contrastBrigthnessToolStripMenuItem.Click += new System.EventHandler(this.contrastBrigthnessToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 424);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redimensionareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastBrigthnessToolStripMenuItem;
    }
}

