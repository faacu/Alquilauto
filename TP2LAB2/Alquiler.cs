using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2LAB2
{
    [Serializable]
    class Alquiler : IGuardar
    {
        Vehiculo auto;
        Cliente cliente;
        DateTime fecha;
        DateTime fechaDevolucion;
        int dias;
        static int numero;
        readonly int orden;
        double precio, viaticos, preciofinal, kmrecorridos;
        List<Conductor> conductores = new List<Conductor>();

        //Constructor
        public Alquiler(Cliente cliente, Vehiculo auto, DateTime fecha, int dias, double valorUnidadCosto)
        {
            this.cliente = cliente;
            this.auto = auto;
            this.fecha = fecha;
            this.dias = dias;
            fechaDevolucion = fecha.AddDays(dias);
            UnidadCosto = valorUnidadCosto;
            orden = numero;
            CostoInicial();
            numero++;
        }

        public void AgregarConductor(Conductor unConductor)
        {
            conductores.Add(unConductor);
        }

        public void CostoInicial()
        {
            if (auto is VehiculoConChofer)
            {
                viaticos = 140 * UnidadCosto;
                precio = auto.Valor * UnidadCosto * dias + viaticos;
            }
            else
            {
                precio = auto.Valor * UnidadCosto;
            }
        }

        public string VerConductor(int indice)
        {
            return "Nombre: " + conductores[indice].Nombre + "\nNro. Carnet: " + conductores[indice].Carnet;
        }

        public string BackUp()
        {
            return orden + ";" + Fecha + ";" + FechaDevolucion + ";" + auto.Patente + ";" + cliente.DNI + ";" + PrecioFinal;
        }

        // Propiedades
        public double PrecioFinal
        {
            get { return preciofinal; }
            set { preciofinal = value; }
        }

        public double Viaticos
        {
            get { return viaticos; }
        }

        public double UnidadCosto
        {
            get;
            set;
        }

        public Vehiculo Auto
        { get { return auto; } }

        public Cliente VerCliente
        { get { return cliente; } }

        public DateTime Fecha
        { get { return fecha; } }

        public DateTime FechaDevolucion
        { get { return fechaDevolucion; } }

        public int Dias
        { get { return dias; } }

        public int Orden
        { get { return orden; } }

        public double KmRecorridos
        {
            get { return kmrecorridos; }
            set { kmrecorridos = value; }
        }

        public double Precio
        { get { return precio; } }
    }
}
