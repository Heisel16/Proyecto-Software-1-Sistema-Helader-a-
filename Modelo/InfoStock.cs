using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class InfoStock
    {
        public int ID_Stock { get; set; }   
        public string Producto {  get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }


        public List<InfoStock> lista()
        {
            List<InfoStock> lista = new List<InfoStock>();
             try
             {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("select s.StockID,p.nombre,s.CantidadActual,s.Estado ");
                    consulta.AppendLine("from Stock s inner join Producto p on s.ProductoID= p.IdProducto");
                    using (SqlCommand cmd = new SqlCommand(consulta.ToString(), con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Console.WriteLine("Descripción obtenida: " + reader[3]);
                                lista.Add(new InfoStock
                                {
                                   ID_Stock= reader.GetInt32(0),
                                   Producto = reader.GetString(1),
                                   Cantidad = reader.GetInt32(2),
                                   Estado = reader.GetString(3),
                                });
                            }
                        }
                    }
                }

             }catch(Exception ex)
             {
                Console.WriteLine(ex.Message);
             }
            return lista;
        }
    }
}
