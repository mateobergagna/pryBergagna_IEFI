using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBergagna_IEFI
{
    public partial class frmLogin : Form
    {

        // Conexion
        clsConexionBD conexion = new clsConexionBD();

        // Variable intentos
        int intentos = 3;
        private bool mostrarContraseña = false;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!conexion.ConectarBD())
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUsuario usuario = new clsUsuario(txtUsuario.Text, txtContraseña.Text);

            if (conexion.VerificarUsuario(usuario))
            {
                DateTime horaInicio = DateTime.Now;

                // Abrir formulario principal
                frmInicio principal = new frmInicio(usuario, horaInicio);
                principal.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            mostrarContraseña = !mostrarContraseña;

            if (mostrarContraseña)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;         
            }
        }
    }
}
