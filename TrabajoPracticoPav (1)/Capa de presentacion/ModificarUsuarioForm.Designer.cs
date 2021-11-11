
namespace TrabajoPractico
{
    partial class ModificarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuarioForm));
            this.lblModificación = new System.Windows.Forms.Label();
            this.grpItemsAModificar = new System.Windows.Forms.GroupBox();
            this.rdbContraseña = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btnContinuarModificación = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtActualizarNombre = new System.Windows.Forms.TextBox();
            this.lblUsuarioActualizar = new System.Windows.Forms.Label();
            this.lblClaveActualizar = new System.Windows.Forms.Label();
            this.txtActualizarClave = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grpModificacionDatos = new System.Windows.Forms.GroupBox();
            this.grpItemsAModificar.SuspendLayout();
            this.grpModificacionDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificación
            // 
            this.lblModificación.AutoSize = true;
            this.lblModificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModificación.Image = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.lblModificación.Location = new System.Drawing.Point(6, 16);
            this.lblModificación.Name = "lblModificación";
            this.lblModificación.Size = new System.Drawing.Size(334, 26);
            this.lblModificación.TabIndex = 0;
            this.lblModificación.Text = "Modificación de datos del usuario";
            // 
            // grpItemsAModificar
            // 
            this.grpItemsAModificar.BackgroundImage = global::TrabajoPractico.Properties.Resources.rosa_correcto;
            this.grpItemsAModificar.Controls.Add(this.rdbContraseña);
            this.grpItemsAModificar.Controls.Add(this.rdbNombre);
            this.grpItemsAModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItemsAModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpItemsAModificar.Location = new System.Drawing.Point(6, 70);
            this.grpItemsAModificar.Name = "grpItemsAModificar";
            this.grpItemsAModificar.Size = new System.Drawing.Size(315, 108);
            this.grpItemsAModificar.TabIndex = 3;
            this.grpItemsAModificar.TabStop = false;
            this.grpItemsAModificar.Text = "Seleccionar lo que se desee modificar";
            // 
            // rdbContraseña
            // 
            this.rdbContraseña.AutoSize = true;
            this.rdbContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdbContraseña.BackgroundImage")));
            this.rdbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbContraseña.Location = new System.Drawing.Point(100, 71);
            this.rdbContraseña.Name = "rdbContraseña";
            this.rdbContraseña.Size = new System.Drawing.Size(110, 24);
            this.rdbContraseña.TabIndex = 1;
            this.rdbContraseña.TabStop = true;
            this.rdbContraseña.Text = "Contraseña";
            this.rdbContraseña.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdbNombre.BackgroundImage")));
            this.rdbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNombre.Location = new System.Drawing.Point(100, 39);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(164, 24);
            this.rdbNombre.TabIndex = 0;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre de Usuario";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // btnContinuarModificación
            // 
            this.btnContinuarModificación.BackColor = System.Drawing.Color.White;
            this.btnContinuarModificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarModificación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinuarModificación.Location = new System.Drawing.Point(352, 322);
            this.btnContinuarModificación.Name = "btnContinuarModificación";
            this.btnContinuarModificación.Size = new System.Drawing.Size(99, 40);
            this.btnContinuarModificación.TabIndex = 4;
            this.btnContinuarModificación.Text = "Continuar";
            this.btnContinuarModificación.UseVisualStyleBackColor = false;
            this.btnContinuarModificación.Click += new System.EventHandler(this.btnContinuarModificación_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(219, 322);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtActualizarNombre
            // 
            this.txtActualizarNombre.Enabled = false;
            this.txtActualizarNombre.Location = new System.Drawing.Point(259, 238);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarNombre.TabIndex = 2;
            // 
            // lblUsuarioActualizar
            // 
            this.lblUsuarioActualizar.AutoSize = true;
            this.lblUsuarioActualizar.Enabled = false;
            this.lblUsuarioActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuarioActualizar.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuarioActualizar.Image")));
            this.lblUsuarioActualizar.Location = new System.Drawing.Point(9, 238);
            this.lblUsuarioActualizar.Name = "lblUsuarioActualizar";
            this.lblUsuarioActualizar.Size = new System.Drawing.Size(250, 20);
            this.lblUsuarioActualizar.TabIndex = 7;
            this.lblUsuarioActualizar.Text = "Ingrese nuevo nombre de usuario:";
            // 
            // lblClaveActualizar
            // 
            this.lblClaveActualizar.AutoSize = true;
            this.lblClaveActualizar.Enabled = false;
            this.lblClaveActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClaveActualizar.Image = ((System.Drawing.Image)(resources.GetObject("lblClaveActualizar.Image")));
            this.lblClaveActualizar.Location = new System.Drawing.Point(102, 271);
            this.lblClaveActualizar.Name = "lblClaveActualizar";
            this.lblClaveActualizar.Size = new System.Drawing.Size(154, 20);
            this.lblClaveActualizar.TabIndex = 8;
            this.lblClaveActualizar.Text = "Ingrese nueva clave:";
            // 
            // txtActualizarClave
            // 
            this.txtActualizarClave.Enabled = false;
            this.txtActualizarClave.Location = new System.Drawing.Point(259, 273);
            this.txtActualizarClave.Name = "txtActualizarClave";
            this.txtActualizarClave.Size = new System.Drawing.Size(192, 20);
            this.txtActualizarClave.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Location = new System.Drawing.Point(12, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grpModificacionDatos
            // 
            this.grpModificacionDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpModificacionDatos.BackgroundImage")));
            this.grpModificacionDatos.Controls.Add(this.lblModificación);
            this.grpModificacionDatos.Controls.Add(this.btnModificar);
            this.grpModificacionDatos.Controls.Add(this.grpItemsAModificar);
            this.grpModificacionDatos.Controls.Add(this.txtActualizarClave);
            this.grpModificacionDatos.Controls.Add(this.btnContinuarModificación);
            this.grpModificacionDatos.Controls.Add(this.lblClaveActualizar);
            this.grpModificacionDatos.Controls.Add(this.btnVolver);
            this.grpModificacionDatos.Controls.Add(this.lblUsuarioActualizar);
            this.grpModificacionDatos.Controls.Add(this.txtActualizarNombre);
            this.grpModificacionDatos.Location = new System.Drawing.Point(56, 69);
            this.grpModificacionDatos.Name = "grpModificacionDatos";
            this.grpModificacionDatos.Size = new System.Drawing.Size(470, 386);
            this.grpModificacionDatos.TabIndex = 9;
            this.grpModificacionDatos.TabStop = false;
            // 
            // ModificarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico.Properties.Resources.horizontar_registra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 513);
            this.Controls.Add(this.grpModificacionDatos);
            this.Name = "ModificarUsuarioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Datos de Usuario";
            this.grpItemsAModificar.ResumeLayout(false);
            this.grpItemsAModificar.PerformLayout();
            this.grpModificacionDatos.ResumeLayout(false);
            this.grpModificacionDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblModificación;
        private System.Windows.Forms.GroupBox grpItemsAModificar;
        private System.Windows.Forms.Button btnContinuarModificación;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtActualizarNombre;
        private System.Windows.Forms.Label lblUsuarioActualizar;
        private System.Windows.Forms.Label lblClaveActualizar;
        private System.Windows.Forms.TextBox txtActualizarClave;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RadioButton rdbContraseña;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.GroupBox grpModificacionDatos;
    }
}