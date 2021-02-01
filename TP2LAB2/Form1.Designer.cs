namespace TP2LAB2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Alquilar = new System.Windows.Forms.Button();
            this.bt_Devolucion = new System.Windows.Forms.Button();
            this.bt_Consulta = new System.Windows.Forms.Button();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.bt_Registro = new System.Windows.Forms.Button();
            this.bt_Valor = new System.Windows.Forms.Button();
            this.tb_Tipo = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.CheckBox();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Combustible = new System.Windows.Forms.ComboBox();
            this.cb_Capacidad = new System.Windows.Forms.ComboBox();
            this.cb_Marca = new System.Windows.Forms.ComboBox();
            this.rb_Combustible = new System.Windows.Forms.RadioButton();
            this.rb_Pasajeros = new System.Windows.Forms.RadioButton();
            this.rb_Marca = new System.Windows.Forms.RadioButton();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSinChofer = new System.Windows.Forms.RadioButton();
            this.radioButtonChofer = new System.Windows.Forms.RadioButton();
            this.bt_Baja = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.bt_Estadistica = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Alquilar
            // 
            this.bt_Alquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Alquilar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Alquilar.Image")));
            this.bt_Alquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Alquilar.Location = new System.Drawing.Point(17, 86);
            this.bt_Alquilar.Name = "bt_Alquilar";
            this.bt_Alquilar.Size = new System.Drawing.Size(101, 40);
            this.bt_Alquilar.TabIndex = 0;
            this.bt_Alquilar.Text = "Alquiler";
            this.bt_Alquilar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Alquilar.UseVisualStyleBackColor = false;
            this.bt_Alquilar.Click += new System.EventHandler(this.bt_Alquilar_Click);
            // 
            // bt_Devolucion
            // 
            this.bt_Devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Devolucion.Image = ((System.Drawing.Image)(resources.GetObject("bt_Devolucion.Image")));
            this.bt_Devolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Devolucion.Location = new System.Drawing.Point(17, 132);
            this.bt_Devolucion.Name = "bt_Devolucion";
            this.bt_Devolucion.Size = new System.Drawing.Size(100, 40);
            this.bt_Devolucion.TabIndex = 1;
            this.bt_Devolucion.Text = "Devolución";
            this.bt_Devolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Devolucion.UseVisualStyleBackColor = false;
            this.bt_Devolucion.Click += new System.EventHandler(this.bt_Devolucion_Click);
            // 
            // bt_Consulta
            // 
            this.bt_Consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("bt_Consulta.Image")));
            this.bt_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Consulta.Location = new System.Drawing.Point(16, 180);
            this.bt_Consulta.Name = "bt_Consulta";
            this.bt_Consulta.Size = new System.Drawing.Size(101, 40);
            this.bt_Consulta.TabIndex = 2;
            this.bt_Consulta.Text = "Consulta";
            this.bt_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Consulta.UseVisualStyleBackColor = false;
            this.bt_Consulta.Click += new System.EventHandler(this.bt_Consulta_Click);
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Agregar.Image")));
            this.bt_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Agregar.Location = new System.Drawing.Point(16, 226);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(100, 40);
            this.bt_Agregar.TabIndex = 3;
            this.bt_Agregar.Text = "Agregar\r\nVehiculo";
            this.bt_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Agregar.UseVisualStyleBackColor = false;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // bt_Registro
            // 
            this.bt_Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Registro.Image = ((System.Drawing.Image)(resources.GetObject("bt_Registro.Image")));
            this.bt_Registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Registro.Location = new System.Drawing.Point(16, 318);
            this.bt_Registro.Name = "bt_Registro";
            this.bt_Registro.Size = new System.Drawing.Size(100, 40);
            this.bt_Registro.TabIndex = 4;
            this.bt_Registro.Text = "Registros";
            this.bt_Registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Registro.UseVisualStyleBackColor = false;
            this.bt_Registro.Click += new System.EventHandler(this.bt_Registro_Click);
            // 
            // bt_Valor
            // 
            this.bt_Valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Valor.Image = ((System.Drawing.Image)(resources.GetObject("bt_Valor.Image")));
            this.bt_Valor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Valor.Location = new System.Drawing.Point(16, 364);
            this.bt_Valor.Name = "bt_Valor";
            this.bt_Valor.Size = new System.Drawing.Size(100, 40);
            this.bt_Valor.TabIndex = 5;
            this.bt_Valor.Text = "Asignar\r\nValor";
            this.bt_Valor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Valor.UseVisualStyleBackColor = false;
            this.bt_Valor.Click += new System.EventHandler(this.bt_Valor_Click);
            // 
            // tb_Tipo
            // 
            this.tb_Tipo.AutoSize = true;
            this.tb_Tipo.Location = new System.Drawing.Point(14, 65);
            this.tb_Tipo.Name = "tb_Tipo";
            this.tb_Tipo.Size = new System.Drawing.Size(34, 13);
            this.tb_Tipo.TabIndex = 0;
            this.tb_Tipo.Text = "Tipo: ";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.AutoSize = true;
            this.cb_Filtro.Location = new System.Drawing.Point(147, 383);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(48, 17);
            this.cb_Filtro.TabIndex = 17;
            this.cb_Filtro.Text = "Filtro";
            this.cb_Filtro.UseVisualStyleBackColor = true;
            this.cb_Filtro.CheckedChanged += new System.EventHandler(this.cb_Filtro_CheckedChanged);
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Controls.Add(this.button1);
            this.gb_Busqueda.Controls.Add(this.cb_Combustible);
            this.gb_Busqueda.Controls.Add(this.cb_Capacidad);
            this.gb_Busqueda.Controls.Add(this.cb_Marca);
            this.gb_Busqueda.Controls.Add(this.rb_Combustible);
            this.gb_Busqueda.Controls.Add(this.rb_Pasajeros);
            this.gb_Busqueda.Controls.Add(this.rb_Marca);
            this.gb_Busqueda.Location = new System.Drawing.Point(269, 426);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Size = new System.Drawing.Size(323, 111);
            this.gb_Busqueda.TabIndex = 18;
            this.gb_Busqueda.TabStop = false;
            this.gb_Busqueda.Text = "Busqueda";
            this.gb_Busqueda.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Combustible
            // 
            this.cb_Combustible.Enabled = false;
            this.cb_Combustible.FormattingEnabled = true;
            this.cb_Combustible.Location = new System.Drawing.Point(104, 77);
            this.cb_Combustible.Name = "cb_Combustible";
            this.cb_Combustible.Size = new System.Drawing.Size(121, 21);
            this.cb_Combustible.TabIndex = 5;
            this.cb_Combustible.SelectedIndexChanged += new System.EventHandler(this.cb_Combustible_SelectedIndexChanged);
            // 
            // cb_Capacidad
            // 
            this.cb_Capacidad.Enabled = false;
            this.cb_Capacidad.FormattingEnabled = true;
            this.cb_Capacidad.Location = new System.Drawing.Point(104, 50);
            this.cb_Capacidad.Name = "cb_Capacidad";
            this.cb_Capacidad.Size = new System.Drawing.Size(121, 21);
            this.cb_Capacidad.TabIndex = 4;
            this.cb_Capacidad.SelectedIndexChanged += new System.EventHandler(this.cb_Capacidad_SelectedIndexChanged);
            // 
            // cb_Marca
            // 
            this.cb_Marca.Enabled = false;
            this.cb_Marca.FormattingEnabled = true;
            this.cb_Marca.Location = new System.Drawing.Point(104, 22);
            this.cb_Marca.Name = "cb_Marca";
            this.cb_Marca.Size = new System.Drawing.Size(121, 21);
            this.cb_Marca.TabIndex = 3;
            this.cb_Marca.SelectedIndexChanged += new System.EventHandler(this.cb_Marca_SelectedIndexChanged);
            // 
            // rb_Combustible
            // 
            this.rb_Combustible.AutoSize = true;
            this.rb_Combustible.Location = new System.Drawing.Point(16, 81);
            this.rb_Combustible.Name = "rb_Combustible";
            this.rb_Combustible.Size = new System.Drawing.Size(82, 17);
            this.rb_Combustible.TabIndex = 2;
            this.rb_Combustible.TabStop = true;
            this.rb_Combustible.Text = "Combustible";
            this.rb_Combustible.UseVisualStyleBackColor = true;
            this.rb_Combustible.CheckedChanged += new System.EventHandler(this.rb_Combustible_CheckedChanged);
            // 
            // rb_Pasajeros
            // 
            this.rb_Pasajeros.AutoSize = true;
            this.rb_Pasajeros.Location = new System.Drawing.Point(17, 51);
            this.rb_Pasajeros.Name = "rb_Pasajeros";
            this.rb_Pasajeros.Size = new System.Drawing.Size(76, 17);
            this.rb_Pasajeros.TabIndex = 1;
            this.rb_Pasajeros.TabStop = true;
            this.rb_Pasajeros.Text = "Capacidad";
            this.rb_Pasajeros.UseVisualStyleBackColor = true;
            this.rb_Pasajeros.CheckedChanged += new System.EventHandler(this.rb_Pasajeros_CheckedChanged);
            // 
            // rb_Marca
            // 
            this.rb_Marca.AutoSize = true;
            this.rb_Marca.Location = new System.Drawing.Point(17, 23);
            this.rb_Marca.Name = "rb_Marca";
            this.rb_Marca.Size = new System.Drawing.Size(55, 17);
            this.rb_Marca.TabIndex = 0;
            this.rb_Marca.TabStop = true;
            this.rb_Marca.Text = "Marca";
            this.rb_Marca.UseVisualStyleBackColor = true;
            this.rb_Marca.CheckedChanged += new System.EventHandler(this.rb_Marca_CheckedChanged);
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Location = new System.Drawing.Point(517, 379);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_Buscar.TabIndex = 6;
            this.bt_Buscar.Text = "Buscar";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // bt_Salir
            // 
            this.bt_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Salir.Image")));
            this.bt_Salir.Location = new System.Drawing.Point(471, 548);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(121, 40);
            this.bt_Salir.TabIndex = 19;
            this.bt_Salir.Text = "Guardar y salir";
            this.bt_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Salir.UseVisualStyleBackColor = false;
            this.bt_Salir.Click += new System.EventHandler(this.bt_Salir_Click);
            // 
            // bt_Limpiar
            // 
            this.bt_Limpiar.Location = new System.Drawing.Point(426, 379);
            this.bt_Limpiar.Name = "bt_Limpiar";
            this.bt_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpiar.TabIndex = 22;
            this.bt_Limpiar.Text = "Borrar";
            this.bt_Limpiar.UseVisualStyleBackColor = true;
            this.bt_Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Patente,
            this.Combustible,
            this.Capacidad});
            this.dataGridView1.Location = new System.Drawing.Point(147, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 287);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // Combustible
            // 
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSinChofer);
            this.groupBox1.Controls.Add(this.radioButtonChofer);
            this.groupBox1.Location = new System.Drawing.Point(147, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 111);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de vehículo";
            // 
            // radioButtonSinChofer
            // 
            this.radioButtonSinChofer.AutoSize = true;
            this.radioButtonSinChofer.Location = new System.Drawing.Point(20, 46);
            this.radioButtonSinChofer.Name = "radioButtonSinChofer";
            this.radioButtonSinChofer.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSinChofer.TabIndex = 1;
            this.radioButtonSinChofer.TabStop = true;
            this.radioButtonSinChofer.Text = "Sin chofer";
            this.radioButtonSinChofer.UseVisualStyleBackColor = true;
            this.radioButtonSinChofer.CheckedChanged += new System.EventHandler(this.radioButtonSinChofer_CheckedChanged);
            // 
            // radioButtonChofer
            // 
            this.radioButtonChofer.AutoSize = true;
            this.radioButtonChofer.Location = new System.Drawing.Point(20, 23);
            this.radioButtonChofer.Name = "radioButtonChofer";
            this.radioButtonChofer.Size = new System.Drawing.Size(56, 17);
            this.radioButtonChofer.TabIndex = 0;
            this.radioButtonChofer.TabStop = true;
            this.radioButtonChofer.Text = "Chofer";
            this.radioButtonChofer.UseVisualStyleBackColor = true;
            this.radioButtonChofer.CheckedChanged += new System.EventHandler(this.radioButtonChofer_CheckedChanged);
            // 
            // bt_Baja
            // 
            this.bt_Baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Baja.Image = ((System.Drawing.Image)(resources.GetObject("bt_Baja.Image")));
            this.bt_Baja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Baja.Location = new System.Drawing.Point(16, 272);
            this.bt_Baja.Name = "bt_Baja";
            this.bt_Baja.Size = new System.Drawing.Size(100, 40);
            this.bt_Baja.TabIndex = 25;
            this.bt_Baja.Text = "Quitar\r\nVehiculo";
            this.bt_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Baja.UseVisualStyleBackColor = false;
            this.bt_Baja.Click += new System.EventHandler(this.bt_Baja_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(341, 379);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(75, 23);
            this.buttonBaja.TabIndex = 26;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Visible = false;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // bt_Estadistica
            // 
            this.bt_Estadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Estadistica.Image = ((System.Drawing.Image)(resources.GetObject("bt_Estadistica.Image")));
            this.bt_Estadistica.Location = new System.Drawing.Point(17, 410);
            this.bt_Estadistica.Name = "bt_Estadistica";
            this.bt_Estadistica.Size = new System.Drawing.Size(99, 40);
            this.bt_Estadistica.TabIndex = 27;
            this.bt_Estadistica.Text = "Estadisticas";
            this.bt_Estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Estadistica.UseVisualStyleBackColor = false;
            this.bt_Estadistica.Click += new System.EventHandler(this.bt_Estadistica_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.agregarUsuarioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.alquileresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.choferesToolStripMenuItem});
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backUpToolStripMenuItem.Text = "BackUp";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // alquileresToolStripMenuItem
            // 
            this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.alquileresToolStripMenuItem.Text = "Alquileres";
            this.alquileresToolStripMenuItem.Click += new System.EventHandler(this.alquileresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda ";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Enabled = false;
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 51);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choferesToolStripMenuItem.Text = "Choferes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 600);
            this.Controls.Add(this.tb_Tipo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Salir);
            this.Controls.Add(this.bt_Estadistica);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.bt_Baja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Busqueda);
            this.Controls.Add(this.bt_Limpiar);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.bt_Valor);
            this.Controls.Add(this.bt_Registro);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.bt_Consulta);
            this.Controls.Add(this.bt_Devolucion);
            this.Controls.Add(this.bt_Alquilar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alquilauto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Busqueda.ResumeLayout(false);
            this.gb_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Alquilar;
        private System.Windows.Forms.Button bt_Devolucion;
        private System.Windows.Forms.Button bt_Consulta;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.Button bt_Registro;
        private System.Windows.Forms.Button bt_Valor;
        private System.Windows.Forms.Label tb_Tipo;
        private System.Windows.Forms.CheckBox cb_Filtro;
        private System.Windows.Forms.GroupBox gb_Busqueda;
        private System.Windows.Forms.ComboBox cb_Combustible;
        private System.Windows.Forms.ComboBox cb_Capacidad;
        private System.Windows.Forms.ComboBox cb_Marca;
        private System.Windows.Forms.RadioButton rb_Combustible;
        private System.Windows.Forms.RadioButton rb_Pasajeros;
        private System.Windows.Forms.RadioButton rb_Marca;
        private System.Windows.Forms.Button bt_Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.Button bt_Limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSinChofer;
        private System.Windows.Forms.RadioButton radioButtonChofer;
        private System.Windows.Forms.Button bt_Baja;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button bt_Estadistica;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
    }
}

