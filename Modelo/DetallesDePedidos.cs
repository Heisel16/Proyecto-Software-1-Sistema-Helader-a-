using BDS.Vista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class DetallesDePedidos
    {
        public int idDetalle { get; set; }
        public Pedido idPedido { get; set; }
        public Productos idProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public string MetodoPago {  get; set; }
        public int Impuesto {  get; set; }
        public DateTime fechaEmision { get; set; }
        public DateTime fechaEntrega { get; set; }

        #region Crud
        public bool RegistrarBoletinyDetalle(string conexion, Pedido boletin, List<DetallesDePedidos> detalles)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string consulta = "insert into BoletinesPedidos(IdProveedor,TotalPedido) OUTPUT INSERTED.IdBoletin values(@idp, @total)";
                    SqlCommand cmd = new SqlCommand(consulta, con, transaction);
                    cmd.Parameters.AddWithValue("@idp", boletin.idProveedor.Id);
                    cmd.Parameters.AddWithValue("@total", boletin.TotalPedido);

                    int idPedidoGenerado = (int)cmd.ExecuteScalar();

                    string queryDetalle = "insert into DetalleBoletin( IdPedido,IdProducto,Cantidad,PrecioUnitario,SubTotal,MetodoPago,Impuesto,FechaEntrega)" +
                        " VALUES (@idPedido, @IdProducto,@cantidad, @pUnitario,@subtotal,@metodoP,@impuesto,@fentrega)";
                    foreach (var detalle in detalles)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaction);
                        cmdDetalle.Parameters.AddWithValue("@idPedido", idPedidoGenerado);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", detalle.idProducto.Id);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@pUnitario", detalle.PrecioUnitario);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.SubTotal);
                        cmdDetalle.Parameters.AddWithValue("@metodoP", detalle.MetodoPago);
                        cmdDetalle.Parameters.AddWithValue("@impuesto", detalle.Impuesto);
                        cmdDetalle.Parameters.AddWithValue("@fentrega", detalle.fechaEntrega);
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
        #endregion

    }
}
