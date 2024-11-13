using BDS.Modelo;
using BDS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace BDS.Controller
{
    public class ControladorDetalleCompra
    {
        public string RegistrarCompraYDetalle(Compras compra, List<DetalleCompras> detalles)
        {
            DetalleCompras dc = new DetalleCompras();
            bool resultado = dc.DobleRegistrarCyD(Conexion.cadena, compra, detalles);
            return resultado ? "La Compra de los productos se ha registrado." : "Error al registrar la compra.";
        }

    }
}
