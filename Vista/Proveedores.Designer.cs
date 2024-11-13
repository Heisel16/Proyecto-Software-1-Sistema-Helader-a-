namespace BDS.Vista
{
    partial class Proveedores
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.ImprimirExcel = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.textDireccion = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textUbic = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.TextEstado = new System.Windows.Forms.ComboBox();
            this.textFecha = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTelefono = new MetroFramework.Controls.MetroTextBox();
            this.textCorreo = new MetroFramework.Controls.MetroTextBox();
            this.textRazonSoc = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDoc = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Refrescar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.TextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridProveedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TextId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedor)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(996, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 30;
            this.BtnGuardar.Location = new System.Drawing.Point(835, 63);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 35);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Location = new System.Drawing.Point(6, 0);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(303, 29);
            this.BtnProductos.TabIndex = 25;
            this.BtnProductos.Text = "Datos del Proveedor";
            this.BtnProductos.UseVisualStyleBackColor = false;
            // 
            // ImprimirExcel
            // 
            this.ImprimirExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprimirExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(64)))));
            this.ImprimirExcel.FlatAppearance.BorderSize = 0;
            this.ImprimirExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.ImprimirExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.ImprimirExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ImprimirExcel.IconColor = System.Drawing.Color.White;
            this.ImprimirExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImprimirExcel.IconSize = 30;
            this.ImprimirExcel.Location = new System.Drawing.Point(19, 10);
            this.ImprimirExcel.Name = "ImprimirExcel";
            this.ImprimirExcel.Size = new System.Drawing.Size(167, 35);
            this.ImprimirExcel.TabIndex = 48;
            this.ImprimirExcel.Text = "Imprimir Excel";
            this.ImprimirExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImprimirExcel.UseVisualStyleBackColor = false;
            this.ImprimirExcel.Click += new System.EventHandler(this.ImprimirExcel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Registro de Proveedores";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.TextId);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.iconButton10);
            this.groupBox1.Controls.Add(this.iconButton11);
            this.groupBox1.Controls.Add(this.textDireccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textUbic);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.iconButton9);
            this.groupBox1.Controls.Add(this.iconButton6);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton5);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.iconButton8);
            this.groupBox1.Controls.Add(this.iconButton7);
            this.groupBox1.Controls.Add(this.TextEstado);
            this.groupBox1.Controls.Add(this.textFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.BtnProductos);
            this.groupBox1.Controls.Add(this.textCorreo);
            this.groupBox1.Controls.Add(this.textRazonSoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 180);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnModificar.IconColor = System.Drawing.Color.White;
            this.BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModificar.IconSize = 30;
            this.BtnModificar.Location = new System.Drawing.Point(835, 101);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(110, 35);
            this.BtnModificar.TabIndex = 81;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 18;
            this.iconButton10.Location = new System.Drawing.Point(633, 104);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(29, 21);
            this.iconButton10.TabIndex = 79;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.iconButton11.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 18;
            this.iconButton11.Location = new System.Drawing.Point(633, 41);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Size = new System.Drawing.Size(23, 21);
            this.iconButton11.TabIndex = 78;
            this.iconButton11.UseVisualStyleBackColor = false;
            // 
            // textDireccion
            // 
            this.textDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textDireccion.CustomButton.Image = null;
            this.textDireccion.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.textDireccion.CustomButton.Name = "";
            this.textDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textDireccion.CustomButton.TabIndex = 1;
            this.textDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDireccion.CustomButton.UseSelectable = true;
            this.textDireccion.CustomButton.Visible = false;
            this.textDireccion.Lines = new string[0];
            this.textDireccion.Location = new System.Drawing.Point(633, 125);
            this.textDireccion.MaxLength = 32767;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.PasswordChar = '\0';
            this.textDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textDireccion.SelectedText = "";
            this.textDireccion.SelectionLength = 0;
            this.textDireccion.SelectionStart = 0;
            this.textDireccion.ShortcutsEnabled = true;
            this.textDireccion.Size = new System.Drawing.Size(171, 23);
            this.textDireccion.TabIndex = 77;
            this.textDireccion.UseSelectable = true;
            this.textDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Direccion";
            // 
            // textUbic
            // 
            this.textUbic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textUbic.CustomButton.Image = null;
            this.textUbic.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.textUbic.CustomButton.Name = "";
            this.textUbic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUbic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUbic.CustomButton.TabIndex = 1;
            this.textUbic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUbic.CustomButton.UseSelectable = true;
            this.textUbic.CustomButton.Visible = false;
            this.textUbic.Lines = new string[0];
            this.textUbic.Location = new System.Drawing.Point(633, 63);
            this.textUbic.MaxLength = 32767;
            this.textUbic.Name = "textUbic";
            this.textUbic.PasswordChar = '\0';
            this.textUbic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUbic.SelectedText = "";
            this.textUbic.SelectionLength = 0;
            this.textUbic.SelectionStart = 0;
            this.textUbic.ShortcutsEnabled = true;
            this.textUbic.Size = new System.Drawing.Size(164, 23);
            this.textUbic.TabIndex = 75;
            this.textUbic.UseSelectable = true;
            this.textUbic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUbic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(656, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Ubicacion";
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 18;
            this.iconButton9.Location = new System.Drawing.Point(16, 105);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(23, 21);
            this.iconButton9.TabIndex = 73;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 18;
            this.iconButton6.Location = new System.Drawing.Point(211, 40);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(23, 21);
            this.iconButton6.TabIndex = 72;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(12, 38);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(24, 22);
            this.iconButton2.TabIndex = 71;
            this.iconButton2.UseVisualStyleBackColor = false;
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
            this.iconButton5.Location = new System.Drawing.Point(416, 103);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(29, 21);
            this.iconButton5.TabIndex = 70;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(564, 126);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 21);
            this.iconButton1.TabIndex = 69;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 18;
            this.iconButton8.Location = new System.Drawing.Point(210, 104);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(23, 21);
            this.iconButton8.TabIndex = 68;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 18;
            this.iconButton7.Location = new System.Drawing.Point(416, 39);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(23, 21);
            this.iconButton7.TabIndex = 67;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // TextEstado
            // 
            this.TextEstado.FormattingEnabled = true;
            this.TextEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.TextEstado.Location = new System.Drawing.Point(210, 126);
            this.TextEstado.Name = "TextEstado";
            this.TextEstado.Size = new System.Drawing.Size(177, 23);
            this.TextEstado.TabIndex = 66;
            // 
            // textFecha
            // 
            this.textFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textFecha.CustomButton.Image = null;
            this.textFecha.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textFecha.CustomButton.Name = "";
            this.textFecha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFecha.CustomButton.TabIndex = 1;
            this.textFecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFecha.CustomButton.UseSelectable = true;
            this.textFecha.CustomButton.Visible = false;
            this.textFecha.Lines = new string[0];
            this.textFecha.Location = new System.Drawing.Point(416, 125);
            this.textFecha.MaxLength = 32767;
            this.textFecha.Name = "textFecha";
            this.textFecha.PasswordChar = '\0';
            this.textFecha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFecha.SelectedText = "";
            this.textFecha.SelectionLength = 0;
            this.textFecha.SelectionStart = 0;
            this.textFecha.ShortcutsEnabled = true;
            this.textFecha.Size = new System.Drawing.Size(177, 23);
            this.textFecha.TabIndex = 65;
            this.textFecha.UseSelectable = true;
            this.textFecha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFecha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Fecha Registro";
            // 
            // textTelefono
            // 
            this.textTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textTelefono.CustomButton.Image = null;
            this.textTelefono.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textTelefono.CustomButton.Name = "";
            this.textTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textTelefono.CustomButton.TabIndex = 1;
            this.textTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textTelefono.CustomButton.UseSelectable = true;
            this.textTelefono.CustomButton.Visible = false;
            this.textTelefono.Lines = new string[0];
            this.textTelefono.Location = new System.Drawing.Point(14, 126);
            this.textTelefono.MaxLength = 32767;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.PasswordChar = '\0';
            this.textTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textTelefono.SelectedText = "";
            this.textTelefono.SelectionLength = 0;
            this.textTelefono.SelectionStart = 0;
            this.textTelefono.ShortcutsEnabled = true;
            this.textTelefono.Size = new System.Drawing.Size(177, 23);
            this.textTelefono.TabIndex = 63;
            this.textTelefono.UseSelectable = true;
            this.textTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textCorreo
            // 
            this.textCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textCorreo.CustomButton.Image = null;
            this.textCorreo.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textCorreo.CustomButton.Name = "";
            this.textCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textCorreo.CustomButton.TabIndex = 1;
            this.textCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textCorreo.CustomButton.UseSelectable = true;
            this.textCorreo.CustomButton.Visible = false;
            this.textCorreo.Lines = new string[0];
            this.textCorreo.Location = new System.Drawing.Point(416, 60);
            this.textCorreo.MaxLength = 32767;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.PasswordChar = '\0';
            this.textCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textCorreo.SelectedText = "";
            this.textCorreo.SelectionLength = 0;
            this.textCorreo.SelectionStart = 0;
            this.textCorreo.ShortcutsEnabled = true;
            this.textCorreo.Size = new System.Drawing.Size(177, 23);
            this.textCorreo.TabIndex = 62;
            this.textCorreo.UseSelectable = true;
            this.textCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textRazonSoc
            // 
            this.textRazonSoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textRazonSoc.CustomButton.Image = null;
            this.textRazonSoc.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textRazonSoc.CustomButton.Name = "";
            this.textRazonSoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textRazonSoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textRazonSoc.CustomButton.TabIndex = 1;
            this.textRazonSoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textRazonSoc.CustomButton.UseSelectable = true;
            this.textRazonSoc.CustomButton.Visible = false;
            this.textRazonSoc.Lines = new string[0];
            this.textRazonSoc.Location = new System.Drawing.Point(211, 61);
            this.textRazonSoc.MaxLength = 32767;
            this.textRazonSoc.Name = "textRazonSoc";
            this.textRazonSoc.PasswordChar = '\0';
            this.textRazonSoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textRazonSoc.SelectedText = "";
            this.textRazonSoc.SelectionLength = 0;
            this.textRazonSoc.SelectionStart = 0;
            this.textRazonSoc.ShortcutsEnabled = true;
            this.textRazonSoc.Size = new System.Drawing.Size(177, 23);
            this.textRazonSoc.TabIndex = 61;
            this.textRazonSoc.UseSelectable = true;
            this.textRazonSoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textRazonSoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Estado";
            // 
            // textDoc
            // 
            this.textDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textDoc.CustomButton.Image = null;
            this.textDoc.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textDoc.CustomButton.Name = "";
            this.textDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textDoc.CustomButton.TabIndex = 1;
            this.textDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDoc.CustomButton.UseSelectable = true;
            this.textDoc.CustomButton.Visible = false;
            this.textDoc.Lines = new string[0];
            this.textDoc.Location = new System.Drawing.Point(18, 61);
            this.textDoc.MaxLength = 32767;
            this.textDoc.Name = "textDoc";
            this.textDoc.PasswordChar = '\0';
            this.textDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textDoc.SelectedText = "";
            this.textDoc.SelectionLength = 0;
            this.textDoc.SelectionStart = 0;
            this.textDoc.ShortcutsEnabled = true;
            this.textDoc.Size = new System.Drawing.Size(177, 23);
            this.textDoc.TabIndex = 59;
            this.textDoc.UseSelectable = true;
            this.textDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Documento";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.Refrescar);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.comboFiltro);
            this.groupBox2.Controls.Add(this.TextBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.GridProveedor);
            this.groupBox2.Controls.Add(this.ImprimirExcel);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 257);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // Refrescar
            // 
            this.Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refrescar.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.Refrescar.IconColor = System.Drawing.Color.Black;
            this.Refrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Refrescar.IconSize = 22;
            this.Refrescar.Location = new System.Drawing.Point(945, 18);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(31, 23);
            this.Refrescar.TabIndex = 54;
            this.Refrescar.UseVisualStyleBackColor = true;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.White;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 20;
            this.BtnBuscar.Location = new System.Drawing.Point(911, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 23);
            this.BtnBuscar.TabIndex = 53;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(634, 19);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(110, 21);
            this.comboFiltro.TabIndex = 52;
            // 
            // TextBuscar
            // 
            // 
            // 
            // 
            this.TextBuscar.CustomButton.Image = null;
            this.TextBuscar.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.TextBuscar.CustomButton.Name = "";
            this.TextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBuscar.CustomButton.TabIndex = 1;
            this.TextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBuscar.CustomButton.UseSelectable = true;
            this.TextBuscar.CustomButton.Visible = false;
            this.TextBuscar.Lines = new string[0];
            this.TextBuscar.Location = new System.Drawing.Point(750, 18);
            this.TextBuscar.MaxLength = 32767;
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.PasswordChar = '\0';
            this.TextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBuscar.SelectedText = "";
            this.TextBuscar.SelectionLength = 0;
            this.TextBuscar.SelectionStart = 0;
            this.TextBuscar.ShortcutsEnabled = true;
            this.TextBuscar.Size = new System.Drawing.Size(162, 23);
            this.TextBuscar.TabIndex = 50;
            this.TextBuscar.UseSelectable = true;
            this.TextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(561, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Buscar por:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridProveedor
            // 
            this.GridProveedor.AllowUserToAddRows = false;
            this.GridProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GridProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridProveedor.ColumnHeadersHeight = 30;
            this.GridProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridProveedor.Location = new System.Drawing.Point(6, 51);
            this.GridProveedor.Name = "GridProveedor";
            this.GridProveedor.Size = new System.Drawing.Size(978, 200);
            this.GridProveedor.TabIndex = 49;
            this.GridProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProveedor_CellContentClick);
            this.GridProveedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
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
            // TextId
            // 
            this.TextId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TextId.CustomButton.Image = null;
            this.TextId.CustomButton.Location = new System.Drawing.Point(-3, 1);
            this.TextId.CustomButton.Name = "";
            this.TextId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextId.CustomButton.TabIndex = 1;
            this.TextId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextId.CustomButton.UseSelectable = true;
            this.TextId.CustomButton.Visible = false;
            this.TextId.Lines = new string[0];
            this.TextId.Location = new System.Drawing.Point(176, 61);
            this.TextId.MaxLength = 32767;
            this.TextId.Name = "TextId";
            this.TextId.PasswordChar = '\0';
            this.TextId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextId.SelectedText = "";
            this.TextId.SelectionLength = 0;
            this.TextId.SelectionStart = 0;
            this.TextId.ShortcutsEnabled = true;
            this.TextId.Size = new System.Drawing.Size(19, 23);
            this.TextId.TabIndex = 60;
            this.TextId.UseSelectable = true;
            this.TextId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Button BtnProductos;
        private FontAwesome.Sharp.IconButton ImprimirExcel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridProveedor;
        private System.Windows.Forms.ComboBox TextEstado;
        private MetroFramework.Controls.MetroTextBox textFecha;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox textTelefono;
        private MetroFramework.Controls.MetroTextBox textCorreo;
        private MetroFramework.Controls.MetroTextBox textRazonSoc;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox textDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.ComboBox comboFiltro;
        private MetroFramework.Controls.MetroTextBox TextBuscar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private MetroFramework.Controls.MetroTextBox textDireccion;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox textUbic;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton Refrescar;
        private MetroFramework.Controls.MetroTextBox TextId;
    }
}