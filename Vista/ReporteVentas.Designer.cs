namespace BDS.Vista
{
    partial class ReporteVentas
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
            this.Reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fin = new MetroFramework.Controls.MetroDateTime();
            this.Inicio = new MetroFramework.Controls.MetroDateTime();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(153, 1);
            this.Reporte.Name = "Reporte";
            this.Reporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.Reporte.ServerReport.BearerToken = null;
            this.Reporte.Size = new System.Drawing.Size(795, 468);
            this.Reporte.TabIndex = 0;
            this.Reporte.Load += new System.EventHandler(this.Reporte_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fin);
            this.panel1.Controls.Add(this.Inicio);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 479);
            this.panel1.TabIndex = 2;
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(14, 225);
            this.Fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(115, 29);
            this.Fin.TabIndex = 4;
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(12, 183);
            this.Inicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(115, 29);
            this.Inicio.TabIndex = 3;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(30, 92);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(97, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Mes";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(30, 128);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Trimestre";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(30, 51);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Semana";
            this.metroButton1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte de Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::BDS.Properties.Resources.beraka_transparent_logo;
            this.pictureBox1.Location = new System.Drawing.Point(186, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reporte);
            this.Name = "ReporteVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Reporte;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime Fin;
        private MetroFramework.Controls.MetroDateTime Inicio;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}