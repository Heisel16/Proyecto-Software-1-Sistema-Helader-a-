using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Controller
{
    public class ControladorInventario
    {
        private static InfoProducto producto = new InfoProducto();
        private static List<InfoProducto> lista = producto.ListaProductos();
        public void buscar(string filtro, DataGridView dataGrid)
        {
            var listar = lista.Where(c => c.Nombre_Producto.ToLower().Contains(filtro)).ToList();
            dataGrid.DataSource = new BindingList<InfoProducto>(listar);
            if (string.IsNullOrEmpty(filtro))
            {
                dataGrid.DataSource = new BindingList<InfoProducto>(lista);
                return;
            }

        }
    }
}
