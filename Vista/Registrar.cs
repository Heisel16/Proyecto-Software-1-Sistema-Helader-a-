using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Registrar_Load(object sender, EventArgs e)
        {
            try { 
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdRol, Descripcion FROM Rol", con);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> roles = new Dictionary<int, string>();
                while (reader.Read())
                {
                    roles.Add(reader.GetInt32(0), reader.GetString(1));
                }

                CbxRol.DataSource = new BindingSource(roles, null);
                CbxRol.DisplayMember = "Value";
                CbxRol.ValueMember = "Key";
            }
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void vaciartexbox()
        {
            textDocumento.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textCorreo.Text = "";
            cbxEstado.Text = "";
            textClave.Text = "";
            textTelefono.Text = "";
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tex = (TextBox)sender;
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

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tex = (TextBox)sender;
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                errorProvider1.SetError(tex, "solo letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(tex, "");
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tex = (TextBox)sender;
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                errorProvider1.SetError(tex, "solo letras");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(tex, "");
            }
        }

        private void RegistrarUser_Click(object sender, EventArgs e)
        {
           ControladorUsuarios cu= new ControladorUsuarios();
            string cedula = textDocumento.Text;
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string Correo = textCorreo.Text;
            string tel = textTelefono.Text;
            string estado = cbxEstado.Text;
            int rol = (int)CbxRol.SelectedValue;
            string contraseña = textClave.Text;

            string mensaje = cu.RegistrarUsuario(cedula, nombre, apellido, Correo, contraseña, rol, estado,tel);
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciartexbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
