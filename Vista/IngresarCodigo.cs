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

namespace BDS.Vista
{
    public partial class IngresarCodigo : Form
    {
        public IngresarCodigo()
        {
            InitializeComponent();
        }
        NuevaContra n;
        private void botonesPerson1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.MessageBox.Show("Codigo verificado", "Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            if (n == null || n.IsDisposed)
            {
                n = new NuevaContra();
                n.Show();
                n.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}
