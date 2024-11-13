using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Controller
{
    public class controladorCategorias
    {

        public string RegistrarCategoria(string cat, string estado)
        {
            if (string.IsNullOrEmpty(Convert.ToString(cat)) || string.IsNullOrEmpty(Convert.ToString(estado)))

            {
                return "Todos los campos son obligatorios.";
            }

            Categoria nuevo = new Categoria
            {
                Descripcion = cat,
                Estado = estado
            };

            if (nuevo.Validacion(cat, Conexion.cadena)){
                return ("Ya existe una categoria con esta descripcion");
            }

            bool registrado = nuevo.registrarCategoria(Conexion.cadena);

            return registrado ? $"La categoria fue registrado exitosamente." : "Error al registrar la categoria.";
        }

        public string Actualizar(int id, string descp, string estado)
        {
            if ((id<=0)||string.IsNullOrEmpty(descp)|| string.IsNullOrEmpty((estado)))
            {
                return "llenar Todos los campos, son obligatorios";
            }
            Categoria Actualizar = new Categoria
            {
                Id = id,
                Descripcion = descp,
                Estado = estado
            };
            bool Actualizado = Actualizar.ActualizarCtegoria(Conexion.cadena);

            return Actualizado ? $"Los datos de la Categoria {descp} se han actualizado exitosamente." : "Error al Actualizar los datos.";
        }

        public string Eliminar(int id)
        {
            Categoria c = new Categoria();
            bool eliminar = c.EliminarCategoria(id);
            if (eliminar)
            {
                return "Categoria eliminada";
            }
            else
            {
                return "No se pudo eliminar la categoria";
            }
        }

        public List<Categoria> Lista()
        {
            Categoria c = new Categoria();
            List<Categoria> lista = c.lista();
            return lista;
        }
    }
}
