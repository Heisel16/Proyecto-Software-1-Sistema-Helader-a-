using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using BDS.Controller;
using BDS.Modelo;
using BDS.Vista.Recursos;

namespace BDS.Vista
{
    public partial class InformeCompras : Form
    {
        private static ControladorCompras c = new ControladorCompras();
        public InformeCompras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformeCompras_Load(object sender, EventArgs e)
        {
            ControladorCompras c= new ControladorCompras();
            c.CargarDatosGrid(GridInformesCompras);
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ControladorServicioExcel ex= new ControladorServicioExcel();
            DialogResult r = System.Windows.Forms.MessageBox.Show("Desea Exportar un Excel con los datos de las compras?","HELADERIA BERAKA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r== DialogResult.Yes)
            {
                ex.exportaraexcel(GridInformesCompras);

            }
        }

        private void FechaInicial_Click(object sender, EventArgs e)
        {
            using(Calendario c = new Calendario())
            {
                if(c.ShowDialog() == DialogResult.OK)
                {
                    TextFechaInicio.Text= c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void FechaFinal_Click(object sender, EventArgs e)
        {
            using (Calendario c = new Calendario())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    TextFechaFin.Text = c.FechaSeleccionada.ToShortDateString();
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Parse(TextFechaInicio.Text);
            DateTime fechaFin= DateTime.Parse(TextFechaFin.Text);
            if(fechaInicio==null || fechaFin == null)
            {
                System.Windows.Forms.MessageBox.Show("Digite las fechas de inicio y fin", "Heladeria BERAKA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ControladorCompras c = new ControladorCompras();
            List<CompraModelo> lista= c.CargarDatosFiltrados(fechaInicio, fechaFin);
            GridInformesCompras.DataSource = lista;
        }

        private void BntFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaI;
            DateTime fechaF;
            switch (CbxPeriodo.SelectedItem.ToString())
            {
                case "Semanal":
                    fechaF = DateTime.Now;
                    fechaI = fechaF.AddDays(-7);
                    break;
                case "Mensual":
                    fechaF = DateTime.Now;
                    fechaI = fechaF.AddMonths(-1);
                    break;
                case "Trimestral":
                    fechaF = DateTime.Now;
                    fechaI = fechaF.AddMonths(-3);
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Seleccione un periodo","Heladeria BERAKA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
            }

            ControladorCompras c = new ControladorCompras();
            List<CompraModelo> lista = c.CargarDatosFiltrados(fechaI, fechaF);
            GridInformesCompras.DataSource = lista;
        }

        private void TexAbuscar_TextChanged(object sender, EventArgs e)
        {
            string f = TexAbuscar.Text;
            c.buscar(f, GridInformesCompras);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string f = buscarFiltro.Text;
            string cl = comboFiltro.SelectedItem.ToString();
            c.buscarporCombo(f, cl, GridInformesCompras);
        }
    }
}
