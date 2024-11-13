using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Controller
{
    public class ControladorProveedores
    {
        public string RegistrarProveedor(string documento, string Rsocial, string telefono, string correo, string estado,string Ubicacion, string direccion)
        {
            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(Rsocial) || string.IsNullOrEmpty(direccion) ||
                string.IsNullOrEmpty(Ubicacion) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(telefono))
            {
                return "Todos los campos son obligatorios.";
            }
            Proveedor nuevo = new Proveedor
            {
                Documento = documento,
                RazonSocial = Rsocial,
                Telefono = telefono,
                Correo = correo,
                Estado = estado,
                Ubicacion = Ubicacion,
                Direccion = direccion
            };
            if (nuevo.ValidarExistencia(Conexion.cadena, documento, Rsocial))
            {
                return "Ya existe un proveedor con estos Datos";
            }

            bool registrado = nuevo.RegistrarProveedor(Conexion.cadena);

            return registrado ? $"el Proveedor {Rsocial} fue registrado exitosamente." : "Error al registrar Proveedor.";
        }

        public List<Proveedor> ListarProveedores()
        {
            Proveedor proveedor = new Proveedor(); 
            List<Proveedor> listaProveedores = proveedor.Listar();
            return listaProveedores;
        }

        public string ActualizarProveedor(int id,string documento, string razonS, string telefono, string correo, string estado, string ubicacion, string direccion)
        {
            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(razonS) || string.IsNullOrEmpty((ubicacion)) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(telefono))
            {
                return "llenar Todos los campos, son obligatorios";
            }
            Proveedor Actualizap = new Proveedor
            {
                Id= id,
                Documento = documento,
                RazonSocial = razonS,
                Telefono = telefono,
                Correo = correo,
                Estado = estado,
                Ubicacion = ubicacion,
                Direccion = direccion
            };

            bool Actualizado = Actualizap.ActualizarProveedor(Conexion.cadena);

            return Actualizado ? $"Los datos del Proveedor {razonS} se han actualizado exitosamente." : "Error al Actualizar los datos.";
        }


        Proveedor p = new Proveedor();
        public string EliminarProveedor(int id)
        {
            bool eliminar = p.EliminarProveedor(id);
            if (eliminar)
            {
                return "Proveedor eliminado";
            }
            else
            {
                return "No se pudo eliminar el Proveedor";
            }
        }
    }
}
