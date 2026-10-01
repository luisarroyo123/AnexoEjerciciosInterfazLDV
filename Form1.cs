using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnexoEjerciciosInterfazLDV {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMaximizar.Visible = false;
            pictureBoxRestaurar.Visible = true;
            
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            pictureBoxRestaurar.Visible = false;
            pictureBoxMaximizar.Visible = true;
           
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e) {
            this.WindowState= FormWindowState.Minimized;
        }
    }
}
