using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Gardel
{
    internal class Usuario
    {
        public string IdUsuario { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private string Mail { get; set; }

        public Usuario() { }

        public Usuario(string idUsuario, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }
}
