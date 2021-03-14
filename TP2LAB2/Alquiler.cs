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
        double adicionalkm = 0;
        double adicionaldias = 0;
        int diastranscurridos = 0, cantConductor = 0;//

        public int DiasTranscurridos
        {
            get { return diastranscurridos; }
            set { diastranscurridos = value; }
        }

        public double AdicionalKm
        {
            get { return adicionalkm; }
            set { adicionalkm = value; }
        }

        public double AdicionalDias
        {
            get { return adicionaldias; }
            set { adicionaldias = value; }
        }

        public int CantConductores //
        {
            get { return cantConductor; }
        }

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
            cantConductor++;
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
            return "Nombre: " + conductores[indice].Nombre + "\nNro. Carnet: " + conductores[indice].Carnet + "\nModelo: " + auto.Modelo + "\nPatente: " + auto.Patente + "\nCombustible: " + auto.TipoCombustible + "\nCapacidad: " + auto.Capacidad + "\nValor: " + auto.Valor;
        }

        public Conductor ImagenConductor(int indice)
        {
            return conductores[indice];
        }

        public string BackUp()
        {
            return "alquiler;"
                + cliente.BackUp() 
                + ';' + auto.BackUp() 
                + ';' + fecha.ToString("dd/MM/yyyy")
                + ';' + dias
                + ';' + UnidadCosto;
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
