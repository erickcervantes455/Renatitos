using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Renatitos
{
    public partial class FormAlmacen : Form
    {
        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
        {
            // Carga todos los productos que se han registrado desde Entrada
            dgvproductos.DataSource = null;
            dgvproductos.DataSource = Datos.ListaProductos;
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            // Actualiza la vista del DataGridView
            dgvproductos.DataSource = null;
            dgvproductos.DataSource = Datos.ListaProductos;
        }
        private void FormAlmacen_Activated(object sender, EventArgs e)
        {
            // Desconecta y vuelve a conectar la lista para obligar a redibujar los datos actualizados
            dgvproductos.DataSource = null;
            dgvproductos.DataSource = Datos.ListaProductos;
        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
