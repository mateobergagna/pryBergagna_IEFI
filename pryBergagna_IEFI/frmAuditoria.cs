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
    public partial class frmAuditoria : Form
    {

        clsConexionBD conexion = new clsConexionBD();

        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            CargarAuditoria(); // Carga todos los registros de la auditoría
        }

        // Método que carga todas las sesiones
        private void CargarAuditoria()
        {
            clsConexionBD conexion = new clsConexionBD();
            string cadenaConexion = conexion.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conn.Open();
                    string consulta = @"SELECT U.Nombre AS Usuario, R.Nombre AS Rol, 
                           S.FechaInicio AS 'Fecha', S.HoraInicio AS 'Hora Inicio'
                    FROM Sesiones S
                    INNER JOIN Usuarios U ON S.IdUsuario = U.Id
                    INNER JOIN Roles R ON U.RolId = R.Id";

                    // Adaptador que ejecuta la consulta y llena una tabla en memoria
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvAuditoria.DataSource = tabla;
                    dgvAuditoria.ReadOnly = true;
                    dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar auditoría: " + ex.Message);
                }
            }
        }
        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = conexion.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conn.Open();

                    // Se obtiene la fecha seleccionada del DateTimePicker
                    DateTime fechaSeleccionada = dtpFecha.Value.Date;
                    string consulta = @"
                SELECT U.Nombre AS Usuario, R.Nombre AS Rol, 
                       S.FechaInicio AS 'Fecha', S.HoraInicio AS 'Hora Inicio'
                FROM Sesiones S
                INNER JOIN Usuarios U ON S.IdUsuario = U.Id
                INNER JOIN Roles R ON U.RolId = R.Id
                WHERE CAST(S.FechaInicio AS DATE) = @FechaSeleccionada";

                    SqlCommand comando = new SqlCommand(consulta, conn);
                    comando.Parameters.AddWithValue("@FechaSeleccionada", fechaSeleccionada);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvAuditoria.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros para la fecha seleccionada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar auditoría: " + ex.Message);
                }
            }
        }
    }
}
