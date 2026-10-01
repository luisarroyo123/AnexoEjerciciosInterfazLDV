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
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.btnJardineria = new System.Windows.Forms.Button();
            this.btnInformatica = new System.Windows.Forms.Button();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnGB = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnGS = new System.Windows.Forms.Button();
            this.btnGM = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIESLeonardo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIESLeonardo)).BeginInit();
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
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
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
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Controls.Add(this.btnGB);
            this.MenuVertical.Controls.Add(this.btnMaster);
            this.MenuVertical.Controls.Add(this.btnGS);
            this.MenuVertical.Controls.Add(this.btnGM);
            this.MenuVertical.Controls.Add(this.btnInformacion);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.pictureBoxIESLeonardo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.btnJardineria);
            this.SubmenuReportes.Controls.Add(this.btnInformatica);
            this.SubmenuReportes.Controls.Add(this.btnAdministrativo);
            this.SubmenuReportes.Location = new System.Drawing.Point(41, 409);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(179, 100);
            this.SubmenuReportes.TabIndex = 7;
            this.SubmenuReportes.Visible = false;
            // 
            // btnJardineria
            // 
            this.btnJardineria.FlatAppearance.BorderSize = 0;
            this.btnJardineria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnJardineria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJardineria.ForeColor = System.Drawing.Color.White;
            this.btnJardineria.Image = ((System.Drawing.Image)(resources.GetObject("btnJardineria.Image")));
            this.btnJardineria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJardineria.Location = new System.Drawing.Point(0, 64);
            this.btnJardineria.Name = "btnJardineria";
            this.btnJardineria.Size = new System.Drawing.Size(176, 28);
            this.btnJardineria.TabIndex = 2;
            this.btnJardineria.Text = "Jardinería";
            this.btnJardineria.UseVisualStyleBackColor = true;
            this.btnJardineria.Click += new System.EventHandler(this.btnJardineria_Click);
            // 
            // btnInformatica
            // 
            this.btnInformatica.FlatAppearance.BorderSize = 0;
            this.btnInformatica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInformatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformatica.ForeColor = System.Drawing.Color.White;
            this.btnInformatica.Image = ((System.Drawing.Image)(resources.GetObject("btnInformatica.Image")));
            this.btnInformatica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformatica.Location = new System.Drawing.Point(0, 33);
            this.btnInformatica.Name = "btnInformatica";
            this.btnInformatica.Size = new System.Drawing.Size(176, 28);
            this.btnInformatica.TabIndex = 1;
            this.btnInformatica.Text = "Informática";
            this.btnInformatica.UseVisualStyleBackColor = true;
            this.btnInformatica.Click += new System.EventHandler(this.btnInformatica_Click);
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.FlatAppearance.BorderSize = 0;
            this.btnAdministrativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrativo.ForeColor = System.Drawing.Color.White;
            this.btnAdministrativo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrativo.Image")));
            this.btnAdministrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrativo.Location = new System.Drawing.Point(0, 3);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(176, 28);
            this.btnAdministrativo.TabIndex = 0;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // btnGB
            // 
            this.btnGB.FlatAppearance.BorderSize = 0;
            this.btnGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGB.ForeColor = System.Drawing.Color.White;
            this.btnGB.Image = ((System.Drawing.Image)(resources.GetObject("btnGB.Image")));
            this.btnGB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGB.Location = new System.Drawing.Point(0, 371);
            this.btnGB.Name = "btnGB";
            this.btnGB.Size = new System.Drawing.Size(217, 32);
            this.btnGB.TabIndex = 6;
            this.btnGB.Text = "Grado Básico";
            this.btnGB.UseVisualStyleBackColor = true;
            this.btnGB.Click += new System.EventHandler(this.btnGB_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.ForeColor = System.Drawing.Color.White;
            this.btnMaster.Image = ((System.Drawing.Image)(resources.GetObject("btnMaster.Image")));
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.Location = new System.Drawing.Point(0, 315);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(217, 32);
            this.btnMaster.TabIndex = 5;
            this.btnMaster.Text = "Máster";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnGS
            // 
            this.btnGS.FlatAppearance.BorderSize = 0;
            this.btnGS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS.ForeColor = System.Drawing.Color.White;
            this.btnGS.Image = ((System.Drawing.Image)(resources.GetObject("btnGS.Image")));
            this.btnGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGS.Location = new System.Drawing.Point(0, 251);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(217, 32);
            this.btnGS.TabIndex = 4;
            this.btnGS.Text = "Grado Superior";
            this.btnGS.UseVisualStyleBackColor = true;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            // 
            // btnGM
            // 
            this.btnGM.FlatAppearance.BorderSize = 0;
            this.btnGM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGM.ForeColor = System.Drawing.Color.White;
            this.btnGM.Image = ((System.Drawing.Image)(resources.GetObject("btnGM.Image")));
            this.btnGM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGM.Location = new System.Drawing.Point(0, 201);
            this.btnGM.Name = "btnGM";
            this.btnGM.Size = new System.Drawing.Size(217, 32);
            this.btnGM.TabIndex = 3;
            this.btnGM.Text = "Grado Medio";
            this.btnGM.UseVisualStyleBackColor = true;
            this.btnGM.Click += new System.EventHandler(this.btnGM_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.ForeColor = System.Drawing.Color.White;
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformacion.Location = new System.Drawing.Point(0, 148);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(217, 32);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 568);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxIESLeonardo
            // 
            this.pictureBoxIESLeonardo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIESLeonardo.Image")));
            this.pictureBoxIESLeonardo.Location = new System.Drawing.Point(47, 0);
            this.pictureBoxIESLeonardo.Name = "pictureBoxIESLeonardo";
            this.pictureBoxIESLeonardo.Size = new System.Drawing.Size(118, 111);
            this.pictureBoxIESLeonardo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIESLeonardo.TabIndex = 0;
            this.pictureBoxIESLeonardo.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIESLeonardo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxIESLeonardo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGB;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Button btnGM;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Button btnJardineria;
        private System.Windows.Forms.Button btnInformatica;
        private System.Windows.Forms.Button btnAdministrativo;
    }
}

