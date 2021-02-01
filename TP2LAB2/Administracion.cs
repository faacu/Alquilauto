using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Drawing;


namespace TP2LAB2
{
    [Serializable]
    class Administracion
    {
        List<Vehiculo> ListaDeVehiculos = new List<Vehiculo>();
        List<VehiculoConChofer> ListaDeVehiculosConChofer = new List<VehiculoConChofer>();
        List<Alquiler> registro = new List<Alquiler>();
        Empresa empresa;
        double unidad;
        List<Alquiler> historico = new List<Alquiler>(); // Alquileres finalizados

        // Constructor
        public Administracion() 
        {
            empresa = new Empresa();
        }

        //Propiedades
        public List<Alquiler> Historico
        {
            get { return historico; }
        }
        public List<Alquiler> VerAlquiler
            {
                get { return registro; }
            }
        public List<Vehiculo> listaDeVehiculos
        {
            get { return ListaDeVehiculos; }
        }
        public List<VehiculoConChofer> listaDeVehiculosConChofer
        {
            get { return ListaDeVehiculosConChofer; }
        }
        public double UnidadCobro
        {
            get { return unidad; }
        }
        public Empresa RazonSocial
        {
            get { return empresa; }
        }

        //Métodos
        public void AgregarRegistro(Alquiler unAlquiler)
        {
            historico.Add(unAlquiler);
        }
        public void EditarRegistro(int indice)
        {
            historico.RemoveAt(indice);
            historico.Sort();
        }
        public void AgregarVehiculo(Vehiculo unVehiculo)
        {
            if (unVehiculo is VehiculoConChofer)
            {
                listaDeVehiculosConChofer.Add((VehiculoConChofer)unVehiculo);
            }
            else if (unVehiculo is Vehiculo)
            {
                ListaDeVehiculos.Add(unVehiculo);
            }
        }
        public void OrdenarLista(int filtro, bool tipo)
        {
            if (tipo == true) // Con chofer
            {
                foreach (VehiculoConChofer i in listaDeVehiculosConChofer)
                {
                    i.OrdenarPor(filtro);
                }
                listaDeVehiculosConChofer.Sort();
            }
            else // Sin chofer
            {
                foreach (Vehiculo i in listaDeVehiculos)
                {
                    i.OrdenarPor(filtro);
                }
                listaDeVehiculos.Sort();
            }
        }
        public int BuscarVehiculo(string patente, bool tipo) // Comprobación de patente-búsqueda sin filtros-
        { // true = con chofer | false = sin chofer
            OrdenarLista(1, tipo);
            int i = 0;
            Vehiculo buscado;
            if (tipo == true)
            {
                buscado = new VehiculoConChofer("", "", patente, 1, 1,"","","","","","","","",0);
                buscado.Patente = patente;
                i = listaDeVehiculosConChofer.BinarySearch((VehiculoConChofer)buscado);
            }
            else
            {
                buscado = new Vehiculo("", "", patente, 1, 1);
                buscado.Patente = patente;
                i = listaDeVehiculos.BinarySearch(buscado);
            }
            return i;
        }

