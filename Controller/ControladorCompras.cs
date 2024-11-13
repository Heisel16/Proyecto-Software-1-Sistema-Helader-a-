using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Controller
{
    public class ControladorCompras
    {
        private static CompraModelo cm= new CompraModelo();
        private static List<CompraModelo> lista = cm.ListarCompras();
        public string RegistrarCompra(int idUs, long prov, float pc)
        {
            if (string.IsNullOrEmpty(Convert.ToString(idUs)) || string.IsNullOrEmpty(Convert.ToString(prov)) || string.IsNullOrEmpty(Convert.ToString(pc)))

            {
                return "Todos los campos son obligatorios.";
            }

            Usuario c = new Usuario { DocumentoID = Convert.ToString(idUs) };
            Proveedor p = new Proveedor { Documento = Convert.ToString(prov)};

            Compras nuevo = new Compras
            {
                idUsuario = c,
                idProveeor= p,
                Total= pc
            };

            bool registrado = nuevo.RegistrarCompra(Conexion.cadena);

            return registrado ? $"La comprra fue registrado exitosamente." : "Error al registrar la Compra.";
        }

        public void CargarDatosGrid(DataGridView dataGrid)
        {
            CompraModelo compraModelo = new CompraModelo();
            List<CompraModelo> lista = compraModelo.ListarCompras();
            dataGrid.DataSource= new BindingList<CompraModelo>(lista);
        }

        public List<CompraModelo> CargarDatosFiltrados(DateTime fi, DateTime fF)
        {
            CompraModelo compraModelo = new CompraModelo();
             return compraModelo.ListarComprasPorFecha(fi,fF);
        }

        public void buscar(string filtro, DataGridView dataGrid)
        {
            var listar = lista.Where(c => c.NombreProducto.ToLower().Contains(filtro)).ToList();
            dataGrid.DataSource = new BindingList<CompraModelo>(listar);
            if (string.IsNullOrEmpty(filtro))
            {
                dataGrid.DataSource = new BindingList<CompraModelo>(lista);
                return;
            }

        }
        public void buscarporCombo(string  filtro, string columna, DataGridView dataGrid) 
        {
            if (string.IsNullOrEmpty(filtro))
            {
                dataGrid.DataSource = new BindingList<CompraModelo>(lista);
                return;
            }

            var listaOtra = lista.Where(c =>
            {
                switch (columna)
                {
                    case "NombreProducto":
                        return c.NombreProducto.ToLower().Contains(filtro.ToLower());
                    case "Codigo":
                        return c.Codigo.ToLower().Contains(filtro.ToLower());
                    case "NombreProveedor":
                        return c.NombreProveedor.ToLower().Contains(filtro.ToLower());

                    default:
                        return false;
                }
            }

            ).ToList();

            dataGrid.DataSource = new BindingList<CompraModelo>(listaOtra);
        }
    }
}