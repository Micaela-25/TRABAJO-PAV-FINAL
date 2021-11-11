using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Capa_de_negocio;
using TrabajoPractico.Entidades;

namespace TrabajoPractico
{
    public partial class ModificarUsuarioForm : Form
    {
        private Usuario user;
        private UsuarioServicios usuSer;

        public ModificarUsuarioForm(Usuario usuLogin)
        {
            user = usuLogin;
            usuSer = new UsuarioServicios();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(user);
            volverPrincipal.Show();
            this.Hide();

        }

        public void modificacionNombreFinal(string nombre)
        {
            usuSer.modificacionNombre(nombre, user.Id);            
        }

        
        public void modificacionClaveFinal(string clave)
        {  
            usuSer.modificacionClave(clave, user.Id);
            
        }


        public bool ValidarNombreUsuario (string nombreDeUsuario)
        {
            bool resultado = false;
            resultado = usuSer.ValidarUsuarioModificar(nombreDeUsuario);
            
            return resultado;
        }
    


        private void btnContinuarModificación_Click(object sender, EventArgs e)
         {

                if (!txtActualizarClave.Text.Equals("")) // Si la clave está para modificar entra por aca
                {
                    modificacionClaveFinal(txtActualizarClave.Text);


                    LoginForm SalirSesion = new LoginForm();
                    SalirSesion.Show();
                    this.Hide();

                }
              
                
                else if (!txtActualizarNombre.Text.Equals("")) //si solo se tiene que modificar el nombre entra aca, porque no hay forma de que entre arriba 
                {

                    string NombreUsu = txtActualizarNombre.Text;
                    bool resultado = false;

                        resultado = ValidarNombreUsuario(NombreUsu); //metodo que valida si el usuario fue encontrado, devuelve true si fue encontrado y lo almacena en resultado
                        if (resultado == true) // esto se realiza cuando el usuario fue encontrado en la base de datos
                        {
                            MessageBox.Show("El nombre de usuario ingresado ya existe", "Intento fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtActualizarNombre.Text = "";
                            txtActualizarNombre.Focus();
                        }
                        else
                        {
                            modificacionNombreFinal(txtActualizarNombre.Text);
                            
                            LoginForm salirSesion = new LoginForm();
                            salirSesion.Show();
                            this.Hide();
                        }

                }
                
               

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             if (rdbNombre.Checked)
            {
                lblUsuarioActualizar.Enabled = true;
                txtActualizarNombre.Enabled = true;
                rdbContraseña.Enabled = false;
                rdbNombre.Enabled = false;
            }
            else if (rdbContraseña.Checked)
            {
                lblClaveActualizar.Enabled = true;
                txtActualizarClave.Enabled = true;
                rdbContraseña.Enabled = false;
                rdbNombre.Enabled = false;
            }
            


        }
    }
}
