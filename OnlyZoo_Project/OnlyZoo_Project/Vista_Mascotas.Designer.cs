namespace OnlyZoo_Project
{
    partial class Vista_Mascotas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            mascotasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "Menu";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mascotasToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogo";
            catalogoToolStripMenuItem.Size = new Size(67, 20);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // mascotasToolStripMenuItem
            // 
            mascotasToolStripMenuItem.Name = "Mascotas";
            mascotasToolStripMenuItem.Size = new Size(124, 22);
            mascotasToolStripMenuItem.Text = "Mascotas";
            // 
            // Vista_Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Vista_Mascotas";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "OnlyZoo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem mascotasToolStripMenuItem;
    }
}