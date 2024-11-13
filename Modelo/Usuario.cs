using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Usuario
    {
        public string DocumentoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdRol { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Contraseña { get; set; }
        public string CodigoVerificacion { get; set; }
        public DateTime FechaExpiracion { get; set; }

        #region CRUD
        public string HashPassword(string contra)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contra));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool RegistrarUsuario(string connectionString)
        {
            string hashedPassword = HashPassword(this.Contraseña);
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "INSERT INTO Usuarios(Documento,nombre,apellido,correo,clave,idRol,estado,Telefono) Values(@cedula,@nombre,@apellido,@correo,@contra,@IdRol,@estado,@telefono)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cedula", this.DocumentoID);
                        cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("@IdRol", this.IdRol);
                        cmd.Parameters.AddWithValue("@correo", this.Correo);
                        cmd.Parameters.AddWithValue("@estado", this.estado);
                        cmd.Parameters.AddWithValue("@contra", hashedPassword);
                        cmd.Parameters.AddWithValue("@telefono", this.telefono);

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }

        public bool ActualizarUsuario(string connectionString)
        {
            try
            {
                string hashedPassword = null;
                if (!string.IsNullOrEmpty(this.Contraseña))
                {
                    hashedPassword = HashPassword(this.Contraseña);
                }
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET nombre = @Nombre, apellido = @Apellido, correo = @Correo, idRol =@idrol, estado= @estado, Telefono = @Telefono";
                    if (!string.IsNullOrEmpty(this.Contraseña))
                    {
                        query += ", clave = @Contraseña";
                    }
                    query += " WHERE Documento = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", this.DocumentoID);
                        cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("@Correo", this.Correo);
                        cmd.Parameters.AddWithValue("@idrol", this.IdRol);
                        cmd.Parameters.AddWithValue("@estado", this.estado);
                        cmd.Parameters.AddWithValue("@Telefono", this.telefono);

                        if (!string.IsNullOrEmpty(this.Contraseña))
                        {
                           cmd.Parameters.AddWithValue("@Contraseña",hashedPassword);
                        }

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
        public bool EliminarUsuario(string cedula)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE Documento = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
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

        public List<Usuario> Listar()
        {
            List<Usuario> list = new List<Usuario>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT Documento, nombre, apellido, correo,idRol, estado, clave, Telefono From Usuarios";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Usuario
                                {
                                    DocumentoID = reader["Documento"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Apellido = reader["apellido"].ToString(),
                                    Correo = reader["correo"].ToString(),
                                    estado = reader["estado"].ToString(),
                                    Contraseña = reader["clave"].ToString(),
                                    telefono = reader["Telefono"].ToString(),
                                    IdRol = int.Parse(reader["idRol"].ToString()),
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

        public bool ValidarExistencia(string conexion, string id, string tlf)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "Select COUNT(*) from Usuarios Where Documento = @doc or Telefono= @tl";
                    using (SqlCommand c = new SqlCommand(consulta, con))
                    {
                        c.Parameters.AddWithValue("@doc", id);
                        c.Parameters.AddWithValue(@"tl", tlf);
                        int contadorProv = Convert.ToInt32(c.ExecuteScalar());
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