using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Pedido
    {
        public int idBoletin { get; set; }
        public Proveedor idProveedor { get; set; }
        public decimal TotalPedido { get; set; }
        public DateTime fechaRegistro { get; set; }

    }
}
