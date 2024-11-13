using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class InfoProducto
    {
        public int Id_Producto { get; set; }
        public string Codigo_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Categoria { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public int Cantidad_Stock { get; set; }


        public List<InfoProducto> ListaProductos()
        {
            List<InfoProducto> lista = new List<InfoProducto>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("SELECT P.IdProducto, P.codigo,P.nombre,Ct.descripcion,P.precioCompra,P.precioVenta,s.CantidadActual");
                    consulta.AppendLine("FROM Producto P INNER JOIN Categoria Ct ON P.idCategoria= Ct.IdCategoria");
                    consulta.AppendLine("INNER JOIN Stock s on P.IdProducto = s.ProductoID");
                    using (SqlCommand cmd = new SqlCommand(consulta.ToString(), con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("Descripción obtenida: " + reader[3]);
                                lista.Add(new InfoProducto
                                {
                                    Id_Producto = reader.GetInt32(0),
                                    Codigo_Producto = reader.GetString(1),
                                    Nombre_Producto = reader.GetString(2),
                                    Categoria = reader.GetString(3),
                                    Precio_Compra = reader.GetDecimal(4),
                                    Precio_Venta = reader.GetDecimal(5),
                                    Cantidad_Stock = reader.GetInt32(6),

                                });
                            }
                        }
                    }

                }
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Número de registros obtenidos: " + lista.Count);
            }
                
            return lista;
        }
    }
}
