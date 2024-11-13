using BDS.Controller;
using BDS.Modelo;
using BDS.Vista.Recursos;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Globalization;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BDS.Vista
{
    public partial class RegistroVentas : Form
    {
        List<DetalleVentas> detalles = new List<DetalleVentas>();
        private static System.Data.DataTable tabla;
        public static ControladorVentas cv= new ControladorVentas();
        public RegistroVentas()
        {
            InitializeComponent();
            tabla= new System.Data.DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Precio Unidad");
            tabla.Columns.Add("Descuento");
            tabla.Columns.Add("Precio Total");
            GridProductosVentas.DataSource = tabla;
        }
        private void CargarGrid()
        {
            DataRow dataRow = tabla.NewRow();
            dataRow["Codigo"] = textCodigo.Text;
            dataRow["Producto"] = textProducto.Text;
            dataRow["Precio Unidad"] = textPrecio.Text;
            dataRow["Cantidad"] = textCant.Text;
            dataRow["Precio Total"] = TotalxProducto.Text;
            dataRow["Descuento"] = textDescuento.Text;
            tabla.Rows.Add(dataRow);
        }
        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            using (Calendario c = new Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    TextFecha.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            using (TablaUsuarios U = new TablaUsuarios())
            {
                if (U.ShowDialog() == DialogResult.OK)
                {
                    usuarioResponsable.Text = U.nombre.ToString();
                    TexIdU.Text = U.Doc.ToString();
                }
            }
        }

        private void SeleccionarProducto_Click(object sender, EventArgs e)
        {
            using (TablaProductos P = new TablaProductos())
            {
                if (P.ShowDialog() == DialogResult.OK)
                {
                    textProducto.Text = P.nombre.ToString();
                    textPrecio.Text = P.pc.ToString();
                    textCodigo.Text = P.codi.ToString();
                    idProducto.Text= P.id.ToString();
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string idU = TexIdU.Text;
                decimal total = decimal.Parse(textTotal.Text);
                double MontoP = double.Parse(textMontopago.Text);
                double MontoC = double.Parse(texMontoCambio.Text);

                Ventas nuevaCompra = new Ventas
                {
                    IdUsuario = new Usuario { DocumentoID = idU },
                    TotalVenta = total,
                    MontoPago = MontoP,
                    MontoCambio = MontoC,
                };

                if (string.IsNullOrEmpty(idU)|| (MontoP <=0)||(MontoC<=0)||(total<=0))
                {
                    MessageBox.Show("Datos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje2 = cv.RegistrarVentaYDetalle(nuevaCompra, detalles);
                MessageBox.Show(mensaje2, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
                sumarTotales();
                int id = int.Parse(idProducto.Text);
                int ctd = int.Parse(textCant.Text);
                decimal precioN = decimal.Parse(textPrecio.Text);
                int descuento = int.Parse(textDescuento.Text);

                string mensaje;
                if (!cv.ValidarCantidad(id, ctd, out mensaje))
                {
                    MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DetalleVentas detalle = new DetalleVentas
                {
                    Id = new Productos { Id = id },
                    PrecioUnitario = precioN,
                    Descuento = descuento,
                    CantidadVendidad = ctd
                };
                detalles.Add(detalle);
                //limpiar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CalcularDescuento()
        {
            decimal subt;
            int cantidad = int.Parse(textCant.Text);
            decimal precio = decimal.Parse(textPrecio.Text);
            int desc = int.Parse(textDescuento.Text);
            decimal pxc = cantidad * precio;
            subt = precio*desc/100;
            TotalxProducto.Text = Convert.ToString(pxc-(subt*cantidad));
        }

        private void textDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuento();
        }
        public void limpiar()
        {
            textCodigo.Text = "";
            textPrecio.Text = "";
            textProducto.Text = "";
            textDescuento.Text = "";
            textCant.ResetText();
        }

        private void sumarTotales()
        {
            string c = "Precio Total";
            double stot = 0.0;
            foreach(DataGridViewRow item in GridProductosVentas.Rows)
            {
                if(item.Cells[c].Value !=null)
                {
                    double total = 0;
                    if (double.TryParse(item.Cells[c].Value.ToString(),out total))
                    {
                        stot += total;
                        textTotal.Text = stot.ToString();
                    }

                }
                else
                {
                    Console.WriteLine("No se encontro la columna");
                }
            }
        }
        private void textMontopago_TextChanged(object sender, EventArgs e)
        {
            double precioApagar = double.Parse(textTotal.Text);
            double plataEntregada = double.Parse(textMontopago.Text);
            double vuelto = plataEntregada-precioApagar;
            texMontoCambio.Text= vuelto.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void MostrarStock_Click(object sender, EventArgs e)
        {
            Recursos.TablaStock t = new TablaStock();
            
             t.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
