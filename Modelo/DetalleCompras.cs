using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace BDS.Modelo
{
    public class DetalleCompras
    {
        public int id { get; set; }
        public Compras idCompra{ get; set; }
        public Productos cod { get; set; }
        public double precioCompra {  get; set; }
        public double precioVenta {  get; set; }
        public int cantidad { get; set; }
        public double Total { get; set; }
        public DateTime fecharegistro { get; set; }

        public bool DobleRegistrarCyD(string conexion, Compras compra, List<DetalleCompras> detalles)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string queryCompra = "INSERT INTO Compra (IdUsuario, IdProveedor, Total) OUTPUT INSERTED.IdCompra VALUES (@id, @prov, @total)";
                    SqlCommand cmdCompra = new SqlCommand(queryCompra, con, transaction);
                    cmdCompra.Parameters.AddWithValue("@id", compra.idUsuario.DocumentoID);
                    cmdCompra.Parameters.AddWithValue("@prov", compra.idProveeor.Documento);
                    cmdCompra.Parameters.AddWithValue("@total", compra.Total);

                    int idCompraGenerado = (int)cmdCompra.ExecuteScalar();

                    string queryDetalle = "INSERT INTO DetalleCompra (IdCompra, Cod_Producto, PrecioCompra, PrecioVenta, Cantidad, MontoPago) VALUES (@idCompra, @CodProducto,@pc,@pv,@ctd,@total)";
                    foreach (var detalle in detalles)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaction);
                        cmdDetalle.Parameters.AddWithValue("@idCompra", idCompraGenerado);
                        cmdDetalle.Parameters.AddWithValue("@CodProducto", detalle.cod.Codigo);
                        cmdDetalle.Parameters.AddWithValue("@pc", detalle.precioCompra);
                        cmdDetalle.Parameters.AddWithValue("@pv", detalle.precioVenta);
                        cmdDetalle.Parameters.AddWithValue("@ctd", detalle.cantidad);
                        cmdDetalle.Parameters.AddWithValue("@total", detalle.Total);
                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }


    }
}
