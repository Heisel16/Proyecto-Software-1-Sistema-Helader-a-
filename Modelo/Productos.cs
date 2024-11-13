using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Productos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Categoria IdCategoria { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public string Estado { get; set; }
        public string FechaRegistro { get; set; }


        #region Crud de Productos
        public bool RegistrarProductos(string conexion)
        {
            try
            {
                using (SqlConnection cox = new SqlConnection(conexion))
                {
                    cox.Open();
                    string query = "INSERT INTO Producto (codigo,nombre,idCategoria,precioCompra,precioVenta,estado) Values(@codigo,@nombre,@idCategoria,@precioCompra,@precioVenta,@estado)";
                    using (SqlCommand cmd = new SqlCommand(query, cox))
                    {
                        cmd.Parameters.AddWithValue("@codigo", this.Codigo);
                        cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("@idCategoria", this.IdCategoria.Id);
                        cmd.Parameters.AddWithValue("@precioCompra", this.PrecioCompra);
                        cmd.Parameters.AddWithValue("@precioVenta", this.PrecioVenta);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool ActualizarProducto(string conexion)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta= "UPDATE Producto SET codigo = @cod, nombre = @n, idCategoria = @cat, precioCompra = @pc, precioVenta =@pv, estado= @estado WHERE IdProducto = @id";
                    using(SqlCommand cmd = new SqlCommand(consulta,con))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.Parameters.AddWithValue("@cod",this.Codigo);
                        cmd.Parameters.AddWithValue("@n", this.Nombre);
                        cmd.Parameters.AddWithValue("@cat", this.IdCategoria.Id);
                        cmd.Parameters.AddWithValue("@pc", this.PrecioCompra);
                        cmd.Parameters.AddWithValue("@pv", this.PrecioVenta);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);

                        int filasAfectadas= cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return false;
            }
        }

        public bool EliminarProducto(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Producto WHERE IdProducto = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id",id);
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

        public List<Productos> ListaDeProductos()
        {
            List<Productos> list = new List<Productos>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT IdProducto, codigo, nombre,idCategoria, precioVenta, precioCompra, estado From Producto";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Productos
                                {
                                    Id = Convert.ToInt32(reader["IdProducto"].ToString()),
                                    Nombre = reader["nombre"].ToString(),
                                    Codigo = reader["codigo"].ToString(),
                                    IdCategoria = new Categoria{Id = Convert.ToInt32(reader["idCategoria"])},
                                    PrecioCompra = float.Parse(reader["precioCompra"].ToString()),
                                    PrecioVenta = float.Parse(reader["precioVenta"].ToString()),
                                    Estado = reader["estado"].ToString()
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

        #endregion

        public bool Validacion(string codig, string connectionString)
        {
            try 
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Producto WHERE codigo = @c";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@c", codig);
                        int contProd = Convert.ToInt32(cmd.ExecuteScalar());
                        return contProd > 0;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
