using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDS.Modelo
{
    public class Stock
    {
        public int id {  get; set; }
        public Productos productoId { get; set; }
        public int cantidad { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public string Alerta {  get; set; } 


        public bool EstablecerStock(string conexion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "insert into Stock(ProductoID,CantidadActual,CapacidadMaxima,Estado,NivelAlerta) values(@prodId,@CntAct,@capacidad,@estado,@alerta)";
                    using(SqlCommand cmd= new SqlCommand(consulta,con))
                    {
                        cmd.Parameters.AddWithValue("@prodId", this.productoId.Id);
                        cmd.Parameters.AddWithValue("@CntAct", this.cantidad);
                        cmd.Parameters.AddWithValue("@capacidad", this.Capacidad);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);
                        cmd.Parameters.AddWithValue("@alerta", this.Alerta);

                        int cont= cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool ActualizarStock(string conexion)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "update Stock set CantidadActual= @cantidad, CapacidadMaxima= @capacidad, Estado= @estado, NivelAlerta= @alerta WHERE StockID= @stockId";
                    using(SqlCommand cmd = new SqlCommand(consulta,con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", this.id);
                        cmd.Parameters.AddWithValue("@cantidad",this.cantidad);
                        cmd.Parameters.AddWithValue("@capacidad", this.Capacidad);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);
                        cmd.Parameters.AddWithValue("@alerta", this.Alerta);

                        int r = cmd.ExecuteNonQuery();
                        return r > 0;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Stock> ListarStock()
        {
            List<Stock> list = new List<Stock>();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string query = "SELECT StockID,ProductoID,CantidadActual,CapacidadMaxima,Estado,NivelAlerta From Stock";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Stock
                                {
                                    id = Convert.ToInt32(reader["StockID"].ToString()),
                                    productoId = new Productos { Id = int.Parse(reader["ProductoID"].ToString())},
                                    cantidad = Convert.ToInt32(reader["CantidadActual"].ToString()),
                                    Capacidad = Convert.ToInt32(reader["CapacidadMaxima"].ToString()),
                                    Estado = reader["Estado"].ToString(),
                                    Alerta =reader["NivelAlerta"].ToString()
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

        public bool ManejarCantidadSctock(int CantVendida, int id, SqlConnection conexion, SqlTransaction transaction)
        {
            try
            {
                string consulta = "Update Stock set CantidadActual= CantidadActual - @cantidadVendida where ProductoID= @idprod";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion, transaction))
                {
                    cmd.Parameters.AddWithValue("@cantidadVendida", CantVendida);
                    cmd.Parameters.AddWithValue("@idprod", id);

                    int r = cmd.ExecuteNonQuery();
                    return r > 0;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
