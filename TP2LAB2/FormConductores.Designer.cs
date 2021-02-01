namespace TP2LAB2
{
    partial class FormConductores
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
            this.bt_Ingresar = new System.Windows.Forms.Button();
            this.tb_NombreConductor = new System.Windows.Forms.TextBox();
            this.tb_CarnetConductor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Ingresar
            // 
            this.bt_Ingresar.Location = new System.Drawing.Point(105, 113);
            this.bt_Ingresar.Name = "bt_Ingresar";
            this.bt_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.bt_Ingresar.TabIndex = 0;
            this.bt_Ingresar.Text = "Ingresar";
            this.bt_Ingresar.UseVisualStyleBackColor = true;
            this.bt_Ingresar.Click += new System.EventHandler(this.bt_Ingresar_Click);
            // 
            // tb_NombreConductor
            // 
            this.tb_NombreConductor.Location = new System.Drawing.Point(105, 24);
            this.tb_NombreConductor.Name = "tb_NombreConductor";
            this.tb_NombreConductor.Size = new System.Drawing.Size(100, 20);
            this.tb_NombreConductor.TabIndex = 1;
            // 
            // tb_CarnetConductor
            // 
            this.tb_CarnetConductor.Location = new System.Drawing.Point(105, 51);
            this.tb_CarnetConductor.Name = "tb_CarnetConductor";
            this.tb_CarnetConductor.Size = new System.Drawing.Size(100, 20);
            this.tb_CarnetConductor.TabIndex = 2;
            this.tb_CarnetConductor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carnet:";
            // 
            // FormConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CarnetConductor);
            this.Controls.Add(this.tb_NombreConductor);
            this.Controls.Add(this.bt_Ingresar);
            this.Name = "FormConductores";
            this.Text = "Ingresar Conductores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ingresar;
        public System.Windows.Forms.TextBox tb_NombreConductor;
        public System.Windows.Forms.TextBox tb_CarnetConductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}