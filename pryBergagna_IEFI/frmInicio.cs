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
        clsConexionBD conexion = new clsConexionBD();

        public frmInicio(clsUsuario usuario, DateTime inicio)
        {
            InitializeComponent();
        }
        
        private void frmInicio_Load(object sender, EventArgs e)
        {
             
        }
    }
}
