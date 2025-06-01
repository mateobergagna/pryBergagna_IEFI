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
            CargarAuditoria();
        }

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
    }
}
