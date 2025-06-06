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
    public partial class frmTareas : Form
    {

        clsConexionBD conexion = new clsConexionBD();

        public frmTareas()
        {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            // Cargar todas las tareas al iniciar
            conexion.ListarTareas(dgvTareas);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            conexion.BuscarTareasPorFecha(dgvTareas, fechaSeleccionada);
        }
    }
}
