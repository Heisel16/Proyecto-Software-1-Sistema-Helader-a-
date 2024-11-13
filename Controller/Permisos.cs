using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Controller
{
    public class Permisos
    {
        public List<Permiso> Listar(int user)
        {
            List<Permiso> list = new List<Permiso>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu from Permiso p");
                    query.AppendLine("inner join Rol r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join Usuarios u on u.idRol = r.IdRol");
                    query.AppendLine("where u.Documento = @documentoId");
                    using (SqlCommand cmd = new SqlCommand(query.ToString(), con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@documentoId", user);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Permiso
                                {
                                    Nombre = new Rol(){IdRol= Convert.ToInt32(reader["IdRol"]) },
                                    MenuDisponibles = reader["NombreMenu"].ToString(),
                                    
                                });
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

    }
}
