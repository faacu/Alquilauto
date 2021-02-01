namespace TP2LAB2
{
    partial class Consulta
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_Cerrar = new System.Windows.Forms.Button();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Usuario",
            "Vehiculo"});
            this.comboBox1.Location = new System.Drawing.Point(81, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Mostrar.Location = new System.Drawing.Point(381, 27);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(107, 23);
            this.bt_Mostrar.TabIndex = 1;
            this.bt_Mostrar.Text = "Mostrar";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Click += new System.EventHandler(this.bt_Mostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 173);
            this.listBox1.TabIndex = 2;
            // 
            // bt_Cerrar
            // 
            this.bt_Cerrar.Location = new System.Drawing.Point(406, 249);
            this.bt_Cerrar.Name = "bt_Cerrar";
            this.bt_Cerrar.Size = new System.Drawing.Size(82, 24);
            this.bt_Cerrar.TabIndex = 3;
            this.bt_Cerrar.Text = "Cerrar";
            this.bt_Cerrar.UseVisualStyleBackColor = true;
            this.bt_Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Limpiar
            // 
            this.bt_Limpiar.Location = new System.Drawing.Point(24, 249);
            this.bt_Limpiar.Name = "bt_Limpiar";
            this.bt_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpiar.TabIndex = 4;
            this.bt_Limpiar.Text = "Limpiar";
            this.bt_Limpiar.UseVisualStyleBackColor = true;
            this.bt_Limpiar.Click += new System.EventHandler(this.bt_Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ver datos:";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Limpiar);
            this.Controls.Add(this.bt_Cerrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button bt_Mostrar;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button bt_Cerrar;
        public System.Windows.Forms.Button bt_Limpiar;
        private System.Windows.Forms.Label label1;
    }
}