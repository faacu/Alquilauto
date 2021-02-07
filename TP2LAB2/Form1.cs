using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace TP2LAB2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Administrador usuario;
            Logueo logueo = new Logueo();
            FileStream fls = new FileStream("usuario.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fls);
            string linea;
            linea = sr.ReadLine();
            List<Administrador> listausuario = new List<Administrador>();
            while(linea != null)
            {
                string[] datos = linea.Split(';');
                if (datos[2] == "Administrador")
                {
                    usuario = new Administrador(datos[0], false, datos[1]);
                    listausuario.Add(usuario);
                }
                else if (datos[2] == "Supervisor")
                {
                    usuario = new Administrador(datos[0], true, datos[1]);
                    listausuario.Add(usuario);
                }
                logueo.comboBoxNombre.Items.Add(datos[0]);
                linea = sr.ReadLine();
            }
            sr.Close();
            fls.Dispose();
            logueo.ShowDialog();

            if (logueo.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (logueo.comboBoxNombre.Text == listausuario[logueo.comboBoxNombre.SelectedIndex].Nombre && logueo.textBox1.Text == listausuario[logueo.comboBoxNombre.SelectedIndex].Contraseña)
                    {
                        if (listausuario[logueo.comboBoxNombre.SelectedIndex].Tipo == true)
                        {
                            tb_Tipo.Text = "Supervisor";
                            agregarUsuarioToolStripMenuItem.Enabled = true;
                        }

                        else
                        {
                            tb_Tipo.Text = "Administrador";
                            bt_Agregar.Enabled = false;
                            bt_Registro.Enabled = false;
                            bt_Valor.Enabled = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: uno o más de los datos ingresados no coinciden. Intentelo nuevamente.");
                    }
                }
                catch
                {
                    MessageBox.Show("Uno o más de los campos requeridos no ha sido completado");
                    logueo.ShowDialog();
                }
            }
        }
        FormAlquiler formalquiler;
        Administracion miAdministracion = new Administracion();
        FormAgregarAuto agregarauto;
        UnidadCobro ActualizarUnidad = new UnidadCobro();
        Devolucion devolucion;
        Factura factura = new Factura();
        Historico historico = new Historico();
        Estadisticas diagrama = new Estadisticas();
        int indiceDtgv;
        bool chofer;
        int filtro=1;
        AyudaWeb ayudaW = new AyudaWeb();
        NuevoUsuario nuevo = new NuevoUsuario();
        Consulta consulta;
        Registro registro;

        public void Buscar() // 1. Patente - 2. Tipo Combustible - 3. Capacidad - 4. Marca
        {
            List<Vehiculo> mostrar = new List<Vehiculo>();
            if (chofer == true)
            {
                foreach (VehiculoConChofer a in miAdministracion.listaDeVehiculosConChofer)
                {
                    switch (filtro)
                    {
                        case 1:
                            if (a.Disponible==true)
                            mostrar.Add(a);
                            break;
                        case 2:
                            if (a.TipoCombustible==cb_Combustible.Text&& a.Disponible == true)
                            mostrar.Add(a);
                            break;
                        case 3:
                            if (a.Capacidad == (Convert.ToInt32(cb_Combustible.Text)) && a.Disponible == true)
                                mostrar.Add(a);
                            break;
                        case 4:
                            if (a.Modelo == cb_Marca.Text && a.Disponible == true)
                                mostrar.Add(a);
                            break;
                    }
                }
            }
            else
            {
                foreach (Vehiculo a in miAdministracion.listaDeVehiculos)
                {
                    switch (filtro)
                    {
                        case 1:
                            if (a.Disponible == true)
                                mostrar.Add(a);
                            break;
                        case 2:
                            if (a.TipoCombustible == cb_Combustible.Text && a.Disponible == true)
                                mostrar.Add(a);
                            break;
                        case 3:
                            if (a.Capacidad == (Convert.ToInt32(cb_Capacidad.Text)) && a.Disponible == true)
                                mostrar.Add(a);
                            break;
                        case 4:
                            if (a.Modelo == cb_Marca.Text && a.Disponible == true)
                                mostrar.Add(a);
                            break;
                    }
                }
            }
            foreach (Vehiculo a in mostrar)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = a.Modelo;
                dataGridView1.Rows[n].Cells[1].Value = a.Patente;
                dataGridView1.Rows[n].Cells[2].Value = a.TipoCombustible;
                dataGridView1.Rows[n].Cells[3].Value = a.Capacidad;
            }
        }

        private void bt_Alquilar_Click(object sender, EventArgs e)
        {
            formalquiler = new FormAlquiler();
            if (radioButtonChofer.Checked == true)
            {
                formalquiler.nud_Conductores.Enabled = false;
                formalquiler.gb_Conductor1.Enabled = false;
            }

            if (dataGridView1.SelectedCells.Count>0)
            {
                formalquiler.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo de la lista.");
            }

            if (formalquiler.DialogResult == DialogResult.OK)
            {
                try
                {
                string fecha = formalquiler.dateTimePickerNacimiento.ToString();
                Cliente unCliente = new Cliente(formalquiler.tb_Nombre.Text, formalquiler.tb_Domicilio.Text, formalquiler.tb_EstadoCivil.Text, formalquiler.tb_Nacionalidad.Text, Convert.ToInt32(formalquiler.tb_Dni.Text), formalquiler.tb_CuitCuil.Text, formalquiler.tb_Telefono.Text, fecha);
                DateTime fechaAlquiler = formalquiler.dateTimePicker1.Value;
                bool chofer = true;
                if (radioButtonChofer.Checked == true)
                {
                    chofer = true;
                }
                else if (radioButtonSinChofer.Checked == true)
                {
                    chofer = false;
                }
                int indice = miAdministracion.Alquiler(unCliente, fechaAlquiler, Convert.ToInt32(formalquiler.nud_Dias.Value), chofer, (string)dataGridView1.Rows[indiceDtgv].Cells[1].Value);


                    Conductor unConductor;
                    if (radioButtonSinChofer.Checked == true)
                    {
                        switch (Convert.ToInt32(formalquiler.nud_Conductores.Value))
                        {
                            case 1:
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c1nombre.Text, formalquiler.tb_c1Carnet.Text, Image.FromFile(formalquiler.path1.FileName)));
                                break;
                            case 2:
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c1nombre.Text, formalquiler.tb_c1Carnet.Text, Image.FromFile(formalquiler.path1.FileName)));
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c2Nombre.Text, formalquiler.tb_c2Carnet.Text, Image.FromFile(formalquiler.path2.FileName)));
                                break;
                            case 3:
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c1nombre.Text, formalquiler.tb_c1Carnet.Text, Image.FromFile(formalquiler.path1.FileName)));
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c2Nombre.Text, formalquiler.tb_c2Carnet.Text, Image.FromFile(formalquiler.path2.FileName)));
                                miAdministracion.AgregarConductor(indice, unConductor = new Conductor(formalquiler.tb_c3nombre.Text, formalquiler.tb_c3Carnet.Text, Image.FromFile(formalquiler.path3.FileName)));
                                break;
                        }
                        int h = 0;
                        while (h < formalquiler.nud_Conductores.Value)
                        {
                            factura.conductores[h] = miAdministracion.Consulta(indice).VerConductor(h);
                            h++;
                        }
                    }
                    factura.texto[0] = "Comprobante";
                    factura.texto[1] = "(No válido como factura)";
                    factura.texto[2] = miAdministracion.Ticket(indice);
                    factura.label1.Text = miAdministracion.Ticket(indice);
                    factura.mostrarconductores = true;

                    factura.ShowDialog();
                    radioButtonChofer.Checked = false;
                    radioButtonSinChofer.Checked = false;
                }
                catch
                {
                    MessageBox.Show("Uno o más de los campos solicitados no ha sido completado");
                    formalquiler.ShowDialog();
                }
            }
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            agregarauto = new FormAgregarAuto();
            agregarauto.ShowDialog();

            if (agregarauto.DialogResult == DialogResult.OK)
            {
                if (agregarauto.cb_Chofer.Checked == true)
                {
                    if (miAdministracion.BuscarVehiculo(agregarauto.tb_Patente.Text, true) >= 0 || miAdministracion.BuscarVehiculo(agregarauto.tb_Patente.Text, false) >= 0)
                    {
                        MessageBox.Show("La patente actual ya existe.\nVerifique los datos del vehiculo");
                    }
                    else
                    {
                        Image imagen = Image.FromFile(agregarauto.archivoImagen.FileName);
                        Vehiculo nuevoVehiculo = new VehiculoConChofer(agregarauto.tb_Marca.Text, agregarauto.cb_Combustible.Text, agregarauto.tb_Patente.Text, Convert.ToInt32(agregarauto.nud_Capacidad.Value), Convert.ToInt32(agregarauto.nud_Valor.Value), agregarauto.tb_Nombre.Text, agregarauto.tb_Domicilio.Text, agregarauto.tb_EstadoCivil.Text, agregarauto.tb_Nacionalidad.Text, agregarauto.tb_Dni.Text, agregarauto.tb_CuitCuil.Text, agregarauto.tb_Telefono.Text, agregarauto.dateTimePickerNac.ToString(), Convert.ToInt32(agregarauto.nud_Edad.Value));
                        nuevoVehiculo.Imagen = imagen;
                        miAdministracion.AgregarVehiculo(nuevoVehiculo);
                    }
                }
                else if (agregarauto.cb_Chofer.Checked == false)
                {
                    if (miAdministracion.BuscarVehiculo(agregarauto.tb_Patente.Text, false) >= 0 || miAdministracion.BuscarVehiculo(agregarauto.tb_Patente.Text, true) >= 0)
                    {
                           MessageBox.Show("La patente actual ya existe.\nVerifique los datos del vehiculo");
                    }
                    else
                    {
                            Image imagen = Image.FromFile(agregarauto.archivoImagen.FileName);
                            Vehiculo nuevoVehiculo = new Vehiculo(agregarauto.tb_Marca.Text, agregarauto.cb_Combustible.Text, agregarauto.tb_Patente.Text, Convert.ToInt32(agregarauto.nud_Capacidad.Value), Convert.ToInt32(agregarauto.nud_Valor.Value));
                            nuevoVehiculo.Imagen = imagen;
                        miAdministracion.AgregarVehiculo(nuevoVehiculo);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fls = new FileStream("administracion.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter formateador = new BinaryFormatter();
            if (fls.Length != 0)
            {
                miAdministracion = (Administracion)formateador.Deserialize(fls);
            }
            fls.Close(); 
        }
        private void bt_Valor_Click(object sender, EventArgs e)
        {
            ActualizarUnidad.ShowDialog();

            if (ActualizarUnidad.bt_Aceptar.DialogResult == DialogResult.OK)
                miAdministracion.EditarUnidades(Convert.ToDouble(ActualizarUnidad.tb_Precio.Text));
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
        }

        private void bt_Siguiente_Click(object sender, EventArgs e)
        {
        }

        private void bt_Anterior_Click(object sender, EventArgs e)
        {

        }

        private void bt_Aceptar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cb_Filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Filtro.Checked == true)
            {
                gb_Busqueda.Visible = true;
            }
            else if (cb_Filtro.Checked == false)
            {
                gb_Busqueda.Visible = false;
            }
        }

        private void rb_Marca_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Marca.Checked == true)
            {
                cb_Marca.Enabled = true;
            }
            else if (rb_Marca.Checked == false)
            {
                cb_Marca.Enabled = false;
            }
            filtro = 4;
            miAdministracion.OrdenarLista(4, chofer);
        }

        private void rb_Pasajeros_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Pasajeros.Checked == true)
            {
                cb_Capacidad.Enabled = true;
            }
            else if (rb_Pasajeros.Checked == false)
            {
                cb_Capacidad.Enabled = false;
            }
            filtro = 3;
            miAdministracion.OrdenarLista(filtro, chofer);
        }

        private void rb_Combustible_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Combustible.Checked == true)
            {
                cb_Combustible.Enabled = true;
            }
            else if (rb_Combustible.Checked == false)
            {
                cb_Combustible.Enabled = false;
            }
            filtro = 2;
            miAdministracion.OrdenarLista(filtro, chofer);
        }

        private void cb_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cb_Capacidad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_Combustible_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            LimpiarDataGrid();
            Buscar();
        }

        private void bt_Devolucion_Click(object sender, EventArgs e)
        {
            devolucion = new Devolucion();
            foreach(Alquiler mostrar in miAdministracion.VerAlquiler)
            {
                string alquiler = mostrar.Orden + " | " + mostrar.VerCliente.nombre + " | " + mostrar.Fecha;
                devolucion.Agregar(alquiler);
            }
            devolucion.ShowDialog();

            if(devolucion.DialogResult == DialogResult.OK)
            {
                DateTime fechaDevolucion = devolucion.dateTimePickerDevolucion.Value;
                if (devolucion.comboBox1.SelectedIndex >= 0)
                {
                    string texto = miAdministracion.Devolucion(devolucion.comboBox1.SelectedIndex, fechaDevolucion, Convert.ToDouble(devolucion.textBoxKm.Text));
                    factura.label1.Text = texto;
                    factura.texto[0] = "Factura";
                    factura.texto[1] = "(Comprobante válido de pago)";
                    factura.texto[2] = texto;
                    factura.label1.Text = texto;
                    factura.ShowDialog();
                    devolucion.LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un alquiler de la lista");
                    devolucion.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//boton agregar
        {
            // 1. Patente - 2. Tipo Combustible - 3. Capacidad - 4. Marca
            if (chofer == true)
            {
                switch (filtro)
                {
                    case 2:
                        {
                            foreach (VehiculoConChofer a in miAdministracion.listaDeVehiculosConChofer)
                            {
                                if (cb_Combustible.Items.Contains(a.TipoCombustible) == false)
                                    cb_Combustible.Items.Add(a.TipoCombustible);
                            }
                        }
                        break;
                    case 3:
                        {
                            foreach (VehiculoConChofer a in miAdministracion.listaDeVehiculosConChofer)
                            {
                                if (cb_Capacidad.Items.Contains(a.Capacidad) == false)
                                    cb_Capacidad.Items.Add(a.Capacidad);
                            }
                        }
                        break;
                    case 4:
                        {
                            foreach (VehiculoConChofer a in miAdministracion.listaDeVehiculosConChofer)
                            {
                                if (cb_Marca.Items.Contains(a.Modelo) == false)
                                    cb_Marca.Items.Add(a.Modelo);
                            }
                        }
                        break;
                }
            }
            else
            {
                switch (filtro)
                {
                    case 2:
                        {
                            foreach (Vehiculo a in miAdministracion.listaDeVehiculos)
                            {
                                if (cb_Combustible.Items.Contains(a.TipoCombustible) == false)
                                    cb_Combustible.Items.Add(a.TipoCombustible);
                            }
                        }
                        break;
                    case 3:
                        {
                            foreach (Vehiculo a in miAdministracion.listaDeVehiculos)
                            {
                                if (cb_Capacidad.Items.Contains(a.Capacidad) == false)
                                    cb_Capacidad.Items.Add(a.Capacidad);
                            }
                        }
                        break;
                    case 4:
                        {
                            foreach (Vehiculo a in miAdministracion.listaDeVehiculos)
                            {
                                if (cb_Marca.Items.Contains(a.Modelo) == false)
                                    cb_Marca.Items.Add(a.Modelo);
                            }
                        }
                        break;
                }
            }
        }
        
        private void bt_Salir_Click(object sender, EventArgs e)
        {
            FileStream fls = new FileStream("administracion.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formateador = new BinaryFormatter();
            formateador.Serialize(fls, miAdministracion);
            fls.Close();
            this.Close();
        }

        private void bt_Consulta_Click(object sender, EventArgs e)
        {
            consulta = new Consulta();
            consulta.ShowDialog();
            if(consulta.bt_Mostrar.DialogResult == DialogResult.OK)
            {
                if (consulta.comboBox1.Text == "Usuario")
                {
                    foreach (Alquiler alquileres in miAdministracion.VerAlquiler)
                    {
                        Alquiler mostrar = alquileres;
                        consulta.listBox1.Items.Add(mostrar.VerCliente.nombre + "| " + mostrar.Fecha + "| " + mostrar.Auto.Patente);
                    }
                    consulta.ShowDialog();
                }
                if (consulta.comboBox1.Text == "Vehiculo")
                {
                    foreach (Alquiler alquileres in miAdministracion.VerAlquiler)
                    {
                        Alquiler mostrar = alquileres;
                        consulta.listBox1.Items.Add(mostrar.Auto.Modelo + "| " + mostrar.Auto.Patente + "| " + mostrar.Auto.TipoCombustible);
                    }
                    consulta.ShowDialog();
                }
            }
        }

        private void bt_Registro_Click(object sender, EventArgs e)
        {
            registro = new Registro();
            foreach(Alquiler mostrar in miAdministracion.Historico)
            {
                registro.listBox1.Items.Add(mostrar.VerCliente.nombre+" | "+ mostrar.Auto.Modelo+" | "+mostrar.FechaDevolucion);
            }
            registro.ShowDialog();

            if(registro.DialogResult == DialogResult.OK)
            {
                if (registro.bt_Borrar.DialogResult==DialogResult.OK && registro.listBox1.SelectedIndex >=0)
                miAdministracion.EditarRegistro(registro.listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún registro. Inténtelo nuvamente.");
            }    
        }

        public void LimpiarDataGrid()
        {
            if (indiceDtgv != -1)
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)// boton borrar
        {
            LimpiarDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceDtgv = e.RowIndex;
        }

        private void bt_Baja_Click(object sender, EventArgs e)
        {
            if (indiceDtgv != -1)
            {
                dataGridView1.Rows.Clear();
            }
            if (radioButtonSinChofer.Checked == false && radioButtonChofer.Checked == false)
            {
                MessageBox.Show("Debe especificar el tipo de vehiculo");
            }
            if (radioButtonSinChofer.Checked == true)
            {
                for (int i = 0; i < miAdministracion.listaDeVehiculos.Count; i++)
                {              
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = miAdministracion.listaDeVehiculos[i].Modelo;
                    dataGridView1.Rows[n].Cells[1].Value = miAdministracion.listaDeVehiculos[i].Patente;
                    dataGridView1.Rows[n].Cells[2].Value = miAdministracion.listaDeVehiculos[i].TipoCombustible;
                    dataGridView1.Rows[n].Cells[3].Value = miAdministracion.listaDeVehiculos[i].Capacidad;                   
                }
                chofer = false;
            }
            else if (radioButtonChofer.Checked == true)
            {
                for (int i = 0; i < miAdministracion.listaDeVehiculosConChofer.Count; i++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = miAdministracion.listaDeVehiculosConChofer[i].Modelo;
                    dataGridView1.Rows[n].Cells[1].Value = miAdministracion.listaDeVehiculosConChofer[i].Patente;
                    dataGridView1.Rows[n].Cells[2].Value = miAdministracion.listaDeVehiculosConChofer[i].TipoCombustible;
                    dataGridView1.Rows[n].Cells[3].Value = miAdministracion.listaDeVehiculosConChofer[i].Capacidad;
                }
                chofer = true;
            }
            buttonBaja.Visible = true;
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
           MessageBox.Show(miAdministracion.BajaVehiculo((int)dataGridView1.Rows[indiceDtgv].Cells[1].RowIndex,chofer));
            buttonBaja.Visible = false;
            dataGridView1.Rows.Clear();
        }

        int contChofer = 0, contSChofer = 0,contCapacidad4 = 0, contCapacidad5 = 0;

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miAdministracion.BackUp());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miAdministracion.BackUp());
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayudaW = new AyudaWeb();
            ayudaW.WindowState = FormWindowState.Maximized;
            string path = System.IO.Path.GetFullPath(@"..\..\..\Web\Ayuda Web.html");
            ayudaW.webBrowser1.Navigate(path);
            ayudaW.ShowDialog();
            ayudaW.Dispose();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
            {
                FileStream fls = new FileStream("usuario.txt", FileMode.Open, FileAccess.Write);
                StreamWriter str = new StreamWriter(fls);
                try
                {
                    str.WriteLine(nuevo.textBoxUsuario.Text + ";" + nuevo.textBoxContraseña.Text + ";" + nuevo.cb_Tipo.Text);
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el nuevo usuario");
                }
                finally
                {
                    str.Close();
                    fls.Dispose();
                }

            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonChofer_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarDataGrid();
            chofer = true;
        }

        private void radioButtonSinChofer_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarDataGrid();
            chofer = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importarDatosDesdeArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.ShowDialog();
            if (Directory.Exists(archivo.FileName)==true)
                MessageBox.Show(miAdministracion.Importar(archivo.FileName));
            else
                MessageBox.Show("Archivo o directorio no encontrado");
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show(miAdministracion.BackUp());
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miAdministracion.BackUp());
        }

        private void bt_Estadistica_Click(object sender, EventArgs e)
        {
            foreach (Alquiler a in miAdministracion.VerAlquiler)
            {
                if (a.Auto is VehiculoConChofer)
                    contChofer++;
                else
                    contSChofer++;
            }

            foreach (Alquiler a in miAdministracion.VerAlquiler)
            {
                if (a.Auto.Capacidad == 4)
                {
                    contCapacidad4++;
                }
                else if (a.Auto.Capacidad == 5)
                {
                    contCapacidad5++;
                }
            }

            if (miAdministracion.VerAlquiler.Count > 0)
            {
                diagrama.contChofer = contChofer;
                diagrama.contSchofer = contSChofer;
                diagrama.contCantidad4 = contCapacidad4;
                diagrama.contCantidad5 = contCapacidad5;
                diagrama.total = miAdministracion.VerAlquiler.Count;
                diagrama.ShowDialog();
            }
            else
                MessageBox.Show("No hay datos suficientes para graficar");
        }
    }
}