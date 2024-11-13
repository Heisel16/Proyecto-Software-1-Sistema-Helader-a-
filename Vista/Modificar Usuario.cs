using BDS.Controller;
using BDS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.Vista
{
    public partial class Modificar_Usuario : Form
    {
        public Usuarios FormularioPrincipal { get; set; }

        public Modificar_Usuario(string id, string nombre, string apellido, string correo, string telefono, int idrol, string estado)
        {
            InitializeComponent();
            textDocumento.Text = id;
            textNombre.Text = nombre;
            textApellido.Text = apellido;
            textCorreo.Text = correo;
            textTelefono.Text = telefono;
            cbxEstado.Text = estado;
            if (idrol == 1)
            {
                CbxRol.Text = "Administrador";
            }else if(idrol == 2)
            {
                CbxRol.Text = "Empleado";
            }
          
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarUser_Click(object sender, EventArgs e)
        {
            ControladorUsuarios cu = new ControladorUsuarios();
            string cedula = textDocumento.Text;
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string Correo = textCorreo.Text;
            string tel = textTelefono.Text;
            string estado = cbxEstado.Text;
            int rol = (int)CbxRol.SelectedValue;
            string contraseña = textClave.Text;

            string mensaje = cu.ActualizarUsuario(cedula, nombre, apellido, Correo, contraseña, rol, estado, tel);
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormularioPrincipal.RecargarDatos();
            vaciartexbox();
            this.Close();
        }

        private void vaciartexbox()
        {
            
        }
    }
}
