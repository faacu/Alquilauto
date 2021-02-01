namespace TP2LAB2
{
    partial class FormAgregarAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Chofer = new System.Windows.Forms.CheckBox();
            this.tb_Marca = new System.Windows.Forms.TextBox();
            this.nud_Capacidad = new System.Windows.Forms.NumericUpDown();
            this.cb_Combustible = new System.Windows.Forms.ComboBox();
            this.bt_Imagen = new System.Windows.Forms.Button();
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.nud_Valor = new System.Windows.Forms.NumericUpDown();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.nud_Edad = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_Nacionalidad = new System.Windows.Forms.TextBox();
            this.tb_EstadoCivil = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.tb_Domicilio = new System.Windows.Forms.TextBox();
            this.tb_CuitCuil = new System.Windows.Forms.TextBox();
            this.tb_Dni = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.dateTimePickerNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Capacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Valor)).BeginInit();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca/Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Combustible:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Imagen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor en Unidades:";
            // 
            // cb_Chofer
            // 
            this.cb_Chofer.AutoSize = true;
            this.cb_Chofer.Location = new System.Drawing.Point(154, 190);
            this.cb_Chofer.Name = "cb_Chofer";
            this.cb_Chofer.Size = new System.Drawing.Size(57, 17);
            this.cb_Chofer.TabIndex = 6;
            this.cb_Chofer.Text = "Chofer";
            this.cb_Chofer.UseVisualStyleBackColor = true;
            this.cb_Chofer.CheckedChanged += new System.EventHandler(this.cb_Chofer_CheckedChanged);
            // 
            // tb_Marca
            // 
            this.tb_Marca.Location = new System.Drawing.Point(113, 26);
            this.tb_Marca.Name = "tb_Marca";
            this.tb_Marca.Size = new System.Drawing.Size(100, 20);
            this.tb_Marca.TabIndex = 7;
            // 
            // nud_Capacidad
            // 
            this.nud_Capacidad.Location = new System.Drawing.Point(113, 52);
            this.nud_Capacidad.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nud_Capacidad.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_Capacidad.Name = "nud_Capacidad";
            this.nud_Capacidad.Size = new System.Drawing.Size(100, 20);
            this.nud_Capacidad.TabIndex = 8;
            this.nud_Capacidad.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cb_Combustible
            // 
            this.cb_Combustible.FormattingEnabled = true;
            this.cb_Combustible.Items.AddRange(new object[] {
            "Diesel",
            "Nafta",
            "GNC"});
            this.cb_Combustible.Location = new System.Drawing.Point(113, 78);
            this.cb_Combustible.Name = "cb_Combustible";
            this.cb_Combustible.Size = new System.Drawing.Size(100, 21);
            this.cb_Combustible.TabIndex = 9;
            this.cb_Combustible.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_Imagen
            // 
            this.bt_Imagen.Location = new System.Drawing.Point(111, 106);
            this.bt_Imagen.Name = "bt_Imagen";
            this.bt_Imagen.Size = new System.Drawing.Size(102, 25);
            this.bt_Imagen.TabIndex = 10;
            this.bt_Imagen.Text = "Desde archivo";
            this.bt_Imagen.UseVisualStyleBackColor = true;
            this.bt_Imagen.Click += new System.EventHandler(this.bt_Imagen_Click);
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(111, 138);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(100, 20);
            this.tb_Patente.TabIndex = 11;
            // 
            // nud_Valor
            // 
            this.nud_Valor.Location = new System.Drawing.Point(111, 164);
            this.nud_Valor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Valor.Name = "nud_Valor";
            this.nud_Valor.Size = new System.Drawing.Size(102, 20);
            this.nud_Valor.TabIndex = 12;
            this.nud_Valor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gb_Datos
            // 
            this.gb_Datos.Controls.Add(this.dateTimePickerNac);
            this.gb_Datos.Controls.Add(this.nud_Edad);
            this.gb_Datos.Controls.Add(this.label14);
            this.gb_Datos.Controls.Add(this.tb_Nacionalidad);
            this.gb_Datos.Controls.Add(this.tb_EstadoCivil);
            this.gb_Datos.Controls.Add(this.tb_Telefono);
            this.gb_Datos.Controls.Add(this.tb_Domicilio);
            this.gb_Datos.Controls.Add(this.tb_CuitCuil);
            this.gb_Datos.Controls.Add(this.tb_Dni);
            this.gb_Datos.Controls.Add(this.tb_Nombre);
            this.gb_Datos.Controls.Add(this.label8);
            this.gb_Datos.Controls.Add(this.label7);
            this.gb_Datos.Controls.Add(this.label9);
            this.gb_Datos.Controls.Add(this.label10);
            this.gb_Datos.Controls.Add(this.label11);
            this.gb_Datos.Controls.Add(this.label12);
            this.gb_Datos.Controls.Add(this.label13);
            this.gb_Datos.Controls.Add(this.label17);
            this.gb_Datos.Enabled = false;
            this.gb_Datos.Location = new System.Drawing.Point(285, 12);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(338, 256);
            this.gb_Datos.TabIndex = 13;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Chofer:";
            // 
            // nud_Edad
            // 
            this.nud_Edad.Location = new System.Drawing.Point(109, 222);
            this.nud_Edad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nud_Edad.Name = "nud_Edad";
            this.nud_Edad.Size = new System.Drawing.Size(120, 20);
            this.nud_Edad.TabIndex = 19;
            this.nud_Edad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Edad:";
            // 
            // tb_Nacionalidad
            // 
            this.tb_Nacionalidad.Location = new System.Drawing.Point(109, 195);
            this.tb_Nacionalidad.Name = "tb_Nacionalidad";
            this.tb_Nacionalidad.Size = new System.Drawing.Size(223, 20);
            this.tb_Nacionalidad.TabIndex = 17;
            // 
            // tb_EstadoCivil
            // 
            this.tb_EstadoCivil.Location = new System.Drawing.Point(109, 168);
            this.tb_EstadoCivil.Name = "tb_EstadoCivil";
            this.tb_EstadoCivil.Size = new System.Drawing.Size(223, 20);
            this.tb_EstadoCivil.TabIndex = 16;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(109, 142);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(223, 20);
            this.tb_Telefono.TabIndex = 15;
            // 
            // tb_Domicilio
            // 
            this.tb_Domicilio.Location = new System.Drawing.Point(109, 92);
            this.tb_Domicilio.Name = "tb_Domicilio";
            this.tb_Domicilio.Size = new System.Drawing.Size(223, 20);
            this.tb_Domicilio.TabIndex = 11;
            // 
            // tb_CuitCuil
            // 
            this.tb_CuitCuil.Location = new System.Drawing.Point(109, 65);
            this.tb_CuitCuil.Name = "tb_CuitCuil";
            this.tb_CuitCuil.Size = new System.Drawing.Size(223, 20);
            this.tb_CuitCuil.TabIndex = 10;
            // 
            // tb_Dni
            // 
            this.tb_Dni.Location = new System.Drawing.Point(109, 38);
            this.tb_Dni.Name = "tb_Dni";
            this.tb_Dni.Size = new System.Drawing.Size(223, 20);
            this.tb_Dni.TabIndex = 9;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(109, 12);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(223, 20);
            this.tb_Nombre.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nacionalidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado Civil:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha de Nac.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Domicilio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "CUIT/CUIL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "DNI:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre y Apellido:";
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Aceptar.Location = new System.Drawing.Point(547, 275);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 14;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(466, 275);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 15;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // dateTimePickerNac
            // 
            this.dateTimePickerNac.Location = new System.Drawing.Point(109, 116);
            this.dateTimePickerNac.Name = "dateTimePickerNac";
            this.dateTimePickerNac.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerNac.TabIndex = 20;
            // 
            // FormAgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 306);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.nud_Valor);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.bt_Imagen);
            this.Controls.Add(this.cb_Combustible);
            this.Controls.Add(this.nud_Capacidad);
            this.Controls.Add(this.tb_Marca);
            this.Controls.Add(this.cb_Chofer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarAuto";
            this.Text = "Agregar Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Capacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Valor)).EndInit();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_Marca;
        public System.Windows.Forms.NumericUpDown nud_Capacidad;
        public System.Windows.Forms.ComboBox cb_Combustible;
        public System.Windows.Forms.Button bt_Imagen;
        public System.Windows.Forms.TextBox tb_Patente;
        public System.Windows.Forms.CheckBox cb_Chofer;
        public System.Windows.Forms.NumericUpDown nud_Valor;
        public System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tb_Nacionalidad;
        public System.Windows.Forms.TextBox tb_EstadoCivil;
        public System.Windows.Forms.TextBox tb_Telefono;
        public System.Windows.Forms.TextBox tb_Domicilio;
        public System.Windows.Forms.TextBox tb_CuitCuil;
        public System.Windows.Forms.TextBox tb_Dni;
        public System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button bt_Aceptar;
        public System.Windows.Forms.Button bt_Cancelar;
        public System.Windows.Forms.NumericUpDown nud_Edad;
        public System.Windows.Forms.DateTimePicker dateTimePickerNac;
    }
}