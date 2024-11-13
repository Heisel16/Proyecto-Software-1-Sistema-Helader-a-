using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }
        IngresarCodigo i;
        private void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            this.Close();
            Controller.ControladorUsuarios c = new Controller.ControladorUsuarios();
            string correo = TextCorreo.Text;
            c.EnviarCodigoVerificacion(correo);
            System.Windows.MessageBox.Show("Se he enviado un codigo de verificacion a su correo", "Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            if (i == null||i.IsDisposed)
            {
                i= new IngresarCodigo();
                i.Show();
                i.StartPosition = FormStartPosition.CenterParent;
            }
        }
    }
}
