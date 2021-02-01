using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP2LAB2
{
    [Serializable]
    class VehiculoConChofer : Vehiculo
    {
        Chofer chofer;

        public Chofer Conductor
        {
            get { return chofer; }
        }

        public VehiculoConChofer (string modelo, string tipocombustible, string patente, int capacidad, int valor, string nombre, string domicilio, string estadoCivil, string nacionalidad, string dni, string cuitCuil, string telefono, string fechaNac, int edad) :base (modelo, tipocombustible, patente, capacidad, valor)
        {
            chofer = new Chofer(nombre, domicilio, estadoCivil, nacionalidad, dni, cuitCuil, telefono, edad, fechaNac);
        }
    }
}
