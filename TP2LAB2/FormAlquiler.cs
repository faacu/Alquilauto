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
    public partial class FormAlquiler : Form
    {
        public FormAlquiler()
        {
            InitializeComponent();
        }    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bt_CargarCliente_Click(object sender, EventArgs e)
        {
            bt_CargarCliente.DialogResult = DialogResult.OK;
            {
                string cuit = tb_CuitCuil.Text;
                string tipo = cuit.Substring(0, 2);
                string identificador = cuit.Substring(cuit.Length - 1);
                string dni = cuit.Substring(2, cuit.Length - 3);

                List<int> enteros = new List<int>();

                if (tipo == "20" || tipo == "27" || tipo == "30") // Verificación de Cuit
                {
                    string numero = tipo + dni;
                    for (int i = 0; i < numero.Length; i++)
                    {
                        enteros.Add(Convert.ToInt16(numero.Substring(i, 1)));
                    }

                    try
                    {
                        int calculo = (enteros[0] * 5) + (enteros[1] * 4) + (enteros[2] * 3) + (enteros[3] * 2) + (enteros[4] * 7) + (enteros[5] * 6) + (enteros[6] * 5) + (enteros[7] * 4) + (enteros[8] * 3) + (enteros[9] * 2);
                        int z = 11 - (calculo % 11);
                        if (identificador == Convert.ToString(z))
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cuil/Cuit incorrecto.\nVuelva a intentarlo!");
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("El número de Cuit/Cuil debe tener 11 caracteres");
                    }
                }
            }
        }

        private void cb_Chofer_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            bt_Cancelar.DialogResult = DialogResult.Cancel;
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {

        }
        public OpenFileDialog path1;
        public OpenFileDialog path2;
        public OpenFileDialog path3;
        private void bt_Foto_Click(object sender, EventArgs e)
        {
            path1 = new OpenFileDialog();
            path1.ShowDialog();
        }

        private void nud_Conductores_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Conductores.Value == 1)
            {
                gb_Conductor1.Enabled = true;
                gb_Conductor2.Enabled = false;
                gb_Conductor3.Enabled = false;
            }
            else if (nud_Conductores.Value==2)
            {
                gb_Conductor1.Enabled = true;
                gb_Conductor2.Enabled = true;
                gb_Conductor3.Enabled = false;
            }
            else if (nud_Conductores.Value == 3)
            {
                gb_Conductor1.Enabled = true;
                gb_Conductor2.Enabled = true;
                gb_Conductor3.Enabled = true;
            }
        }

        private void bt_foto2_Click(object sender, EventArgs e)
        {
            path2 = new OpenFileDialog();
            path2.ShowDialog();
        }

        private void bt_foto3_Click(object sender, EventArgs e)
        {
            path3 = new OpenFileDialog();
            path3.ShowDialog();
        }

        private void tb_CuitCuil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
