using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBergagna_IEFI
{
    public class clsTarea
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tarea { get; set; }
        public string Lugar { get; set; }
        public string Comentarios { get; set; }

        public bool Uniforme { get; set; }
        public bool LicenciaEstudio { get; set; }
        public bool LicenciaVacacion { get; set; }
        public bool ReclamoSalario { get; set; }
        public bool ReclamoRecibo { get; set; }
    }
}
