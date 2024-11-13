using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BDS.Controller
{
    public class ControladorUsuarios
    {

        #region CRUD
        public string RegistrarUsuario(string documento, string nombre, string apellido, string correo, string clave, int idRol, string estado, string telefono)
        {
            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(Convert.ToString(idRol)) ||
                string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(telefono))
            {
                return "Todos los campos son obligatorios.";
            }

            if (clave.Length < 4)
            {
                return "La contraseña debe tener al menos 4 caracteres.";
            }
            Usuario nuevoUsuario = new Usuario
            {
                DocumentoID = documento,
                Nombre = nombre,
                Apellido = apellido,
                Correo = correo,
                Contraseña = clave,
                IdRol = idRol,
                estado = estado,
                telefono = telefono
            };
            if (nuevoUsuario.ValidarExistencia(Conexion.cadena, documento, telefono))
            {
                return "Ya existe un Usuario con estos datos";
            }

            bool registrado = nuevoUsuario.RegistrarUsuario(Conexion.cadena);

            return registrado ? $"el Usuario {nombre} fue registrado exitosamente." : "Error al registrar usuario.";
        }

        public string ActualizarUsuario(string documento, string nombre, string apellido, string correo, string clave, int idRol, string estado, string telefono)
        {
            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(Convert.ToString(idRol)) ||
                string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) ||string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(telefono))
            {
                return "Todos los campos son obligatorios, Excepto la contraseña";
            }
            Usuario ActualizarUser = new Usuario
            {
                DocumentoID = documento,
                Nombre = nombre,
                Apellido = apellido,
                Correo = correo,
                IdRol = idRol,
                estado = estado,
                telefono = telefono
            };
            if (!string.IsNullOrEmpty(clave))
            {
                ActualizarUser.Contraseña = clave;
            }


            bool Actualizado = ActualizarUser.ActualizarUsuario(Conexion.cadena);

            return Actualizado ? $"Los datos del Usuario {nombre} se han actualizado exitosamente." : "Error al Actualizar los datos del usuario.";
        }


        Usuario U = new Usuario();
      public string EliminarUsuario(string documento)
        {
            bool eliminar = U.EliminarUsuario(documento);
            if (eliminar)
            {
                return "Usuario eliminado";
            }
            else
            {
                return "No se pudo eliminar el usuario";
            }
        }
        #endregion

        public void ExportarUsuariosAExcel(DataGridView tabla)
        {
            ControladorServicioExcel excel = new ControladorServicioExcel();
            excel.exportaraexcel(tabla);
        }
        public void EnviarCodigoVerificacion(string email)
        {
            string codigo = GenerarCodigoVerificacion();
            ServiciosdeUsuario.GuardarCodigoVerificacion(email, codigo);
            ServicioEmail.EnviarCorreo(email, codigo);  
        }
        private string GenerarCodigoVerificacion()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
