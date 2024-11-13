using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Principal : Form
    {
        private static Modelo.Usuario UsuarioActual;
        public Principal(Modelo.Usuario a)
        {
            InitializeComponent();
            SubMenus();
            UsuarioActual = a;
            NombreUsuario.Text = UsuarioActual.Nombre;
            Hora.Start();

            foreach (Control ctrl in MenuVertical.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.Click += new EventHandler(MenuVertical_Click);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void SubMenus()
        {
            SubMenu.Visible = false;
        }
        private void OcultarSubMenus()
        {
            if(SubMenu.Visible ==true)
                SubMenu.Visible = false;
        }

        public void mostrarSubMenus(Panel submenus)
        {
            if(submenus.Visible == false)
            {
                OcultarSubMenus();
                submenus.Visible = true;
            }
            else
            {
                submenus.Visible = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public void AbrirFormulario(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Producto());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Proveedores());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermiso = new Controller.Permisos().Listar(Int32.Parse( UsuarioActual.DocumentoID));
            foreach(Button btn in MenuVertical.Controls.OfType<Button>())
            {
                bool exito = listaPermiso.Any(a => a.MenuDisponibles == btn.Name);

                if(exito== false)
                {
                    btn.Enabled = false;
                }
            }

            //int idRol = UsuarioActual.IdRol;
            //foreach (Button btn in panelBarraHoriz.Controls.OfType<Button>())
            //{
            //    if (idRol == 2)
            //    {
            //        if (btn.Name == "BtnConfiguracion")
            //        {
            //            btn.Enabled = false;
            //            continue;
            //        }
            //    }
            //}

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenus(SubMenu);
        }
        private void ReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new InformeVentas());
            OcultarSubMenus();
        }

        private void ReportesCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new InformeCompras());
            OcultarSubMenus();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Usuarios());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistroVentas());
        }

        private void subMVentas1_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void subMVentas2_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panelBarraHoriz_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelBarraHoriz_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario( new Inventario());
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            //labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            foreach (Control item in MenuVertical.Controls)
            {
                if (item is Button)
                {
                    Button b = (Button)item;
                    b.BackColor = Color.FromArgb(31, 30, 68);
                }
            }

            Button botonselect = (Button)sender;
            botonselect.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            botonselect.ForeColor = Color.White;
        }
        InicioSesion s;
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                if (s== null||s.IsDisposed)
                {
                    s = new InicioSesion();
                    s.Show();
                }
            }
        }

        private void MenuCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarCompras());
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Close();
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Informacion_Financiera());
            OcultarSubMenus();
        }
    }
}
