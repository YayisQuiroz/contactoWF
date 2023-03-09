using Agenda_C;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int length = 0;
        private int index = 0;
        private Contacto[] array;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (length < index)
            {
                var x = new Contacto();
                x.Nombre = txtNombre.Text;
                x.Fecha = dtpFecha.Value;
                x.Numero = txtNumero.Text;
                x.Correo = txtCorreo.Text;
                array[length] = x;
                length++;
                string linea = x.ToString() + Environment.NewLine;
                lblMostrar.Text = lblMostrar.Text + linea;
                txtNombre.Clear();
                dtpFecha.Value=DateTime.Now;
                txtNumero.Clear();
                txtCorreo.Clear();
            }
            if(length == index)
            {
                MessageBox.Show("se han registrado todos");
            }
        }

        private void txtNcontactos_TextChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(txtNcontactos.Text);
            index = valor;
            length = 0;
            array = new Contacto[index];
        }
    }
}
