using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class CompraModelo
    {
        public int IdCompra {  get; set; }
        public string NombreProducto { get; set; }
        public string NombreProveedor {  get; set; }
        public string Codigo {  get; set; }
        public int Cantidad {  get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<CompraModelo> ListarCompras()
        {
            List<CompraModelo> lista = new List<CompraModelo>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("SELECT DC.IdCompra,Pr.RazonSocial,P.nombre,DC.Cod_Producto,DC.Cantidad,DC.PrecioCompra,DC.MontoPago,DC.FechaVenta");
                    consulta.AppendLine("FROM DetalleCompra DC INNER JOIN Producto P ON DC.Cod_Producto = P.codigo");
                    consulta.AppendLine("INNER JOIN Compra C ON DC.IdCompra = C.IdCompra");
                    consulta.AppendLine("INNER JOIN Proveedor Pr ON C.IdProveedor = Pr.IdProveedor");
                    using (SqlCommand cmd = new SqlCommand(consulta.ToString(), con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new CompraModelo
                                {
                                    IdCompra = reader.GetInt32(0),
                                    NombreProveedor = reader.GetString(1),
                                    NombreProducto = reader.GetString(2),
                                    Codigo = reader.GetString(3),
                                    Cantidad = reader.GetInt32(4),
                                    PrecioCompra = reader.GetDecimal(5),
                                    MontoPagado = reader.GetDecimal(6),
                                    FechaRegistro = reader.GetDateTime(7),

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
            Console.WriteLine("Número de registros obtenidos: " + lista.Count);
            return lista;
        }

        public List<CompraModelo> ListarComprasPorFecha(DateTime fechaInicio, DateTime FechaFinal)
        {
            List<CompraModelo> lista = new List<CompraModelo>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("SELECT DC.IdCompra,Pr.RazonSocial,P.nombre,DC.Cod_Producto,DC.Cantidad,DC.PrecioCompra,DC.MontoPago,DC.FechaVenta");
                    consulta.AppendLine("FROM DetalleCompra DC INNER JOIN Producto P ON DC.Cod_Producto = P.codigo");
                    consulta.AppendLine("INNER JOIN Compra C ON DC.IdCompra = C.IdCompra");
                    consulta.AppendLine("INNER JOIN Proveedor Pr ON C.IdProveedor = Pr.IdProveedor");
                    consulta.AppendLine("WHERE DC.FechaVenta BETWEEN @FechaInicio AND @FechaFin");
                    using (SqlCommand cmd = new SqlCommand(consulta.ToString(), con))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio",fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin",FechaFinal);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new CompraModelo
                                {
                                    IdCompra = reader.GetInt32(0),
                                    NombreProveedor = reader.GetString(1),
                                    NombreProducto = reader.GetString(2),
                                    Codigo = reader.GetString(3),
                                    Cantidad = reader.GetInt32(4),
                                    PrecioCompra = reader.GetDecimal(5),
                                    MontoPagado = reader.GetDecimal(6),
                                    FechaRegistro = reader.GetDateTime(7),

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
            Console.WriteLine("Número de registros obtenidos: " + lista.Count);
            return lista;
        }

    }
}
