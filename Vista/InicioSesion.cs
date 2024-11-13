using BDS.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDS.Modelo;

namespace BDS
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public string HashPassword(string contra)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contra));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar r = new Registrar();
            r.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTNEntrar_Click(object sender, EventArgs e)
        {
            string claveIngresada = HashPassword(textClave.Text);
            List<Usuario> list = new Modelo.Usuario().Listar();
            Usuario a = new Usuario().Listar().Where(u => u.DocumentoID == textUser.Text && u.Contraseña == claveIngresada).FirstOrDefault();
            if (a != null)
            {
                this.Hide();
                Principal p;
                p = new Principal(a);
                p.Show();
                textUser.Text = "";
                textClave.Text = "";
            }
            else
            {
                MessageBox.Show("Datos incorretos", "INICIO DE SESION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Usuario")
            {
                textUser.Text = "";
            }
           
        }

        private void textClave_Enter(object sender, EventArgs e)
        {
            if (textClave.Text == "Contraseña")
            {
                textClave.Text = "";
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Usuario";
            }
        }

        private void textClave_Leave(object sender, EventArgs e)
        {
            if (textClave.Text == "")
            {
                textClave.Text = "Contraseña";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        RecuperarContraseña R;
        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (R == null || R.IsDisposed)
            {
                R= new RecuperarContraseña();
                R.Show();
            }
        }
    }
}
