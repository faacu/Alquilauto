using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Chofer : Persona, IGuardar
    {
        int edad;
        string domicilio, estadoCivil, nacionalidad, fechaNac, cuitCuil, dni, telefono;

        public Chofer (string nombre, string domicilio, string estadoCivil, string nacionalidad, string dni, string cuitCuil, string telefono, int edad, string fechaNac) : base (nombre)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.cuitCuil = cuitCuil;
            this.telefono = telefono;
            this.edad = edad;
            this.domicilio = domicilio;
            this.estadoCivil = estadoCivil;
            this.nacionalidad = nacionalidad;
            this.fechaNac = fechaNac;
        }

        public string BackUp()
        {
            return "chofer;"
                + nombre + ";"
                + domicilio + ";"
                + estadoCivil + ";"
                + nacionalidad + ";"
                + dni + ";"
                + cuitCuil + ";"
                + telefono + ";"
                + fechaNac + ";"
                + edad;  
        }
    }
}

//string nombre, 
//string domicilio, 
//string estadoCivil, 
//string nacionalidad, 
//string dni, 
//string cuitCuil, 
//string telefono, 
//string fechaNac, 
//int edad