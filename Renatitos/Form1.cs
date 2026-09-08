using System;
using System.Windows.Forms;

namespace Renatitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarPanel(Panel panelAMostrar)
        {
            panelinicio.Visible = false;
            panelsiguiente.Visible = false;

            panelAMostrar.Visible = true;
            panelAMostrar.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPanel(panelinicio);
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelsiguiente);
        }

        private void btniniciarsecion_Click(object sender, EventArgs e)
        {
            Form2 pantallaPrincipal = new Form2();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}