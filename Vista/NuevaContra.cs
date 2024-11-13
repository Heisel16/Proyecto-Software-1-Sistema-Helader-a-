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
    public partial class NuevaContra : Form
    {
        public NuevaContra()
        {
            InitializeComponent();
        }
        InicioSesion i;
        private void botonesPerson1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.MessageBox.Show("Su contraseña se ha restablecido","Sistema",MessageBoxButton.OK, MessageBoxImage.Information);
            if(i== null||i.IsDisposed)
            {
                i = new InicioSesion();
                i.Show();
                i.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}
