using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Renatitos
{
    public partial class Form2 : Form
    {
        private Form1 _formLogin;
        private bool _esCerrarSesion = false;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 formLogin) : this()
        {
            _formLogin = formLogin;
        }

        // Este método detecta automáticamente cuando se cierra Form2
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (!_esCerrarSesion)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _esCerrarSesion = true;
            if (_formLogin != null)
            {
                _formLogin.Show(); // Muestra Form1
            }
            this.Close(); // Cierra Form2
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear la instancia del nuevo formulario
            FormPuntoDeVenta ventanaVentas = new FormPuntoDeVenta();

            //Abrir como ventana emergente bloqueante 
            ventanaVentas.ShowDialog();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntrada f = new FormEntrada();
            f.ShowDialog();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSalida f = new FormSalida();
            f.ShowDialog();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlmacen f = new FormAlmacen();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
