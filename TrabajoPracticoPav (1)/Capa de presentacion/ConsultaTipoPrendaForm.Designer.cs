
namespace TrabajoPractico
{
    partial class ConsultaTipoPrendaForm
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
            this.grbConsultaTiposPrenda = new System.Windows.Forms.GroupBox();
            this.btnEliminarTipoPrenda = new System.Windows.Forms.Button();
            this.btnVolverConsultaTipoPrenda = new System.Windows.Forms.Button();
            this.gdrConsultaTipoPrenda = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConsultaTiposPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConsultaTiposPrenda
            // 
            this.grbConsultaTiposPrenda.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grbConsultaTiposPrenda.Controls.Add(this.label1);
            this.grbConsultaTiposPrenda.Controls.Add(this.btnEliminarTipoPrenda);
            this.grbConsultaTiposPrenda.Controls.Add(this.btnVolverConsultaTipoPrenda);
            this.grbConsultaTiposPrenda.Controls.Add(this.gdrConsultaTipoPrenda);
            this.grbConsultaTiposPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsultaTiposPrenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbConsultaTiposPrenda.Location = new System.Drawing.Point(56, 57);
            this.grbConsultaTiposPrenda.Name = "grbConsultaTiposPrenda";
            this.grbConsultaTiposPrenda.Size = new System.Drawing.Size(512, 277);
            this.grbConsultaTiposPrenda.TabIndex = 1;
            this.grbConsultaTiposPrenda.TabStop = false;
            // 
            // btnEliminarTipoPrenda
            // 
            this.btnEliminarTipoPrenda.BackColor = System.Drawing.Color.White;
            this.btnEliminarTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarTipoPrenda.Location = new System.Drawing.Point(391, 204);
            this.btnEliminarTipoPrenda.Name = "btnEliminarTipoPrenda";
            this.btnEliminarTipoPrenda.Size = new System.Drawing.Size(115, 41);
            this.btnEliminarTipoPrenda.TabIndex = 3;
            this.btnEliminarTipoPrenda.Text = "Eliminar";
            this.btnEliminarTipoPrenda.UseVisualStyleBackColor = false;
            this.btnEliminarTipoPrenda.Click += new System.EventHandler(this.btnEliminarTipoPrenda_Click);
            // 
            // btnVolverConsultaTipoPrenda
            // 
            this.btnVolverConsultaTipoPrenda.BackColor = System.Drawing.Color.White;
            this.btnVolverConsultaTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverConsultaTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverConsultaTipoPrenda.Location = new System.Drawing.Point(0, 204);
            this.btnVolverConsultaTipoPrenda.Name = "btnVolverConsultaTipoPrenda";
            this.btnVolverConsultaTipoPrenda.Size = new System.Drawing.Size(115, 41);
            this.btnVolverConsultaTipoPrenda.TabIndex = 2;
            this.btnVolverConsultaTipoPrenda.Text = "Volver";
            this.btnVolverConsultaTipoPrenda.UseVisualStyleBackColor = false;
            this.btnVolverConsultaTipoPrenda.Click += new System.EventHandler(this.btnVolverConsultaTipoPrenda_Click);
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
            this.gdrConsultaTipoPrenda.Location = new System.Drawing.Point(6, 39);
            this.gdrConsultaTipoPrenda.Name = "gdrConsultaTipoPrenda";
            this.gdrConsultaTipoPrenda.ReadOnly = true;
            this.gdrConsultaTipoPrenda.RowHeadersWidth = 51;
            this.gdrConsultaTipoPrenda.Size = new System.Drawing.Size(500, 149);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos de tipos de prenda";
            // 
            // ConsultaTipoPrendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 379);
            this.Controls.Add(this.grbConsultaTiposPrenda);
            this.Name = "ConsultaTipoPrendaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar tipo de prenda";
            this.grbConsultaTiposPrenda.ResumeLayout(false);
            this.grbConsultaTiposPrenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultaTipoPrenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsultaTiposPrenda;
        private System.Windows.Forms.Button btnVolverConsultaTipoPrenda;
        private System.Windows.Forms.DataGridView gdrConsultaTipoPrenda;
        private System.Windows.Forms.Button btnEliminarTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label1;
    }
}