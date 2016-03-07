using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Ejample
{
    public partial class Form2 : Form
    {
        private string mensaje;
        public Form2(string mensaje)
        {
            this.mensaje = mensaje;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("Libros");
            doc.AppendChild(raiz);

            XmlElement archivo = doc.CreateElement("libro");
            raiz.AppendChild(archivo);

            XmlElement titulo = doc.CreateElement("titulo");
            titulo.AppendChild(doc.CreateTextNode("El hobbit"));
            archivo.AppendChild(titulo);

            XmlElement precio = doc.CreateElement("Precio");
            precio.AppendChild(doc.CreateTextNode("$100.00"));
            archivo.AppendChild(precio);

            archivo = doc.CreateElement("libro");
            raiz.AppendChild(archivo);

            titulo = doc.CreateElement("titulo");
            titulo.AppendChild(doc.CreateTextNode("Jarry Poker"));
            archivo.AppendChild(titulo);

            precio = doc.CreateElement("Precio");
            precio.AppendChild(doc.CreateTextNode("$80.00"));
            archivo.AppendChild(precio);

            doc.Save("D:\\bandeja\\archivo.xml");

            MessageBox.Show("Archivo guardado", "MSJ");
        }
    }
}
