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
    public class ControladorProductos
    {
        public string RegistrarProducto(string codigo, string nombre, int categoria, float pc, float pv, string estado)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) ||
                (categoria<=0) ||(pc<=0)|| (pv <= 0)||string.IsNullOrEmpty(estado))
                
            {
                return "Todos los campos son obligatorios.";
            }

            Productos p = new Productos();
            if (p.Validacion(codigo,Conexion.cadena))
            {
                return "Ya existe un producto con este codigo";
            }

            Categoria c = new Categoria { Id = categoria };

            Productos nuevo = new Productos
            {
                Codigo = codigo,
                Nombre = nombre,
                IdCategoria = c,
                PrecioCompra = pc,
                PrecioVenta = pv,
                Estado = estado,
            };

            bool registrado = nuevo.RegistrarProductos(Conexion.cadena);

            return registrado ? $"el Producto {nombre} fue registrado exitosamente." : "Error al registrar producto.";
        }
        public string ActualizarProducto(int id,string codigo, string nombre, int categoria, float pc, float pv, string estado)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) ||
                (categoria <= 0) || (pc <= 0) || (pv <= 0) || string.IsNullOrEmpty(estado))

            {
                return "Todos los campos son obligatorios.";
            }

            Categoria c = new Categoria { Id = categoria };

            Productos nuevo = new Productos
            {
                Id= id,
                Codigo = codigo,
                Nombre = nombre,
                IdCategoria = c,
                PrecioCompra = pc,
                PrecioVenta = pv,
                Estado = estado,
            };

            bool registrado = nuevo.ActualizarProducto(Conexion.cadena);

            return registrado ? $"el Producto {nombre} fue actualizado exitosamente." : "Error al actualizar el producto.";
        }

        public string EliminarProducto(int id)
        {
            Productos p = new Productos();
            bool eliminar = p.EliminarProducto(id);
            if (eliminar)
            {
                return "Producto eliminado";
            }
            else
            {
                return "No se pudo eliminar el producto";
            }
        }

        public List<Productos> ListarProductos()
        {
            Productos p = new Productos();
            List<Productos> lista = p.ListaDeProductos();
            return lista;
        }

        public void CargarInfoCompleta(DataGridView dataGrid)
        {
            InfoProducto p = new InfoProducto();
            List<InfoProducto> lista= p.ListaProductos();
            dataGrid.DataSource= new BindingList<InfoProducto>(lista);
        }
    }
}
