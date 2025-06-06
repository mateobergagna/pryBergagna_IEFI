using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBergagna_IEFI
{
    public class clsConexionBD
    {

        // Cadena de conexión 
        public string cadena = @"Server=DESKTOP-2KP08TQ\Mateo;Database=GestionUsuarios;Trusted_Connection=True;";
        //string cadena = @"Server=.\SQLEXPRESS;Database=GestionUsuarios;Trusted_Connection=True;";
  
        public string CadenaConexion
        {
            get { return cadena; }
        }

        public bool ConectarBD()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                }
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Listar Usuarios en un DataGridView
        public void ListarBD(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre, Contraseña, RolId, DNI, Gmail, Telefono FROM Usuarios";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudieron cargar los Usuarios correctamente. Detalles: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Agregar usuario nuevo
        public void Agregar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Usuarios (Nombre, Contraseña, RolId, DNI, Gmail, Telefono) VALUES (@Nombre, @Contraseña, @RolId, @DNI, @Gmail, @Telefono)", conexion);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@RolId", usuario.RolId);
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Gmail", usuario.Gmail);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Modificar usuario existente
        public void Modificar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Usuarios SET Nombre = @Nombre, Contraseña = @Contraseña, RolId = @RolId, DNI = @DNI, Gmail = @Gmail, Telefono = @Telefono WHERE Id = @Id", conexion);
                    cmd.Parameters.AddWithValue("@Id", usuario.Id);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@RolId", usuario.RolId);
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Gmail", usuario.Gmail);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar usuario por Id
        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar usuarios por nombre
        public void BuscarporNombre(DataGridView Grilla, string nombreUsuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Usuarios WHERE Nombre LIKE @nombre";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombre", "%" + nombreUsuario + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró el usuario", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Grilla.DataSource = tabla;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al buscar el usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verificar usuario (login)
        public bool VerificarUsuario(clsUsuario usuario)
        {
            bool loginExitoso = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT RolId FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                    object rol = comando.ExecuteScalar();

                    if (rol != null)
                    {
                        usuario.RolId = Convert.ToInt32(rol);
                        loginExitoso = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al verificar el Usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return loginExitoso;
        }

        // Guardar sesión (ejemplo básico)
        public void GuardarSesion(string nombreUsuario, DateTime horaInicio, DateTime horaFin, TimeSpan tiempoTotal)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"INSERT INTO Sesiones (IdUsuario, FechaInicio, HoraInicio, HoraFin, TotalHoras)
                                     VALUES (
                                        (SELECT Id FROM Usuarios WHERE Nombre = @NombreUsuario),
                                        @FechaInicio, @HoraInicio, @HoraFin, @TotalHoras)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@FechaInicio", horaInicio.Date);
                    comando.Parameters.AddWithValue("@HoraInicio", horaInicio);
                    comando.Parameters.AddWithValue("@HoraFin", horaFin);
                    comando.Parameters.Add("@TotalHoras", SqlDbType.Decimal).Value = Math.Round(tiempoTotal.TotalHours, 2);


                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar Sesión: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Listar sesiones en un DataGridView
        public void ListarSesiones(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"SELECT u.Id, u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TotalHoras AS TiempoTranscurrido 
                                     FROM Sesiones s 
                                     INNER JOIN Usuarios u ON s.IdUsuario = u.Id 
                                     ORDER BY s.FechaInicio DESC, s.HoraInicio DESC;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudieron cargar las sesiones correctamente. Detalles: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        public void AgregarTarea(clsTarea tarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"INSERT INTO Tareas 
                (Fecha, Tarea, Lugar, Comentarios, Uniforme, LicenciaEstudio, LicenciaVacacion, ReclamoSalario, ReclamoRecibo)
                VALUES 
                (@Fecha, @Tarea, @Lugar, @Comentarios, @Uniforme, @LicenciaEstudio, @LicenciaVacacion, @ReclamoSalario, @ReclamoRecibo)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Fecha", tarea.Fecha);
                    comando.Parameters.AddWithValue("@Tarea", tarea.Tarea);
                    comando.Parameters.AddWithValue("@Lugar", tarea.Lugar);
                    comando.Parameters.AddWithValue("@Comentarios", tarea.Comentarios);
                    comando.Parameters.AddWithValue("@Uniforme", tarea.Uniforme);
                    comando.Parameters.AddWithValue("@LicenciaEstudio", tarea.LicenciaEstudio);
                    comando.Parameters.AddWithValue("@LicenciaVacacion", tarea.LicenciaVacacion);
                    comando.Parameters.AddWithValue("@ReclamoSalario", tarea.ReclamoSalario);
                    comando.Parameters.AddWithValue("@ReclamoRecibo", tarea.ReclamoRecibo);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tarea registrada con éxito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarTareas(DataGridView grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Tareas ORDER BY Fecha DESC";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    grilla.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BuscarTareasPorFecha(DataGridView grilla, DateTime fecha)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Tareas WHERE CONVERT(date, Fecha) = @fecha";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    grilla.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron tareas para esa fecha.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar tareas por fecha: " + ex.Message);
            }
        }
    }
}
