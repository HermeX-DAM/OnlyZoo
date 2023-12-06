namespace OnlyZoo_Project.VistaElementoMascota
{
    partial class UCElementoMascota
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            imgMascota = new PictureBox();
            lblNombre = new Label();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)imgMascota).BeginInit();
            SuspendLayout();
            // 
            // imgMascota
            // 
            imgMascota.Location = new Point(13, 13);
            imgMascota.Name = "imgMascota";
            imgMascota.Size = new Size(115, 115);
            imgMascota.SizeMode = PictureBoxSizeMode.Zoom;
            imgMascota.TabIndex = 0;
            imgMascota.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(150, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(150, 78);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            lblTipo.Click += lblTipo_Click;
            // 
            // UCElementoMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(imgMascota);
            Name = "UCElementoMascota";
            Size = new Size(322, 144);
            ((System.ComponentModel.ISupportInitialize)imgMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgMascota;
        private Label lblNombre;
        private Label lblTipo;

    }
}
