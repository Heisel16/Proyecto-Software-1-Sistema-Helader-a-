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
    public class ControladorStock
    {
        public string EstablecerStock(int producto, int cant, int capacidad, string estado, string alerta)
        {
            if (string.IsNullOrEmpty(Convert.ToString(producto)) || string.IsNullOrEmpty(alerta) || (cant <= 0) ||
                (capacidad <= 0)|| string.IsNullOrEmpty(estado))

            {
                return "Todos los campos son obligatorios o no se pueden asignar valores negativos";
            }

            Productos p = new Productos { Id = producto };

            Stock nuevo = new Stock
            {
                productoId = p,
                cantidad = cant,
                Capacidad = capacidad,
                Alerta= alerta,
                Estado = estado,
            };

            bool registrado = nuevo.EstablecerStock(Conexion.cadena);

            return registrado ? $"se ha establecido correctamente el stock." : "Error.";
        }

        public string ActualizarStock(int id, int cant, int capacidad, string estado, string alerta)
        {
            if (string.IsNullOrEmpty(Convert.ToString(id)) || string.IsNullOrEmpty(alerta) || (cant <= 0) ||
                (capacidad <= 0) || string.IsNullOrEmpty(estado))

            {
                return "Todos los campos son obligatorios o no se pueden asignar valores negativos";
            }

            Stock a = new Stock
            {
                id = id,
                cantidad = cant,
                Capacidad = capacidad,
                Alerta = alerta,
                Estado = estado,
            };

            bool actualizado = a.ActualizarStock(Conexion.cadena);

            return actualizado ? $"se ha actualizado correctamente el stock." : "Error.";
        }
        public List<Stock> lista()
        {
            Stock stock = new Stock();
            List<Stock> lst = stock.ListarStock(); ;
            return lst;
        }

        public void Cargar(DataGridView dataGrid)
        {
            InfoStock p = new InfoStock();
            List<InfoStock> lista = p.lista();
            dataGrid.DataSource = new BindingList<InfoStock>(lista);
        }
    }
}
