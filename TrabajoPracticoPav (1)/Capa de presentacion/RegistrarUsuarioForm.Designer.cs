
namespace TrabajoPractico
{
    partial class RegistrarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarioForm));
            this.grpNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.grpRol = new System.Windows.Forms.GroupBox();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.lblRolNuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarNuevoUsu = new System.Windows.Forms.Button();
            this.btnConfirmarAlta = new System.Windows.Forms.Button();
            this.txtRepetirNuevaContraUsu = new System.Windows.Forms.TextBox();
            this.txtNuevaContraUsu = new System.Windows.Forms.TextBox();
            this.txtNombreNuevoUsu = new System.Windows.Forms.TextBox();
            this.lblRepetirNuevaContra = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblNombreNuevoUsu = new System.Windows.Forms.Label();
            this.grpNuevoUsuario.SuspendLayout();
            this.grpRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNuevoUsuario
            // 
            this.grpNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpNuevoUsuario.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpNuevoUsuario.Controls.Add(this.grpRol);
            this.grpNuevoUsuario.Controls.Add(this.label1);
            this.grpNuevoUsuario.Controls.Add(this.btnLimpiarNuevoUsu);
            this.grpNuevoUsuario.Controls.Add(this.btnConfirmarAlta);
            this.grpNuevoUsuario.Controls.Add(this.txtRepetirNuevaContraUsu);
            this.grpNuevoUsuario.Controls.Add(this.txtNuevaContraUsu);
            this.grpNuevoUsuario.Controls.Add(this.txtNombreNuevoUsu);
            this.grpNuevoUsuario.Controls.Add(this.lblRepetirNuevaContra);
            this.grpNuevoUsuario.Controls.Add(this.lblNuevaContraseña);
            this.grpNuevoUsuario.Controls.Add(this.lblNombreNuevoUsu);
            this.grpNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpNuevoUsuario.Location = new System.Drawing.Point(45, 52);
            this.grpNuevoUsuario.Name = "grpNuevoUsuario";
            this.grpNuevoUsuario.Size = new System.Drawing.Size(428, 300);
            this.grpNuevoUsuario.TabIndex = 0;
            this.grpNuevoUsuario.TabStop = false;
            this.grpNuevoUsuario.Text = "Datos del nuevo usuario";
            // 
            // grpRol
            // 
            this.grpRol.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpRol.Controls.Add(this.rdbVendedor);
            this.grpRol.Controls.Add(this.rdbAdmin);
            this.grpRol.Controls.Add(this.lblRolNuevo);
            this.grpRol.Location = new System.Drawing.Point(116, 143);
            this.grpRol.Name = "grpRol";
            this.grpRol.Size = new System.Drawing.Size(258, 82);
            this.grpRol.TabIndex = 10;
            this.grpRol.TabStop = false;
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.rdbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbVendedor.Location = new System.Drawing.Point(95, 45);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(97, 24);
            this.rdbVendedor.TabIndex = 11;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.rdbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbAdmin.Location = new System.Drawing.Point(95, 17);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(125, 24);
            this.rdbAdmin.TabIndex = 10;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblRolNuevo
            // 
            this.lblRolNuevo.AutoSize = true;
            this.lblRolNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRolNuevo.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.lblRolNuevo.Location = new System.Drawing.Point(6, 25);
            this.lblRolNuevo.Name = "lblRolNuevo";
            this.lblRolNuevo.Size = new System.Drawing.Size(37, 20);
            this.lblRolNuevo.TabIndex = 9;
            this.lblRolNuevo.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 8;
            // 
            // btnLimpiarNuevoUsu
            // 
            this.btnLimpiarNuevoUsu.BackColor = System.Drawing.Color.White;
            this.btnLimpiarNuevoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarNuevoUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarNuevoUsu.Location = new System.Drawing.Point(38, 241);
            this.btnLimpiarNuevoUsu.Name = "btnLimpiarNuevoUsu";
            this.btnLimpiarNuevoUsu.Size = new System.Drawing.Size(158, 49);
            this.btnLimpiarNuevoUsu.TabIndex = 7;
            this.btnLimpiarNuevoUsu.Text = "Limpiar campos";
            this.btnLimpiarNuevoUsu.UseVisualStyleBackColor = false;
            this.btnLimpiarNuevoUsu.Click += new System.EventHandler(this.btnLimpiarNuevoUsu_Click);
            // 
            // btnConfirmarAlta
            // 
            this.btnConfirmarAlta.BackColor = System.Drawing.Color.White;
            this.btnConfirmarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmarAlta.Location = new System.Drawing.Point(225, 241);
            this.btnConfirmarAlta.Name = "btnConfirmarAlta";
            this.btnConfirmarAlta.Size = new System.Drawing.Size(158, 49);
            this.btnConfirmarAlta.TabIndex = 6;
            this.btnConfirmarAlta.Text = "Confirmar Datos";
            this.btnConfirmarAlta.UseVisualStyleBackColor = false;
            this.btnConfirmarAlta.Click += new System.EventHandler(this.btnConfirmarAlta_Click);
            // 
            // txtRepetirNuevaContraUsu
            // 
            this.txtRepetirNuevaContraUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirNuevaContraUsu.Location = new System.Drawing.Point(211, 112);
            this.txtRepetirNuevaContraUsu.Name = "txtRepetirNuevaContraUsu";
            this.txtRepetirNuevaContraUsu.PasswordChar = '*';
            this.txtRepetirNuevaContraUsu.Size = new System.Drawing.Size(172, 24);
            this.txtRepetirNuevaContraUsu.TabIndex = 3;
            // 
            // txtNuevaContraUsu
            // 
            this.txtNuevaContraUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraUsu.Location = new System.Drawing.Point(211, 77);
            this.txtNuevaContraUsu.Name = "txtNuevaContraUsu";
            this.txtNuevaContraUsu.PasswordChar = '*';
            this.txtNuevaContraUsu.Size = new System.Drawing.Size(172, 24);
            this.txtNuevaContraUsu.TabIndex = 2;
            // 
            // txtNombreNuevoUsu
            // 
            this.txtNombreNuevoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevoUsu.ForeColor = System.Drawing.Color.Black;
            this.txtNombreNuevoUsu.Location = new System.Drawing.Point(211, 43);
            this.txtNombreNuevoUsu.Name = "txtNombreNuevoUsu";
            this.txtNombreNuevoUsu.Size = new System.Drawing.Size(172, 24);
            this.txtNombreNuevoUsu.TabIndex = 1;
            // 
            // lblRepetirNuevaContra
            // 
            this.lblRepetirNuevaContra.AutoSize = true;
            this.lblRepetirNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirNuevaContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRepetirNuevaContra.Image = ((System.Drawing.Image)(resources.GetObject("lblRepetirNuevaContra.Image")));
            this.lblRepetirNuevaContra.Location = new System.Drawing.Point(59, 116);
            this.lblRepetirNuevaContra.Name = "lblRepetirNuevaContra";
            this.lblRepetirNuevaContra.Size = new System.Drawing.Size(149, 20);
            this.lblRepetirNuevaContra.TabIndex = 2;
            this.lblRepetirNuevaContra.Text = "Repetir contraseña:";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNuevaContraseña.Image = ((System.Drawing.Image)(resources.GetObject("lblNuevaContraseña.Image")));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(107, 82);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Contraseña:";
            // 
            // lblNombreNuevoUsu
            // 
            this.lblNombreNuevoUsu.AutoSize = true;
            this.lblNombreNuevoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNuevoUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreNuevoUsu.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreNuevoUsu.Image")));
            this.lblNombreNuevoUsu.Location = new System.Drawing.Point(57, 47);
            this.lblNombreNuevoUsu.Name = "lblNombreNuevoUsu";
            this.lblNombreNuevoUsu.Size = new System.Drawing.Size(147, 20);
            this.lblNombreNuevoUsu.TabIndex = 0;
            this.lblNombreNuevoUsu.Text = "Nombre de usuario:";
            // 
            // RegistrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 396);
            this.Controls.Add(this.grpNuevoUsuario);
            this.DoubleBuffered = true;
            this.Name = "RegistrarUsuarioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nuevo usuario";
            this.grpNuevoUsuario.ResumeLayout(false);
            this.grpNuevoUsuario.PerformLayout();
            this.grpRol.ResumeLayout(false);
            this.grpRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoUsuario;
        private System.Windows.Forms.Label lblNombreNuevoUsu;
        private System.Windows.Forms.Button btnConfirmarAlta;
        private System.Windows.Forms.TextBox txtRepetirNuevaContraUsu;
        private System.Windows.Forms.TextBox txtNuevaContraUsu;
        private System.Windows.Forms.TextBox txtNombreNuevoUsu;
        private System.Windows.Forms.Label lblRepetirNuevaContra;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Button btnLimpiarNuevoUsu;
        private System.Windows.Forms.Label lblRolNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRol;
        private System.Windows.Forms.RadioButton rdbVendedor;
        private System.Windows.Forms.RadioButton rdbAdmin;
    }
}