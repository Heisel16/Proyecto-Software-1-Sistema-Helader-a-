using BDS.Modelo;
using BDS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Controller
{
    public class ControladorPedidos
    {
        public string RegistrarBoletin(Pedido pedido, List<DetallesDePedidos> detalles)
        {
            DetallesDePedidos dp = new DetallesDePedidos();
            bool resultado = dp.RegistrarBoletinyDetalle(Conexion.cadena, pedido, detalles);
            return resultado ? "El boletin de faltantes de productos se ha registrado." : "Error al registrar el boletin.";
        }
    }
}
