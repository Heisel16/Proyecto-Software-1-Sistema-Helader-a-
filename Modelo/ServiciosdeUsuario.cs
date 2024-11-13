using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;

namespace BDS.Modelo
{
    public class ServiciosdeUsuario
    {
        public static void GuardarCodigoVerificacion(string email, string codigo)
        {
            try
            {
                using(System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "UPDATE Usuarios SET CodigoVerificacion = @Codigo, FechaExpiracionCodigo = @Expiracion WHERE correo = @Email";
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Expiracion", DateTime.Now.AddMinutes(15));
                        cmd.Parameters.AddWithValue("@Email",email);

                       cmd.ExecuteNonQuery();

                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el código de verificación: " + ex.Message);
            }
        }

        public static Usuario ObtenerPorEmail(string email)
        {
            Usuario usuario = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT * FROM Usuarios WHERE correo = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuario = new Usuario
                                {
                                    DocumentoID = reader["IdUsuario"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Correo = reader["correo"].ToString(),
                                    Contraseña = reader["clave"].ToString(),
                                    CodigoVerificacion = reader["CodigoVerificacion"].ToString(),
                                    FechaExpiracion = Convert.ToDateTime(reader["FechaExpiracionCodigo"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuario por email: " + ex.Message);
            }
            return usuario;
        }
    }
}
