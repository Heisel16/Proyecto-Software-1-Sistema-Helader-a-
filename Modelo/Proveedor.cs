using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Xml.Linq;
using System.Data.SqlClient;
using BDS.Modelo;
using System.Data;

namespace BDS.Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public string Ubicacion { get; set; }
        public string Direccion {  get; set; }
        public DateTime FechaCreacion { get; set; }

        #region CRUD Proveedores

        public bool RegistrarProveedor(string conexion)
        {
            try
            {
                using (SqlConnection cox = new SqlConnection(conexion))
                {
                    cox.Open();
                    string query = "INSERT INTO Proveedor (documento,razonSocial,telefono,correo,estado,Ubicacion,Direccion) Values(@documento,@razonsocial,@telefono,@correo,@estado,@ubicacion,@direccion)";
                    using (SqlCommand cmd = new SqlCommand(query, cox))
                    {
                        cmd.Parameters.AddWithValue("@documento", this.Documento);
                        cmd.Parameters.AddWithValue("@razonsocial", this.RazonSocial);
                        cmd.Parameters.AddWithValue("@telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("@correo", this.Correo);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);
                        cmd.Parameters.AddWithValue("@ubicacion", this.Ubicacion);
                        cmd.Parameters.AddWithValue("@direccion", this.Direccion);

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

        public bool ActualizarProveedor(string connectionString)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "UPDATE Proveedor SET documento = @documento, razonSocial = @rsocial,telefono = @Telefono, correo = @Correo, Ubicacion =@ubicacion, estado= @estado, Direccion=@direccion WHERE IdProveedor = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.Parameters.AddWithValue("@documento", this.Documento);
                        cmd.Parameters.AddWithValue("@rsocial", this.RazonSocial);
                        cmd.Parameters.AddWithValue("@Telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", this.Correo);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);
                        cmd.Parameters.AddWithValue("@ubicacion", this.Ubicacion);
                        cmd.Parameters.AddWithValue("@direccion", this.Direccion);

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
        public bool EliminarProveedor(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Proveedor WHERE IdProveedor = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", Documento);
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

        public List<Proveedor> Listar()
        {
            List<Proveedor> list = new List<Proveedor>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT IdProveedor,documento, razonSocial, Ubicacion, correo, estado, Direccion, telefono, fechaRegistro From Proveedor";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Proveedor
                                {
                                    Id = Convert.ToInt32(reader["IdProveedor"].ToString()),
                                    Documento = reader["documento"].ToString(),
                                    RazonSocial = reader["razonSocial"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["correo"].ToString(),
                                    Estado = reader["estado"].ToString(),
                                    FechaCreacion= Convert.ToDateTime(reader["fechaRegistro"].ToString()),
                                    Ubicacion = reader["Ubicacion"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                }); ;
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

        public bool ValidarExistencia(string conexion, string id, string rz)
        {
            try
            {
                using(SqlConnection  con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "Select COUNT(*) from Proveedor Where documento = @doc or razonSocial= @Rz";
                    using(SqlCommand c= new SqlCommand(consulta,con))
                    {
                        c.Parameters.AddWithValue("@doc", id);
                        c.Parameters.AddWithValue(@"Rz", rz);
                        int contadorProv= Convert.ToInt32(c.ExecuteScalar());
                        return contadorProv > 0;
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
