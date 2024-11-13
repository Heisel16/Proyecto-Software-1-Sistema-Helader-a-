using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Producto : Form
    {
        private DataTable originalDataTable;

        public Producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            CargarDatosOriginales();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IdCategoria, descripcion FROM Categoria", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> categorias = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        categorias.Add(reader.GetInt32(0), reader.GetString(1));
                    }

                    combocategoria.DataSource = new BindingSource(categorias, null);
                    combocategoria.DisplayMember = "Value";
                    combocategoria.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProductos.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\escritura.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProductos.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProductos.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProductos.Columns["Column2"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\borrar_.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProductos.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProductos.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            using (Recursos.Calendario c = new Recursos.Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    c.StartPosition = FormStartPosition.CenterParent;
                    TextFechaInicio.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaProveedor p = new Recursos.TablaProveedor())
            {
                if(p.ShowDialog()== DialogResult.OK)
                {
                    textProveedor.Text= p.nombre.ToString();
                    textcorreo.Text = p.correo.ToString();
                    textEstado.Text= p.estado.ToString();
                }
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            using (Recursos.TablaUsuarios p = new Recursos.TablaUsuarios())
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    textUser.Text=p.nombre.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControladorProductos c = new ControladorProductos();
            string nombre = TextProductos.Text;
            string codigo = textcodigo.Text;
            int categoria = (int)combocategoria.SelectedValue;
            float precioC = float.Parse(textPrecioCompra.Text);
            float precioV = float.Parse(textPrecioVenta.Text);
            string estado = comboBoxEst.Text;

            string mensaje = c.RegistrarProducto(codigo, nombre, categoria,precioC, precioV, estado);

            MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatosOriginales();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private DataTable MiTabla(List<Productos> productos)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id Producto", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Codigo", typeof(string));
            table.Columns.Add("Id Categoria", typeof(int));
            table.Columns.Add("Precio Compra", typeof(float));
            table.Columns.Add("Precio Venta", typeof(float));
            table.Columns.Add("Estado", typeof(string));
            foreach (var item in productos)
            {
                table.Rows.Add(item.Id, item.Nombre, item.Codigo,item.IdCategoria.Id, item.PrecioCompra, item.PrecioVenta, item.Estado);
            }
            return table;
        }

        private void CargarDatosOriginales()
        {
            ControladorProductos c = new ControladorProductos();
            originalDataTable = new DataTable();
            originalDataTable = MiTabla(c.ListarProductos());
            GridProductos.DataSource = originalDataTable;
            GridProductos.Columns["Id Producto"].DisplayIndex = 0;
            GridProductos.Columns["Nombre"].DisplayIndex = 1;
            GridProductos.Columns["Codigo"].DisplayIndex = 2;
            GridProductos.Columns["Id Categoria"].DisplayIndex = 3;
            GridProductos.Columns["Precio Compra"].DisplayIndex = 4;
            GridProductos.Columns["Precio Venta"].DisplayIndex = 5;
            GridProductos.Columns["Estado"].DisplayIndex = 6;
            GridProductos.Columns["Column1"].DisplayIndex = 7;
            GridProductos.Columns["Column2"].DisplayIndex = 8;

        }

        private void generarExcel_Click(object sender, EventArgs e)
        {
            ControladorServicioExcel ex= new ControladorServicioExcel();
            ex.exportaraexcel(GridProductos);
        }

        private void GridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProductos.Columns[e.ColumnIndex].Name == "Column2")
            {
                ControladorProductos c = new ControladorProductos();
                DataGridViewRow row = GridProductos.Rows[e.RowIndex];
                int ide = int.Parse(row.Cells["Id Producto"].Value.ToString());
                DialogResult result = MessageBox.Show("Desea Eliminar los Datos del producto ", "Heladeria BERAKA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string eliminar = c.EliminarProducto(ide);
                    MessageBox.Show(eliminar, "Heladeria BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosOriginales();

                }

            }
            if (GridProductos.Columns[e.ColumnIndex].Name == "Column1")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridProductos.Rows[rowindex];
                string valorColumna = filaSeleccionada.Cells["Id Producto"].Value.ToString();
                string valorColumna1 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Codigo"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Id Categoria"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Precio Compra"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["Precio Venta"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["Estado"].Value.ToString();

                textId.Text = valorColumna;
                TextProductos.Text = valorColumna1;
                textcodigo.Text = valorColumna2;
                combocategoria.Text = valorColumna3;
                textPrecioCompra.Text = valorColumna4;
                textPrecioVenta.Text = valorColumna5;
                comboBoxEst.Text = valorColumna7;

            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ControladorProductos cu = new ControladorProductos();
            int id = int.Parse(textId.Text);
            string cod = textcodigo.Text;
            string pro = TextProductos.Text;
            int categ = int.Parse(combocategoria.Text);
            float pc = float.Parse(textPrecioCompra.Text);
            float pv = float.Parse(textPrecioVenta.Text);
            string estado = comboBoxEst.Text;

            string mensaje = cu.ActualizarProducto(id, cod, pro, categ, pc, pv, estado);
            MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciartexbox();
            CargarDatosOriginales();
        }

        private void vaciartexbox()
        {
            textId.Text = "";
            TextProductos.Text = "";
            textcodigo.Text = "";
            combocategoria.Text = "";
            textPrecioCompra.Text = "";
            textPrecioVenta.Text = "";
            textEstado.Text = "";
        }

        private void TextAbuscar_TextChanged(object sender, EventArgs e)
        {
            (GridProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Codigo LIKE '%{0}%'",TextAbuscar.Text);
        }
    }
}
