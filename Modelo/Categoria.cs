using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Fecha { get; set; }

        #region crud

        public bool registrarCategoria(string conexion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "INSERT INTO Categoria(descripcion,estado) values(@descrip,@estado)";
                    using (SqlCommand cmd = new SqlCommand(consulta,con))
                    {
                        cmd.Parameters.AddWithValue("@descrip", this.Descripcion);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);

                        int filasafectadas = cmd.ExecuteNonQuery();
                        return filasafectadas > 0;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ActualizarCtegoria(string connectionString)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "UPDATE Categoria SET descripcion = @d,estado = @est WHERE IdCategoria = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.Parameters.AddWithValue("@d", this.Descripcion);
                        cmd.Parameters.AddWithValue("@est", this.Estado);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool EliminarCategoria(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Categoria WHERE IdCategoria = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int FilaAfectada = cmd.ExecuteNonQuery();
                        return FilaAfectada > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Categoria ObtenerCategoria(int idcategoria)
        {
            Categoria categoria = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT IdCategoria, descripcion, estado FROM Categoria WHERE descripcion = @Descripcion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", idcategoria);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoria = new Categoria
                                {
                                    Id = Convert.ToInt32(reader["Idcategoria"]),
                                    Descripcion = reader["descripcion"].ToString(),
                                    Estado = reader["estado"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("NO SE PUDO OBTERNER LA CATEGORIA: " + ex.Message);
            }

            return categoria;
        }

        public List<Categoria>lista()
        {
            List<Categoria> categoria = new List<Categoria>();

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT IdCategoria, descripcion, estado FROM Categoria";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType= System.Data.CommandType.Text;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categoria.Add( new Categoria
                                {
                                    Id = Convert.ToInt32(reader["Idcategoria"]),
                                    Descripcion = reader["descripcion"].ToString(),
                                    Estado = reader["estado"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("NO SE PUDO OBTERNER LA CATEGORIA: " + ex.Message);
            }

            return categoria;
        }

        public bool Validacion(string categ, string connectionString)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Categoria WHERE descripcion = @c";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@c", categ);
                        int contProd = Convert.ToInt32(cmd.ExecuteScalar());
                        return contProd > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion
    }
}
