using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Persona
    {
        public string nombre;

        public string Nombre
        {
            get { return nombre; }
        }

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
    }
}
