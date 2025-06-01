using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pryBergagna_IEFI
{
    public class clsUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int RolId { get; set; }
        public string NombreUsuario { get; set; }
        public string DNI { get; set; }
        public string Gmail { get; set; }
        public string Telefono { get; set; }

        public clsUsuario(int id, string nombre, string contraseña, int rolId, string dni, string gmail, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            RolId = rolId;
            DNI = dni;
            Gmail = gmail;
            Telefono = telefono;
        }
        public clsUsuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }
    }
}
