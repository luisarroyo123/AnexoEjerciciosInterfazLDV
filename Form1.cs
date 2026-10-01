using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace AnexoEjerciciosInterfazLDV {

    public partial class Form1 : Form {

        
[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
    wParam, int lParam);
    




    public Form1() {
            InitializeComponent();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e) {
            pictureBoxRestaurar.Location = pictureBoxMaximizar.Location;
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

        private void pictureBox1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnGB_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = true;
        }

        private void btnAdministrativo_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = false;
        }

        private void btnInformatica_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = false;
        }

        private void btnJardineria_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = false;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaster_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = true;
        }

        private void btnGS_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = true;
        }

        private void btnGM_Click(object sender, EventArgs e) {
            SubmenuReportes.Visible = true;
        }

        private void AbrirFormEnPanel(object formhija) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }



    }
}
