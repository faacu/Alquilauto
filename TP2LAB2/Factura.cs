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
            Font fuente = new Font("Giorgia", 20, FontStyle.Bold);
            SizeF tamañoLinea;
            float posY = 10;
            float posX = 10;
            string fullPath = Path.GetFullPath(@"..\..\..\Imagenes\LogoAlquilauto.png");
            Image logo = Image.FromFile(fullPath);

            string textoActual = texto[0];
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY));
            posY = posY + tamañoLinea.Height;
            textoActual = texto[1];
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height; // A posY, se le suma el alto de un renglón para setear el interlineado
            textoActual = "---------------------------------";
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY));
            posY = posY + tamañoLinea.Height;
            //--------------------------------------------------------------------------------------------------//
            textoActual = "Fecha y Hora";
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height;
            textoActual = DateTime.Now.ToString();
            fuente = new Font("Giorgia", 11, FontStyle.Regular);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY)); // Dibuja textoActual
            posY = posY + tamañoLinea.Height;
            textoActual = "---------------------------------";
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY));
            posY = posY + tamañoLinea.Height;
            //----------------------------------------------------------------------------------------------------------
            fuente = new Font("Giorgia", 10, FontStyle.Regular);
            textoActual = texto[2];
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posX = (e.MarginBounds.Width) / 2;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
            posY = posY + tamañoLinea.Height;
            textoActual = "---------------------------------";
            fuente = new Font("Giorgia", 11, FontStyle.Bold);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY));
            posY = posY + tamañoLinea.Height;

            // Datos Conductores
            int h = 0;
            if (mostrarconductores == true)
                {
                while (conductores[h] != null)
                {
                    fuente = new Font("Giorgia", 10, FontStyle.Regular);
                    textoActual = "Conductor N° " + h + 1;
                    tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                    posX = (e.MarginBounds.Width) / 2;
                    e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                    posY = posY + tamañoLinea.Height;
                    textoActual = conductores[h];
                    tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                    posX = (e.MarginBounds.Width) / 2;
                    e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                    posY = posY + tamañoLinea.Height;
                    h++;

                }
                textoActual = "---------------------------------";
                fuente = new Font("Giorgia", 11, FontStyle.Bold);
                tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF((e.MarginBounds.Width) / 2, posY));
                posY = posY + tamañoLinea.Height;
            }

            // Dibujamos Logo
            e.Graphics.DrawImage(logo, (e.MarginBounds.Width + 110) / 2, posY+10, 70, 70);
            int i = 70 + Convert.ToInt32(posY);

            // Márgenes del ticket
            e.Graphics.DrawRectangle(borde, new Rectangle((e.MarginBounds.Width - 110) / 2, 10, 300, i));
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
