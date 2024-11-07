using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productos.Models
{
    public class Producto
    {
        // Propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public byte[] Imagen { get; set; } // Usamos byte[] para el LONGBLOB

        // Constructor
        public Producto(int id, string nombre, int cantidad, decimal costo, byte[] imagen)
        {
            ID = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Costo = costo;
            Imagen = imagen;
        }

        // Constructor sin parámetros
        public Producto() { }
    }
}