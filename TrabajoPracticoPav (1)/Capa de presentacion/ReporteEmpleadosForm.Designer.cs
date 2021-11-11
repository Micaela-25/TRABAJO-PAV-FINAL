
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class ReporteEmpleadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleadosForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsEmpleadosVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosVentas = new TrabajoPractico.Reportes.DsEmpleadosVentas();
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.btnConsultarEmpleados = new System.Windows.Forms.Button();
            this.dtpFechaHastaEmpleados = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeEmpleados = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblFechaDesdeEmpleados = new System.Windows.Forms.Label();
            this.lblFechaHastaEmpleados = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosVentas)).BeginInit();
            this.grpFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsEmpleadosVentasBindingSource
            // 
            this.dsEmpleadosVentasBindingSource.DataSource = this.dsEmpleadosVentas;
            this.dsEmpleadosVentasBindingSource.Position = 0;
            // 
            // dsEmpleadosVentas
            // 
            this.dsEmpleadosVentas.DataSetName = "DsEmpleadosVentas";
            this.dsEmpleadosVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpFechas
            // 
            this.grpFechas.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpFechas.Controls.Add(this.reportViewer1);
            this.grpFechas.Controls.Add(this.btnVolver);
            this.grpFechas.Controls.Add(this.btnConsultarEmpleados);
            this.grpFechas.Controls.Add(this.dtpFechaHastaEmpleados);
            this.grpFechas.Controls.Add(this.dtpFechaDesdeEmpleados);
            this.grpFechas.Controls.Add(this.lblSeleccion);
            this.grpFechas.Controls.Add(this.lblFechaDesdeEmpleados);
            this.grpFechas.Controls.Add(this.lblFechaHastaEmpleados);
            this.grpFechas.Location = new System.Drawing.Point(84, 110);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(767, 608);
            this.grpFechas.TabIndex = 4;
            this.grpFechas.TabStop = false;
            // 
            // btnConsultarEmpleados
            // 
            this.btnConsultarEmpleados.BackColor = System.Drawing.Color.White;
            this.btnConsultarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarEmpleados.Location = new System.Drawing.Point(522, 68);
            this.btnConsultarEmpleados.Name = "btnConsultarEmpleados";
            this.btnConsultarEmpleados.Size = new System.Drawing.Size(140, 40);
            this.btnConsultarEmpleados.TabIndex = 6;
            this.btnConsultarEmpleados.Text = "Consultar";
            this.btnConsultarEmpleados.UseVisualStyleBackColor = false;
            this.btnConsultarEmpleados.Click += new System.EventHandler(this.btnConsultarEmpleados_Click);
            // 
            // dtpFechaHastaEmpleados
            // 
            this.dtpFechaHastaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaEmpleados.Location = new System.Drawing.Point(156, 88);
            this.dtpFechaHastaEmpleados.Name = "dtpFechaHastaEmpleados";
            this.dtpFechaHastaEmpleados.Size = new System.Drawing.Size(320, 26);
            this.dtpFechaHastaEmpleados.TabIndex = 4;
            // 
            // dtpFechaDesdeEmpleados
            // 
            this.dtpFechaDesdeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesdeEmpleados.Location = new System.Drawing.Point(156, 53);
            this.dtpFechaDesdeEmpleados.Name = "dtpFechaDesdeEmpleados";
            this.dtpFechaDesdeEmpleados.Size = new System.Drawing.Size(320, 26);
            this.dtpFechaDesdeEmpleados.TabIndex = 3;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("lblSeleccion.Image")));
            this.lblSeleccion.Location = new System.Drawing.Point(6, 16);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(193, 24);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Seleccione las fechas";
            // 
            // lblFechaDesdeEmpleados
            // 
            this.lblFechaDesdeEmpleados.AutoSize = true;
            this.lblFechaDesdeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdeEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesdeEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaDesdeEmpleados.Image")));
            this.lblFechaDesdeEmpleados.Location = new System.Drawing.Point(35, 53);
            this.lblFechaDesdeEmpleados.Name = "lblFechaDesdeEmpleados";
            this.lblFechaDesdeEmpleados.Size = new System.Drawing.Size(106, 20);
            this.lblFechaDesdeEmpleados.TabIndex = 0;
            this.lblFechaDesdeEmpleados.Text = "Fecha desde:";
            // 
            // lblFechaHastaEmpleados
            // 
            this.lblFechaHastaEmpleados.AutoSize = true;
            this.lblFechaHastaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaHastaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaHastaEmpleados.Image")));
            this.lblFechaHastaEmpleados.Location = new System.Drawing.Point(39, 88);
            this.lblFechaHastaEmpleados.Name = "lblFechaHastaEmpleados";
            this.lblFechaHastaEmpleados.Size = new System.Drawing.Size(102, 20);
            this.lblFechaHastaEmpleados.TabIndex = 1;
            this.lblFechaHastaEmpleados.Text = "Fecha hasta:";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dsEmpleadosVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPractico.Reportes.rptEmpleadosPorVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 129);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(755, 406);
            this.reportViewer1.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(21, 561);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 40);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ReporteEmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 810);
            this.Controls.Add(this.grpFechas);
            this.Name = "ReporteEmpleadosForm";
            this.ShowIcon = false;
            this.Text = "Reporte de empleados";
            this.Load += new System.EventHandler(this.ReporteEmpleadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosVentas)).EndInit();
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.Button btnConsultarEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeEmpleados;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblFechaDesdeEmpleados;
        private System.Windows.Forms.Label lblFechaHastaEmpleados;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsEmpleadosVentasBindingSource;
        private Reportes.DsEmpleadosVentas dsEmpleadosVentas;
        private System.Windows.Forms.Button btnVolver;
    }
}