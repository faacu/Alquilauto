using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Empresa
    {
        string razonsocial, direccion, cuit;

        public Empresa()
        {
            RazonSocial = "Alquilauto";
            Cuit = "20357073589";
            Direccion = "P. Sherman 42";
        }

        public string RazonSocial
        {
            get { return razonsocial; }
            set { razonsocial = value; }
        }
        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
