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

namespace BDS.Vista.Recursos
{
    public partial class TablaStock : Form
    {
        public TablaStock()
        {
            InitializeComponent();
        }

        private void GridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridProd_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == GridProd.Columns["Seleccionar"].Index)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            //    System.Drawing.Icon icono = new System.Drawing.Icon(Environment.CurrentDirectory + @"\Iconos\controlar.ico");
            //    e.Graphics.DrawIcon(icono, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
            //    this.GridProd.Rows[e.RowIndex].Height = icono.Height + 8;
            //    this.GridProd.Columns[e.ColumnIndex].Width = icono.Width + 8;

            //    e.Handled = true;
            //}
        }

        private void TablaStock_Load(object sender, EventArgs e)
        {
            ControladorStock stock = new ControladorStock();
            stock.Cargar(GridProd);
        }
    }
}
