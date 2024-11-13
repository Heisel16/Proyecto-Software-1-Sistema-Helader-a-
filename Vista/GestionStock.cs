using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDS.Controller;
using BDS.Modelo;
using BDS.Vista.Recursos;
using Microsoft.Extensions.Primitives;

namespace BDS.Vista
{
    public partial class GestionStock : Form
    {
        public DataTable DataTablePrincipal { get; private set; }

        public GestionStock()
        {
            InitializeComponent();
        }

        private void BtnSelec_Prod_Click(object sender, EventArgs e)
        {
            using (TablaProductos tp= new TablaProductos())
            {
                if(tp.ShowDialog() == DialogResult.OK)
                {
                    TextProductos.Text= Convert.ToString(tp.id);
                }
            }
        }

        private DataTable MiTabla(List<Stock> s)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID Prodcuto", typeof(int));
            table.Columns.Add("Cantidad Stock", typeof(int));
            table.Columns.Add("Capacidad Maxima", typeof(int));
            table.Columns.Add("Estado", typeof(string));
            table.Columns.Add("Nivel de Alerta", typeof(string));
            foreach (var item in s)
            {
                table.Rows.Add(item.productoId.Id, item.cantidad, item.Capacidad, item.Estado, item.Alerta);
            }
            return table;
        }

        private void CargarDatos()
        {
            ControladorStock pd = new ControladorStock();
            DataTablePrincipal = new DataTable();
            DataTablePrincipal = MiTabla(pd.lista());
            dtgStock.DataSource = DataTablePrincipal;
            dtgStock.Columns["ID Prodcuto"].DisplayIndex = 0;
            dtgStock.Columns["Cantidad Stock"].DisplayIndex = 1;
            dtgStock.Columns["Capacidad Maxima"].DisplayIndex = 2;
            dtgStock.Columns["Estado"].DisplayIndex = 3;
            dtgStock.Columns["Nivel de Alerta"].DisplayIndex = 4;
            dtgStock.Columns["Column1"].DisplayIndex = 5;
            dtgStock.Columns["Column2"].DisplayIndex = 6;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ControladorStock s= new ControladorStock();
            int id = int.Parse(TextProductos.Text);
            int cantid= int.Parse(CantProd.Text);
            int capac= int.Parse(textCapacidad.Text);
            string est= comboEstado.Text;
            string alerta= comboAlerta.Text;

            string proceso= s.EstablecerStock(id,cantid,capac,est,alerta);
            MessageBox.Show(proceso,"HELADERIA BERAKA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarDatos();
        }

        private void dtgCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgStock.Columns["Column1"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\escritura.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dtgStock.Rows[e.RowIndex].Height = icono.Height + 8;
                this.dtgStock.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgStock.Columns["Column2"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\borrar_.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dtgStock.Rows[e.RowIndex].Height = icono.Height + 8;
                this.dtgStock.Columns[e.ColumnIndex].Width = icono.Width + 8;

                e.Handled = true;
            }
        }

        private void GestionStock_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgStock.Columns[e.ColumnIndex].Name == "Column1")
            {

                int rowindex = e.RowIndex;
                DataGridViewRow filaSeleccionada = dtgStock.Rows[rowindex];
                string valorColumna = filaSeleccionada.Cells["ID Prodcuto"].Value.ToString();
                string valorColumna1 = filaSeleccionada.Cells["Cantidad Stock"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Capacidad Maxima"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Estado"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Nivel de Alerta"].Value.ToString();

                TextProductos.Text = valorColumna;
                CantProd.Text = valorColumna1;
                textCapacidad.Text = valorColumna2;
                comboEstado.Text = valorColumna3;
                comboAlerta.Text = valorColumna4;

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ControladorStock s = new ControladorStock();
            int id = int.Parse(TextProductos.Text);
            int cant= int.Parse(CantProd.Text);
            int capacidad = int.Parse(textCapacidad.Text);
            string estado = comboEstado.Text;
            string alerta= comboAlerta.Text;

            string r = s.ActualizarStock(id,cant,capacidad,estado,alerta);

            MessageBox.Show(r,"HELADERIA BERAKA",MessageBoxButtons.OK,MessageBoxIcon.Information);

            CargarDatos();
        }
    }
}
