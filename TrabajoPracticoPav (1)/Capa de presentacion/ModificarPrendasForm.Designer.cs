
namespace TrabajoPractico
{
    partial class ModificarPrendasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPrendasForm));
            this.grpModificarPrenda = new System.Windows.Forms.GroupBox();
            this.lblTallePrenda = new System.Windows.Forms.Label();
            this.txtModificarCantidadPrendas = new System.Windows.Forms.TextBox();
            this.cmbModificarTipoPrenda = new System.Windows.Forms.ComboBox();
            this.txtModificarPrecioUnitarioPrenda = new System.Windows.Forms.TextBox();
            this.txtModificarDescripcionPrenda = new System.Windows.Forms.TextBox();
            this.txtModificarColorPrenda = new System.Windows.Forms.TextBox();
            this.txtModificarMarcaPrenda = new System.Windows.Forms.TextBox();
            this.txtModificarNombrePrenda = new System.Windows.Forms.TextBox();
            this.lblModificarMarcaPrenda = new System.Windows.Forms.Label();
            this.lblModificarColorPrenda = new System.Windows.Forms.Label();
            this.lblModificarDescripciónPrenda = new System.Windows.Forms.Label();
            this.lblModificarPrecioUnitarioPrenda = new System.Windows.Forms.Label();
            this.lblModificarTipoPrenda = new System.Windows.Forms.Label();
            this.lblModificarCantidadPrenda = new System.Windows.Forms.Label();
            this.lblModificarNombrePrenda = new System.Windows.Forms.Label();
            this.btnVolverAltaPrenda = new System.Windows.Forms.Button();
            this.btnModificarRegistrarPrenda = new System.Windows.Forms.Button();
            this.btnLimpiarCamposPrenda = new System.Windows.Forms.Button();
            this.gdrModificarPrenda = new System.Windows.Forms.DataGridView();
            this.grpModifcarGrande = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTalle = new System.Windows.Forms.ComboBox();
            this.grpModificarPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrModificarPrenda)).BeginInit();
            this.grpModifcarGrande.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarPrenda
            // 
            this.grpModificarPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpModificarPrenda.Controls.Add(this.cmbTalle);
            this.grpModificarPrenda.Controls.Add(this.lblTallePrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarCantidadPrendas);
            this.grpModificarPrenda.Controls.Add(this.cmbModificarTipoPrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarPrecioUnitarioPrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarDescripcionPrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarColorPrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarMarcaPrenda);
            this.grpModificarPrenda.Controls.Add(this.txtModificarNombrePrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarMarcaPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarColorPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarDescripciónPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarPrecioUnitarioPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarTipoPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarCantidadPrenda);
            this.grpModificarPrenda.Controls.Add(this.lblModificarNombrePrenda);
            this.grpModificarPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpModificarPrenda.Location = new System.Drawing.Point(18, 23);
            this.grpModificarPrenda.Name = "grpModificarPrenda";
            this.grpModificarPrenda.Size = new System.Drawing.Size(976, 161);
            this.grpModificarPrenda.TabIndex = 1;
            this.grpModificarPrenda.TabStop = false;
            this.grpModificarPrenda.Text = "Modificar Prenda";
            // 
            // lblTallePrenda
            // 
            this.lblTallePrenda.AutoSize = true;
            this.lblTallePrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallePrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTallePrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblTallePrenda.Image")));
            this.lblTallePrenda.Location = new System.Drawing.Point(379, 121);
            this.lblTallePrenda.Name = "lblTallePrenda";
            this.lblTallePrenda.Size = new System.Drawing.Size(46, 20);
            this.lblTallePrenda.TabIndex = 9;
            this.lblTallePrenda.Text = "Talle:";
            // 
            // txtModificarCantidadPrendas
            // 
            this.txtModificarCantidadPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarCantidadPrendas.Location = new System.Drawing.Point(768, 56);
            this.txtModificarCantidadPrendas.Name = "txtModificarCantidadPrendas";
            this.txtModificarCantidadPrendas.Size = new System.Drawing.Size(150, 24);
            this.txtModificarCantidadPrendas.TabIndex = 7;
            // 
            // cmbModificarTipoPrenda
            // 
            this.cmbModificarTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModificarTipoPrenda.FormattingEnabled = true;
            this.cmbModificarTipoPrenda.Location = new System.Drawing.Point(431, 84);
            this.cmbModificarTipoPrenda.Name = "cmbModificarTipoPrenda";
            this.cmbModificarTipoPrenda.Size = new System.Drawing.Size(150, 26);
            this.cmbModificarTipoPrenda.TabIndex = 6;
            // 
            // txtModificarPrecioUnitarioPrenda
            // 
            this.txtModificarPrecioUnitarioPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarPrecioUnitarioPrenda.Location = new System.Drawing.Point(431, 49);
            this.txtModificarPrecioUnitarioPrenda.Name = "txtModificarPrecioUnitarioPrenda";
            this.txtModificarPrecioUnitarioPrenda.Size = new System.Drawing.Size(150, 24);
            this.txtModificarPrecioUnitarioPrenda.TabIndex = 5;
            // 
            // txtModificarDescripcionPrenda
            // 
            this.txtModificarDescripcionPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarDescripcionPrenda.Location = new System.Drawing.Point(116, 84);
            this.txtModificarDescripcionPrenda.Name = "txtModificarDescripcionPrenda";
            this.txtModificarDescripcionPrenda.Size = new System.Drawing.Size(150, 24);
            this.txtModificarDescripcionPrenda.TabIndex = 2;
            // 
            // txtModificarColorPrenda
            // 
            this.txtModificarColorPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarColorPrenda.Location = new System.Drawing.Point(768, 94);
            this.txtModificarColorPrenda.Name = "txtModificarColorPrenda";
            this.txtModificarColorPrenda.Size = new System.Drawing.Size(150, 24);
            this.txtModificarColorPrenda.TabIndex = 4;
            // 
            // txtModificarMarcaPrenda
            // 
            this.txtModificarMarcaPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarMarcaPrenda.Location = new System.Drawing.Point(116, 119);
            this.txtModificarMarcaPrenda.Name = "txtModificarMarcaPrenda";
            this.txtModificarMarcaPrenda.Size = new System.Drawing.Size(150, 24);
            this.txtModificarMarcaPrenda.TabIndex = 3;
            // 
            // txtModificarNombrePrenda
            // 
            this.txtModificarNombrePrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarNombrePrenda.Location = new System.Drawing.Point(116, 49);
            this.txtModificarNombrePrenda.Name = "txtModificarNombrePrenda";
            this.txtModificarNombrePrenda.Size = new System.Drawing.Size(150, 24);
            this.txtModificarNombrePrenda.TabIndex = 1;
            // 
            // lblModificarMarcaPrenda
            // 
            this.lblModificarMarcaPrenda.AutoSize = true;
            this.lblModificarMarcaPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMarcaPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarMarcaPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarMarcaPrenda.Image")));
            this.lblModificarMarcaPrenda.Location = new System.Drawing.Point(56, 122);
            this.lblModificarMarcaPrenda.Name = "lblModificarMarcaPrenda";
            this.lblModificarMarcaPrenda.Size = new System.Drawing.Size(57, 20);
            this.lblModificarMarcaPrenda.TabIndex = 7;
            this.lblModificarMarcaPrenda.Text = "Marca:";
            // 
            // lblModificarColorPrenda
            // 
            this.lblModificarColorPrenda.AutoSize = true;
            this.lblModificarColorPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarColorPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarColorPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarColorPrenda.Image")));
            this.lblModificarColorPrenda.Location = new System.Drawing.Point(712, 94);
            this.lblModificarColorPrenda.Name = "lblModificarColorPrenda";
            this.lblModificarColorPrenda.Size = new System.Drawing.Size(50, 20);
            this.lblModificarColorPrenda.TabIndex = 6;
            this.lblModificarColorPrenda.Text = "Color:";
            // 
            // lblModificarDescripciónPrenda
            // 
            this.lblModificarDescripciónPrenda.AutoSize = true;
            this.lblModificarDescripciónPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarDescripciónPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarDescripciónPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarDescripciónPrenda.Image")));
            this.lblModificarDescripciónPrenda.Location = new System.Drawing.Point(19, 91);
            this.lblModificarDescripciónPrenda.Name = "lblModificarDescripciónPrenda";
            this.lblModificarDescripciónPrenda.Size = new System.Drawing.Size(96, 20);
            this.lblModificarDescripciónPrenda.TabIndex = 5;
            this.lblModificarDescripciónPrenda.Text = "Descripción:";
            // 
            // lblModificarPrecioUnitarioPrenda
            // 
            this.lblModificarPrecioUnitarioPrenda.AutoSize = true;
            this.lblModificarPrecioUnitarioPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPrecioUnitarioPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarPrecioUnitarioPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarPrecioUnitarioPrenda.Image")));
            this.lblModificarPrecioUnitarioPrenda.Location = new System.Drawing.Point(312, 54);
            this.lblModificarPrecioUnitarioPrenda.Name = "lblModificarPrecioUnitarioPrenda";
            this.lblModificarPrecioUnitarioPrenda.Size = new System.Drawing.Size(113, 20);
            this.lblModificarPrecioUnitarioPrenda.TabIndex = 4;
            this.lblModificarPrecioUnitarioPrenda.Text = "Precio unitario:";
            // 
            // lblModificarTipoPrenda
            // 
            this.lblModificarTipoPrenda.AutoSize = true;
            this.lblModificarTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarTipoPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarTipoPrenda.Image")));
            this.lblModificarTipoPrenda.Location = new System.Drawing.Point(309, 89);
            this.lblModificarTipoPrenda.Name = "lblModificarTipoPrenda";
            this.lblModificarTipoPrenda.Size = new System.Drawing.Size(119, 20);
            this.lblModificarTipoPrenda.TabIndex = 3;
            this.lblModificarTipoPrenda.Text = "Tipo de prenda:";
            // 
            // lblModificarCantidadPrenda
            // 
            this.lblModificarCantidadPrenda.AutoSize = true;
            this.lblModificarCantidadPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCantidadPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarCantidadPrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarCantidadPrenda.Image")));
            this.lblModificarCantidadPrenda.Location = new System.Drawing.Point(601, 55);
            this.lblModificarCantidadPrenda.Name = "lblModificarCantidadPrenda";
            this.lblModificarCantidadPrenda.Size = new System.Drawing.Size(161, 20);
            this.lblModificarCantidadPrenda.TabIndex = 2;
            this.lblModificarCantidadPrenda.Text = "Cantidad de prendas:";
            // 
            // lblModificarNombrePrenda
            // 
            this.lblModificarNombrePrenda.AutoSize = true;
            this.lblModificarNombrePrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarNombrePrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificarNombrePrenda.Image = ((System.Drawing.Image)(resources.GetObject("lblModificarNombrePrenda.Image")));
            this.lblModificarNombrePrenda.Location = new System.Drawing.Point(40, 56);
            this.lblModificarNombrePrenda.Name = "lblModificarNombrePrenda";
            this.lblModificarNombrePrenda.Size = new System.Drawing.Size(73, 20);
            this.lblModificarNombrePrenda.TabIndex = 0;
            this.lblModificarNombrePrenda.Text = "Nombre: ";
            // 
            // btnVolverAltaPrenda
            // 
            this.btnVolverAltaPrenda.BackColor = System.Drawing.Color.White;
            this.btnVolverAltaPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAltaPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverAltaPrenda.Location = new System.Drawing.Point(18, 389);
            this.btnVolverAltaPrenda.Name = "btnVolverAltaPrenda";
            this.btnVolverAltaPrenda.Size = new System.Drawing.Size(108, 37);
            this.btnVolverAltaPrenda.TabIndex = 17;
            this.btnVolverAltaPrenda.Text = "Volver";
            this.btnVolverAltaPrenda.UseVisualStyleBackColor = false;
            this.btnVolverAltaPrenda.Click += new System.EventHandler(this.btnVolverAltaPrenda_Click);
            // 
            // btnModificarRegistrarPrenda
            // 
            this.btnModificarRegistrarPrenda.BackColor = System.Drawing.Color.White;
            this.btnModificarRegistrarPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRegistrarPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarRegistrarPrenda.Location = new System.Drawing.Point(835, 389);
            this.btnModificarRegistrarPrenda.Name = "btnModificarRegistrarPrenda";
            this.btnModificarRegistrarPrenda.Size = new System.Drawing.Size(116, 37);
            this.btnModificarRegistrarPrenda.TabIndex = 16;
            this.btnModificarRegistrarPrenda.Text = "Modificar ";
            this.btnModificarRegistrarPrenda.UseVisualStyleBackColor = false;
            this.btnModificarRegistrarPrenda.Click += new System.EventHandler(this.btnModificarRegistrarPrenda_Click);
            // 
            // btnLimpiarCamposPrenda
            // 
            this.btnLimpiarCamposPrenda.BackColor = System.Drawing.Color.White;
            this.btnLimpiarCamposPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarCamposPrenda.Location = new System.Drawing.Point(711, 389);
            this.btnLimpiarCamposPrenda.Name = "btnLimpiarCamposPrenda";
            this.btnLimpiarCamposPrenda.Size = new System.Drawing.Size(108, 37);
            this.btnLimpiarCamposPrenda.TabIndex = 15;
            this.btnLimpiarCamposPrenda.Text = "Limpiar";
            this.btnLimpiarCamposPrenda.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposPrenda.Click += new System.EventHandler(this.btnLimpiarCamposPrenda_Click);
            // 
            // gdrModificarPrenda
            // 
            this.gdrModificarPrenda.AllowUserToAddRows = false;
            this.gdrModificarPrenda.AllowUserToDeleteRows = false;
            this.gdrModificarPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrModificarPrenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CodigoPrenda,
            this.Descripción,
            this.IdTipoPrenda,
            this.PrecioUni,
            this.CantidadStock,
            this.Color,
            this.Marca,
            this.Talle});
            this.gdrModificarPrenda.Location = new System.Drawing.Point(18, 209);
            this.gdrModificarPrenda.Name = "gdrModificarPrenda";
            this.gdrModificarPrenda.ReadOnly = true;
            this.gdrModificarPrenda.Size = new System.Drawing.Size(1005, 150);
            this.gdrModificarPrenda.TabIndex = 2;
            this.gdrModificarPrenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrModificarPrenda_CellClick);
            // 
            // grpModifcarGrande
            // 
            this.grpModifcarGrande.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpModifcarGrande.Controls.Add(this.gdrModificarPrenda);
            this.grpModifcarGrande.Controls.Add(this.btnVolverAltaPrenda);
            this.grpModifcarGrande.Controls.Add(this.btnLimpiarCamposPrenda);
            this.grpModifcarGrande.Controls.Add(this.grpModificarPrenda);
            this.grpModifcarGrande.Controls.Add(this.btnModificarRegistrarPrenda);
            this.grpModifcarGrande.Location = new System.Drawing.Point(105, 84);
            this.grpModifcarGrande.Name = "grpModifcarGrande";
            this.grpModifcarGrande.Size = new System.Drawing.Size(1041, 463);
            this.grpModifcarGrande.TabIndex = 18;
            this.grpModifcarGrande.TabStop = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // CodigoPrenda
            // 
            this.CodigoPrenda.DataPropertyName = "CodigoPrenda";
            this.CodigoPrenda.HeaderText = "CodigoPrenda";
            this.CodigoPrenda.Name = "CodigoPrenda";
            this.CodigoPrenda.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripción";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 150;
            // 
            // IdTipoPrenda
            // 
            this.IdTipoPrenda.DataPropertyName = "IdTipoPrenda";
            this.IdTipoPrenda.HeaderText = "Tipo Prenda";
            this.IdTipoPrenda.Name = "IdTipoPrenda";
            this.IdTipoPrenda.ReadOnly = true;
            // 
            // PrecioUni
            // 
            this.PrecioUni.DataPropertyName = "PrecioUnitario";
            this.PrecioUni.HeaderText = "PrecioUnitario";
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.ReadOnly = true;
            this.PrecioUni.Width = 120;
            // 
            // CantidadStock
            // 
            this.CantidadStock.DataPropertyName = "CantidadStock";
            this.CantidadStock.HeaderText = "Cantidad en Stock";
            this.CantidadStock.Name = "CantidadStock";
            this.CantidadStock.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Talle
            // 
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            this.Talle.Width = 85;
            // 
            // cmbTalle
            // 
            this.cmbTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTalle.FormattingEnabled = true;
            this.cmbTalle.Location = new System.Drawing.Point(431, 119);
            this.cmbTalle.Name = "cmbTalle";
            this.cmbTalle.Size = new System.Drawing.Size(150, 26);
            this.cmbTalle.TabIndex = 10;
            // 
            // ModificarPrendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 617);
            this.Controls.Add(this.grpModifcarGrande);
            this.Name = "ModificarPrendasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Prendas";
            this.Load += new System.EventHandler(this.ModificarPrendasForm_Load);
            this.grpModificarPrenda.ResumeLayout(false);
            this.grpModificarPrenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrModificarPrenda)).EndInit();
            this.grpModifcarGrande.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarPrenda;
        private System.Windows.Forms.Button btnVolverAltaPrenda;
        private System.Windows.Forms.Button btnModificarRegistrarPrenda;
        private System.Windows.Forms.Button btnLimpiarCamposPrenda;
        private System.Windows.Forms.TextBox txtModificarCantidadPrendas;
        private System.Windows.Forms.ComboBox cmbModificarTipoPrenda;
        private System.Windows.Forms.TextBox txtModificarPrecioUnitarioPrenda;
        private System.Windows.Forms.TextBox txtModificarDescripcionPrenda;
        private System.Windows.Forms.TextBox txtModificarColorPrenda;
        private System.Windows.Forms.TextBox txtModificarMarcaPrenda;
        private System.Windows.Forms.TextBox txtModificarNombrePrenda;
        private System.Windows.Forms.Label lblModificarMarcaPrenda;
        private System.Windows.Forms.Label lblModificarColorPrenda;
        private System.Windows.Forms.Label lblModificarDescripciónPrenda;
        private System.Windows.Forms.Label lblModificarPrecioUnitarioPrenda;
        private System.Windows.Forms.Label lblModificarTipoPrenda;
        private System.Windows.Forms.Label lblModificarCantidadPrenda;
        private System.Windows.Forms.Label lblModificarNombrePrenda;
        private System.Windows.Forms.DataGridView gdrModificarPrenda;
        private System.Windows.Forms.Label lblTallePrenda;
        private System.Windows.Forms.GroupBox grpModifcarGrande;
        private System.Windows.Forms.ComboBox cmbTalle;
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