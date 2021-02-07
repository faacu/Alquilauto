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
        List<Alquiler> registro = new List<Alquiler>(); // Alquileres activos
        Empresa empresa;
        double unidad;
        List<Alquiler> historico = new List<Alquiler>(); // Alquileres finalizados
        int IdFacturas = 0;

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
                buscado = new VehiculoConChofer("", "", patente, 1, 1, "", "", "", "", "", "", "", "", 0);
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
            int demora = 0;

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
                alquiler.PrecioFinal += alquiler.Precio + alquiler.Auto.Valor * alquiler.UnidadCosto * 1.10 * demora;
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
            return "TICKET:\nRazon Social: " + empresa.RazonSocial + "\nVehiculo: " + alquiler.Auto.Modelo + "\nPatente: " + alquiler.Auto.Patente + "\nCliente: " + alquiler.VerCliente.nombre + "\nFecha Alquiler: " + alquiler.Fecha.ToString("dd/MM/yyyy") + "\nFecha Devolucion: " + alquiler.FechaDevolucion.ToString("dd/MM/yyyy") + "\nValor: $" + alquiler.Precio;
        }
        public string Factura(Alquiler alquiler)
        {
            string texto;
            if (alquiler.Auto is VehiculoConChofer)
                texto = "Razon Social: " + empresa.RazonSocial + "\nCliente: " + alquiler.VerCliente.Nombre + "\nCuit: " + alquiler.VerCliente.cuitCuil + "\nPatente: " + alquiler.Auto.Patente + "Km recorridos: " + alquiler.KmRecorridos + "\nValor Inicial: $" + alquiler.Precio.ToString() + "\nViáticos: $" + alquiler.Viaticos + "\nValor Final: $" + alquiler.PrecioFinal;
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
            if (chofer == true)
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
        public string BackUp()
        {
            //string archivo = "BackUp(" + DateTime.Now + ").csv";
            FileStream fls = new FileStream("Back Up.csv", FileMode.Create, FileAccess.Write);
            StreamWriter swr = new StreamWriter(fls);

            foreach (Alquiler a in registro)
            {
                swr.WriteLine(a.BackUp());
            }
            foreach (Vehiculo v in listaDeVehiculos)
            {
                swr.WriteLine(v.BackUp());
            }
            foreach (VehiculoConChofer vc in listaDeVehiculosConChofer)
            {
                swr.WriteLine(vc.BackUp());
            }

            swr.Close();
            fls.Dispose();

            return "Los datos han sido exportados exitosamente";
        }

        public string Importar(string path)
        {
            FileStream fls = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader srd = new StreamReader(fls);
            List<string> lineas = new List<string>();

            while (srd.EndOfStream == false)
            {
                string linea = srd.ReadLine();
                lineas.Add(linea);
            }

            foreach (string l in lineas)
            {
                string[] datos = l.Split(';');
                Cliente cl;
                Vehiculo vh;
                Alquiler alq;

                if (datos[0] == "alquiler")
                {
                    // 2 al 9
                    cl = new Cliente(datos[2], datos[3], datos[4], datos[5], Convert.ToInt32(datos[6]),
                        datos[7], datos[8], datos[9]);

                    if (datos.Contains("chofer")==true)
                    {
                        // 11 al 25
                        // alquiler con chofer
                        vh = new VehiculoConChofer(datos[11], datos[12], datos[13], Convert.ToInt32(datos[14]), Convert.ToInt32(datos[15]),
                            datos[17], datos[18], datos[19], datos[20], datos[21], datos[22],
                            datos[23], datos[24], Convert.ToInt32(datos[25]));
                        DateTime fecha = new DateTime();
                        //alq = new Alquiler(cl, vh, )
                    }
                    else
                    {
                        // 11 al 15
                        // Alquiler sin chofer
                        vh = new Vehiculo(datos[11], datos[12], datos[13], Convert.ToInt32(datos[14]), Convert.ToInt32(datos[15]));
                    }
                }

                else if (datos[0] == "vehiculo")
                { 
                    
                }

                else if (datos[0] == "vehiculoconchofer")
                { 
                    
                }
            }

            srd.Close();
            fls.Dispose();

            return "Los datos han sido importados exitosamente";
        }
    }
}