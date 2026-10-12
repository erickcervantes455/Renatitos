using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Renatitos
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Debe ingresar al menos el código y la cantidad.");
                return;
            }

            // 1. Revisamos si el producto ya fue registrado antes
            foreach (Producto p in Datos.ListaProductos)
            {
                if (p.Codigo == txtcodigo.Text)
                {
                    // Si ya existe, solo le sumamos la nueva cantidad
                    int cantidad = Convert.ToInt32(txtcantidad.Text);
                    p.Stock = p.Stock + cantidad;

                    MessageBox.Show("Se sumó la cantidad al producto existente: " + p.Nombre + "\nNuevo stock: " + p.Stock);

                    txtcodigo.Clear();
                    txtnombre.Clear();
                    txtprecio.Clear();
                    txtcantidad.Clear();
                    return;
                }
            }

            // 2. Si no existe en la lista, obligamos a escribir Nombre y Precio para crearlo nuevo
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Es un producto nuevo. Debe ingresar también el Nombre y el Precio.");
                return;
            }

            // Creamos el producto nuevo
            Producto nuevo = new Producto();
            nuevo.Codigo = txtcodigo.Text;
            nuevo.Nombre = txtnombre.Text;
            nuevo.Precio = Convert.ToDouble(txtprecio.Text);
            nuevo.Stock = Convert.ToInt32(txtcantidad.Text);

            // Lo guardamos en la lista global
            Datos.ListaProductos.Add(nuevo);

            MessageBox.Show("¡Producto nuevo registrado e ingresado con éxito!");

            txtcodigo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}

