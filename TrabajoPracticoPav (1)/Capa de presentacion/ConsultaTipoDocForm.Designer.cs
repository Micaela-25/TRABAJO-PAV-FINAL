
namespace TrabajoPractico.Capa_de_presentacion
{
    partial class ConsultaTipoDocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTipoDocForm));
            this.grbConsultaTiposDoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTipoDoc = new System.Windows.Forms.Button();
            this.btnVolverConsultaTipoDoc = new System.Windows.Forms.Button();
            this.gdrConsultaTipoDoc = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreConsultaTipoDoc = new System.Windows.Forms.Label();
            this.txtDescripcionTipoDocConsulta = new System.Windows.Forms.TextBox();
            this.lblTituloConsultaTipoDoc = new System.Windows.Forms.Label();
            this.lblDescripcionTipoDocConsulta = new System.Windows.Forms.Label();
            this.btnConsultarTipoDoc = new System.Windows.Forms.Button();
            this.grpConsultaTiposDoc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTipoDocConsulta = new System.Windows.Forms.TextBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.grbConsultaTiposDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoDoc)).BeginInit();
            this.grpConsultaTiposDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsultaTiposDoc
            // 
            this.grbConsultaTiposDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbConsultaTiposDoc.BackgroundImage")));
            this.grbConsultaTiposDoc.Controls.Add(this.label2);
            this.grbConsultaTiposDoc.Controls.Add(this.btnEliminarTipoDoc);
            this.grbConsultaTiposDoc.Controls.Add(this.btnVolverConsultaTipoDoc);
            this.grbConsultaTiposDoc.Controls.Add(this.gdrConsultaTipoDoc);
            this.grbConsultaTiposDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsultaTiposDoc.Location = new System.Drawing.Point(55, 236);
            this.grbConsultaTiposDoc.Name = "grbConsultaTiposDoc";
            this.grbConsultaTiposDoc.Size = new System.Drawing.Size(490, 275);
            this.grbConsultaTiposDoc.TabIndex = 2;
            this.grbConsultaTiposDoc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datos de los tipos de documentos";
            // 
            // btnEliminarTipoDoc
            // 
            this.btnEliminarTipoDoc.BackColor = System.Drawing.Color.White;
            this.btnEliminarTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarTipoDoc.Location = new System.Drawing.Point(364, 227);
            this.btnEliminarTipoDoc.Name = "btnEliminarTipoDoc";
            this.btnEliminarTipoDoc.Size = new System.Drawing.Size(115, 41);
            this.btnEliminarTipoDoc.TabIndex = 3;
            this.btnEliminarTipoDoc.Text = "Eliminar";
            this.btnEliminarTipoDoc.UseVisualStyleBackColor = false;
            this.btnEliminarTipoDoc.Click += new System.EventHandler(this.btnEliminarTipoDoc_Click);
            // 
            // btnVolverConsultaTipoDoc
            // 
            this.btnVolverConsultaTipoDoc.BackColor = System.Drawing.Color.White;
            this.btnVolverConsultaTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverConsultaTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverConsultaTipoDoc.Location = new System.Drawing.Point(6, 227);
            this.btnVolverConsultaTipoDoc.Name = "btnVolverConsultaTipoDoc";
            this.btnVolverConsultaTipoDoc.Size = new System.Drawing.Size(115, 41);
            this.btnVolverConsultaTipoDoc.TabIndex = 2;
            this.btnVolverConsultaTipoDoc.Text = "Volver";
            this.btnVolverConsultaTipoDoc.UseVisualStyleBackColor = false;
            this.btnVolverConsultaTipoDoc.Click += new System.EventHandler(this.btnVolverConsultaTipoDoc_Click);
            // 
            // gdrConsultaTipoDoc
            // 
            this.gdrConsultaTipoDoc.AllowUserToAddRows = false;
            this.gdrConsultaTipoDoc.AllowUserToDeleteRows = false;
            this.gdrConsultaTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultaTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Borrado});
            this.gdrConsultaTipoDoc.Location = new System.Drawing.Point(6, 45);
            this.gdrConsultaTipoDoc.Name = "gdrConsultaTipoDoc";
            this.gdrConsultaTipoDoc.ReadOnly = true;
            this.gdrConsultaTipoDoc.RowHeadersWidth = 51;
            this.gdrConsultaTipoDoc.Size = new System.Drawing.Size(473, 176);
            this.gdrConsultaTipoDoc.TabIndex = 0;
            this.gdrConsultaTipoDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrConsultaTipoDoc_CellClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Id_Tipo_Doc";
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 58;
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
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Width = 58;
            // 
            // lblNombreConsultaTipoDoc
            // 
            this.lblNombreConsultaTipoDoc.AutoSize = true;
            this.lblNombreConsultaTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreConsultaTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreConsultaTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreConsultaTipoDoc.Image")));
            this.lblNombreConsultaTipoDoc.Location = new System.Drawing.Point(23, 94);
            this.lblNombreConsultaTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreConsultaTipoDoc.Name = "lblNombreConsultaTipoDoc";
            this.lblNombreConsultaTipoDoc.Size = new System.Drawing.Size(69, 20);
            this.lblNombreConsultaTipoDoc.TabIndex = 3;
            this.lblNombreConsultaTipoDoc.Text = "Nombre:";
            // 
            // txtDescripcionTipoDocConsulta
            // 
            this.txtDescripcionTipoDocConsulta.Location = new System.Drawing.Point(118, 124);
            this.txtDescripcionTipoDocConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionTipoDocConsulta.Name = "txtDescripcionTipoDocConsulta";
            this.txtDescripcionTipoDocConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTipoDocConsulta.TabIndex = 4;
            // 
            // lblTituloConsultaTipoDoc
            // 
            this.lblTituloConsultaTipoDoc.AutoSize = true;
            this.lblTituloConsultaTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloConsultaTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("lblTituloConsultaTipoDoc.Image")));
            this.lblTituloConsultaTipoDoc.Location = new System.Drawing.Point(16, 51);
            this.lblTituloConsultaTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloConsultaTipoDoc.Name = "lblTituloConsultaTipoDoc";
            this.lblTituloConsultaTipoDoc.Size = new System.Drawing.Size(195, 24);
            this.lblTituloConsultaTipoDoc.TabIndex = 6;
            this.lblTituloConsultaTipoDoc.Text = "Criterios de búsqueda";
            // 
            // lblDescripcionTipoDocConsulta
            // 
            this.lblDescripcionTipoDocConsulta.AutoSize = true;
            this.lblDescripcionTipoDocConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTipoDocConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescripcionTipoDocConsulta.Image = ((System.Drawing.Image)(resources.GetObject("lblDescripcionTipoDocConsulta.Image")));
            this.lblDescripcionTipoDocConsulta.Location = new System.Drawing.Point(23, 127);
            this.lblDescripcionTipoDocConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionTipoDocConsulta.Name = "lblDescripcionTipoDocConsulta";
            this.lblDescripcionTipoDocConsulta.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcionTipoDocConsulta.TabIndex = 7;
            this.lblDescripcionTipoDocConsulta.Text = "Descripción:";
            // 
            // btnConsultarTipoDoc
            // 
            this.btnConsultarTipoDoc.BackColor = System.Drawing.Color.White;
            this.btnConsultarTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarTipoDoc.Location = new System.Drawing.Point(241, 113);
            this.btnConsultarTipoDoc.Name = "btnConsultarTipoDoc";
            this.btnConsultarTipoDoc.Size = new System.Drawing.Size(189, 37);
            this.btnConsultarTipoDoc.TabIndex = 4;
            this.btnConsultarTipoDoc.Text = "Consultar";
            this.btnConsultarTipoDoc.UseVisualStyleBackColor = false;
            this.btnConsultarTipoDoc.Click += new System.EventHandler(this.btnConsultarTipoDoc_Click);
            // 
            // grpConsultaTiposDoc
            // 
            this.grpConsultaTiposDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpConsultaTiposDoc.BackgroundImage")));
            this.grpConsultaTiposDoc.Controls.Add(this.label1);
            this.grpConsultaTiposDoc.Controls.Add(this.txtNombreTipoDocConsulta);
            this.grpConsultaTiposDoc.Controls.Add(this.lblTituloConsultaTipoDoc);
            this.grpConsultaTiposDoc.Controls.Add(this.chkBaja);
            this.grpConsultaTiposDoc.Controls.Add(this.btnConsultarTipoDoc);
            this.grpConsultaTiposDoc.Controls.Add(this.lblNombreConsultaTipoDoc);
            this.grpConsultaTiposDoc.Controls.Add(this.txtDescripcionTipoDocConsulta);
            this.grpConsultaTiposDoc.Controls.Add(this.lblDescripcionTipoDocConsulta);
            this.grpConsultaTiposDoc.Location = new System.Drawing.Point(55, 80);
            this.grpConsultaTiposDoc.Name = "grpConsultaTiposDoc";
            this.grpConsultaTiposDoc.Size = new System.Drawing.Size(490, 165);
            this.grpConsultaTiposDoc.TabIndex = 10;
            this.grpConsultaTiposDoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consulta de tipos de documentos";
            // 
            // txtNombreTipoDocConsulta
            // 
            this.txtNombreTipoDocConsulta.Location = new System.Drawing.Point(118, 94);
            this.txtNombreTipoDocConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTipoDocConsulta.Name = "txtNombreTipoDocConsulta";
            this.txtNombreTipoDocConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoDocConsulta.TabIndex = 11;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.chkBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkBaja.Location = new System.Drawing.Point(241, 90);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(184, 20);
            this.chkBaja.TabIndex = 10;
            this.chkBaja.Text = "Incluir tipos dados de baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // ConsultaTipoDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.grpConsultaTiposDoc);
            this.Controls.Add(this.grbConsultaTiposDoc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaTipoDocForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de tipos de documento";
            this.Load += new System.EventHandler(this.ConsultaTipoDocForm_Load);
            this.grbConsultaTiposDoc.ResumeLayout(false);
            this.grbConsultaTiposDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoDoc)).EndInit();
            this.grpConsultaTiposDoc.ResumeLayout(false);
            this.grpConsultaTiposDoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsultaTiposDoc;
        private System.Windows.Forms.Button btnEliminarTipoDoc;
        private System.Windows.Forms.Button btnVolverConsultaTipoDoc;
        private System.Windows.Forms.DataGridView gdrConsultaTipoDoc;
        private System.Windows.Forms.Label lblNombreConsultaTipoDoc;
        private System.Windows.Forms.TextBox txtDescripcionTipoDocConsulta;
        private System.Windows.Forms.Label lblTituloConsultaTipoDoc;
        private System.Windows.Forms.Label lblDescripcionTipoDocConsulta;
        private System.Windows.Forms.Button btnConsultarTipoDoc;
        private System.Windows.Forms.GroupBox grpConsultaTiposDoc;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.TextBox txtNombreTipoDocConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label1;
    }
}