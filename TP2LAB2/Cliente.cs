using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Cliente : Persona, IGuardar
    {
        int dni;
        public string domicilio, estadoCivil, nacionalidad, fechaNac, cuitCuil, telefono;

        public Cliente(string nombre, string domicilio, string estadoCivil, string nacionalidad, int dni, string cuitCuil, string telefono, string fechaNac) : base(nombre)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.cuitCuil = cuitCuil;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.estadoCivil = estadoCivil;
            this.nacionalidad = nacionalidad;
            this.fechaNac = fechaNac;
        }

        public string Domicilio
            {get {return domicilio;} }

        public int DNI
        { get { return dni; } }



        public string BackUp()
        {
            return "cliente;" +
                nombre + ';' +
                domicilio + ';' +
                estadoCivil + ';' +
                nacionalidad + ';' +
                dni + ';' +
                cuitCuil + ';' +
                telefono + ';' +
                fechaNac;
        }
    }
}
