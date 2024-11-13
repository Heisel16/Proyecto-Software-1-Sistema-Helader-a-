using BDS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDS.Modelo;

namespace BDS.Vista
{
    public partial class Usuarios : Form
    {
        private DataTable filtroDataTable;
        public Usuarios()
        {
            InitializeComponent();
        }
        private DataTable originalDataTable;

        Modificar_Usuario md;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUsuarios.Columns[e.ColumnIndex].Name == "Column1")
            {
                ControladorUsuarios c = new ControladorUsuarios();
                DataGridViewRow row = GridUsuarios.Rows[e.RowIndex];
                string cedula = row.Cells["ID"].Value.ToString();
                DialogResult result = MessageBox.Show("Desea Eliminar los Datos", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string eliminar= c.EliminarUsuario(cedula);
                    MessageBox.Show(eliminar, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosOriginales();

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            if (GridUsuarios.Columns[e.ColumnIndex].Name == "Column2")
            {
                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridUsuarios.Rows[rowindex];

                string Columna1 = filaSeleccionada.Cells["ID"].Value.ToString();
                string Columna2 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string Columna3 = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string Columna4 = filaSeleccionada.Cells["Correo"].Value.ToString();
                string Columna5 = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string Columna6 = filaSeleccionada.Cells["IdRol"].Value.ToString();
                string Columna7 = filaSeleccionada.Cells["Estado"].Value.ToString();

                if (md== null || md.IsDisposed)
                {
                    md= new Modificar_Usuario(Columna1, Columna2, Columna3,Columna4,Columna5,Int32.Parse(Columna6),Columna7);
                    md.FormularioPrincipal = this;
                    md.Show();
                    md.StartPosition= FormStartPosition.CenterScreen;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridUsuarios.Columns["Column2"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\escritura.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridUsuarios.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridUsuarios.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == GridUsuarios.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\borrar_.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridUsuarios.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridUsuarios.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private DataTable MiTabla(List<Usuario> usuarios)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Correo", typeof(string));
            table.Columns.Add("IdRol", typeof(int));
            table.Columns.Add("Estado", typeof(string));
            table.Columns.Add("Contraseña", typeof(string));
            foreach (var item in usuarios)
            {
                table.Rows.Add(item.DocumentoID, item.Nombre,item.Apellido,item.telefono, item.Correo,item.IdRol,item.estado,item.Contraseña);
            }
            return table;
        }

        private void CargarDatosOriginales()
        {
            Usuario c = new Usuario();
            originalDataTable = new DataTable();
            originalDataTable = MiTabla(c.Listar());
            GridUsuarios.DataSource = originalDataTable;
            GridUsuarios.Columns["ID"].DisplayIndex = 0;
            GridUsuarios.Columns["Nombre"].DisplayIndex = 1;
            GridUsuarios.Columns["Apellido"].DisplayIndex = 2;
            GridUsuarios.Columns["Telefono"].DisplayIndex = 3;
            GridUsuarios.Columns["Correo"].DisplayIndex = 4;
            GridUsuarios.Columns["IdRol"].DisplayIndex = 5;
            GridUsuarios.Columns["Estado"].DisplayIndex= 6;
            GridUsuarios.Columns["Contraseña"].Visible= false;
            GridUsuarios.Columns["Column1"].DisplayIndex = 8;
            GridUsuarios.Columns["Column2"].DisplayIndex = 9;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatosOriginales();
        }
        private void RealizarBusqueda(string filtro)
        {
            filtroDataTable = originalDataTable.Clone();

            foreach (DataRow row in originalDataTable.Rows)
            {
                if (CumpleCriterio(row, filtro))
                {
                    filtroDataTable.ImportRow(row);
                }
            }

            GridUsuarios.DataSource = filtroDataTable;
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
        private void iconButton1_Click(object sender, EventArgs e)
        {  
            string textaBuscar = TexBuscar.Text;
            RealizarBusqueda(textaBuscar);
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            GridUsuarios.DataSource = originalDataTable;
            TexBuscar.Text = "";
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ControladorUsuarios cu= new ControladorUsuarios();
            cu.ExportarUsuariosAExcel(GridUsuarios);
        }

        public void RecargarDatos()
        {
            CargarDatosOriginales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
