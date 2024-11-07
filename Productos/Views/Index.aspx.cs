using Productos.Controller;
using Productos.Data.DbTiendaTableAdapters;
using Productos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Productos.Views
{
    public partial class Index : System.Web.UI.Page
    {
        private ProductoController _controller = new ProductoController();

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Captura los datos del formulario
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);
            byte[] imagenBytes = null;

            // Convierte la imagen en un arreglo de bytes si se sube una
            if (fileImagen.HasFile)
            {
                using (BinaryReader br = new BinaryReader(fileImagen.PostedFile.InputStream))
                {
                    imagenBytes = br.ReadBytes(fileImagen.PostedFile.ContentLength);
                }
            }

            // Crea una instancia del TableAdapter y llama al método Insert
            productosTableAdapter productosAdapter = new productosTableAdapter();
            productosAdapter.Insert(nombre, cantidad, costo, imagenBytes);

            // Redirigir o mostrar un mensaje de éxito
            Response.Redirect("ListaProductos.aspx");
        }
    }
    }
