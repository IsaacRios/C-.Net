using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = new Button();
            boton.Text = "Salir";
            boton.Location = new Point(100, 100);
            boton.BackColor = Color.Aqua;
            boton.Click += Boton_Click;
            this.Controls.Add(boton);
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
