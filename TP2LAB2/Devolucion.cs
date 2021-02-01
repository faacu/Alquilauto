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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarControles()
        {
            comboBox1.Items.Clear();
            textBoxKm.Clear();
        }

        public void Agregar(string alquiler)
        {
            comboBox1.Items.Add(alquiler);
        }

        private void bt_Seleccionar_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarControles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
