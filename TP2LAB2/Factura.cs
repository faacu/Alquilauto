using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP2LAB2
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        Brush relleno = new SolidBrush(Color.Black);
        Pen borde = new Pen(Color.Black);
        public string[] conductores = new string[3];
        public string[] texto = new string[3]; // 0. titulo - 1. subtitulo - 2.
        public bool mostrarconductores = false;
        static string fullPath = Path.GetFullPath(@"..\..\..\Imagenes\LogoAlquilauto.png");
        Image logo = Image.FromFile(fullPath);
        public Image[] carnet = new Image[3];

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Giorgia", 20, FontStyle.Bold); // Configuramos estilo de fuente.
            SizeF tamañoLinea; // me permite saber que tamaño mide el renglón (ancho, alto)
            // Posición vertical en la hoja.
            float posY = 10; //Márgenes de la página
            float posX = 10;

            // Calculamos el alto del texto al ser dibujado con la fuente indicada
            string textoActual = texto[0];
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(15, posY));
            // Dibujamos Logo
            e.Graphics.DrawImage(logo, (e.MarginBounds.Width + 80), posY + 10, 100, 100);
            posY = posY + tamañoLinea.Height;
            textoActual = texto[1];
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(15, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height; // A posY, se le suma el alto de un renglón para setear el interlineado
            textoActual = "_____________________";
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(15, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height; // A posY, se le suma el alto de un renglón para setear el interlineado
            // Primer marco
            e.Graphics.DrawRectangle(borde, new Rectangle(10, 10, e.MarginBounds.Right + 75, 120));
            //posY += 100;
            //--------------------------------------------------------------------------------------------------//
            textoActual = "Fecha y Hora";
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(15, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height;
            textoActual = DateTime.Now.ToString();
            fuente = new Font("Giorgia", 11, FontStyle.Regular);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(15, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height;

            float lineasPermitidas = e.MarginBounds.Height / fuente.GetHeight(e.Graphics);
            float lineasRealizadas = posY / fuente.GetHeight(e.Graphics);

            // Segundo marco
            e.Graphics.DrawRectangle(borde, new Rectangle(10, Convert.ToInt32(posY) + 15, e.MarginBounds.Right + 75, e.MarginBounds.Bottom - 50));
            //----------------------------------------------------------------------------------------------------------
            fuente = new Font("Giorgia", 11, FontStyle.Regular);
            textoActual = texto[2];
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posX = (e.MarginBounds.Width / 2) - 70;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY + 25));
            posY = posY + tamañoLinea.Height;
            textoActual = "------------------------------------------------------------";
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posX = (e.MarginBounds.Width / 2) - 70;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY + 25));
            posY = posY + tamañoLinea.Height;
            //e.HasMorePages = true;
            
            if (mostrarconductores == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (conductores[i] != null)
                    {
                        textoActual = conductores[i] +
                            "\n* Habilitación para uso" +
                            "\n del vehículo";
                        e.Graphics.DrawRectangle(borde, new Rectangle((e.MarginBounds.Width / 2) - 50, Convert.ToInt32(posY) + 60, 300, 170));//modificar ultimo valor
                        e.Graphics.DrawImage(carnet[i], e.MarginBounds.Width / 2 - 30, posY + 70, 70, 70);
                        e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(e.MarginBounds.Width / 2 + 50, posY + 75));
                        posY = posY + 170;
                    }
                }
            }
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
