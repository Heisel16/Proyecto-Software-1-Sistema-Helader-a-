using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace BDS.Vista.Recursos
{
    public partial class TablaProductos : Form
    {
        private DataTable DataTable;

        public string codi { get; private set; }
        public string nombre { get; private set; }
        public string pc { get; private set; }
        public string pv { get; private set; }
        public string cant { get; private set; }
        public int id {  get; private set; }

        public TablaProductos()
        {
            InitializeComponent();
        }

        private void TablaCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private DataTable MiTabla(List<Productos> p)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id Producto", typeof(int));
            table.Columns.Add("Codigo", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Precio Compra", typeof(float));
            table.Columns.Add("Precio Venta", typeof(float));
            foreach (var item in p)
            {
                table.Rows.Add(item.Id,item.Codigo, item.Nombre, item.PrecioCompra,item.PrecioVenta);
            }
            return table;
        }

        private void CargarDatos()
        {
            ControladorProductos pd = new ControladorProductos();
            DataTable = new DataTable();
            DataTable = MiTabla(pd.ListarProductos());
            GridProd.DataSource =DataTable;
            GridProd.Columns["Id Producto"].DisplayIndex = 0;
            GridProd.Columns["Codigo"].DisplayIndex = 1;
            GridProd.Columns["Nombre"].DisplayIndex = 2;
            GridProd.Columns["Precio Compra"].DisplayIndex = 3;
            GridProd.Columns["Precio Venta"].DisplayIndex = 4;
            GridProd.Columns["Seleccionar"].DisplayIndex = 5;
        }
        private void GridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridProd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProd.Columns[e.ColumnIndex].Name == "Seleccionar")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridProd.Rows[rowindex];
                string valorColumna = filaSeleccionada.Cells["Id Producto"].Value.ToString();
                string valorColumna1 = filaSeleccionada.Cells["Codigo"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Precio Compra"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["Precio Venta"].Value.ToString();

                id = int.Parse(valorColumna);
                codi = valorColumna1;
                nombre = valorColumna2;
                pc = valorColumna4;
                pv = valorColumna5;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void GridProd_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProd.Columns["Seleccionar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\controlar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProd.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProd.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }
    }
}
