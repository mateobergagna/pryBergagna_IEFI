﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBergagna_IEFI
{
    internal class clsConexionBD
    {
        //Cadena de Conexion
        //

        //Verificar Conexión
        public void ConectarBD()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Listar BD
        public void ListarBD(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT u.Id, u.Nombre, u.Contraseña, r.Nombre AS Rol FROM Usuarios u INNER JOIN Roles r ON u.RolId = r.Id;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    Grilla.DataSource = tabla;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar los Usuarios correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Agregar
        public void Agregar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Contraseña, RolId) VALUES (@nombre, @contraseña, @rolId)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@rolId", 2);  //Siempre será 'usuario'//

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Modificar
        public void Modificar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Nombre = @nombre, Contraseña = @contraseña  WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@id", usuario.Id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Eliminar
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



        //Buscar por nombre
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




        //-----------------------------------------------------------------------------------------------------------------

        //Guardar Sesión
        public void GuardarSesion(string nombreUsuario, DateTime horaInicio, DateTime horaFin, TimeSpan tiempototal)
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
                    comando.Parameters.AddWithValue("@TotalHoras", tiempototal);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar Sesión: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Listar Sesiones
        public void ListarSesiones(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = "SELECT u.Id, u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TotalHoras AS TiempoTranscurrido FROM Sesiones s INNER JOIN Usuarios u ON s.IdUsuario = u.Id ORDER BY s.FechaInicio DESC, s.HoraInicio DESC;";


                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar las sesiones correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //-----------------------------------------------------------------------------------------

        //Verificar Usuario
        public bool verificarUsuario(clsUsuario usuario)
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

                    object match = comando.ExecuteScalar();

                    if (match != null)
                    {
                        usuario.RolId = Convert.ToInt32(match);
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
    }
}
