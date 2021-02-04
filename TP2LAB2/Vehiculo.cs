using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Vehiculo : IComparable, IGuardar
    {
        string modelo, tipoCombustible, patente;
        int capacidad;
        Image imagen;
        int valor;
        bool disponible = true;
        int buscar=1;
        // 1. Patente - 2. Tipo Combustible - 3. Capacidad - 4. Marca
        public Vehiculo(string modelo, string tipocombustible, string patente, int capacidad, int valor) // string modelo, string timpocombustible, string patente, int capacidad, int valor, Image imagen
        {
            Modelo = modelo;
            TipoCombustible = tipocombustible;
            Patente = patente;
            Capacidad = capacidad;
            Valor = valor;
        }

        public void OrdenarPor(int i)
        {
            buscar = i;
        }

        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public string TipoCombustible
        {
            get { return tipoCombustible; }
            set { tipoCombustible = value; }
        }

        public Image Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }

        public int Capacidad
        {
            set { capacidad = value; }
            get { return capacidad; }
        }

        public int Valor
        {
            set { valor = value; }
            get { return valor; }
        }

        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }

        public int CompareTo(Object auto)
        {
            Vehiculo buscado = (Vehiculo)auto;
            int indice=0;

            if (buscado == null) return 1;

            // 1. Patente - 2. Tipo Combustible - 3. Capacidad - 4. Marca
            switch (buscar)
            {
                case 1:
                    indice= this.Patente.CompareTo(buscado.Patente);
                    break;
                case 2:
                    indice = this.TipoCombustible.CompareTo(buscado.TipoCombustible);
                    break;
                case 3:
                    indice = this.Capacidad.CompareTo(buscado.Capacidad);
                    break;
                case 4:
                    indice = this.Modelo.CompareTo(buscado.Modelo);
                    break;
            }
            return indice;
        }
        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public virtual string BackUp()
        {
            return "vehiculo;"
                + modelo + ';'
                + tipoCombustible + ';'
                + patente + ';'
                + capacidad + ';'
                + valor;
        }
    }
}
