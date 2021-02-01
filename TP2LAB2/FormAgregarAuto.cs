using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2LAB2
{
    public partial class FormAgregarAuto : Form
    {
        public FormAgregarAuto()
        {
            InitializeComponent();

        }
        public OpenFileDialog archivoImagen;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Imagen_Click(object sender, EventArgs e)
        {
            archivoImagen = new OpenFileDialog();
            archivoImagen.ShowDialog();
        }

        private void cb_Chofer_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Chofer.Checked == true)
                gb_Datos.Enabled = true;
            else if (cb_Chofer.Checked == false)
                gb_Datos.Enabled = false;

        }

        private void bt_Aceptar_Click(object sender, EventArgs e) // FALTAN EXCEPCIONES
        {
            this.Close();
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
