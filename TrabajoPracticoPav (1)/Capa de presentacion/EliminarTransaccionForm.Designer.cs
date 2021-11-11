
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class EliminarTransaccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarTransaccionForm));
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gdrEliminarVentas = new System.Windows.Forms.DataGridView();
            this.NroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarEliminar = new System.Windows.Forms.Button();
            this.dtpFechaHastaEliminar = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeEliminar = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblFechaDesdeEliminar = new System.Windows.Forms.Label();
            this.lblFechaHastaEliminar = new System.Windows.Forms.Label();
            this.grpFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEliminarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFechas
            // 
            this.grpFechas.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpFechas.Controls.Add(this.btnVolver);
            this.grpFechas.Controls.Add(this.btnEliminar);
            this.grpFechas.Controls.Add(this.gdrEliminarVentas);
            this.grpFechas.Controls.Add(this.btnConsultarEliminar);
            this.grpFechas.Controls.Add(this.dtpFechaHastaEliminar);
            this.grpFechas.Controls.Add(this.dtpFechaDesdeEliminar);
            this.grpFechas.Controls.Add(this.lblSeleccion);
            this.grpFechas.Controls.Add(this.lblFechaDesdeEliminar);
            this.grpFechas.Controls.Add(this.lblFechaHastaEliminar);
            this.grpFechas.Location = new System.Drawing.Point(101, 96);
            this.grpFechas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFechas.Size = new System.Drawing.Size(946, 543);
            this.grpFechas.TabIndex = 4;
            this.grpFechas.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(32, 469);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(148, 55);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Location = new System.Drawing.Point(745, 480);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 55);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Anular factura";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gdrEliminarVentas
            // 
            this.gdrEliminarVentas.AllowUserToAddRows = false;
            this.gdrEliminarVentas.AllowUserToDeleteRows = false;
            this.gdrEliminarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEliminarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroTicket,
            this.NombreUsuario,
            this.Fecha,
            this.NombreCliente,
            this.FormaPago});
            this.gdrEliminarVentas.Location = new System.Drawing.Point(-3, 193);
            this.gdrEliminarVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdrEliminarVentas.Name = "gdrEliminarVentas";
            this.gdrEliminarVentas.ReadOnly = true;
            this.gdrEliminarVentas.Size = new System.Drawing.Size(941, 268);
            this.gdrEliminarVentas.TabIndex = 5;
            this.gdrEliminarVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEliminarVentas_CellClick);
            // 
            // NroTicket
            // 
            this.NroTicket.HeaderText = "Numero de ticket";
            this.NroTicket.Name = "NroTicket";
            this.NroTicket.ReadOnly = true;
            this.NroTicket.Width = 150;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre del vendedor";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 200;
            // 
            // FormaPago
            // 
            this.FormaPago.HeaderText = "Forma de pago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            this.FormaPago.Width = 150;
            // 
            // btnConsultarEliminar
            // 
            this.btnConsultarEliminar.BackColor = System.Drawing.Color.White;
            this.btnConsultarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarEliminar.Location = new System.Drawing.Point(745, 99);
            this.btnConsultarEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarEliminar.Name = "btnConsultarEliminar";
            this.btnConsultarEliminar.Size = new System.Drawing.Size(148, 56);
            this.btnConsultarEliminar.TabIndex = 6;
            this.btnConsultarEliminar.Text = "Consultar";
            this.btnConsultarEliminar.UseVisualStyleBackColor = false;
            this.btnConsultarEliminar.Click += new System.EventHandler(this.btnConsultarEliminar_Click);
            // 
            // dtpFechaHastaEliminar
            // 
            this.dtpFechaHastaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaEliminar.Location = new System.Drawing.Point(234, 135);
            this.dtpFechaHastaEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaHastaEliminar.Name = "dtpFechaHastaEliminar";
            this.dtpFechaHastaEliminar.Size = new System.Drawing.Size(478, 26);
            this.dtpFechaHastaEliminar.TabIndex = 4;
            // 
            // dtpFechaDesdeEliminar
            // 
            this.dtpFechaDesdeEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesdeEliminar.Location = new System.Drawing.Point(234, 82);
            this.dtpFechaDesdeEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesdeEliminar.Name = "dtpFechaDesdeEliminar";
            this.dtpFechaDesdeEliminar.Size = new System.Drawing.Size(478, 26);
            this.dtpFechaDesdeEliminar.TabIndex = 3;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("lblSeleccion.Image")));
            this.lblSeleccion.Location = new System.Drawing.Point(9, 25);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(193, 24);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Seleccione las fechas";
            // 
            // lblFechaDesdeEliminar
            // 
            this.lblFechaDesdeEliminar.AutoSize = true;
            this.lblFechaDesdeEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdeEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesdeEliminar.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaDesdeEliminar.Image")));
            this.lblFechaDesdeEliminar.Location = new System.Drawing.Point(52, 82);
            this.lblFechaDesdeEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeEliminar.Name = "lblFechaDesdeEliminar";
            this.lblFechaDesdeEliminar.Size = new System.Drawing.Size(106, 20);
            this.lblFechaDesdeEliminar.TabIndex = 0;
            this.lblFechaDesdeEliminar.Text = "Fecha desde:";
            // 
            // lblFechaHastaEliminar
            // 
            this.lblFechaHastaEliminar.AutoSize = true;
            this.lblFechaHastaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaHastaEliminar.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaHastaEliminar.Image")));
            this.lblFechaHastaEliminar.Location = new System.Drawing.Point(58, 135);
            this.lblFechaHastaEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaEliminar.Name = "lblFechaHastaEliminar";
            this.lblFechaHastaEliminar.Size = new System.Drawing.Size(102, 20);
            this.lblFechaHastaEliminar.TabIndex = 1;
            this.lblFechaHastaEliminar.Text = "Fecha hasta:";
            // 
            // EliminarTransaccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 721);
            this.Controls.Add(this.grpFechas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarTransaccionForm";
            this.ShowIcon = false;
            this.Text = "Eliminar ventas";
            this.Load += new System.EventHandler(this.EliminarTransaccionForm_Load);
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEliminarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.Button btnConsultarEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeEliminar;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblFechaDesdeEliminar;
        private System.Windows.Forms.Label lblFechaHastaEliminar;
        private System.Windows.Forms.DataGridView gdrEliminarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
    }
}