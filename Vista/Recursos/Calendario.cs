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
    public partial class Calendario : Form
    {
        public DateTime FechaSeleccionada { get; private set; }
        public Calendario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            FechaSeleccionada = monthCalendar1.SelectionStart;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {

        }
    }
}
