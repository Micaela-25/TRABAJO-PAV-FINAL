
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class ModificaciónTipoDocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaciónTipoDocForm));
            this.grbModificaciónTiposPrenda = new System.Windows.Forms.GroupBox();
            this.gdrConsultaTipoDoc = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarTipoDoc = new System.Windows.Forms.Button();
            this.txtActualizarDescripciónTipoDoc = new System.Windows.Forms.TextBox();
            this.lblModificaciónDescrTipoDoc = new System.Windows.Forms.Label();
            this.lblModificaciónNombreTipoDoc = new System.Windows.Forms.Label();
            this.txtActualizarNombreTipoDoc = new System.Windows.Forms.TextBox();
            this.btnVolverActualizarTipoDoc = new System.Windows.Forms.Button();
            this.lblModificaciónTipoDoc = new System.Windows.Forms.Label();
            this.grpMpodificionDocumento = new System.Windows.Forms.GroupBox();
            this.grbModificaciónTiposPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoDoc)).BeginInit();
            this.grpMpodificionDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbModificaciónTiposPrenda
            // 
            this.grbModificaciónTiposPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbModificaciónTiposPrenda.Controls.Add(this.gdrConsultaTipoDoc);
            this.grbModificaciónTiposPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificaciónTiposPrenda.Location = new System.Drawing.Point(21, 56);
            this.grbModificaciónTiposPrenda.Name = "grbModificaciónTiposPrenda";
            this.grbModificaciónTiposPrenda.Size = new System.Drawing.Size(503, 204);
            this.grbModificaciónTiposPrenda.TabIndex = 26;
            this.grbModificaciónTiposPrenda.TabStop = false;
            this.grbModificaciónTiposPrenda.Text = "Datos de tipos de documento";
            // 
            // gdrConsultaTipoDoc
            // 
            this.gdrConsultaTipoDoc.AllowUserToAddRows = false;
            this.gdrConsultaTipoDoc.AllowUserToDeleteRows = false;
            this.gdrConsultaTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultaTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción});
            this.gdrConsultaTipoDoc.Location = new System.Drawing.Point(26, 38);
            this.gdrConsultaTipoDoc.Name = "gdrConsultaTipoDoc";
            this.gdrConsultaTipoDoc.ReadOnly = true;
            this.gdrConsultaTipoDoc.RowHeadersWidth = 51;
            this.gdrConsultaTipoDoc.Size = new System.Drawing.Size(477, 150);
            this.gdrConsultaTipoDoc.TabIndex = 0;
            this.gdrConsultaTipoDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrConsultaTipoDoc_CellClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripción";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 150;
            // 
            // btnModificarTipoDoc
            // 
            this.btnModificarTipoDoc.BackColor = System.Drawing.Color.White;
            this.btnModificarTipoDoc.Enabled = false;
            this.btnModificarTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarTipoDoc.Location = new System.Drawing.Point(356, 376);
            this.btnModificarTipoDoc.Name = "btnModificarTipoDoc";
            this.btnModificarTipoDoc.Size = new System.Drawing.Size(144, 35);
            this.btnModificarTipoDoc.TabIndex = 20;
            this.btnModificarTipoDoc.Text = "Modificar";
            this.btnModificarTipoDoc.UseVisualStyleBackColor = false;
            this.btnModificarTipoDoc.Click += new System.EventHandler(this.btnModificarTipoDoc_Click);
            // 
            // txtActualizarDescripciónTipoDoc
            // 
            this.txtActualizarDescripciónTipoDoc.Enabled = false;
            this.txtActualizarDescripciónTipoDoc.Location = new System.Drawing.Point(261, 329);
            this.txtActualizarDescripciónTipoDoc.Name = "txtActualizarDescripciónTipoDoc";
            this.txtActualizarDescripciónTipoDoc.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarDescripciónTipoDoc.TabIndex = 22;
            // 
            // lblModificaciónDescrTipoDoc
            // 
            this.lblModificaciónDescrTipoDoc.AutoSize = true;
            this.lblModificaciónDescrTipoDoc.Enabled = false;
            this.lblModificaciónDescrTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónDescrTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónDescrTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("lblModificaciónDescrTipoDoc.Image")));
            this.lblModificaciónDescrTipoDoc.Location = new System.Drawing.Point(50, 327);
            this.lblModificaciónDescrTipoDoc.Name = "lblModificaciónDescrTipoDoc";
            this.lblModificaciónDescrTipoDoc.Size = new System.Drawing.Size(198, 20);
            this.lblModificaciónDescrTipoDoc.TabIndex = 25;
            this.lblModificaciónDescrTipoDoc.Text = "Ingrese nueva descripción:";
            // 
            // lblModificaciónNombreTipoDoc
            // 
            this.lblModificaciónNombreTipoDoc.AutoSize = true;
            this.lblModificaciónNombreTipoDoc.Enabled = false;
            this.lblModificaciónNombreTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónNombreTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónNombreTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("lblModificaciónNombreTipoDoc.Image")));
            this.lblModificaciónNombreTipoDoc.Location = new System.Drawing.Point(28, 285);
            this.lblModificaciónNombreTipoDoc.Name = "lblModificaciónNombreTipoDoc";
            this.lblModificaciónNombreTipoDoc.Size = new System.Drawing.Size(227, 20);
            this.lblModificaciónNombreTipoDoc.TabIndex = 24;
            this.lblModificaciónNombreTipoDoc.Text = "Ingrese nuevo nombre del tipo:";
            // 
            // txtActualizarNombreTipoDoc
            // 
            this.txtActualizarNombreTipoDoc.Enabled = false;
            this.txtActualizarNombreTipoDoc.Location = new System.Drawing.Point(261, 287);
            this.txtActualizarNombreTipoDoc.Name = "txtActualizarNombreTipoDoc";
            this.txtActualizarNombreTipoDoc.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarNombreTipoDoc.TabIndex = 21;
            // 
            // btnVolverActualizarTipoDoc
            // 
            this.btnVolverActualizarTipoDoc.BackColor = System.Drawing.Color.White;
            this.btnVolverActualizarTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverActualizarTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverActualizarTipoDoc.Location = new System.Drawing.Point(230, 376);
            this.btnVolverActualizarTipoDoc.Name = "btnVolverActualizarTipoDoc";
            this.btnVolverActualizarTipoDoc.Size = new System.Drawing.Size(120, 35);
            this.btnVolverActualizarTipoDoc.TabIndex = 23;
            this.btnVolverActualizarTipoDoc.Text = "Volver";
            this.btnVolverActualizarTipoDoc.UseVisualStyleBackColor = false;
            this.btnVolverActualizarTipoDoc.Click += new System.EventHandler(this.btnVolverActualizarTipoDoc_Click);
            // 
            // lblModificaciónTipoDoc
            // 
            this.lblModificaciónTipoDoc.AutoSize = true;
            this.lblModificaciónTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaciónTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificaciónTipoDoc.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.lblModificaciónTipoDoc.Location = new System.Drawing.Point(17, 16);
            this.lblModificaciónTipoDoc.Name = "lblModificaciónTipoDoc";
            this.lblModificaciónTipoDoc.Size = new System.Drawing.Size(353, 26);
            this.lblModificaciónTipoDoc.TabIndex = 19;
            this.lblModificaciónTipoDoc.Text = "Modificación del tipo de documento";
            // 
            // grpMpodificionDocumento
            // 
            this.grpMpodificionDocumento.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpMpodificionDocumento.Controls.Add(this.lblModificaciónTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.grbModificaciónTiposPrenda);
            this.grpMpodificionDocumento.Controls.Add(this.btnVolverActualizarTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.btnModificarTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.txtActualizarNombreTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.txtActualizarDescripciónTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.lblModificaciónNombreTipoDoc);
            this.grpMpodificionDocumento.Controls.Add(this.lblModificaciónDescrTipoDoc);
            this.grpMpodificionDocumento.Location = new System.Drawing.Point(65, 74);
            this.grpMpodificionDocumento.Name = "grpMpodificionDocumento";
            this.grpMpodificionDocumento.Size = new System.Drawing.Size(594, 417);
            this.grpMpodificionDocumento.TabIndex = 27;
            this.grpMpodificionDocumento.TabStop = false;
            // 
            // ModificaciónTipoDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.grpMpodificionDocumento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificaciónTipoDocForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion del tipo de documento";
            this.grbModificaciónTiposPrenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoDoc)).EndInit();
            this.grpMpodificionDocumento.ResumeLayout(false);
            this.grpMpodificionDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbModificaciónTiposPrenda;
        private System.Windows.Forms.DataGridView gdrConsultaTipoDoc;
        private System.Windows.Forms.Button btnModificarTipoDoc;
        private System.Windows.Forms.TextBox txtActualizarDescripciónTipoDoc;
        private System.Windows.Forms.Label lblModificaciónDescrTipoDoc;
        private System.Windows.Forms.Label lblModificaciónNombreTipoDoc;
        private System.Windows.Forms.TextBox txtActualizarNombreTipoDoc;
        private System.Windows.Forms.Button btnVolverActualizarTipoDoc;
        private System.Windows.Forms.Label lblModificaciónTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.GroupBox grpMpodificionDocumento;
    }
}