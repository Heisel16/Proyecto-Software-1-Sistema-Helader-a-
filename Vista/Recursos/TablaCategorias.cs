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
    public partial class TablaCategorias : Form
    {
        public DataTable Tablafiltro { get; private set; }

        public DataTable PrincipalDataTable { get; private set; }

        public TablaCategorias()
        {
            InitializeComponent();
        }

        private DataTable MiTabla(List<Categoria> ctg)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id Categoria", typeof(int));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("Estado", typeof(string));
            foreach (var item in ctg)
            {
                table.Rows.Add(item.Id, item.Descripcion,item.Estado);
            }
            return table;
        }

        private void CargarDatos()
        {
            controladorCategorias c = new controladorCategorias();
            PrincipalDataTable = new DataTable();
            PrincipalDataTable = MiTabla(c.Lista());
            GridCategoria.DataSource = PrincipalDataTable;
            GridCategoria.Columns["Id Categoria"].DisplayIndex = 0;
            GridCategoria.Columns["Descripcion"].DisplayIndex = 1;
            GridCategoria.Columns["Estado"].DisplayIndex = 2;
            GridCategoria.Columns["Column1"].DisplayIndex = 3;
            GridCategoria.Columns["Column2"].DisplayIndex = 4;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TablaCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string desc = textcateg.Text;
            string estado = texEst.Text;
            controladorCategorias c= new controladorCategorias();
            string proceso= c.RegistrarCategoria(desc, estado);
            MessageBox.Show(proceso,"HELADERIA BERAKA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarDatos();
            limpiartext();
        }

        private void limpiartext()
        {
            textcateg.Text="";
            texEst.Text = "";
        }

        private void GridCategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridCategoria.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\escritura.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridCategoria.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridCategoria.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == GridCategoria.Columns["Column2"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\borrar_.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridCategoria.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridCategoria.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private void GridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCategoria.Columns[e.ColumnIndex].Name == "Column2")
            {
                controladorCategorias c = new controladorCategorias();
                DataGridViewRow row = GridCategoria.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["Id Categoria"].Value.ToString());
                DialogResult result = MessageBox.Show("Desea Eliminar los Datos La categoria ", "HELADERIA BERAKA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string eliminar = c.Eliminar(id);
                    MessageBox.Show(eliminar, "Heladeria BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();

                }

            }
            if (GridCategoria.Columns[e.ColumnIndex].Name == "Column1")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridCategoria.Rows[rowindex];
                string valorColumna1 = filaSeleccionada.Cells["Id Categoria"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Estado"].Value.ToString();
                textId.Text = valorColumna1;
                textcateg.Text = valorColumna2;
                texEst.Text = valorColumna3;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            string desc = textcateg.Text;
            string estado = texEst.Text;
            controladorCategorias c = new controladorCategorias();
            string proceso = c.Actualizar(id,desc,estado);
            MessageBox.Show(proceso, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
            limpiartext();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda(textBuscar.Text);
        }

        private void RealizarBusqueda(string filtro)
        {
            Tablafiltro = PrincipalDataTable.Clone();

            foreach (DataRow row in PrincipalDataTable.Rows)
            {
                if (CumpleCriterio(row, filtro))
                {
                    Tablafiltro.ImportRow(row);
                }
            }

            GridCategoria.DataSource = Tablafiltro;
        }

        private bool CumpleCriterio(DataRow row, string filtro)
        {
            foreach (var cellValue in row.ItemArray)
            {
                if (Convert.ToString(cellValue).IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            GridCategoria.DataSource = PrincipalDataTable;
            textBuscar.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
