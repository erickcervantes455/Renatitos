using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Renatitos
{
    public partial class FormSalida : Form
    {
        public FormSalida()
        {
            InitializeComponent();
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            // El Load déjalo vacío
        }

        // --- MUEVE EL CÓDIGO A UN BOTÓN ---

        private void btnsalida_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Debe ingresar al menos el código y la cantidad.");
                return;
            }

            foreach (Producto p in Datos.ListaProductos)
            {
                if (p.Codigo == txtcodigo.Text)
                {
                    int cantidad = Convert.ToInt32(txtcantidad.Text);

                    if (p.Stock >= cantidad)
                    {
                        p.Stock = p.Stock - cantidad; // Resta la baja en la memoria global
                        MessageBox.Show("Salida de almacén registrada.\nStock restante de " + p.Nombre + ": " + p.Stock);

                        txtcodigo.Clear();
                        txtcantidad.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock. Disponible: " + p.Stock);
                    }
                    return;
                }
            }

            MessageBox.Show("El producto no existe en el catálogo.");
        }
    }
    }