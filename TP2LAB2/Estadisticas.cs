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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }
        public int contChofer, contSchofer, contCantidad4, contCantidad5, total;
        private void buttonGraficar_Click(object sender, EventArgs e)
        {
            if(radioButtonChofer.Checked == true)
            {
                int ancho = pictureBox1.Width - 100;
                int alto = pictureBox1.Height - 100;

                // porcentajes
                float Pchofer = contChofer * 100 / total;
                float Schofer = contSchofer * 100 / total;

                float AnguloInicial = 0;
                float AnguloBarrido = Pchofer * 360 / 100;
                float angRestante = Schofer * 360 / 100;

                SolidBrush ConChofer = new SolidBrush(Color.DarkViolet);
                SolidBrush SinChofer = new SolidBrush(Color.Orange);
                Pen pen = new Pen(Color.Black, 3);
                Rectangle rec = new Rectangle(73, 92, ancho, alto);
                try
                {
                    pictureBox1.CreateGraphics().FillPie(SinChofer, rec, AnguloInicial, AnguloBarrido);
                    pictureBox1.CreateGraphics().FillPie(ConChofer, rec, AnguloBarrido, angRestante);
                    pictureBox1.CreateGraphics().DrawEllipse(pen, 73, 92, ancho, alto);
                    pictureBox1.CreateGraphics().DrawPie(pen, rec, AnguloInicial, AnguloBarrido);
                    pictureBoxSeleccion.BackColor = Color.Orange;
                    pictureBox3.BackColor = Color.DarkViolet;
                    labelSeleccion.Text = "Chofer: "+contChofer;
                    label2.Text = "Sin Chofer: "+contSchofer;
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se pudo crear el grafico" + error);
                }
                finally
                {
                    ConChofer.Dispose();
                    SinChofer.Dispose();
                    pen.Dispose();
                    AnguloInicial = 0;
                    AnguloBarrido = 0;
                    angRestante = 0;
                }
            }
            else if(radioButtonCapacidad.Checked == true)
            {
                int ancho = pictureBox1.Width - 100;
                int alto = pictureBox1.Height - 100;

                // porcentajes

                float PorCant4 = contCantidad4 * 100 / total;
                float PorCant5 = contCantidad5 * 100 / total;


                float AnguloInicial = 0;
                float AnguloBarrido = PorCant4 * 360 / 100;
                float angRestante = PorCant5 * 360 / 100;

                SolidBrush brush = new SolidBrush(Color.DarkViolet);
                SolidBrush second = new SolidBrush(Color.Orange);
                Pen pen = new Pen(Color.Black, 3);
                Rectangle rec = new Rectangle(73, 92, ancho, alto);
                try
                {
                    pictureBox1.CreateGraphics().FillPie(second, rec, AnguloBarrido, angRestante);
                    pictureBox1.CreateGraphics().FillPie(brush, rec, AnguloInicial, AnguloBarrido);
                    pictureBox1.CreateGraphics().DrawEllipse(pen, 73, 92, ancho, alto);
                    pictureBox1.CreateGraphics().DrawPie(pen, rec, AnguloInicial, AnguloBarrido);
                    pictureBoxSeleccion.BackColor = Color.DarkViolet;
                    pictureBox3.BackColor = Color.Orange;
                    labelSeleccion.Text = "4 personas: "+contCantidad4;
                    label2.Text = "5 personas: "+contCantidad5;
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se pudo crear el grafico" + error);
                }
                finally
                {
                    second.Dispose();
                    brush.Dispose();
                    pen.Dispose();
                    AnguloInicial = 0;
                    AnguloBarrido = 0;
                    angRestante = 0;
                }
            }
            radioButtonChofer.Checked = false;
            radioButtonCapacidad.Checked = false;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
