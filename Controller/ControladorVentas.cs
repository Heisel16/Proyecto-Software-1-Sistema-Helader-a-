using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Controller
{
    public class ControladorVentas
    {
        public static DetalleVentas dv= new DetalleVentas();

        public string RegistrarVentaYDetalle(Ventas ventas, List<DetalleVentas> detalles)
        {
            DetalleVentas dv = new DetalleVentas();
            bool resultado = dv.DobleRegistrarVyD(Conexion.cadena, ventas, detalles);
            return resultado ? "La Venta se ha registrado." : "Error al registrar la Venta.";
        }
        public bool ValidarCantidad(int id, int cant, out string mensaje)
        {
            int cantidad = dv.GestionarCantidad(id);

            if (cantidad == -1)
            {
                mensaje ="El producto no se encuntra en el stock";
                return false; 
            }

            if(cant>cantidad)
            {
                mensaje= $"Stock Insuficiente, Cantidad Disponible:{cantidad}";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }
    }
}
