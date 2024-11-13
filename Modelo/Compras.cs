using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class Compras
    {
        public int id {  get; set; }
        public Usuario idUsuario { get; set; }
        public Proveedor idProveeor { get; set; }
        public float Total {  get; set; }
        public DateTime fecharegistro { get; set; }


        public bool RegistrarCompra(string conexion)
        {
            try
            {
                using (SqlConnection cox = new SqlConnection(conexion))
                {
                    cox.Open();
                    string query = "INSERT INTO Compra (idUsuario,idProveedor,Total) Values(@user,@prov,@total)";
                    using (SqlCommand cmd = new SqlCommand(query, cox))
                    {
                        cmd.Parameters.AddWithValue("@user", Convert.ToInt32(this.idUsuario.DocumentoID));
                        cmd.Parameters.AddWithValue("@prov", this.idProveeor.Documento);
                        cmd.Parameters.AddWithValue("@total", this.Total);

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

    }
}
