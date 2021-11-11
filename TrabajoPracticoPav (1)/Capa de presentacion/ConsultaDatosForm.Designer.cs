
namespace TrabajoPractico
{
    partial class ConsultaDatosForm
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
            this.grConsultaDatos = new System.Windows.Forms.DataGridView();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatosUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grConsultaDatos)).BeginInit();
            this.grpDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grConsultaDatos
            // 
            this.grConsultaDatos.AllowUserToAddRows = false;
            this.grConsultaDatos.AllowUserToDeleteRows = false;
            this.grConsultaDatos.BackgroundColor = System.Drawing.Color.White;
            this.grConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grConsultaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Usuario,
            this.NombreUsuario,
            this.Contraseña,
            this.rolUsu});
            this.grConsultaDatos.Location = new System.Drawing.Point(18, 41);
            this.grConsultaDatos.Name = "grConsultaDatos";
            this.grConsultaDatos.ReadOnly = true;
            this.grConsultaDatos.Size = new System.Drawing.Size(745, 267);
            this.grConsultaDatos.TabIndex = 0;
            this.grConsultaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grConsultaDatos_CellClick);
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.DataPropertyName = "Id_Usuario";
            this.Id_Usuario.HeaderText = "Código";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "Nombre de Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 200;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Width = 200;
            // 
            // rolUsu
            // 
            this.rolUsu.DataPropertyName = "Rol";
            this.rolUsu.HeaderText = "Rol";
            this.rolUsu.Name = "rolUsu";
            this.rolUsu.ReadOnly = true;
            this.rolUsu.Width = 200;
            // 
            // grpDatosUsuario
            // 
            this.grpDatosUsuario.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpDatosUsuario.Controls.Add(this.btnVolver);
            this.grpDatosUsuario.Controls.Add(this.label1);
            this.grpDatosUsuario.Controls.Add(this.btnEliminarDatos);
            this.grpDatosUsuario.Controls.Add(this.grConsultaDatos);
            this.grpDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosUsuario.ForeColor = System.Drawing.Color.Black;
            this.grpDatosUsuario.Location = new System.Drawing.Point(81, 67);
            this.grpDatosUsuario.Name = "grpDatosUsuario";
            this.grpDatosUsuario.Size = new System.Drawing.Size(774, 398);
            this.grpDatosUsuario.TabIndex = 1;
            this.grpDatosUsuario.TabStop = false;
            this.grpDatosUsuario.Visible = false;
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.BackColor = System.Drawing.Color.White;
            this.btnEliminarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarDatos.Location = new System.Drawing.Point(560, 333);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(203, 47);
            this.btnEliminarDatos.TabIndex = 2;
            this.btnEliminarDatos.Text = "Eliminar usuario";
            this.btnEliminarDatos.UseVisualStyleBackColor = false;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(18, 333);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(134, 47);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos del usuario";
            // 
            // ConsultaDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 525);
            this.Controls.Add(this.grpDatosUsuario);
            this.Name = "ConsultaDatosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar datos del usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grConsultaDatos)).EndInit();
            this.grpDatosUsuario.ResumeLayout(false);
            this.grpDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grConsultaDatos;
        private System.Windows.Forms.GroupBox grpDatosUsuario;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsu;
        private System.Windows.Forms.Label label1;
    }
}