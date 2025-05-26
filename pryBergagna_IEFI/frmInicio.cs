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

        private string nombreUsuario;
        private int rolUsuario;
        private DateTime horaInicio;
        private DateTime horaFin;
        private TimeSpan tiempoTotal;


        private int tiempoActual = 0;

        clsConexionBD conexion = new clsConexionBD();

        public frmInicio()
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = rol;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now; 
            timerTiempo.Enabled = true; 

            //Usuario activo
            lblUsuarioActivo.Text = $"Bienvenido: {nombreUsuario}";

            //Fecha de Inicio
            lblFechaInicio.Text = $"Fecha de Inicio: {horaInicio.ToString("dd/MM/yyyy")}";


            //control de acceso
            if (rolUsuario == 1)
            {
                mnuHome.Visible = true;
                mnuTareas.Visible = false;
                mnuAdmin.Visible = true;

            }
            else
            {
                mnuHome.Visible = true;
                mnuTareas.Visible = true;
                mnuAdmin.Visible = false;
            }
        }

        //Cierre FrmInicio
        // private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //  timerTiempo.Enabled = false; //detiene el timer

        //  horaFin = DateTime.Now; //obtiene la hora de cierre 

            //Tiempo Total
           // tiempoTotal = horaFin - horaInicio;
            //conexion.GuardarSesion(nombreUsuario, horaInicio, horaFin, tiempoTotal);

            //Application.Exit();
        //}

       
    }
}
