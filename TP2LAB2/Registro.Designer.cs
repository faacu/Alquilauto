namespace TP2LAB2
{
    partial class Registro
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 186);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el registro que desee eliminar y presione el botón \"Borrar\".";
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(247, 274);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(103, 27);
            this.bt_Cancelar.TabIndex = 5;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Borrar.Location = new System.Drawing.Point(356, 274);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(102, 27);
            this.bt_Borrar.TabIndex = 6;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 306);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bt_Cancelar;
        public System.Windows.Forms.Button bt_Borrar;
    }
}