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

        // Variable guarda ID
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
            conexion.ListarBD(dgvUsuarios);
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbRol.Items.Clear();
            cmbRol.Items.Add("1");
            cmbRol.Items.Add("2");
            cmbRol.SelectedIndex = 0; // Selecciona el primer valor por defecto


            // Asociar evento SelectionChanged
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Complete nombre y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rolSeleccionado = Convert.ToInt32(cmbRol.SelectedItem);
            clsUsuario nuevoUsuario = new clsUsuario(0, txtNombre.Text, txtContraseña.Text, rolSeleccionado, txtDNI.Text, txtGmail.Text, txtTelefono.Text);
            conexion.Agregar(nuevoUsuario);
            conexion.ListarBD(dgvUsuarios); // Recargar la grilla con el nuevo usuario
            LimpiarCampos(); // Limpiar los campos


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuarios.SelectedRows[0];

                clsUsuario usuario = new clsUsuario(
                    Convert.ToInt32(fila.Cells["Id"].Value),
                    txtNombre.Text,
                    txtContraseña.Text,
                    Convert.ToInt32(cmbRol.SelectedItem),
                    txtDNI.Text,
                    txtGmail.Text,
                    txtTelefono.Text
                );

                conexion.Modificar(usuario);
                conexion.ListarBD(dgvUsuarios); // Actualizar la grilla
                LimpiarCampos();
            }

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
            dgvUsuarios.ClearSelection();  // Desseleccionar filas
            MessageBox.Show("Lista de usuarios actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuarios.SelectedRows[0];

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtContraseña.Text = fila.Cells["Contraseña"].Value?.ToString() ?? "";
                txtDNI.Text = fila.Cells["DNI"].Value?.ToString() ?? "";
                txtGmail.Text = fila.Cells["Gmail"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                cmbRol.SelectedItem = fila.Cells["RolId"].Value?.ToString();
            }

        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Habilita los botones solo si hay selección
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtDNI.Text = "";
            txtGmail.Text = "";
            txtTelefono.Text = "";
            cmbRol.SelectedIndex = 0;
        }
    }
}
