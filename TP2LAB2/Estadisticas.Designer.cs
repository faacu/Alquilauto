namespace TP2LAB2
{
    partial class Estadisticas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonChofer = new System.Windows.Forms.RadioButton();
            this.radioButtonCapacidad = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSeleccion = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGraficar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonChofer);
            this.groupBox1.Controls.Add(this.radioButtonCapacidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graficar según:";
            // 
            // radioButtonChofer
            // 
            this.radioButtonChofer.AutoSize = true;
            this.radioButtonChofer.Location = new System.Drawing.Point(154, 20);
            this.radioButtonChofer.Name = "radioButtonChofer";
            this.radioButtonChofer.Size = new System.Drawing.Size(56, 17);
            this.radioButtonChofer.TabIndex = 1;
            this.radioButtonChofer.TabStop = true;
            this.radioButtonChofer.Text = "Chofer";
            this.radioButtonChofer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCapacidad
            // 
            this.radioButtonCapacidad.AutoSize = true;
            this.radioButtonCapacidad.Location = new System.Drawing.Point(20, 20);
            this.radioButtonCapacidad.Name = "radioButtonCapacidad";
            this.radioButtonCapacidad.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCapacidad.TabIndex = 0;
            this.radioButtonCapacidad.TabStop = true;
            this.radioButtonCapacidad.Text = "Capacidad";
            this.radioButtonCapacidad.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 291);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSeleccion
            // 
            this.pictureBoxSeleccion.Location = new System.Drawing.Point(489, 64);
            this.pictureBoxSeleccion.Name = "pictureBoxSeleccion";
            this.pictureBoxSeleccion.Size = new System.Drawing.Size(45, 29);
            this.pictureBoxSeleccion.TabIndex = 4;
            this.pictureBoxSeleccion.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(489, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 31);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Location = new System.Drawing.Point(540, 64);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(35, 13);
            this.labelSeleccion.TabIndex = 6;
            this.labelSeleccion.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // buttonGraficar
            // 
            this.buttonGraficar.Location = new System.Drawing.Point(330, 26);
            this.buttonGraficar.Name = "buttonGraficar";
            this.buttonGraficar.Size = new System.Drawing.Size(153, 23);
            this.buttonGraficar.TabIndex = 8;
            this.buttonGraficar.Text = "Graficar";
            this.buttonGraficar.UseVisualStyleBackColor = true;
            this.buttonGraficar.Click += new System.EventHandler(this.buttonGraficar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(339, 361);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(144, 23);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGraficar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxSeleccion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGraficar;
        private System.Windows.Forms.RadioButton radioButtonChofer;
        private System.Windows.Forms.RadioButton radioButtonCapacidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxSeleccion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalir;
    }
}