        public int Alquiler(Cliente unCliente, DateTime fecha, int dias, bool chofer, string patente)
        {
            Alquiler nuevoAlquiler;
            int posicion = 0;
            if (chofer == true) // Con chofer
            {
                int indice = BuscarVehiculo(patente, chofer);
                nuevoAlquiler = new Alquiler(unCliente, listaDeVehiculosConChofer[indice], fecha, dias, unidad);
                listaDeVehiculosConChofer[indice].Disponible = false;
                registro.Add(nuevoAlquiler);
                posicion = registro.IndexOf(nuevoAlquiler);
            }
            else if (chofer == false) // Sin chofer
            {
                int indice = BuscarVehiculo(patente, chofer);
                nuevoAlquiler = new Alquiler(unCliente, ListaDeVehiculos[indice], fecha, dias, unidad);
                ListaDeVehiculos[indice].Disponible = false;
                registro.Add(nuevoAlquiler);
                posicion = registro.IndexOf(nuevoAlquiler);
            }

            return posicion;
        }
        public string Devolucion(int indice, DateTime fecha, double km)
        {
            Alquiler alquiler = registro[indice];
            alquiler.KmRecorridos = km;
            registro.RemoveAt(indice);
            int dias = fecha.Day - alquiler.Fecha.Day;
            int demora=0;

            if (dias <= alquiler.Dias && fecha.Hour < 22)
            {
                alquiler.PrecioFinal = alquiler.Precio;
            }
            else
            {
                demora = dias - alquiler.Dias;
                if (fecha.Hour >= 22)
                {
                    demora++;
                }
                alquiler.PrecioFinal += alquiler.Precio+ alquiler.Auto.Valor * alquiler.UnidadCosto * 1.10 * demora;
            }

            double kmPermitidos = (alquiler.Dias + demora) * 500;
            if (km > kmPermitidos)
            {
                double diferencia = km - kmPermitidos;
                if (diferencia <= 100)
                {
                    alquiler.PrecioFinal += diferencia * 3 * alquiler.UnidadCosto;
                }
                else if (diferencia > 100)
                {
                    alquiler.PrecioFinal += diferencia * 5 * alquiler.UnidadCosto;
                }
            }

            LiberarVehiculo(alquiler.Auto);
            AgregarRegistro(alquiler);
            return Factura(alquiler);
        }
        public Alquiler Consulta(int indice) // Alquileres activos
        {
            return registro[indice];
        }
        public void EditarUnidades(double precio)
        {
            unidad = precio;
        }
        public void LiberarVehiculo(Vehiculo unVehiculo)
        {
            if (unVehiculo is VehiculoConChofer)
            {
                int i = listaDeVehiculosConChofer.IndexOf((VehiculoConChofer)unVehiculo);
                listaDeVehiculosConChofer[i].Disponible = true;
            }
            else
            {
                int i = listaDeVehiculos.IndexOf(unVehiculo);
                listaDeVehiculos[i].Disponible = true;
            }
        }
        public string Ticket(int indice)
        {
            Alquiler alquiler = registro[indice];
            return "TICKET:\nRazon Social: "+empresa.RazonSocial+ "\nVehiculo: " + alquiler.Auto.Modelo + "\nPatente: " + alquiler.Auto.Patente + "\nCliente: " + alquiler.VerCliente.nombre + "\nFecha Alquiler: " + alquiler.Fecha.ToString("dd/MM/yyyy") + "\nFecha Devolucion: " + alquiler.FechaDevolucion.ToString("dd/MM/yyyy") + "\nValor: $" + alquiler.Precio;
        }
        public string Factura(Alquiler alquiler)
        {
            string texto;
            if (alquiler.Auto is VehiculoConChofer)
                texto = "Razon Social: "+empresa.RazonSocial+ "\nCliente: "+alquiler.VerCliente.Nombre+ "\nCuit: "+alquiler.VerCliente.cuitCuil+"\nPatente: " + alquiler.Auto.Patente + "Km recorridos: " + alquiler.KmRecorridos + "\nValor Inicial: $" + alquiler.Precio.ToString() + "\nViáticos: $" + alquiler.Viaticos + "\nValor Final: $" + alquiler.PrecioFinal;
            else texto = "Razon Social: " + empresa.RazonSocial + "\nCliente: " + alquiler.VerCliente.Nombre + "\nCuit: " + alquiler.VerCliente.cuitCuil + "\nPatente: " + alquiler.Auto.Patente + "Km recorridos: " + alquiler.KmRecorridos + "\nValor Inicial: $" + alquiler.Precio.ToString() + "\nValor Final: $" + alquiler.PrecioFinal;
            
            return texto;
        }
        public void AgregarConductor(int indice, Conductor unConductor)
        {
            registro[indice].AgregarConductor(unConductor);
        }
        public string BajaVehiculo(int indice, bool chofer)
        {
            string mensaje = "";
            if(chofer == true)
            {
                if (listaDeVehiculosConChofer[indice].Disponible == true)
                {
                    listaDeVehiculosConChofer.RemoveAt(indice);
                    mensaje = "El vehiculo ha sido removido";
                }
                else mensaje = "El vehiculo no se encuentra disponible";
            }
            else if (chofer == false)
            {
                if (listaDeVehiculos[indice].Disponible == true)
                {
                    listaDeVehiculos.RemoveAt(indice);
                    mensaje = "El vehiculo ha sido removido";
                }
                else mensaje = "El vehiculo no se encuentra disponible";
            }
            return mensaje;
        }
        public string BackUp (int tipo)//1-Vehiculo,2-Alquileres,3-Clientes
        {
            FileStream fls;
            StreamWriter swr;
            switch (tipo)
            {
                case 1:
                    fls = new FileStream("vehiculo.csv", FileMode.Create, FileAccess.Write);
                    swr = new StreamWriter(fls);
                    for (int i = 0; i < listaDeVehiculos.Count; i++)
                    {
                        swr.WriteLine(listaDeVehiculos[i].BackUp());
                    }
                    for (int i = 0; i < listaDeVehiculosConChofer.Count; i++)
                    {
                        swr.WriteLine(listaDeVehiculosConChofer[i].BackUp());
                    }
                    fls.Dispose();
                    swr.Dispose();
                    break;
                case 2:
                    fls = new FileStream("alquileres.csv", FileMode.Create, FileAccess.Write);
                    swr = new StreamWriter(fls);
                    for (int i = 0; i < registro.Count; i++)
                    {
                        swr.WriteLine(registro[i].BackUp());
                    }
                    fls.Dispose();
                    swr.Dispose();
                    break;
                case 3:
                    fls = new FileStream("clientes.csv", FileMode.Create, FileAccess.Write);
                    swr = new StreamWriter(fls);
                    for (int i = 0; i < registro.Count; i++)
                    {
                        swr.WriteLine(registro[i].VerCliente.BackUp());
                    }
                    fls.Dispose();
                    swr.Dispose();
                    break;
                case 4:
                    fls = new FileStream("clientes.csv", FileMode.Create, FileAccess.Write);
                    swr = new StreamWriter(fls);
                    foreach(VehiculoConChofer a in ListaDeVehiculosConChofer)
                    {
                        swr.WriteLine(a.Conductor.BackUp());
                    }
                    fls.Dispose();
                    swr.Dispose();
                    break;

            }
            return "BackUp exitoso";
        }
    }
}