namespace BDS.Vista
{
    partial class GestionStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.comboAlerta = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textCapacidad = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CantProd = new MetroFramework.Controls.MetroTextBox();
            this.iconButton18 = new FontAwesome.Sharp.IconButton();
            this.label22 = new System.Windows.Forms.Label();
            this.TextProductos = new MetroFramework.Controls.MetroTextBox();
            this.BtnSelec_Prod = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestionar Stock";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnActualizar);
            this.groupBox4.Controls.Add(this.comboAlerta);
            this.groupBox4.Controls.Add(this.comboEstado);
            this.groupBox4.Controls.Add(this.iconButton4);
            this.groupBox4.Controls.Add(this.iconButton3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textCapacidad);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CantProd);
            this.groupBox4.Controls.Add(this.iconButton18);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.TextProductos);
            this.groupBox4.Controls.Add(this.BtnSelec_Prod);
            this.groupBox4.Controls.Add(this.iconButton2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.iconButton1);
            this.groupBox4.Controls.Add(this.BtnRegistrar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 409);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.BtnActualizar.IconColor = System.Drawing.Color.White;
            this.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActualizar.IconSize = 24;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(28, 373);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(134, 32);
            this.BtnActualizar.TabIndex = 88;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // comboAlerta
            // 
            this.comboAlerta.FormattingEnabled = true;
            this.comboAlerta.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.comboAlerta.Location = new System.Drawing.Point(16, 289);
            this.comboAlerta.Name = "comboAlerta";
            this.comboAlerta.Size = new System.Drawing.Size(161, 21);
            this.comboAlerta.TabIndex = 87;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Sobre Stock",
            "Disponible",
            "Bajo Stock"});
            this.comboEstado.Location = new System.Drawing.Point(14, 231);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(161, 21);
            this.comboEstado.TabIndex = 86;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 18;
            this.iconButton4.Location = new System.Drawing.Point(6, 154);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(29, 21);
            this.iconButton4.TabIndex = 85;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SortNumericUp;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(6, 91);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(29, 21);
            this.iconButton3.TabIndex = 84;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Capacidad Maxima";
            // 
            // textCapacidad
            // 
            // 
            // 
            // 
            this.textCapacidad.CustomButton.Image = null;
            this.textCapacidad.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.textCapacidad.CustomButton.Name = "";
            this.textCapacidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textCapacidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textCapacidad.CustomButton.TabIndex = 1;
            this.textCapacidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textCapacidad.CustomButton.UseSelectable = true;
            this.textCapacidad.CustomButton.Visible = false;
            this.textCapacidad.Lines = new string[0];
            this.textCapacidad.Location = new System.Drawing.Point(12, 175);
            this.textCapacidad.MaxLength = 32767;
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.PasswordChar = '\0';
            this.textCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textCapacidad.SelectedText = "";
            this.textCapacidad.SelectionLength = 0;
            this.textCapacidad.SelectionStart = 0;
            this.textCapacidad.ShortcutsEnabled = true;
            this.textCapacidad.Size = new System.Drawing.Size(165, 23);
            this.textCapacidad.TabIndex = 82;
            this.textCapacidad.UseSelectable = true;
            this.textCapacidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCapacidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cantidad en Stock";
            // 
            // CantProd
            // 
            // 
            // 
            // 
            this.CantProd.CustomButton.Image = null;
            this.CantProd.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.CantProd.CustomButton.Name = "";
            this.CantProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CantProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CantProd.CustomButton.TabIndex = 1;
            this.CantProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CantProd.CustomButton.UseSelectable = true;
            this.CantProd.CustomButton.Visible = false;
            this.CantProd.Lines = new string[0];
            this.CantProd.Location = new System.Drawing.Point(12, 112);
            this.CantProd.MaxLength = 32767;
            this.CantProd.Name = "CantProd";
            this.CantProd.PasswordChar = '\0';
            this.CantProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CantProd.SelectedText = "";
            this.CantProd.SelectionLength = 0;
            this.CantProd.SelectionStart = 0;
            this.CantProd.ShortcutsEnabled = true;
            this.CantProd.Size = new System.Drawing.Size(165, 23);
            this.CantProd.TabIndex = 80;
            this.CantProd.UseSelectable = true;
            this.CantProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CantProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.iconButton18.Location = new System.Drawing.Point(12, 34);
            this.iconButton18.Name = "iconButton18";
            this.iconButton18.Size = new System.Drawing.Size(23, 21);
            this.iconButton18.TabIndex = 79;
            this.iconButton18.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 13);
            this.label22.TabIndex = 78;
            this.label22.Text = "Seleccione el  Producto  *";
            // 
            // TextProductos
            // 
            // 
            // 
            // 
            this.TextProductos.CustomButton.Image = null;
            this.TextProductos.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.TextProductos.CustomButton.Name = "";
            this.TextProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextProductos.CustomButton.TabIndex = 1;
            this.TextProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextProductos.CustomButton.UseSelectable = true;
            this.TextProductos.CustomButton.Visible = false;
            this.TextProductos.Lines = new string[0];
            this.TextProductos.Location = new System.Drawing.Point(10, 55);
            this.TextProductos.MaxLength = 32767;
            this.TextProductos.Name = "TextProductos";
            this.TextProductos.PasswordChar = '\0';
            this.TextProductos.ReadOnly = true;
            this.TextProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextProductos.SelectedText = "";
            this.TextProductos.SelectionLength = 0;
            this.TextProductos.SelectionStart = 0;
            this.TextProductos.ShortcutsEnabled = true;
            this.TextProductos.Size = new System.Drawing.Size(165, 23);
            this.TextProductos.TabIndex = 77;
            this.TextProductos.UseSelectable = true;
            this.TextProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSelec_Prod
            // 
            this.BtnSelec_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelec_Prod.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnSelec_Prod.IconColor = System.Drawing.Color.Black;
            this.BtnSelec_Prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSelec_Prod.IconSize = 20;
            this.BtnSelec_Prod.Location = new System.Drawing.Point(174, 55);
            this.BtnSelec_Prod.Name = "BtnSelec_Prod";
            this.BtnSelec_Prod.Size = new System.Drawing.Size(37, 23);
            this.BtnSelec_Prod.TabIndex = 76;
            this.BtnSelec_Prod.UseVisualStyleBackColor = true;
            this.BtnSelec_Prod.Click += new System.EventHandler(this.BtnSelec_Prod_Click);
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
            this.iconButton2.Location = new System.Drawing.Point(10, 210);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 21);
            this.iconButton2.TabIndex = 75;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Estado";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(13, 265);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 21);
            this.iconButton1.TabIndex = 72;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(126)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.BtnRegistrar.IconColor = System.Drawing.Color.White;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 24;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(28, 335);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(134, 32);
            this.BtnRegistrar.TabIndex = 68;
            this.BtnRegistrar.Text = "Establecer";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Nivel de Alerta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Detalles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgStock
            // 
            this.dtgStock.AllowUserToAddRows = false;
            this.dtgStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgStock.ColumnHeadersHeight = 26;
            this.dtgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgStock.EnableHeadersVisualStyles = false;
            this.dtgStock.Location = new System.Drawing.Point(244, 86);
            this.dtgStock.Name = "dtgStock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgStock.Size = new System.Drawing.Size(758, 370);
            this.dtgStock.TabIndex = 71;
            this.dtgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStock_CellContentClick);
            this.dtgStock.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgCompras_CellPainting);
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(244, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 33);
            this.label3.TabIndex = 72;
            this.label3.Text = "Detalle del Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.metroTextBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(563, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 33);
            this.panel1.TabIndex = 73;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 22;
            this.iconButton5.Location = new System.Drawing.Point(438, 5);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(31, 31);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 20;
            this.iconButton6.Location = new System.Drawing.Point(197, 5);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(31, 23);
            this.iconButton6.TabIndex = 4;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Categoria",
            "Nombre"});
            this.metroComboBox1.Location = new System.Drawing.Point(312, 1);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Filtrar Por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(58, 5);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(156, 23);
            this.metroTextBox3.TabIndex = 1;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgStock);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "GestionStock";
            this.Text = "GestionStock";
            this.Load += new System.EventHandler(this.GestionStock_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgStock;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BtnSelec_Prod;
        private MetroFramework.Controls.MetroTextBox TextProductos;
        private System.Windows.Forms.Label label22;
        private FontAwesome.Sharp.IconButton iconButton18;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox textCapacidad;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox CantProd;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboAlerta;
        private System.Windows.Forms.ComboBox comboEstado;
        private FontAwesome.Sharp.IconButton BtnActualizar;
    }
}