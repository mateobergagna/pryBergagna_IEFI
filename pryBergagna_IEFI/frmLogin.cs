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

        //Conexion
        clsConexionBD conexion = new clsConexionBD();

        //Variable intentos
        int intentos = 3;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else
            {
                clsUsuario usuario = new clsUsuario(0, txtUsuario.Text, txtContraseña.Text, 0);

                bool resultado = conexion.verificarUsuario(usuario);

                if (resultado)
                {
                    frmInicio ventana = new frmInicio(usuario.Nombre, usuario.RolId);
                    this.Hide();
                    ventana.ShowDialog();

                }
                else
                {
                    intentos = intentos - 1;
                    MessageBox.Show("Datos incorrectos. Intentos restantes: " + intentos);

                    if (intentos == 0)
                    {
                        MessageBox.Show("Has alcanzado el límite de intentos. Contacta con el administrador.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnIngresar.Enabled = false;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
