using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows;
using BDS.Controller;

namespace BDS.Vista
{
    public partial class BoletinPedido : Form
    {
        private DataTable dt;
        private List<DetallesDePedidos> detalles = new List<DetallesDePedidos>();
        public BoletinPedido()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre_Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Precio Total");
            dt.Columns.Add("Proveedor");
            gridPedidos.DataSource = dt;
        }

        private void CargarGrid()
        {
            DataRow dataRow = dt.NewRow();
            dataRow["Codigo"] = codigoproducto.Text;
            dataRow["Nombre_Producto"] = textproducto.Text;
            dataRow["Precio x Unidad"] = precio.Text;
            dataRow["Cantidad"] = cant.Text;
            dataRow["Precio Total"] = textsubtotal.Text;
            dataRow["Proveedor"] = textProveedor.Text;
            dt.Rows.Add(dataRow);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (Recursos.Calendario c = new Recursos.Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    c.StartPosition = FormStartPosition.CenterParent;
                    TextFechaEmision.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void seleccionarprod_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaProductos p = new Recursos.TablaProductos())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textproducto.Text = p.nombre.ToString();
                    codigoproducto.Text = p.codi.ToString();
                    textIdProd.Text = p.id.ToString();
                }
            }
        }

        private void BtnBuscarProv_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaProveedor p = new Recursos.TablaProveedor())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textProveedor.Text = p.nombre.ToString();
                    textcorreo.Text = p.correo.ToString();
                    textEstado.Text = p.estado.ToString();
                    IdProv.Text = p.id.ToString();
                }
            }
        }

        private void selectUsuario_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaUsuarios p = new Recursos.TablaUsuarios())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textUser.Text = p.nombre.ToString();
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            using (Recursos.Calendario c = new Recursos.Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    c.StartPosition = FormStartPosition.CenterParent;
                    fechaEntreg.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float pr= float.Parse(precio.Text);
            int ctd = int.Parse(cant.Text);
            float subtotal= pr*ctd;
            textsubtotal.Text = subtotal.ToString();
            CargarGrid();
            SumarTotal();
        }

        public void SumarTotal()
        {
            string columna = "Precio Total";

            double subTotal = 0.0;

            foreach (DataGridViewRow item in gridPedidos.Rows)
            {
                if (item.Cells[columna].Value != null)
                {
                    double totalCompra;
                    if (double.TryParse(item.Cells[columna].Value.ToString(), out totalCompra))
                    {
                        subTotal += totalCompra;
                        SubtotalPedido.Text = Convert.ToString(subTotal);

                    }

                }
                else
                {
                    Console.WriteLine("nombre de la columna" + columna);
                }

            }
        }
        private void CalcularImpuesto()
        {
            double totalImpuesto;
            double subt= double.Parse(SubtotalPedido.Text);
            int imp = int.Parse(Impuesto.Text);
            totalImpuesto= subt*imp/100;
            textTotal.Text = Convert.ToString(subt + totalImpuesto);
        }

        private void BoletinPedido_Load(object sender, EventArgs e)
        {

        }
        private void Impuesto_TextChanged(object sender, EventArgs e)
        {
            CalcularImpuesto();
        }

        private void GenerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = "Boletin Faltantes" + ".pdf";

                string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PROVEEDOR", textProveedor.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CORREO", textcorreo.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in gridPedidos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre_Producto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Precio x Unidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Precio Total"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total += decimal.Parse(row.Cells["Precio Total"].Value.ToString());
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", textTotal.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAENTREGA", fechaEntreg.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PAGO", MetodoDePago.Text);

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.beraka_transparent_logo, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {

            ControladorPedidos cp = new ControladorPedidos();
            try
            {
                if (string.IsNullOrWhiteSpace(textTotal.Text))
                {
                    System.Windows.Forms.MessageBox.Show("El total está vacío. Asegúrate de que se haya calculado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int Proveedor = int.Parse(IdProv.Text);
                decimal PrecioTotal = decimal.Parse(textTotal.Text);

                Pedido nuevo = new Pedido
                {
                    idProveedor = new Proveedor { Id = Proveedor },
                    TotalPedido = PrecioTotal
                };
                decimal Precio_Unidad = decimal.Parse(precio.Text);
                int Cantidad = int.Parse(cant.Text);
                int idp = int.Parse(textIdProd.Text);
                string mp = MetodoDePago.Text;
                int imp = int.Parse(Impuesto.Text);
                DateTime fent = DateTime.Parse(fechaEntreg.Text);
                decimal subt = decimal.Parse(textsubtotal.Text);

                DetallesDePedidos detalle = new DetallesDePedidos
                {
                    idProducto = new Productos { Id = idp },
                    PrecioUnitario = Precio_Unidad,
                    SubTotal = subt,
                    MetodoPago = mp,
                    Impuesto = imp,
                    Cantidad = Cantidad,
                    fechaEntrega = fent
                };
                detalles.Add(detalle);
                string mensaje = cp.RegistrarBoletin(nuevo, detalles);
                 System.Windows.Forms.MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
