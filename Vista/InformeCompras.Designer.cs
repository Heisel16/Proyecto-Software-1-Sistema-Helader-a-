namespace BDS.Vista
{
    partial class InformeCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaFinal = new FontAwesome.Sharp.IconButton();
            this.FechaInicial = new FontAwesome.Sharp.IconButton();
            this.BtnConsultar = new FontAwesome.Sharp.IconButton();
            this.TextFechaFin = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFechaInicio = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxPeriodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buscarFiltro = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.TexAbuscar = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportarPDF = new FontAwesome.Sharp.IconButton();
            this.ExportarExcel = new FontAwesome.Sharp.IconButton();
            this.GridInformesCompras = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BntFiltrar = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInformesCompras)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Informes de las Compras de Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.FechaFinal);
            this.groupBox1.Controls.Add(this.FechaInicial);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.TextFechaFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextFechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 89);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por fechas";
            // 
            // FechaFinal
            // 
            this.FechaFinal.BackColor = System.Drawing.SystemColors.Control;
            this.FechaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaFinal.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.FechaFinal.IconColor = System.Drawing.Color.Black;
            this.FechaFinal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FechaFinal.IconSize = 18;
            this.FechaFinal.Location = new System.Drawing.Point(434, 40);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(29, 21);
            this.FechaFinal.TabIndex = 39;
            this.FechaFinal.UseVisualStyleBackColor = false;
            this.FechaFinal.Click += new System.EventHandler(this.FechaFinal_Click);
            // 
            // FechaInicial
            // 
            this.FechaInicial.BackColor = System.Drawing.SystemColors.Control;
            this.FechaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaInicial.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.FechaInicial.IconColor = System.Drawing.Color.Black;
            this.FechaInicial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FechaInicial.IconSize = 18;
            this.FechaInicial.Location = new System.Drawing.Point(212, 40);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(29, 21);
            this.FechaInicial.TabIndex = 38;
            this.FechaInicial.UseVisualStyleBackColor = false;
            this.FechaInicial.Click += new System.EventHandler(this.FechaInicial_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnConsultar.IconColor = System.Drawing.Color.White;
            this.BtnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultar.IconSize = 20;
            this.BtnConsultar.Location = new System.Drawing.Point(481, 39);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(94, 23);
            this.BtnConsultar.TabIndex = 6;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TextFechaFin
            // 
            // 
            // 
            // 
            this.TextFechaFin.CustomButton.Image = null;
            this.TextFechaFin.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.TextFechaFin.CustomButton.Name = "";
            this.TextFechaFin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextFechaFin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextFechaFin.CustomButton.TabIndex = 1;
            this.TextFechaFin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextFechaFin.CustomButton.UseSelectable = true;
            this.TextFechaFin.CustomButton.Visible = false;
            this.TextFechaFin.Lines = new string[0];
            this.TextFechaFin.Location = new System.Drawing.Point(329, 39);
            this.TextFechaFin.MaxLength = 32767;
            this.TextFechaFin.Name = "TextFechaFin";
            this.TextFechaFin.PasswordChar = '\0';
            this.TextFechaFin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextFechaFin.SelectedText = "";
            this.TextFechaFin.SelectionLength = 0;
            this.TextFechaFin.SelectionStart = 0;
            this.TextFechaFin.ShortcutsEnabled = true;
            this.TextFechaFin.Size = new System.Drawing.Size(134, 23);
            this.TextFechaFin.TabIndex = 3;
            this.TextFechaFin.UseSelectable = true;
            this.TextFechaFin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextFechaFin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin:";
            // 
            // TextFechaInicio
            // 
            // 
            // 
            // 
            this.TextFechaInicio.CustomButton.Image = null;
            this.TextFechaInicio.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TextFechaInicio.CustomButton.Name = "";
            this.TextFechaInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextFechaInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextFechaInicio.CustomButton.TabIndex = 1;
            this.TextFechaInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextFechaInicio.CustomButton.UseSelectable = true;
            this.TextFechaInicio.CustomButton.Visible = false;
            this.TextFechaInicio.Lines = new string[0];
            this.TextFechaInicio.Location = new System.Drawing.Point(88, 39);
            this.TextFechaInicio.MaxLength = 32767;
            this.TextFechaInicio.Name = "TextFechaInicio";
            this.TextFechaInicio.PasswordChar = '\0';
            this.TextFechaInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextFechaInicio.SelectedText = "";
            this.TextFechaInicio.SelectionLength = 0;
            this.TextFechaInicio.SelectionStart = 0;
            this.TextFechaInicio.ShortcutsEnabled = true;
            this.TextFechaInicio.Size = new System.Drawing.Size(153, 23);
            this.TextFechaInicio.TabIndex = 1;
            this.TextFechaInicio.UseSelectable = true;
            this.TextFechaInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextFechaInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio:";
            // 
            // CbxPeriodo
            // 
            this.CbxPeriodo.FormattingEnabled = true;
            this.CbxPeriodo.Items.AddRange(new object[] {
            "Semanal",
            "Mensual",
            "Trimestral"});
            this.CbxPeriodo.Location = new System.Drawing.Point(74, 38);
            this.CbxPeriodo.Name = "CbxPeriodo";
            this.CbxPeriodo.Size = new System.Drawing.Size(121, 21);
            this.CbxPeriodo.TabIndex = 11;
            this.CbxPeriodo.Text = "(seleccione)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Periodo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buscarFiltro);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.comboFiltro);
            this.groupBox2.Controls.Add(this.TexAbuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ExportarPDF);
            this.groupBox2.Controls.Add(this.ExportarExcel);
            this.groupBox2.Controls.Add(this.GridInformesCompras);
            this.groupBox2.Location = new System.Drawing.Point(17, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 362);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Buscar:";
            // 
            // buscarFiltro
            // 
            // 
            // 
            // 
            this.buscarFiltro.CustomButton.Image = null;
            this.buscarFiltro.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.buscarFiltro.CustomButton.Name = "";
            this.buscarFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.buscarFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.buscarFiltro.CustomButton.TabIndex = 1;
            this.buscarFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buscarFiltro.CustomButton.UseSelectable = true;
            this.buscarFiltro.CustomButton.Visible = false;
            this.buscarFiltro.Lines = new string[0];
            this.buscarFiltro.Location = new System.Drawing.Point(613, 27);
            this.buscarFiltro.MaxLength = 32767;
            this.buscarFiltro.Name = "buscarFiltro";
            this.buscarFiltro.PasswordChar = '\0';
            this.buscarFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscarFiltro.SelectedText = "";
            this.buscarFiltro.SelectionLength = 0;
            this.buscarFiltro.SelectionStart = 0;
            this.buscarFiltro.ShortcutsEnabled = true;
            this.buscarFiltro.Size = new System.Drawing.Size(111, 23);
            this.buscarFiltro.TabIndex = 38;
            this.buscarFiltro.UseSelectable = true;
            this.buscarFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.buscarFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.BtnBuscar.Location = new System.Drawing.Point(723, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 23);
            this.BtnBuscar.TabIndex = 37;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Codigo",
            "Proveedor"});
            this.comboFiltro.Location = new System.Drawing.Point(501, 28);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(110, 21);
            this.comboFiltro.TabIndex = 36;
            // 
            // TexAbuscar
            // 
            // 
            // 
            // 
            this.TexAbuscar.CustomButton.Image = null;
            this.TexAbuscar.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.TexAbuscar.CustomButton.Name = "";
            this.TexAbuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAbuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAbuscar.CustomButton.TabIndex = 1;
            this.TexAbuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAbuscar.CustomButton.UseSelectable = true;
            this.TexAbuscar.CustomButton.Visible = false;
            this.TexAbuscar.Lines = new string[0];
            this.TexAbuscar.Location = new System.Drawing.Point(817, 27);
            this.TexAbuscar.MaxLength = 32767;
            this.TexAbuscar.Name = "TexAbuscar";
            this.TexAbuscar.PasswordChar = '\0';
            this.TexAbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAbuscar.SelectedText = "";
            this.TexAbuscar.SelectionLength = 0;
            this.TexAbuscar.SelectionStart = 0;
            this.TexAbuscar.ShortcutsEnabled = true;
            this.TexAbuscar.Size = new System.Drawing.Size(162, 23);
            this.TexAbuscar.TabIndex = 12;
            this.TexAbuscar.UseSelectable = true;
            this.TexAbuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAbuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TexAbuscar.TextChanged += new System.EventHandler(this.TexAbuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Buscar por:";
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ExportarPDF.FlatAppearance.BorderSize = 0;
            this.ExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportarPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarPDF.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ExportarPDF.IconColor = System.Drawing.Color.White;
            this.ExportarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExportarPDF.IconSize = 30;
            this.ExportarPDF.Location = new System.Drawing.Point(179, 19);
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.Size = new System.Drawing.Size(167, 32);
            this.ExportarPDF.TabIndex = 34;
            this.ExportarPDF.Text = "Generar PDF";
            this.ExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportarPDF.UseVisualStyleBackColor = false;
            // 
            // ExportarExcel
            // 
            this.ExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(64)))));
            this.ExportarExcel.FlatAppearance.BorderSize = 0;
            this.ExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.ExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportarExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ExportarExcel.IconColor = System.Drawing.Color.White;
            this.ExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExportarExcel.IconSize = 30;
            this.ExportarExcel.Location = new System.Drawing.Point(6, 19);
            this.ExportarExcel.Name = "ExportarExcel";
            this.ExportarExcel.Size = new System.Drawing.Size(167, 32);
            this.ExportarExcel.TabIndex = 33;
            this.ExportarExcel.Text = "Generar Excel";
            this.ExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportarExcel.UseVisualStyleBackColor = false;
            this.ExportarExcel.Click += new System.EventHandler(this.ExportarExcel_Click);
            // 
            // GridInformesCompras
            // 
            this.GridInformesCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridInformesCompras.BackgroundColor = System.Drawing.Color.White;
            this.GridInformesCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridInformesCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridInformesCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridInformesCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridInformesCompras.ColumnHeadersHeight = 35;
            this.GridInformesCompras.EnableHeadersVisualStyles = false;
            this.GridInformesCompras.Location = new System.Drawing.Point(0, 65);
            this.GridInformesCompras.Name = "GridInformesCompras";
            this.GridInformesCompras.Size = new System.Drawing.Size(982, 291);
            this.GridInformesCompras.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(996, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 25);
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BntFiltrar
            // 
            this.BntFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BntFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.BntFiltrar.FlatAppearance.BorderSize = 0;
            this.BntFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BntFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntFiltrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntFiltrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BntFiltrar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BntFiltrar.IconColor = System.Drawing.Color.White;
            this.BntFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntFiltrar.IconSize = 20;
            this.BntFiltrar.Location = new System.Drawing.Point(209, 36);
            this.BntFiltrar.Name = "BntFiltrar";
            this.BntFiltrar.Size = new System.Drawing.Size(111, 23);
            this.BntFiltrar.TabIndex = 40;
            this.BntFiltrar.Text = "Filtrar";
            this.BntFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BntFiltrar.UseVisualStyleBackColor = false;
            this.BntFiltrar.Click += new System.EventHandler(this.BntFiltrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BntFiltrar);
            this.groupBox3.Controls.Add(this.CbxPeriodo);
            this.groupBox3.Location = new System.Drawing.Point(653, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 89);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por periodos";
            // 
            // InformeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeCompras";
            this.Text = "InformeCompras";
            this.Load += new System.EventHandler(this.InformeCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInformesCompras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton FechaFinal;
        private FontAwesome.Sharp.IconButton FechaInicial;
        private System.Windows.Forms.ComboBox CbxPeriodo;
        private FontAwesome.Sharp.IconButton BtnConsultar;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox TextFechaFin;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TextFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.ComboBox comboFiltro;
        private MetroFramework.Controls.MetroTextBox TexAbuscar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton ExportarPDF;
        private FontAwesome.Sharp.IconButton ExportarExcel;
        private System.Windows.Forms.DataGridView GridInformesCompras;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton BntFiltrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox buscarFiltro;
    }
}