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
    public partial class FormConductores : Form
    {
        public FormConductores()
        {
            InitializeComponent();
        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            string conductor = tb_NombreConductor.Text + " | " + tb_CarnetConductor;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormConductores_Load(object sender, EventArgs e)
        {

        }
    }
}
