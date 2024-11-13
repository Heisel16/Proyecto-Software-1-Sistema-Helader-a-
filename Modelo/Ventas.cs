using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public Usuario IdUsuario { get; set;}
        public decimal TotalVenta { get; set; }
        public double MontoPago { get; set; }
        public double MontoCambio { get; set; }

    }
}
