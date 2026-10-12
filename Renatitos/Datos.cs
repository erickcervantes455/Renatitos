using System.Collections.Generic;

namespace Renatitos
{
    // Estructura simple de un producto
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }

    // Lista en memoria compartida por todo el programa
    public static class Datos
    {
        public static List<Producto> ListaProductos = new List<Producto>();
    }
}