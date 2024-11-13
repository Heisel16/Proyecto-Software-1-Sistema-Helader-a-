using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Inventario : Form
    {
        public static ControladorInventario Controlador= new ControladorInventario();
        public DataTable DataTablePrincipal { get; private set; }
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ControladorProductos p= new ControladorProductos();
            p.CargarInfoCompleta(GridInvent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }
        BoletinPedido b;
        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (b == null || b.IsDisposed)
            {
                b= new BoletinPedido();
                b.Show();
            }
        }
        private DataTable MiTabla(List<Productos> productos)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id Producto", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Codigo", typeof(string));
            table.Columns.Add("Id Categoria", typeof(string));
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
            DataTablePrincipal = new DataTable();
            DataTablePrincipal = MiTabla(c.ListarProductos());
            GridInvent.DataSource = DataTablePrincipal;
            GridInvent.Columns["Id Producto"].DisplayIndex = 0;
            GridInvent.Columns["Nombre"].DisplayIndex = 1;
            GridInvent.Columns["Codigo"].DisplayIndex = 2;
            GridInvent.Columns["Id Categoria"].DisplayIndex = 3;
            GridInvent.Columns["Precio Compra"].DisplayIndex = 4;
            GridInvent.Columns["Precio Venta"].DisplayIndex = 5;
            GridInvent.Columns["Estado"].DisplayIndex = 6;
            GridInvent.Columns["AbrirFormProd"].DisplayIndex = 7;
            GridInvent.Columns["Column2"].DisplayIndex = 8;
            GridInvent.Columns["Column3"].DisplayIndex = 9;
        }
        Recursos.TablaCategorias t;
        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            if (t == null || t.IsDisposed)
            {
                t = new Recursos.TablaCategorias();
                t.Show();
            }
        }
        GestionStock gs;
        private void BtnStock_Click(object sender, EventArgs e)
        {
            if (gs == null || gs.IsDisposed)
            {
                gs = new GestionStock();
                gs.Show();
            }
        }

        private void GridInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TexAbuscar_TextChanged(object sender, EventArgs e)
        {
            Controlador.buscar(TexAbuscar.Text, GridInvent);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ControladorServicioExcel excel = new ControladorServicioExcel();
            excel.exportaraexcel(GridInvent);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ControladorProductos p = new ControladorProductos();
            p.CargarInfoCompleta(GridInvent);
        }
    }
}
