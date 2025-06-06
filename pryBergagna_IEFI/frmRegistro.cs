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
    public partial class frmRegistro : Form
    {

        //Conexion
        clsConexionBD conexion = new clsConexionBD();

        public frmRegistro()
        {
            InitializeComponent();
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cmbTarea.Items.AddRange(new string[] { "Auditoría", "Consultas", "Inspección", "Reclamos", "Visita" });
            cmbLugar.Items.AddRange(new string[] { "Empresa", "Servicio", "Oficina" });

            cmbTarea.SelectedIndex = 0;
            cmbLugar.SelectedIndex = 0;

            CargarGrilla();
        }
        private void CargarGrilla()
        {
            clsConexionBD conexion = new clsConexionBD();
            conexion.ListarTareas(dgvTareas); 
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear el DateTimePicker a la fecha de hoy
            dtpFecha.Value = DateTime.Today;

            // Limpiar ComboBoxes
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;

            // Limpiar comentarios
            txtComentarios.Clear();

            // Desmarcar todos los CheckBoxes
            chkInsumos.Checked = false;
            chkEstudio.Checked = false;
            chkVacacion.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsTarea tarea = new clsTarea
            {
                Fecha = dtpFecha.Value,
                Tarea = cmbTarea.SelectedItem.ToString(),
                Lugar = cmbLugar.SelectedItem.ToString(),
                Comentarios = txtComentarios.Text,
                Uniforme = chkInsumos.Checked,
                LicenciaEstudio = chkEstudio.Checked,
                LicenciaVacacion = chkVacacion.Checked,
                ReclamoSalario = chkSalario.Checked,
                ReclamoRecibo = chkRecibo.Checked
            };

            clsConexionBD conexion = new clsConexionBD();
            conexion.AgregarTarea(tarea);

            CargarGrilla();
        }
    }
}
