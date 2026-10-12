using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // Validar si el campo de usuario o contraseña están vacíos o contienen solo espacios
            if (string.IsNullOrWhiteSpace(txtboxusuario.Text) || string.IsNullOrWhiteSpace(txtcontra.Text))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución para que no abra Form2
            }
            // Limpiar las cajas de texto para cuando el usuario regrese
            txtboxusuario.Clear();
            txtcontra.Clear();
            // Si ambos campos están completos, abre la pantalla principal
            Form2 pantallaPrincipal = new Form2(this);
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            txtcontra.PasswordChar = '*';
        }
    }
}