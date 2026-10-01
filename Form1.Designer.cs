namespace AnexoEjerciciosInterfazLDV {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.pictureBoxRestaurar);
            this.BarraTitulo.Controls.Add(this.pictureBoxMinimizar);
            this.BarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.BarraTitulo.Controls.Add(this.pictureBoxMaximizar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 612);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1264, 13);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // pictureBoxMaximizar
            // 
            this.pictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximizar.Image")));
            this.pictureBoxMaximizar.Location = new System.Drawing.Point(1233, 13);
            this.pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            this.pictureBoxMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximizar.TabIndex = 1;
            this.pictureBoxMaximizar.TabStop = false;
            this.pictureBoxMaximizar.Click += new System.EventHandler(this.pictureBoxMaximizar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1202, 13);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 2;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxRestaurar
            // 
            this.pictureBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestaurar.Image")));
            this.pictureBoxRestaurar.Location = new System.Drawing.Point(1171, 13);
            this.pictureBoxRestaurar.Name = "pictureBoxRestaurar";
            this.pictureBoxRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestaurar.TabIndex = 3;
            this.pictureBoxRestaurar.TabStop = false;
            this.pictureBoxRestaurar.Click += new System.EventHandler(this.pictureBoxRestaurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxMaximizar;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxRestaurar;
    }
}

