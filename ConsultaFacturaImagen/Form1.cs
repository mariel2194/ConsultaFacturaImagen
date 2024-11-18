using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing; 
using System.IO;     
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ConsultaFacturaImagen
{
    public partial class Form1 : Form
    {
        public Form1(string numeroFactura)
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
            string[] extensiones = { ".jpg", ".png" };
            string rutaImagen = null;
            textBox1.Paste(numeroFactura);


            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            foreach (string extension in extensiones)
            {
                string posibleRuta = Path.Combine(rutaBase, "Facturas", $"{numeroFactura}{extension}");
                if (File.Exists(posibleRuta))
                {
                    rutaImagen = posibleRuta;
                    break;
                }
            }
            if (rutaImagen != null)
            {
                pictureBox1.Image = Image.FromFile(rutaImagen);
            }
            else
            {

                MessageBox.Show($"No se encontró una imagen para la factura {numeroFactura}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }



}

