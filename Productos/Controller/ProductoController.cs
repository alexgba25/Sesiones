using Productos.Data.DbTiendaTableAdapters;
using Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productos.Controller
{
    public class ProductoController
    {
        private const string CarritoSessionKey = "Carrito";

        public void AgregarProductoACarrito(Producto producto)
        {
            List<Producto> carrito = ObtenerCarrito();

            // Agregar el producto al carrito (simula agregar varios elementos)
            carrito.Add(producto);

            // Actualizar la sesión con el carrito actualizado
            HttpContext.Current.Session[CarritoSessionKey] = carrito;
        }

        public List<Producto> ObtenerCarrito()
        {
            // Obtener el carrito de la sesión, si no existe, crear uno vacío
            var carrito = (List<Producto>)HttpContext.Current.Session[CarritoSessionKey];
            if (carrito == null)
            {
                carrito = new List<Producto>();
                HttpContext.Current.Session[CarritoSessionKey] = carrito;
            }
            return carrito;
        }
    }
}