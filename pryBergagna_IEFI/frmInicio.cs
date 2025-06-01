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
    public partial class frmInicio : Form
    {
        private clsUsuario usuarioLogueado;
        private DateTime horaInicio;
        private int tiempoActual = 0;
        private DateTime horaInicioSesion;
        private string nombreUsuarioActual = "admin"; 

        clsConexionBD conexion = new clsConexionBD();

        public frmInicio(clsUsuario usuario, DateTime inicio)
        {
            InitializeComponent();

            // Guardamos los datos recibidos
            usuarioLogueado = usuario;
            horaInicio = inicio;

            // Mostrar usuario activo en la barra de estado
            lblUsuarioActivo.Text = $"Usuario Activo: {usuario.NombreUsuario}";

            // Mostrar fecha actual
            lblFechaInicio.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";

            // Iniciar timer para mostrar tiempo
            timer1.Start();
        }
        
        private void frmInicio_Load(object sender, EventArgs e)
        {
            horaInicioSesion = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoActual++;
            TimeSpan tiempo = TimeSpan.FromSeconds(tiempoActual);
            lblTiempo.Text = $"Tiempo: {tiempo.ToString(@"hh\:mm\:ss")}";
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void mnuAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime horaFin = DateTime.Now;
            TimeSpan duracion = horaFin - horaInicioSesion;

            clsConexionBD conexion = new clsConexionBD();
            conexion.GuardarSesion(nombreUsuarioActual, horaInicioSesion, horaFin, duracion);
        }
    }
}
