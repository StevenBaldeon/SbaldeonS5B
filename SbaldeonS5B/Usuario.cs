using System;
using System.Collections.Generic;
using System.Text;

namespace SbaldeonS5B
{
    public class Usuario
    {
        public int IdUsuarios { set; get; }
        public string Nombre { set; get; }
        public string Email { set; get; }
        public string Contrasena { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Genero { set; get; }

        public string Telefono { set; get; }
    }
}
