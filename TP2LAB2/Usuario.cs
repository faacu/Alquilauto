using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    class Administrador : Persona
    {
        bool tipo; // true=supervisor | false=administrador

        public bool Tipo
        {
            get { return tipo; }
        }
        public string Contraseña
        {
            get;
            set;
        }
        public Administrador (string nombreUsuario, bool tipo, string contraseña) : base (nombreUsuario)
        {           
            this.tipo = tipo;
            this.Contraseña = contraseña;
        }
    }
}
