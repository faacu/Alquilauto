using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Historico
    {
        public List<Alquiler> historico = new List<Alquiler>();

        public List<Alquiler> Consulta
        {
            get { return historico; }
        }
        public void AgregarRegistro(Alquiler unAlquiler)
        {
            historico.Add(unAlquiler);
        }
    }
}
