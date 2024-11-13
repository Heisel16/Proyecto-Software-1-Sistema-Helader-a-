namespace BDS.Vista.Recursos
{
    partial class TablaCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBuscar = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.texEst = new MetroFramework.Controls.MetroTextBox();
            this.textcateg = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textId = new System.Windows.Forms.TextBox();
            this.Refrescar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCategoria
            // 
            this.GridCategoria.AllowUserToAddRows = false;
            this.GridCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCategoria.ColumnHeadersHeight = 35;
            this.GridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCategoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridCategoria.EnableHeadersVisualStyles = false;
            this.GridCategoria.Location = new System.Drawing.Point(241, 89);
            this.GridCategoria.Name = "GridCategoria";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridCategoria.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridCategoria.Size = new System.Drawing.Size(491, 257);
            this.GridCategoria.TabIndex = 58;
            this.GridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCategoria_CellContentClick);
            this.GridCategoria.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridCategoria_CellPainting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refrescar);
            this.groupBox1.Controls.Add(this.textBuscar);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 76);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Categorias";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBuscar
            // 
            // 
            // 
            // 
            this.textBuscar.CustomButton.Image = null;
            this.textBuscar.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.textBuscar.CustomButton.Name = "";
            this.textBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBuscar.CustomButton.TabIndex = 1;
            this.textBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBuscar.CustomButton.UseSelectable = true;
            this.textBuscar.CustomButton.Visible = false;
            this.textBuscar.Lines = new string[0];
            this.textBuscar.Location = new System.Drawing.Point(89, 41);
            this.textBuscar.MaxLength = 32767;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.PasswordChar = '\0';
            this.textBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBuscar.SelectedText = "";
            this.textBuscar.SelectionLength = 0;
            this.textBuscar.SelectionStart = 0;
            this.textBuscar.ShortcutsEnabled = true;
            this.textBuscar.Size = new System.Drawing.Size(131, 23);
            this.textBuscar.TabIndex = 51;
            this.textBuscar.UseSelectable = true;
            this.textBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.BtnBuscar.Location = new System.Drawing.Point(221, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 23);
            this.BtnBuscar.TabIndex = 54;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Buscar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textId);
            this.groupBox2.Controls.Add(this.BtnEditar);
            this.groupBox2.Controls.Add(this.iconButton13);
            this.groupBox2.Controls.Add(this.iconButton10);
            this.groupBox2.Controls.Add(this.texEst);
            this.groupBox2.Controls.Add(this.textcateg);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 333);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Categoria";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(214)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Window;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.Location = new System.Drawing.Point(35, 258);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(144, 35);
            this.BtnEditar.TabIndex = 55;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton13.FlatAppearance.BorderSize = 0;
            this.iconButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.iconButton13.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton13.IconSize = 18;
            this.iconButton13.Location = new System.Drawing.Point(18, 81);
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Size = new System.Drawing.Size(23, 22);
            this.iconButton13.TabIndex = 52;
            this.iconButton13.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 18;
            this.iconButton10.Location = new System.Drawing.Point(18, 142);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(23, 21);
            this.iconButton10.TabIndex = 51;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // texEst
            // 
            // 
            // 
            // 
            this.texEst.CustomButton.Image = null;
            this.texEst.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.texEst.CustomButton.Name = "";
            this.texEst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.texEst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.texEst.CustomButton.TabIndex = 1;
            this.texEst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.texEst.CustomButton.UseSelectable = true;
            this.texEst.CustomButton.Visible = false;
            this.texEst.Lines = new string[0];
            this.texEst.Location = new System.Drawing.Point(18, 163);
            this.texEst.MaxLength = 32767;
            this.texEst.Name = "texEst";
            this.texEst.PasswordChar = '\0';
            this.texEst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.texEst.SelectedText = "";
            this.texEst.SelectionLength = 0;
            this.texEst.SelectionStart = 0;
            this.texEst.ShortcutsEnabled = true;
            this.texEst.Size = new System.Drawing.Size(187, 23);
            this.texEst.TabIndex = 49;
            this.texEst.UseSelectable = true;
            this.texEst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.texEst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textcateg
            // 
            // 
            // 
            // 
            this.textcateg.CustomButton.Image = null;
            this.textcateg.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.textcateg.CustomButton.Name = "";
            this.textcateg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textcateg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textcateg.CustomButton.TabIndex = 1;
            this.textcateg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textcateg.CustomButton.UseSelectable = true;
            this.textcateg.CustomButton.Visible = false;
            this.textcateg.Lines = new string[0];
            this.textcateg.Location = new System.Drawing.Point(18, 103);
            this.textcateg.MaxLength = 32767;
            this.textcateg.Name = "textcateg";
            this.textcateg.PasswordChar = '\0';
            this.textcateg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textcateg.SelectedText = "";
            this.textcateg.SelectionLength = 0;
            this.textcateg.SelectionStart = 0;
            this.textcateg.ShortcutsEnabled = true;
            this.textcateg.Size = new System.Drawing.Size(187, 23);
            this.textcateg.TabIndex = 48;
            this.textcateg.UseSelectable = true;
            this.textcateg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textcateg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "Descripcion de la categoria";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(159)))), ((int)(((byte)(73)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnAgregar.IconColor = System.Drawing.SystemColors.Window;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 30;
            this.BtnAgregar.Location = new System.Drawing.Point(35, 217);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 35);
            this.BtnAgregar.TabIndex = 34;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(193, 24);
            this.textId.Multiline = true;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(23, 20);
            this.textId.TabIndex = 56;
            this.textId.Visible = false;
            // 
            // Refrescar
            // 
            this.Refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.Refrescar.FlatAppearance.BorderSize = 0;
            this.Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refrescar.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.Refrescar.IconColor = System.Drawing.Color.White;
            this.Refrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Refrescar.IconSize = 22;
            this.Refrescar.Location = new System.Drawing.Point(257, 41);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(31, 23);
            this.Refrescar.TabIndex = 55;
            this.Refrescar.UseVisualStyleBackColor = false;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // TablaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridCategoria);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaCategorias";
            this.Load += new System.EventHandler(this.TablaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox textBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton iconButton13;
        private FontAwesome.Sharp.IconButton iconButton10;
        private MetroFramework.Controls.MetroTextBox texEst;
        private MetroFramework.Controls.MetroTextBox textcateg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.TextBox textId;
        private FontAwesome.Sharp.IconButton Refrescar;
    }
}