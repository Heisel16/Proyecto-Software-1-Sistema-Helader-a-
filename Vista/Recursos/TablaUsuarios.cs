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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace BDS.Vista.Recursos
{
    public partial class TablaUsuarios : Form
    {
        private DataTable originalDataTable;
        public string nombre { get; private set; }
        public string Doc { get; private set; }
        public TablaUsuarios()
        {
            InitializeComponent();
        }

        private void TablaUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatosOriginales();
        }

        private DataTable MiTabla(List<Usuario> usuarios)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Documento",typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Estado", typeof(string));
            foreach (var item in usuarios)
            {
                table.Rows.Add(item.DocumentoID,item.Nombre, item.Apellido, item.telefono, item.estado);
            }
            return table;
        }

        private void CargarDatosOriginales()
        {
            Usuario c = new Usuario();
            originalDataTable = new DataTable();
            originalDataTable = MiTabla(c.Listar());
            GridUsuarios.DataSource = originalDataTable;
            GridUsuarios.Columns["Column1"].DisplayIndex = 0;
            GridUsuarios.Columns["Documento"].DisplayIndex = 1;
            GridUsuarios.Columns["Nombre"].DisplayIndex = 2;
            GridUsuarios.Columns["Apellido"].DisplayIndex = 3;
            GridUsuarios.Columns["Telefono"].DisplayIndex = 4;
            GridUsuarios.Columns["Estado"].DisplayIndex = 5;

        }

        private void GridUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridUsuarios.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\controlar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridUsuarios.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridUsuarios.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private void GridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUsuarios.Columns[e.ColumnIndex].Name == "Column1")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridUsuarios.Rows[rowindex];
                string valorColumna2 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Documento"].Value.ToString();

                nombre = valorColumna2+" "+ valorColumna3;
                Doc = valorColumna4;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
