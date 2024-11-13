using System;

namespace BDS.Vista
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.BtnCalendario = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnUsuario = new FontAwesome.Sharp.IconButton();
            this.TextFechaInicio = new MetroFramework.Controls.MetroTextBox();
            this.textUser = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.textcorreo = new MetroFramework.Controls.MetroTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnProveedor = new FontAwesome.Sharp.IconButton();
            this.textProveedor = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textEstado = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textId = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxEst = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.iconButton15 = new FontAwesome.Sharp.IconButton();
            this.textPrecioVenta = new MetroFramework.Controls.MetroTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.iconButton16 = new FontAwesome.Sharp.IconButton();
            this.iconButton18 = new FontAwesome.Sharp.IconButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textcodigo = new MetroFramework.Controls.MetroTextBox();
            this.textPrecioCompra = new MetroFramework.Controls.MetroTextBox();
            this.TextProductos = new MetroFramework.Controls.MetroTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.GridProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.generarExcel = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextAbuscar = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(1010, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Registro de Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.iconButton5);
            this.groupBox1.Controls.Add(this.iconButton6);
            this.groupBox1.Controls.Add(this.BtnCalendario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnUsuario);
            this.groupBox1.Controls.Add(this.TextFechaInicio);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 106);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 18;
            this.iconButton5.Location = new System.Drawing.Point(17, 29);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(29, 21);
            this.iconButton5.TabIndex = 39;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 16;
            this.iconButton6.Location = new System.Drawing.Point(219, 28);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(23, 21);
            this.iconButton6.TabIndex = 38;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.BtnCalendario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.BtnCalendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCalendario.IconSize = 18;
            this.BtnCalendario.Location = new System.Drawing.Point(150, 51);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(29, 21);
            this.BtnCalendario.TabIndex = 37;
            this.BtnCalendario.UseVisualStyleBackColor = false;
            this.BtnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Informacion del Registro";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnUsuario.IconColor = System.Drawing.Color.Black;
            this.BtnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsuario.IconSize = 16;
            this.BtnUsuario.Location = new System.Drawing.Point(378, 51);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(23, 21);
            this.BtnUsuario.TabIndex = 5;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // TextFechaInicio
            // 
            // 
            // 
            // 
            this.TextFechaInicio.CustomButton.Image = null;
            this.TextFechaInicio.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.TextFechaInicio.CustomButton.Name = "";
            this.TextFechaInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextFechaInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextFechaInicio.CustomButton.TabIndex = 1;
            this.TextFechaInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextFechaInicio.CustomButton.UseSelectable = true;
            this.TextFechaInicio.CustomButton.Visible = false;
            this.TextFechaInicio.Lines = new string[0];
            this.TextFechaInicio.Location = new System.Drawing.Point(19, 50);
            this.TextFechaInicio.MaxLength = 32767;
            this.TextFechaInicio.Name = "TextFechaInicio";
            this.TextFechaInicio.PasswordChar = '\0';
            this.TextFechaInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextFechaInicio.SelectedText = "";
            this.TextFechaInicio.SelectionLength = 0;
            this.TextFechaInicio.SelectionStart = 0;
            this.TextFechaInicio.ShortcutsEnabled = true;
            this.TextFechaInicio.Size = new System.Drawing.Size(161, 23);
            this.TextFechaInicio.TabIndex = 3;
            this.TextFechaInicio.UseSelectable = true;
            this.TextFechaInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextFechaInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textUser
            // 
            // 
            // 
            // 
            this.textUser.CustomButton.Image = null;
            this.textUser.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.textUser.CustomButton.Name = "";
            this.textUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUser.CustomButton.TabIndex = 1;
            this.textUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUser.CustomButton.UseSelectable = true;
            this.textUser.CustomButton.Visible = false;
            this.textUser.Lines = new string[0];
            this.textUser.Location = new System.Drawing.Point(219, 50);
            this.textUser.MaxLength = 32767;
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUser.SelectedText = "";
            this.textUser.SelectionLength = 0;
            this.textUser.SelectionStart = 0;
            this.textUser.ShortcutsEnabled = true;
            this.textUser.Size = new System.Drawing.Size(182, 23);
            this.textUser.TabIndex = 2;
            this.textUser.UseSelectable = true;
            this.textUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Usuario Responsable";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fecha Registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.iconButton9);
            this.groupBox2.Controls.Add(this.iconButton10);
            this.groupBox2.Controls.Add(this.iconButton11);
            this.groupBox2.Controls.Add(this.textcorreo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.BtnProveedor);
            this.groupBox2.Controls.Add(this.textProveedor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textEstado);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(457, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 106);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 18;
            this.iconButton9.Location = new System.Drawing.Point(218, 32);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(23, 21);
            this.iconButton9.TabIndex = 41;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 18;
            this.iconButton10.Location = new System.Drawing.Point(375, 32);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(23, 21);
            this.iconButton10.TabIndex = 40;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconButton11.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 18;
            this.iconButton11.Location = new System.Drawing.Point(17, 32);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Size = new System.Drawing.Size(23, 21);
            this.iconButton11.TabIndex = 39;
            this.iconButton11.UseVisualStyleBackColor = false;
            // 
            // textcorreo
            // 
            // 
            // 
            // 
            this.textcorreo.CustomButton.Image = null;
            this.textcorreo.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.textcorreo.CustomButton.Name = "";
            this.textcorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textcorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textcorreo.CustomButton.TabIndex = 1;
            this.textcorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textcorreo.CustomButton.UseSelectable = true;
            this.textcorreo.CustomButton.Visible = false;
            this.textcorreo.Lines = new string[0];
            this.textcorreo.Location = new System.Drawing.Point(378, 53);
            this.textcorreo.MaxLength = 32767;
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.PasswordChar = '\0';
            this.textcorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textcorreo.SelectedText = "";
            this.textcorreo.SelectionLength = 0;
            this.textcorreo.SelectionStart = 0;
            this.textcorreo.ShortcutsEnabled = true;
            this.textcorreo.Size = new System.Drawing.Size(160, 23);
            this.textcorreo.TabIndex = 38;
            this.textcorreo.UseSelectable = true;
            this.textcorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textcorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(395, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Correo";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 23);
            this.label14.TabIndex = 36;
            this.label14.Text = "Informacion del Proveedor";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnProveedor.IconColor = System.Drawing.Color.Black;
            this.BtnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProveedor.IconSize = 16;
            this.BtnProveedor.Location = new System.Drawing.Point(178, 54);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(23, 21);
            this.BtnProveedor.TabIndex = 5;
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // textProveedor
            // 
            // 
            // 
            // 
            this.textProveedor.CustomButton.Image = null;
            this.textProveedor.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.textProveedor.CustomButton.Name = "";
            this.textProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textProveedor.CustomButton.TabIndex = 1;
            this.textProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textProveedor.CustomButton.UseSelectable = true;
            this.textProveedor.CustomButton.Visible = false;
            this.textProveedor.Lines = new string[0];
            this.textProveedor.Location = new System.Drawing.Point(19, 53);
            this.textProveedor.MaxLength = 32767;
            this.textProveedor.Name = "textProveedor";
            this.textProveedor.PasswordChar = '\0';
            this.textProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textProveedor.SelectedText = "";
            this.textProveedor.SelectionLength = 0;
            this.textProveedor.SelectionStart = 0;
            this.textProveedor.ShortcutsEnabled = true;
            this.textProveedor.Size = new System.Drawing.Size(182, 23);
            this.textProveedor.TabIndex = 2;
            this.textProveedor.UseSelectable = true;
            this.textProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Proveedor Emisor";
            // 
            // textEstado
            // 
            // 
            // 
            // 
            this.textEstado.CustomButton.Image = null;
            this.textEstado.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.textEstado.CustomButton.Name = "";
            this.textEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEstado.CustomButton.TabIndex = 1;
            this.textEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEstado.CustomButton.UseSelectable = true;
            this.textEstado.CustomButton.Visible = false;
            this.textEstado.Lines = new string[0];
            this.textEstado.Location = new System.Drawing.Point(221, 53);
            this.textEstado.MaxLength = 32767;
            this.textEstado.Name = "textEstado";
            this.textEstado.PasswordChar = '\0';
            this.textEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEstado.SelectedText = "";
            this.textEstado.SelectionLength = 0;
            this.textEstado.SelectionStart = 0;
            this.textEstado.ShortcutsEnabled = true;
            this.textEstado.Size = new System.Drawing.Size(136, 23);
            this.textEstado.TabIndex = 3;
            this.textEstado.UseSelectable = true;
            this.textEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(237, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Estado del Proveedor";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.textId);
            this.groupBox3.Controls.Add(this.comboBoxEst);
            this.groupBox3.Controls.Add(this.iconButton2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.combocategoria);
            this.groupBox3.Controls.Add(this.iconButton15);
            this.groupBox3.Controls.Add(this.textPrecioVenta);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.iconButton13);
            this.groupBox3.Controls.Add(this.iconButton16);
            this.groupBox3.Controls.Add(this.iconButton18);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textcodigo);
            this.groupBox3.Controls.Add(this.textPrecioCompra);
            this.groupBox3.Controls.Add(this.TextProductos);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(24, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 160);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textId
            // 
            // 
            // 
            // 
            this.textId.CustomButton.Image = null;
            this.textId.CustomButton.Location = new System.Drawing.Point(-2, 1);
            this.textId.CustomButton.Name = "";
            this.textId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textId.CustomButton.TabIndex = 1;
            this.textId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textId.CustomButton.UseSelectable = true;
            this.textId.CustomButton.Visible = false;
            this.textId.Lines = new string[0];
            this.textId.Location = new System.Drawing.Point(266, 58);
            this.textId.MaxLength = 32767;
            this.textId.Name = "textId";
            this.textId.PasswordChar = '\0';
            this.textId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textId.SelectedText = "";
            this.textId.SelectionLength = 0;
            this.textId.SelectionStart = 0;
            this.textId.ShortcutsEnabled = true;
            this.textId.Size = new System.Drawing.Size(20, 23);
            this.textId.TabIndex = 55;
            this.textId.UseSelectable = true;
            this.textId.Visible = false;
            this.textId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxEst
            // 
            this.comboBoxEst.FormattingEnabled = true;
            this.comboBoxEst.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.comboBoxEst.Location = new System.Drawing.Point(411, 124);
            this.comboBoxEst.Name = "comboBoxEst";
            this.comboBoxEst.Size = new System.Drawing.Size(139, 21);
            this.comboBoxEst.TabIndex = 54;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(411, 101);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(23, 21);
            this.iconButton2.TabIndex = 53;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Estado";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(510, 38);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 21);
            this.iconButton1.TabIndex = 50;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // combocategoria
            // 
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(510, 60);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(139, 21);
            this.combocategoria.TabIndex = 49;
            // 
            // iconButton15
            // 
            this.iconButton15.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton15.FlatAppearance.BorderSize = 0;
            this.iconButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton15.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconButton15.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton15.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton15.IconSize = 16;
            this.iconButton15.Location = new System.Drawing.Point(212, 101);
            this.iconButton15.Name = "iconButton15";
            this.iconButton15.Size = new System.Drawing.Size(23, 21);
            this.iconButton15.TabIndex = 47;
            this.iconButton15.UseVisualStyleBackColor = false;
            // 
            // textPrecioVenta
            // 
            // 
            // 
            // 
            this.textPrecioVenta.CustomButton.Image = null;
            this.textPrecioVenta.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textPrecioVenta.CustomButton.Name = "";
            this.textPrecioVenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPrecioVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPrecioVenta.CustomButton.TabIndex = 1;
            this.textPrecioVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPrecioVenta.CustomButton.UseSelectable = true;
            this.textPrecioVenta.CustomButton.Visible = false;
            this.textPrecioVenta.Lines = new string[0];
            this.textPrecioVenta.Location = new System.Drawing.Point(217, 122);
            this.textPrecioVenta.MaxLength = 32767;
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.PasswordChar = '\0';
            this.textPrecioVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPrecioVenta.SelectedText = "";
            this.textPrecioVenta.SelectionLength = 0;
            this.textPrecioVenta.SelectionStart = 0;
            this.textPrecioVenta.ShortcutsEnabled = true;
            this.textPrecioVenta.Size = new System.Drawing.Size(179, 23);
            this.textPrecioVenta.TabIndex = 46;
            this.textPrecioVenta.UseSelectable = true;
            this.textPrecioVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPrecioVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Precio Venta";
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton13.FlatAppearance.BorderSize = 0;
            this.iconButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconButton13.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton13.IconSize = 16;
            this.iconButton13.Location = new System.Drawing.Point(34, 102);
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Size = new System.Drawing.Size(23, 21);
            this.iconButton13.TabIndex = 43;
            this.iconButton13.UseVisualStyleBackColor = false;
            // 
            // iconButton16
            // 
            this.iconButton16.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton16.FlatAppearance.BorderSize = 0;
            this.iconButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton16.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.iconButton16.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton16.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton16.IconSize = 16;
            this.iconButton16.Location = new System.Drawing.Point(316, 38);
            this.iconButton16.Name = "iconButton16";
            this.iconButton16.Size = new System.Drawing.Size(23, 21);
            this.iconButton16.TabIndex = 42;
            this.iconButton16.UseVisualStyleBackColor = false;
            // 
            // iconButton18
            // 
            this.iconButton18.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton18.FlatAppearance.BorderSize = 0;
            this.iconButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton18.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.iconButton18.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton18.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton18.IconSize = 18;
            this.iconButton18.Location = new System.Drawing.Point(23, 37);
            this.iconButton18.Name = "iconButton18";
            this.iconButton18.Size = new System.Drawing.Size(23, 21);
            this.iconButton18.TabIndex = 41;
            this.iconButton18.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 23);
            this.label18.TabIndex = 40;
            this.label18.Text = "Listado de Productos";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(337, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Cod. Producto";
            // 
            // textcodigo
            // 
            // 
            // 
            // 
            this.textcodigo.CustomButton.Image = null;
            this.textcodigo.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.textcodigo.CustomButton.Name = "";
            this.textcodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textcodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textcodigo.CustomButton.TabIndex = 1;
            this.textcodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textcodigo.CustomButton.UseSelectable = true;
            this.textcodigo.CustomButton.Visible = false;
            this.textcodigo.Lines = new string[0];
            this.textcodigo.Location = new System.Drawing.Point(316, 59);
            this.textcodigo.MaxLength = 32767;
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.PasswordChar = '\0';
            this.textcodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textcodigo.SelectedText = "";
            this.textcodigo.SelectionLength = 0;
            this.textcodigo.SelectionStart = 0;
            this.textcodigo.ShortcutsEnabled = true;
            this.textcodigo.Size = new System.Drawing.Size(173, 23);
            this.textcodigo.TabIndex = 6;
            this.textcodigo.UseSelectable = true;
            this.textcodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textcodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textPrecioCompra
            // 
            // 
            // 
            // 
            this.textPrecioCompra.CustomButton.Image = null;
            this.textPrecioCompra.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.textPrecioCompra.CustomButton.Name = "";
            this.textPrecioCompra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPrecioCompra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPrecioCompra.CustomButton.TabIndex = 1;
            this.textPrecioCompra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPrecioCompra.CustomButton.UseSelectable = true;
            this.textPrecioCompra.CustomButton.Visible = false;
            this.textPrecioCompra.Lines = new string[0];
            this.textPrecioCompra.Location = new System.Drawing.Point(36, 123);
            this.textPrecioCompra.MaxLength = 32767;
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.PasswordChar = '\0';
            this.textPrecioCompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPrecioCompra.SelectedText = "";
            this.textPrecioCompra.SelectionLength = 0;
            this.textPrecioCompra.SelectionStart = 0;
            this.textPrecioCompra.ShortcutsEnabled = true;
            this.textPrecioCompra.Size = new System.Drawing.Size(147, 23);
            this.textPrecioCompra.TabIndex = 8;
            this.textPrecioCompra.UseSelectable = true;
            this.textPrecioCompra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPrecioCompra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextProductos
            // 
            // 
            // 
            // 
            this.TextProductos.CustomButton.Image = null;
            this.TextProductos.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.TextProductos.CustomButton.Name = "";
            this.TextProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextProductos.CustomButton.TabIndex = 1;
            this.TextProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextProductos.CustomButton.UseSelectable = true;
            this.TextProductos.CustomButton.Visible = false;
            this.TextProductos.Lines = new string[0];
            this.TextProductos.Location = new System.Drawing.Point(28, 58);
            this.TextProductos.MaxLength = 32767;
            this.TextProductos.Name = "TextProductos";
            this.TextProductos.PasswordChar = '\0';
            this.TextProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextProductos.SelectedText = "";
            this.TextProductos.SelectionLength = 0;
            this.TextProductos.SelectionStart = 0;
            this.TextProductos.ShortcutsEnabled = true;
            this.TextProductos.Size = new System.Drawing.Size(258, 23);
            this.TextProductos.TabIndex = 7;
            this.TextProductos.UseSelectable = true;
            this.TextProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(54, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Precio Compra";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(156, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Digite el nombre del Producto  *";
            // 
            // GridProductos
            // 
            this.GridProductos.AllowUserToAddRows = false;
            this.GridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProductos.ColumnHeadersHeight = 35;
            this.GridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridProductos.EnableHeadersVisualStyles = false;
            this.GridProductos.Location = new System.Drawing.Point(20, 53);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.Size = new System.Drawing.Size(938, 162);
            this.GridProductos.TabIndex = 48;
            this.GridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductos_CellContentClick);
            this.GridProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // generarExcel
            // 
            this.generarExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(64)))));
            this.generarExcel.FlatAppearance.BorderSize = 0;
            this.generarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.generarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.generarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.generarExcel.IconColor = System.Drawing.Color.White;
            this.generarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generarExcel.IconSize = 30;
            this.generarExcel.Location = new System.Drawing.Point(23, 12);
            this.generarExcel.Name = "generarExcel";
            this.generarExcel.Size = new System.Drawing.Size(167, 35);
            this.generarExcel.TabIndex = 27;
            this.generarExcel.Text = "Imprimir Excel";
            this.generarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generarExcel.UseVisualStyleBackColor = false;
            this.generarExcel.Click += new System.EventHandler(this.generarExcel_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(168)))), ((int)(((byte)(73)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 24;
            this.btnAgregar.Location = new System.Drawing.Point(40, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnModificar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Location = new System.Drawing.Point(795, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 161);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnModificar.IconColor = System.Drawing.Color.White;
            this.BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModificar.IconSize = 24;
            this.BtnModificar.Location = new System.Drawing.Point(40, 95);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(116, 35);
            this.BtnModificar.TabIndex = 56;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Acciones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.iconButton7);
            this.groupBox5.Controls.Add(this.btnBuscar);
            this.groupBox5.Controls.Add(this.TextAbuscar);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.GridProductos);
            this.groupBox5.Controls.Add(this.generarExcel);
            this.groupBox5.Location = new System.Drawing.Point(24, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(977, 214);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.Location = new System.Drawing.Point(196, 13);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(167, 34);
            this.iconButton7.TabIndex = 56;
            this.iconButton7.Text = "Generar PDF";
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(922, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 23);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // TextAbuscar
            // 
            // 
            // 
            // 
            this.TextAbuscar.CustomButton.Image = null;
            this.TextAbuscar.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.TextAbuscar.CustomButton.Name = "";
            this.TextAbuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextAbuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextAbuscar.CustomButton.TabIndex = 1;
            this.TextAbuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextAbuscar.CustomButton.UseSelectable = true;
            this.TextAbuscar.CustomButton.Visible = false;
            this.TextAbuscar.Lines = new string[0];
            this.TextAbuscar.Location = new System.Drawing.Point(785, 20);
            this.TextAbuscar.MaxLength = 32767;
            this.TextAbuscar.Name = "TextAbuscar";
            this.TextAbuscar.PasswordChar = '\0';
            this.TextAbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextAbuscar.SelectedText = "";
            this.TextAbuscar.SelectionLength = 0;
            this.TextAbuscar.SelectionStart = 0;
            this.TextAbuscar.ShortcutsEnabled = true;
            this.TextAbuscar.Size = new System.Drawing.Size(162, 23);
            this.TextAbuscar.TabIndex = 49;
            this.TextAbuscar.UseSelectable = true;
            this.TextAbuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextAbuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextAbuscar.TextChanged += new System.EventHandler(this.TextAbuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Buscar:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1030, 554);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton generarExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton BtnCalendario;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnUsuario;
        private MetroFramework.Controls.MetroTextBox TextFechaInicio;
        private MetroFramework.Controls.MetroTextBox textUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private MetroFramework.Controls.MetroTextBox textcorreo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton BtnProveedor;
        private MetroFramework.Controls.MetroTextBox textProveedor;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroTextBox textEstado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridProductos;
        private FontAwesome.Sharp.IconButton iconButton15;
        private MetroFramework.Controls.MetroTextBox textPrecioVenta;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton iconButton13;
        private FontAwesome.Sharp.IconButton iconButton16;
        private FontAwesome.Sharp.IconButton iconButton18;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox textcodigo;
        private MetroFramework.Controls.MetroTextBox textPrecioCompra;
        private MetroFramework.Controls.MetroTextBox TextProductos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox combocategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEst;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox TextAbuscar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private MetroFramework.Controls.MetroTextBox textId;
    }
}