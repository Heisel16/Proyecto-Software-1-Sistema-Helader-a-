using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class RegistrarCompras : Form
    {
        private List<DetalleCompras> detalles = new List<DetalleCompras>();
        private static DataTable dt;
        public RegistrarCompras()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre_Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Precio Total");
            dt.Columns.Add("Proveedor");
            dtgCompras.DataSource = dt;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            using (Recursos.Calendario c = new Recursos.Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    c.StartPosition = FormStartPosition.CenterParent;
                    textFecha.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaUsuarios p = new Recursos.TablaUsuarios())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textUsuario.Text = p.nombre.ToString();
                    IdUsuario.Text = p.Doc.ToString();
                }
            }
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaProveedor p = new Recursos.TablaProveedor())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textProveedor.Text = p.nombre.ToString();
                    textcorreo.Text = p.correo.ToString();
                    textDocumento.Text = p.doc.ToString();
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ControladorDetalleCompra cd = new ControladorDetalleCompra();
            try
            {
                if (string.IsNullOrWhiteSpace(textTotal.Text))
                {
                    MessageBox.Show("El total está vacío. Asegúrate de que se haya calculado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idU = IdUsuario.Text;
                long prov = long.Parse(textDocumento.Text);
                float total = float.Parse(textTotal.Text);


                   Compras nuevaCompra = new Compras
                   {
                      idUsuario = new Usuario { DocumentoID = idU },
                      idProveeor = new Proveedor { Documento = Convert.ToString(prov) },
                      Total = total
                   };
                string mensaje = cd.RegistrarCompraYDetalle(nuevaCompra, detalles);
                MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void RegistrarCompras_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelec_Prod_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaProductos p = new Recursos.TablaProductos())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    TextProductos.Text = p.nombre.ToString();
                    textcodigo.Text = p.codi.ToString();
                    textcantidad.Text = p.cant.ToString();
                    textPrecioCompra.Text= p.pc.ToString();
                    textPv.Text= p.pv.ToString();
                }
                CalcularSubTotal();
            }
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }
         private void CalcularSubTotal()
        {
            double total = 0;
            int cantidad = int.Parse(textcantidad.Value.ToString());
            double precio = double.Parse(textPrecioCompra.Text);
            total = cantidad * precio;
            textSubtotal.Text = total.ToString();
        }

        private void BntAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
                SumarTotal();
                string cdg = textcodigo.Text;
                int ctd = int.Parse(textcantidad.Text);
                double pcc = double.Parse(textPrecioCompra.Text);
                double pcv = double.Parse(textPv.Text);
                double montoPago = double.Parse(textSubtotal.Text);
                if ((string.IsNullOrEmpty(cdg)) || (pcc <= 0) || (pcv < 0))
                {
                    MessageBox.Show("todos los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DetalleCompras detalle = new DetalleCompras
                {
                    cod = new Productos { Codigo = cdg },
                    precioCompra = pcc,
                    precioVenta = pcv,
                    cantidad = ctd,
                    Total = montoPago
                };
                detalles.Add(detalle);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CargarGrid()
        {
            DataRow dataRow = dt.NewRow();
            dataRow["Codigo"] = textcodigo.Text;
            dataRow["Nombre_Producto"] = TextProductos.Text;
            dataRow["Precio x Unidad"] = textPrecioCompra.Text;
            dataRow["Cantidad"] = textcantidad.Text;
            dataRow["Precio Total"] = textSubtotal.Text;
            dataRow["Proveedor"] = textProveedor.Text;
            dt.Rows.Add(dataRow);
        }

        public void SumarTotal()
        {
            string columna = "Precio Total";

            double subTotal =0.0;

            foreach (DataGridViewRow item in dtgCompras.Rows)
            {
                if (item.Cells[columna].Value != null)
                {
                    double totalCompra;
                    if (double.TryParse(item.Cells[columna].Value.ToString(), out totalCompra))
                    {
                        subTotal += totalCompra;
                        textTotal.Text = Convert.ToString(subTotal);

                    }

                }
                else
                {
                    Console.WriteLine("nombre de la columna"+columna);
                }

            }
        }
    }
}
