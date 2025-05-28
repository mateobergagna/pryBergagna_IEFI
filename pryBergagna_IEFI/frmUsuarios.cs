using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBergagna_IEFI
{
    public partial class frmUsuarios : Form
    {

        clsConexionBD conexion = new clsConexionBD();

        //Variable guarda ID
        private int IdSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            conexion.ListarBD(dgvUsuarios);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Complete nombre y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUsuario nuevoUsuario = new clsUsuario(0, txtNombre.Text, txtContraseña.Text, 1);
            conexion.Agregar(nuevoUsuario);
            LimpiarCampos();
            CargarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvUsuarios.SelectedRows[0];
            clsUsuario usuario = new clsUsuario(
                Convert.ToInt32(fila.Cells["Id"].Value),
                txtNombre.Text,
                txtContraseña.Text,
                Convert.ToInt32(fila.Cells["RolId"].Value)
            );

            conexion.Modificar(usuario);
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                conexion.Eliminar(id);
                CargarUsuarios();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                conexion.BuscarporNombre(dgvUsuarios, txtBuscar.Text);
            }
            else
            {
                CargarUsuarios();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            LimpiarCampos();
            txtBuscar.Text = "";
            MessageBox.Show("Lista de usuarios actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
            frmInicio inicio = new frmInicio(); // Asume que tienes un formulario llamado frmInicio
            inicio.Show();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuarios.SelectedRows[0];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
        }
    }
}
