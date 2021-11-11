
namespace TrabajoPractico
{
    partial class ConsultaPrenda
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
            this.grbBoxGrillaPrenda = new System.Windows.Forms.GroupBox();
            this.btnVolverConsultaPrenda = new System.Windows.Forms.Button();
            this.btnEliminarPrenda = new System.Windows.Forms.Button();
            this.gdrConsultaPrenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBoxGrillaPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBoxGrillaPrenda
            // 
            this.grbBoxGrillaPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbBoxGrillaPrenda.Controls.Add(this.label1);
            this.grbBoxGrillaPrenda.Controls.Add(this.btnVolverConsultaPrenda);
            this.grbBoxGrillaPrenda.Controls.Add(this.btnEliminarPrenda);
            this.grbBoxGrillaPrenda.Controls.Add(this.gdrConsultaPrenda);
            this.grbBoxGrillaPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBoxGrillaPrenda.Location = new System.Drawing.Point(122, 50);
            this.grbBoxGrillaPrenda.Name = "grbBoxGrillaPrenda";
            this.grbBoxGrillaPrenda.Size = new System.Drawing.Size(1120, 256);
            this.grbBoxGrillaPrenda.TabIndex = 0;
            this.grbBoxGrillaPrenda.TabStop = false;
            this.grbBoxGrillaPrenda.Text = "";
            // 
            // btnVolverConsultaPrenda
            // 
            this.btnVolverConsultaPrenda.BackColor = System.Drawing.Color.White;
            this.btnVolverConsultaPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverConsultaPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverConsultaPrenda.Location = new System.Drawing.Point(16, 203);
            this.btnVolverConsultaPrenda.Name = "btnVolverConsultaPrenda";
            this.btnVolverConsultaPrenda.Size = new System.Drawing.Size(115, 41);
            this.btnVolverConsultaPrenda.TabIndex = 2;
            this.btnVolverConsultaPrenda.Text = "Volver";
            this.btnVolverConsultaPrenda.UseVisualStyleBackColor = false;
            this.btnVolverConsultaPrenda.Click += new System.EventHandler(this.btnVolverConsultaPrenda_Click);
            // 
            // btnEliminarPrenda
            // 
            this.btnEliminarPrenda.BackColor = System.Drawing.Color.White;
            this.btnEliminarPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPrenda.Location = new System.Drawing.Point(1007, 203);
            this.btnEliminarPrenda.Name = "btnEliminarPrenda";
            this.btnEliminarPrenda.Size = new System.Drawing.Size(107, 41);
            this.btnEliminarPrenda.TabIndex = 1;
            this.btnEliminarPrenda.Text = "Eliminar prenda";
            this.btnEliminarPrenda.UseVisualStyleBackColor = false;
            this.btnEliminarPrenda.Click += new System.EventHandler(this.btnEliminarPrenda_Click);
            // 
            // gdrConsultaPrenda
            // 
            this.gdrConsultaPrenda.AllowUserToAddRows = false;
            this.gdrConsultaPrenda.AllowUserToDeleteRows = false;
            this.gdrConsultaPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultaPrenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CodigoPrenda,
            this.Descripción,
            this.IdTipoPrenda,
            this.PrecioUni,
            this.CantidadStock,
            this.Color,
            this.Marca,
            this.Talle});
            this.gdrConsultaPrenda.Location = new System.Drawing.Point(16, 47);
            this.gdrConsultaPrenda.Name = "gdrConsultaPrenda";
            this.gdrConsultaPrenda.ReadOnly = true;
            this.gdrConsultaPrenda.RowHeadersWidth = 51;
            this.gdrConsultaPrenda.Size = new System.Drawing.Size(1098, 150);
            this.gdrConsultaPrenda.TabIndex = 0;
            this.gdrConsultaPrenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrConsultaPrenda_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos de Prendas";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // CodigoPrenda
            // 
            this.CodigoPrenda.DataPropertyName = "CodigoPrenda";
            this.CodigoPrenda.HeaderText = "CodigoPrenda";
            this.CodigoPrenda.MinimumWidth = 6;
            this.CodigoPrenda.Name = "CodigoPrenda";
            this.CodigoPrenda.ReadOnly = true;
            this.CodigoPrenda.Width = 120;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripción";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 125;
            // 
            // IdTipoPrenda
            // 
            this.IdTipoPrenda.DataPropertyName = "IdTipoPrenda";
            this.IdTipoPrenda.HeaderText = "Tipo Prenda";
            this.IdTipoPrenda.MinimumWidth = 6;
            this.IdTipoPrenda.Name = "IdTipoPrenda";
            this.IdTipoPrenda.ReadOnly = true;
            this.IdTipoPrenda.Width = 125;
            // 
            // PrecioUni
            // 
            this.PrecioUni.DataPropertyName = "PrecioUnitario";
            this.PrecioUni.HeaderText = "PrecioUnitario";
            this.PrecioUni.MinimumWidth = 6;
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.ReadOnly = true;
            this.PrecioUni.Width = 125;
            // 
            // CantidadStock
            // 
            this.CantidadStock.DataPropertyName = "CantidadStock";
            this.CantidadStock.HeaderText = "Cantidad en Stock";
            this.CantidadStock.MinimumWidth = 6;
            this.CantidadStock.Name = "CantidadStock";
            this.CantidadStock.ReadOnly = true;
            this.CantidadStock.Width = 115;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 115;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Talle
            // 
            this.Talle.DataPropertyName = "Talle";
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            this.Talle.Width = 75;
            // 
            // ConsultaPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 347);
            this.Controls.Add(this.grbBoxGrillaPrenda);
            this.Name = "ConsultaPrenda";
            this.ShowIcon = false;
            this.Text = "Consulta de prendas";
            this.grbBoxGrillaPrenda.ResumeLayout(false);
            this.grbBoxGrillaPrenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaPrenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBoxGrillaPrenda;
        private System.Windows.Forms.DataGridView gdrConsultaPrenda;
        private System.Windows.Forms.Button btnEliminarPrenda;
        private System.Windows.Forms.Button btnVolverConsultaPrenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
    }
}