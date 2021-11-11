
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class ModificarTipoPrendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTipoPrendaForm));
            this.btnModificarTipoPrenda = new System.Windows.Forms.Button();
            this.txtActualizarDescripciónTipo = new System.Windows.Forms.TextBox();
            this.lblModificaciónDescrTipo = new System.Windows.Forms.Label();
            this.lblModificaciónNombreTipo = new System.Windows.Forms.Label();
            this.txtActualizarNombreTipo = new System.Windows.Forms.TextBox();
            this.btnVolverActualizarTipo = new System.Windows.Forms.Button();
            this.lblModificaciónTipoPrenda = new System.Windows.Forms.Label();
            this.grbModificaciónTiposPrenda = new System.Windows.Forms.GroupBox();
            this.gdrConsultaTipoPrenda = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbModificacionTipoPrenda = new System.Windows.Forms.GroupBox();
            this.grbModificaciónTiposPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoPrenda)).BeginInit();
            this.grbModificacionTipoPrenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarTipoPrenda
            // 
            this.btnModificarTipoPrenda.BackColor = System.Drawing.Color.White;
            this.btnModificarTipoPrenda.Enabled = false;
            this.btnModificarTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarTipoPrenda.Location = new System.Drawing.Point(339, 353);
            this.btnModificarTipoPrenda.Name = "btnModificarTipoPrenda";
            this.btnModificarTipoPrenda.Size = new System.Drawing.Size(152, 40);
            this.btnModificarTipoPrenda.TabIndex = 10;
            this.btnModificarTipoPrenda.Text = "Modificar";
            this.btnModificarTipoPrenda.UseVisualStyleBackColor = false;
            this.btnModificarTipoPrenda.Click += new System.EventHandler(this.btnModificarTipoPrenda_Click);
            // 
            // txtActualizarDescripciónTipo
            // 
            this.txtActualizarDescripciónTipo.Enabled = false;
            this.txtActualizarDescripciónTipo.Location = new System.Drawing.Point(239, 313);
            this.txtActualizarDescripciónTipo.Name = "txtActualizarDescripciónTipo";
            this.txtActualizarDescripciónTipo.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarDescripciónTipo.TabIndex = 12;
            // 
            // lblModificaciónDescrTipo
            // 
            this.lblModificaciónDescrTipo.AutoSize = true;
            this.lblModificaciónDescrTipo.Enabled = false;
            this.lblModificaciónDescrTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónDescrTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónDescrTipo.Image = ((System.Drawing.Image)(resources.GetObject("lblModificaciónDescrTipo.Image")));
            this.lblModificaciónDescrTipo.Location = new System.Drawing.Point(32, 311);
            this.lblModificaciónDescrTipo.Name = "lblModificaciónDescrTipo";
            this.lblModificaciónDescrTipo.Size = new System.Drawing.Size(198, 20);
            this.lblModificaciónDescrTipo.TabIndex = 17;
            this.lblModificaciónDescrTipo.Text = "Ingrese nueva descripción:";
            // 
            // lblModificaciónNombreTipo
            // 
            this.lblModificaciónNombreTipo.AutoSize = true;
            this.lblModificaciónNombreTipo.Enabled = false;
            this.lblModificaciónNombreTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónNombreTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónNombreTipo.Image = ((System.Drawing.Image)(resources.GetObject("lblModificaciónNombreTipo.Image")));
            this.lblModificaciónNombreTipo.Location = new System.Drawing.Point(6, 271);
            this.lblModificaciónNombreTipo.Name = "lblModificaciónNombreTipo";
            this.lblModificaciónNombreTipo.Size = new System.Drawing.Size(227, 20);
            this.lblModificaciónNombreTipo.TabIndex = 16;
            this.lblModificaciónNombreTipo.Text = "Ingrese nuevo nombre del tipo:";
            // 
            // txtActualizarNombreTipo
            // 
            this.txtActualizarNombreTipo.Enabled = false;
            this.txtActualizarNombreTipo.Location = new System.Drawing.Point(239, 273);
            this.txtActualizarNombreTipo.Name = "txtActualizarNombreTipo";
            this.txtActualizarNombreTipo.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarNombreTipo.TabIndex = 11;
            // 
            // btnVolverActualizarTipo
            // 
            this.btnVolverActualizarTipo.BackColor = System.Drawing.Color.White;
            this.btnVolverActualizarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverActualizarTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverActualizarTipo.Location = new System.Drawing.Point(178, 353);
            this.btnVolverActualizarTipo.Name = "btnVolverActualizarTipo";
            this.btnVolverActualizarTipo.Size = new System.Drawing.Size(140, 40);
            this.btnVolverActualizarTipo.TabIndex = 15;
            this.btnVolverActualizarTipo.Text = "Volver";
            this.btnVolverActualizarTipo.UseVisualStyleBackColor = false;
            this.btnVolverActualizarTipo.Click += new System.EventHandler(this.btnVolverActualizarTipo_Click);
            // 
            // lblModificaciónTipoPrenda
            // 
            this.lblModificaciónTipoPrenda.AutoSize = true;
            this.lblModificaciónTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónTipoPrenda.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.lblModificaciónTipoPrenda.Location = new System.Drawing.Point(6, 16);
            this.lblModificaciónTipoPrenda.Name = "lblModificaciónTipoPrenda";
            this.lblModificaciónTipoPrenda.Size = new System.Drawing.Size(312, 25);
            this.lblModificaciónTipoPrenda.TabIndex = 9;
            this.lblModificaciónTipoPrenda.Text = "Modificación del tipo de prenda";
            // 
            // grbModificaciónTiposPrenda
            // 
            this.grbModificaciónTiposPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbModificaciónTiposPrenda.Controls.Add(this.gdrConsultaTipoPrenda);
            this.grbModificaciónTiposPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificaciónTiposPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbModificaciónTiposPrenda.Location = new System.Drawing.Point(8, 63);
            this.grbModificaciónTiposPrenda.Name = "grbModificaciónTiposPrenda";
            this.grbModificaciónTiposPrenda.Size = new System.Drawing.Size(619, 204);
            this.grbModificaciónTiposPrenda.TabIndex = 18;
            this.grbModificaciónTiposPrenda.TabStop = false;
            this.grbModificaciónTiposPrenda.Text = "Datos de tipos de prenda";
            // 
            // gdrConsultaTipoPrenda
            // 
            this.gdrConsultaTipoPrenda.AllowUserToAddRows = false;
            this.gdrConsultaTipoPrenda.AllowUserToDeleteRows = false;
            this.gdrConsultaTipoPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultaTipoPrenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.IdTipoPrenda,
            this.Descripción,
            this.Borrado});
            this.gdrConsultaTipoPrenda.Location = new System.Drawing.Point(28, 34);
            this.gdrConsultaTipoPrenda.Name = "gdrConsultaTipoPrenda";
            this.gdrConsultaTipoPrenda.ReadOnly = true;
            this.gdrConsultaTipoPrenda.RowHeadersWidth = 51;
            this.gdrConsultaTipoPrenda.Size = new System.Drawing.Size(542, 150);
            this.gdrConsultaTipoPrenda.TabIndex = 0;
            this.gdrConsultaTipoPrenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrConsultaTipoPrenda_CellClick);
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
            // IdTipoPrenda
            // 
            this.IdTipoPrenda.DataPropertyName = "IdTipoPrenda";
            this.IdTipoPrenda.HeaderText = "Código";
            this.IdTipoPrenda.MinimumWidth = 6;
            this.IdTipoPrenda.Name = "IdTipoPrenda";
            this.IdTipoPrenda.ReadOnly = true;
            this.IdTipoPrenda.Width = 125;
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
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Width = 125;
            // 
            // grbModificacionTipoPrenda
            // 
            this.grbModificacionTipoPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbModificacionTipoPrenda.Controls.Add(this.lblModificaciónTipoPrenda);
            this.grbModificacionTipoPrenda.Controls.Add(this.grbModificaciónTiposPrenda);
            this.grbModificacionTipoPrenda.Controls.Add(this.btnVolverActualizarTipo);
            this.grbModificacionTipoPrenda.Controls.Add(this.btnModificarTipoPrenda);
            this.grbModificacionTipoPrenda.Controls.Add(this.txtActualizarNombreTipo);
            this.grbModificacionTipoPrenda.Controls.Add(this.txtActualizarDescripciónTipo);
            this.grbModificacionTipoPrenda.Controls.Add(this.lblModificaciónNombreTipo);
            this.grbModificacionTipoPrenda.Controls.Add(this.lblModificaciónDescrTipo);
            this.grbModificacionTipoPrenda.Location = new System.Drawing.Point(72, 71);
            this.grbModificacionTipoPrenda.Name = "grbModificacionTipoPrenda";
            this.grbModificacionTipoPrenda.Size = new System.Drawing.Size(644, 408);
            this.grbModificacionTipoPrenda.TabIndex = 19;
            this.grbModificacionTipoPrenda.TabStop = false;
            // 
            // ModificarTipoPrendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 542);
            this.Controls.Add(this.grbModificacionTipoPrenda);
            this.Name = "ModificarTipoPrendaForm";
            this.ShowIcon = false;
            this.Text = "Modificación del tipo de prenda";
            this.grbModificaciónTiposPrenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoPrenda)).EndInit();
            this.grbModificacionTipoPrenda.ResumeLayout(false);
            this.grbModificacionTipoPrenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarTipoPrenda;
        private System.Windows.Forms.TextBox txtActualizarDescripciónTipo;
        private System.Windows.Forms.Label lblModificaciónDescrTipo;
        private System.Windows.Forms.Label lblModificaciónNombreTipo;
        private System.Windows.Forms.TextBox txtActualizarNombreTipo;
        private System.Windows.Forms.Button btnVolverActualizarTipo;
        private System.Windows.Forms.Label lblModificaciónTipoPrenda;
        private System.Windows.Forms.GroupBox grbModificaciónTiposPrenda;
        private System.Windows.Forms.DataGridView gdrConsultaTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.GroupBox grbModificacionTipoPrenda;
    }
}