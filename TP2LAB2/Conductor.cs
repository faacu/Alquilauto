using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP2LAB2
{
    [Serializable]
    class Conductor : Persona
    {
        

        public string Carnet
        {
            get;
        }

        public Image Foto
        {
            get;
        }
        public Conductor (string nombre, string carnet, Image foto) : base (nombre)
        {
            Carnet = carnet;
            Foto = foto;
        }
    }
}
