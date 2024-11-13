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
using System.Windows.Forms;

namespace BDS.Vista.Recursos
{
    public partial class TablaProveedor : Form
    {
        private DataTable originalDataTable;
        public string nombre { get; private set; }
        public string correo { get; private set; }
        public string estado { get; private set; }
        public long doc {  get; private set; }
        public int id {  get; private set; }
        public TablaProveedor()
        {
            InitializeComponent();
        }

        private void GridProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProveedores.Columns["Seleccionar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\controlar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProveedores.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProveedores.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private DataTable MiTabla(List<Proveedor> prov)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("RazonSocial", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Correo", typeof(string));
            table.Columns.Add("Estado", typeof(string));
            table.Columns.Add("Direccion", typeof(string));
            foreach (var item in prov)
            {
                table.Rows.Add(item.Id, item.RazonSocial, item.Telefono, item.Correo, item.Estado,item.Direccion);
            }
            return table;
        }

        private void CargarDatosOriginales()
        {
            ControladorProveedores c = new ControladorProveedores();
            originalDataTable = new DataTable();
            originalDataTable = MiTabla(c.ListarProveedores());
            GridProveedores.DataSource = originalDataTable;
            GridProveedores.Columns["Id"].DisplayIndex = 0;
            GridProveedores.Columns["RazonSocial"].DisplayIndex = 1;
            GridProveedores.Columns["Telefono"].DisplayIndex = 2;
            GridProveedores.Columns["Correo"].DisplayIndex = 3;
            GridProveedores.Columns["Estado"].DisplayIndex = 4;
            GridProveedores.Columns["Direccion"].DisplayIndex = 5;
            GridProveedores.Columns["Seleccionar"].DisplayIndex = 6;

        }

        private void TablaProveedor_Load(object sender, EventArgs e)
        {
            CargarDatosOriginales();
        }

        private void GridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProveedores.Columns[e.ColumnIndex].Name == "Seleccionar")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridProveedores.Rows[rowindex];
                string valorColumna1 = filaSeleccionada.Cells["Id"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["RazonSocial"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Correo"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["Direccion"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["Estado"].Value.ToString();

                nombre = valorColumna2;
                correo = valorColumna4;
                estado = valorColumna7;
                doc = long.Parse(valorColumna1);
                id= int.Parse(valorColumna1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
