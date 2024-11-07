using Productos.Data.DbTiendaTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Productos.Views
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            // Crea una instancia del TableAdapter
            productosTableAdapter productosAdapter = new productosTableAdapter();

            // Llama al método para obtener los datos
            var productosDataTable = productosAdapter.GetData();

            // Asigna los datos al GridView
            gvProductos.DataSource = productosDataTable;
            gvProductos.DataBind();
        }
    }
}