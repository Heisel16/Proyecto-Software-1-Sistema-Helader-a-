using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Modelo
{
    public class DetalleVentas
    {
        public int IdDetalleVenta { get; set; }
        public Ventas IdVenta { get; set; }
        public Productos Id { get; set; }
        public int CantidadVendidad {  get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Descuento { get; set; }
        public DateTime Fecharegistro { get; set; }

        public bool DobleRegistrarVyD(string conexion, Ventas venta, List<DetalleVentas> detalles)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string consulta = "INSERT INTO Venta (IdUsuario,Total, MontoPago,MontoCambio) OUTPUT INSERTED.IdVenta VALUES (@id, @total,@montoP,@montoC)";
                    SqlCommand cmd = new SqlCommand(consulta, con, transaction);
                    cmd.Parameters.AddWithValue("@id", venta.IdUsuario.DocumentoID);
                    cmd.Parameters.AddWithValue("@total", venta.TotalVenta);
                    cmd.Parameters.AddWithValue("@montoP", venta.MontoPago);
                    cmd.Parameters.AddWithValue("@montoC", venta.MontoCambio);

                    int idCompraGenerado = (int)cmd.ExecuteScalar();

                    string ConsultaDetalle = "INSERT INTO DetalleVenta (Id_Venta, id_Producto,PrecioUnitario,Descuento, CantidadVendida)" +
                                             " VALUES (@idVenta, @idProducto,@pUnitario,@descuento,@cant)";
                    foreach (var detalle in detalles)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(ConsultaDetalle, con, transaction);
                        cmdDetalle.Parameters.AddWithValue("@idVenta", idCompraGenerado);
                        cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.Id.Id);
                        cmdDetalle.Parameters.AddWithValue("@pUnitario", detalle.PrecioUnitario);
                        cmdDetalle.Parameters.AddWithValue("@descuento", detalle.Descuento);
                        cmdDetalle.Parameters.AddWithValue("@cant", detalle.CantidadVendidad);
                        cmdDetalle.ExecuteNonQuery();

                        Stock s = new Stock();
                        bool restar = s.ManejarCantidadSctock(detalle.CantidadVendidad, detalle.Id.Id,con,transaction);
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
        public int GestionarCantidad(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string consulta = "select CantidadActual From Stock where ProductoID=@idprod";
                    using(SqlCommand cmd = new SqlCommand(consulta,con))
                    {
                        cmd.Parameters.AddWithValue("@idprod",id);
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            return Convert.ToInt32(resultado);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }

            }catch(Exception ex)
            {
            Console.WriteLine(ex.Message);
            return -1;
            }
        }
    }
}
