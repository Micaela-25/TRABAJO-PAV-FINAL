
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class TransaccionVentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaccionVentaForm));
            this.lblBusquedaVenta = new System.Windows.Forms.Label();
            this.btnAgregarADetalleTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdrPrendaTrans = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarPrenda = new System.Windows.Forms.Button();
            this.txtFiltroCodigoTrans = new System.Windows.Forms.TextBox();
            this.txtCantPrendasTran = new System.Windows.Forms.TextBox();
            this.lblCantPrendasTran = new System.Windows.Forms.Label();
            this.txtSubtotalTran = new System.Windows.Forms.TextBox();
            this.lblSubtotalTran = new System.Windows.Forms.Label();
            this.btnEliminarPrendaDetalleTran = new System.Windows.Forms.Button();
            this.gdrAgregadoADetalleTrans = new System.Windows.Forms.DataGridView();
            this.NombrePrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescrPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TallePrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContinuarVentaTran = new System.Windows.Forms.Button();
            this.grbBuscarPrenda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPrendaTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrAgregadoADetalleTrans)).BeginInit();
            this.grbBuscarPrenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusquedaVenta
            // 
            this.lblBusquedaVenta.AutoSize = true;
            this.lblBusquedaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBusquedaVenta.Image = ((System.Drawing.Image)(resources.GetObject("lblBusquedaVenta.Image")));
            this.lblBusquedaVenta.Location = new System.Drawing.Point(13, 14);
            this.lblBusquedaVenta.Name = "lblBusquedaVenta";
            this.lblBusquedaVenta.Size = new System.Drawing.Size(156, 26);
            this.lblBusquedaVenta.TabIndex = 0;
            this.lblBusquedaVenta.Text = "Buscar Prenda";
            // 
            // btnAgregarADetalleTrans
            // 
            this.btnAgregarADetalleTrans.BackColor = System.Drawing.Color.White;
            this.btnAgregarADetalleTrans.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosita_bebe;
            this.btnAgregarADetalleTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarADetalleTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarADetalleTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarADetalleTrans.Image")));
            this.btnAgregarADetalleTrans.Location = new System.Drawing.Point(805, 159);
            this.btnAgregarADetalleTrans.Name = "btnAgregarADetalleTrans";
            this.btnAgregarADetalleTrans.Size = new System.Drawing.Size(160, 40);
            this.btnAgregarADetalleTrans.TabIndex = 2;
            this.btnAgregarADetalleTrans.Text = "Agregar Prenda";
            this.btnAgregarADetalleTrans.UseVisualStyleBackColor = false;
            this.btnAgregarADetalleTrans.Click += new System.EventHandler(this.btnAgregarADetalleTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el código de la prenda:";
            // 
            // gdrPrendaTrans
            // 
            this.gdrPrendaTrans.AllowUserToAddRows = false;
            this.gdrPrendaTrans.AllowUserToDeleteRows = false;
            this.gdrPrendaTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPrendaTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Código,
            this.Precio,
            this.Stock,
            this.Marca,
            this.Color,
            this.Tipo,
            this.Descripción,
            this.Talle});
            this.gdrPrendaTrans.Location = new System.Drawing.Point(21, 95);
            this.gdrPrendaTrans.Name = "gdrPrendaTrans";
            this.gdrPrendaTrans.ReadOnly = true;
            this.gdrPrendaTrans.Size = new System.Drawing.Size(944, 46);
            this.gdrPrendaTrans.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Talle
            // 
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            // 
            // btnBuscarPrenda
            // 
            this.btnBuscarPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosita_bebe;
            this.btnBuscarPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrenda.Image = global::TrabajoPractico.Properties.Resources._510861_find_magnifying_glass_search_zoom_icon;
            this.btnBuscarPrenda.Location = new System.Drawing.Point(477, 50);
            this.btnBuscarPrenda.Name = "btnBuscarPrenda";
            this.btnBuscarPrenda.Size = new System.Drawing.Size(41, 37);
            this.btnBuscarPrenda.TabIndex = 1;
            this.btnBuscarPrenda.UseVisualStyleBackColor = true;
            this.btnBuscarPrenda.Click += new System.EventHandler(this.btnBuscarPrenda_Click);
            // 
            // txtFiltroCodigoTrans
            // 
            this.txtFiltroCodigoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCodigoTrans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFiltroCodigoTrans.Location = new System.Drawing.Point(248, 58);
            this.txtFiltroCodigoTrans.Name = "txtFiltroCodigoTrans";
            this.txtFiltroCodigoTrans.Size = new System.Drawing.Size(223, 23);
            this.txtFiltroCodigoTrans.TabIndex = 0;
            this.txtFiltroCodigoTrans.Text = "Ingrese el codigo de la prenda...";
            // 
            // txtCantPrendasTran
            // 
            this.txtCantPrendasTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPrendasTran.Location = new System.Drawing.Point(477, 428);
            this.txtCantPrendasTran.Name = "txtCantPrendasTran";
            this.txtCantPrendasTran.Size = new System.Drawing.Size(49, 23);
            this.txtCantPrendasTran.TabIndex = 9;
            // 
            // lblCantPrendasTran
            // 
            this.lblCantPrendasTran.AutoSize = true;
            this.lblCantPrendasTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPrendasTran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantPrendasTran.Image = ((System.Drawing.Image)(resources.GetObject("lblCantPrendasTran.Image")));
            this.lblCantPrendasTran.Location = new System.Drawing.Point(310, 431);
            this.lblCantPrendasTran.Name = "lblCantPrendasTran";
            this.lblCantPrendasTran.Size = new System.Drawing.Size(161, 20);
            this.lblCantPrendasTran.TabIndex = 8;
            this.lblCantPrendasTran.Text = "Cantidad de prendas:";
            // 
            // txtSubtotalTran
            // 
            this.txtSubtotalTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalTran.Location = new System.Drawing.Point(192, 428);
            this.txtSubtotalTran.Name = "txtSubtotalTran";
            this.txtSubtotalTran.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotalTran.TabIndex = 7;
            // 
            // lblSubtotalTran
            // 
            this.lblSubtotalTran.AutoSize = true;
            this.lblSubtotalTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalTran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotalTran.Image = ((System.Drawing.Image)(resources.GetObject("lblSubtotalTran.Image")));
            this.lblSubtotalTran.Location = new System.Drawing.Point(103, 431);
            this.lblSubtotalTran.Name = "lblSubtotalTran";
            this.lblSubtotalTran.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotalTran.TabIndex = 6;
            this.lblSubtotalTran.Text = "Subtotal:";
            // 
            // btnEliminarPrendaDetalleTran
            // 
            this.btnEliminarPrendaDetalleTran.BackColor = System.Drawing.Color.White;
            this.btnEliminarPrendaDetalleTran.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosita_bebe;
            this.btnEliminarPrendaDetalleTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrendaDetalleTran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPrendaDetalleTran.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPrendaDetalleTran.Image")));
            this.btnEliminarPrendaDetalleTran.Location = new System.Drawing.Point(805, 431);
            this.btnEliminarPrendaDetalleTran.Name = "btnEliminarPrendaDetalleTran";
            this.btnEliminarPrendaDetalleTran.Size = new System.Drawing.Size(160, 40);
            this.btnEliminarPrendaDetalleTran.TabIndex = 3;
            this.btnEliminarPrendaDetalleTran.Text = "Eliminar Prenda";
            this.btnEliminarPrendaDetalleTran.UseVisualStyleBackColor = false;
            this.btnEliminarPrendaDetalleTran.Click += new System.EventHandler(this.btnEliminarPrendaDetalleTran_Click);
            // 
            // gdrAgregadoADetalleTrans
            // 
            this.gdrAgregadoADetalleTrans.AllowUserToAddRows = false;
            this.gdrAgregadoADetalleTrans.AllowUserToDeleteRows = false;
            this.gdrAgregadoADetalleTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrAgregadoADetalleTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePrenda,
            this.CodigoPrenda,
            this.PrecioPrenda,
            this.StockInicial,
            this.StockActual,
            this.MarcaPrenda,
            this.ColorPrenda,
            this.TipoPrenda,
            this.DescrPrenda,
            this.TallePrenda});
            this.gdrAgregadoADetalleTrans.Location = new System.Drawing.Point(21, 205);
            this.gdrAgregadoADetalleTrans.Name = "gdrAgregadoADetalleTrans";
            this.gdrAgregadoADetalleTrans.ReadOnly = true;
            this.gdrAgregadoADetalleTrans.Size = new System.Drawing.Size(945, 220);
            this.gdrAgregadoADetalleTrans.TabIndex = 3;
            this.gdrAgregadoADetalleTrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrAgregadoADetalleTrans_CellClick);
            // 
            // NombrePrenda
            // 
            this.NombrePrenda.HeaderText = "Nombre";
            this.NombrePrenda.Name = "NombrePrenda";
            this.NombrePrenda.ReadOnly = true;
            // 
            // CodigoPrenda
            // 
            this.CodigoPrenda.HeaderText = "CodigoPrenda";
            this.CodigoPrenda.Name = "CodigoPrenda";
            this.CodigoPrenda.ReadOnly = true;
            this.CodigoPrenda.Width = 80;
            // 
            // PrecioPrenda
            // 
            this.PrecioPrenda.HeaderText = "Precio";
            this.PrecioPrenda.Name = "PrecioPrenda";
            this.PrecioPrenda.ReadOnly = true;
            // 
            // StockInicial
            // 
            this.StockInicial.HeaderText = "Stock inicial";
            this.StockInicial.Name = "StockInicial";
            this.StockInicial.ReadOnly = true;
            // 
            // StockActual
            // 
            this.StockActual.HeaderText = "Stock actual";
            this.StockActual.Name = "StockActual";
            this.StockActual.ReadOnly = true;
            // 
            // MarcaPrenda
            // 
            this.MarcaPrenda.HeaderText = "Marca";
            this.MarcaPrenda.Name = "MarcaPrenda";
            this.MarcaPrenda.ReadOnly = true;
            // 
            // ColorPrenda
            // 
            this.ColorPrenda.HeaderText = "Color";
            this.ColorPrenda.Name = "ColorPrenda";
            this.ColorPrenda.ReadOnly = true;
            // 
            // TipoPrenda
            // 
            this.TipoPrenda.HeaderText = "Tipo";
            this.TipoPrenda.Name = "TipoPrenda";
            this.TipoPrenda.ReadOnly = true;
            this.TipoPrenda.Width = 50;
            // 
            // DescrPrenda
            // 
            this.DescrPrenda.HeaderText = "Descripción";
            this.DescrPrenda.Name = "DescrPrenda";
            this.DescrPrenda.ReadOnly = true;
            // 
            // TallePrenda
            // 
            this.TallePrenda.HeaderText = "Talle";
            this.TallePrenda.Name = "TallePrenda";
            this.TallePrenda.ReadOnly = true;
            this.TallePrenda.Width = 80;
            // 
            // btnContinuarVentaTran
            // 
            this.btnContinuarVentaTran.BackColor = System.Drawing.Color.White;
            this.btnContinuarVentaTran.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosita_bebe;
            this.btnContinuarVentaTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarVentaTran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinuarVentaTran.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuarVentaTran.Image")));
            this.btnContinuarVentaTran.Location = new System.Drawing.Point(806, 477);
            this.btnContinuarVentaTran.Name = "btnContinuarVentaTran";
            this.btnContinuarVentaTran.Size = new System.Drawing.Size(160, 43);
            this.btnContinuarVentaTran.TabIndex = 4;
            this.btnContinuarVentaTran.Text = "Continuar venta";
            this.btnContinuarVentaTran.UseVisualStyleBackColor = false;
            this.btnContinuarVentaTran.Click += new System.EventHandler(this.btnContinuarVentaTran_Click);
            // 
            // grbBuscarPrenda
            // 
            this.grbBuscarPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbBuscarPrenda.Controls.Add(this.lblBusquedaVenta);
            this.grbBuscarPrenda.Controls.Add(this.btnEliminarPrendaDetalleTran);
            this.grbBuscarPrenda.Controls.Add(this.txtFiltroCodigoTrans);
            this.grbBuscarPrenda.Controls.Add(this.txtCantPrendasTran);
            this.grbBuscarPrenda.Controls.Add(this.btnBuscarPrenda);
            this.grbBuscarPrenda.Controls.Add(this.btnAgregarADetalleTrans);
            this.grbBuscarPrenda.Controls.Add(this.gdrPrendaTrans);
            this.grbBuscarPrenda.Controls.Add(this.lblCantPrendasTran);
            this.grbBuscarPrenda.Controls.Add(this.gdrAgregadoADetalleTrans);
            this.grbBuscarPrenda.Controls.Add(this.btnContinuarVentaTran);
            this.grbBuscarPrenda.Controls.Add(this.lblSubtotalTran);
            this.grbBuscarPrenda.Controls.Add(this.txtSubtotalTran);
            this.grbBuscarPrenda.Controls.Add(this.label1);
            this.grbBuscarPrenda.Location = new System.Drawing.Point(107, 99);
            this.grbBuscarPrenda.Name = "grbBuscarPrenda";
            this.grbBuscarPrenda.Size = new System.Drawing.Size(983, 532);
            this.grbBuscarPrenda.TabIndex = 10;
            this.grbBuscarPrenda.TabStop = false;
            // 
            // TransaccionVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.grbBuscarPrenda);
            this.Name = "TransaccionVentaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.gdrPrendaTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrAgregadoADetalleTrans)).EndInit();
            this.grbBuscarPrenda.ResumeLayout(false);
            this.grbBuscarPrenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaVenta;
        private System.Windows.Forms.Button btnBuscarPrenda;
        private System.Windows.Forms.TextBox txtFiltroCodigoTrans;
        private System.Windows.Forms.DataGridView gdrPrendaTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarADetalleTrans;
        private System.Windows.Forms.TextBox txtCantPrendasTran;
        private System.Windows.Forms.Label lblCantPrendasTran;
        private System.Windows.Forms.TextBox txtSubtotalTran;
        private System.Windows.Forms.Label lblSubtotalTran;
        private System.Windows.Forms.Button btnEliminarPrendaDetalleTran;
        private System.Windows.Forms.Button btnContinuarVentaTran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
        private System.Windows.Forms.DataGridView gdrAgregadoADetalleTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescrPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TallePrenda;
        private System.Windows.Forms.GroupBox grbBuscarPrenda;
    }
}