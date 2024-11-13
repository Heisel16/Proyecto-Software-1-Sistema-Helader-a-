using BDS.Controller;
using BDS.Modelo;
using BDS.Vista.Recursos;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Proveedores : Form
    {
        private DataTable originalDataTable;
        private DataTable filtroDataTable;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ControladorProveedores pc = new ControladorProveedores();
            string doc= textDoc.Text;
            string rz = textRazonSoc.Text;
            string telefono= textTelefono.Text;
            string correo = textCorreo.Text;
            string estado = TextEstado.Text;
            string ubicacion = textUbic.Text;
            string direccion = textDireccion.Text;

            string exito = pc.RegistrarProveedor(doc, rz, telefono,correo, estado,ubicacion,direccion);
            MessageBox.Show(exito,"Heladeria BERAKA",MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciartexbox();
            CargarDatosOriginales();
        }

        private void vaciartexbox()
        {
            textDoc.Text = "";
            textRazonSoc.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            TextEstado.Text = "";
            textUbic.Text="";
            textFecha.Text = "";
            textDireccion.Text = "";
        }

        private void textDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroTextBox tex = (MetroTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(tex, "solo numero");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(tex, "");
            }
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroTextBox tex = (MetroTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(tex, "solo numero");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(tex, "");
            }
        }

        private void dvgProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProveedor.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\escritura.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProveedor.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProveedor.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == GridProveedor.Columns["Column2"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\borrar_.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.GridProveedor.Rows[e.RowIndex].Height = icono.Height + 8;
                this.GridProveedor.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarDatosOriginales();
        }

        private DataTable MiTabla(List<Proveedor> prov)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID Proveedor", typeof(int));
            table.Columns.Add("Documento", typeof(string));
            table.Columns.Add("RazonSocial", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Correo", typeof(string));
            table.Columns.Add("Estado", typeof(string));
            table.Columns.Add("Ubicacion", typeof(string));
            table.Columns.Add("Direccion", typeof(string));
            table.Columns.Add("Fecha Registro",typeof(DateTime));
            foreach (var item in prov)
            {
                table.Rows.Add(item.Id,item.Documento, item.RazonSocial,item.Telefono, item.Correo, item.Estado,item.Ubicacion,item.Direccion,item.FechaCreacion);
            }
            return table;
        }

        private void CargarDatosOriginales()
        {
            ControladorProveedores c= new ControladorProveedores();
            originalDataTable = new DataTable();
            originalDataTable = MiTabla(c.ListarProveedores());
            GridProveedor.DataSource = originalDataTable;
            GridProveedor.Columns["ID Proveedor"].Visible= false;
            GridProveedor.Columns["Documento"].DisplayIndex = 1;
            GridProveedor.Columns["RazonSocial"].DisplayIndex = 2;
            GridProveedor.Columns["Telefono"].DisplayIndex = 3;
            GridProveedor.Columns["Correo"].DisplayIndex = 4;
            GridProveedor.Columns["Estado"].DisplayIndex = 5;
            GridProveedor.Columns["Ubicacion"].DisplayIndex = 6;
            GridProveedor.Columns["Direccion"].DisplayIndex = 7;
            GridProveedor.Columns["Fecha Registro"].Visible= false;
            GridProveedor.Columns["Column1"].DisplayIndex = 9;
            GridProveedor.Columns["Column2"].DisplayIndex = 10;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (Calendario tp = new Calendario())
            {
                if (tp.ShowDialog() == DialogResult.OK)
                {
                    textFecha.Text = Convert.ToString(tp.FechaSeleccionada);
                }
            }
        }

        private void GridProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProveedor.Columns[e.ColumnIndex].Name == "Column2")
            {
                ControladorProveedores c = new ControladorProveedores();
                DataGridViewRow row = GridProveedor.Rows[e.RowIndex];
                int ide = int.Parse(row.Cells["ID Proveedor"].Value.ToString());
                DialogResult result = MessageBox.Show("Desea Eliminar los Datos del Proveedor ", "Heladeria BERAKA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string eliminar = c.EliminarProveedor(ide);
                    MessageBox.Show(eliminar, "Heladeria BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosOriginales();

                }

            }
            if (GridProveedor.Columns[e.ColumnIndex].Name == "Column1")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = GridProveedor.Rows[rowindex];
                string valorColumna = filaSeleccionada.Cells["ID Proveedor"].Value.ToString();
                string valorColumna1 = filaSeleccionada.Cells["Documento"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["RazonSocial"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Correo"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["Ubicacion"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["Direccion"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["Estado"].Value.ToString();
                string valorColumna8 = filaSeleccionada.Cells["Fecha Registro"].Value.ToString();

                TextId.Text = valorColumna;
                textDoc.Text = valorColumna1;
                textRazonSoc.Text = valorColumna2;
                textTelefono.Text = valorColumna3;
                textCorreo.Text = valorColumna4;
                textUbic.Text = valorColumna5;
                textDireccion.Text = valorColumna6;
                TextEstado.Text = valorColumna7;
                textFecha.Text = valorColumna8;
            }
        }

        private void ImprimirExcel_Click(object sender, EventArgs e)
        {
            ControladorServicioExcel c= new ControladorServicioExcel();
            c.exportaraexcel(GridProveedor);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ControladorProveedores cu = new ControladorProveedores();
            int id = int.Parse(TextId.Text);
            string doc = textDoc.Text;
            string nombre = textRazonSoc.Text;
            string direccion = textDireccion.Text;
            string Correo = textCorreo.Text;
            string tel = textTelefono.Text;
            string estado = TextEstado.Text;
            string Ubic = textUbic.Text;

            string mensaje = cu.ActualizarProveedor(id,doc, nombre, tel, Correo, estado, Ubic, direccion);
            MessageBox.Show(mensaje, "HELADERIA BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciartexbox();
            CargarDatosOriginales();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda(TextBuscar.Text);
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

            GridProveedor.DataSource = filtroDataTable;
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
            GridProveedor.DataSource = originalDataTable;
            TextBuscar.Text = "";
        }
    }
}
