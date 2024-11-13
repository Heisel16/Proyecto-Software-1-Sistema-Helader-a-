using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Permiso
    {
        public int IdPermiso {  get; set; }
        public Rol Nombre { get; set; }
        public string MenuDisponibles { get; set; }
        public DateTime fechaRegistro { get; set; }

    }
}
