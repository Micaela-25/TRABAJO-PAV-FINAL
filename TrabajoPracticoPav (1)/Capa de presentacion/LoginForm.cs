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
    public partial class LoginForm : Form
    {
        private static UsuarioServicios usuSer;
        private Usuario usuario;

        public LoginForm()
        {
            InitializeComponent();

        }
      

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            

            usuSer = new UsuarioServicios();
            //usuario = usu.CrearUsu(txtNombreUsuario.Text, txtPassword.Text);
            // Verificamos el ingreso de los datos de forma correcta
            if (txtNombreUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {   //Si alguno de los dos datos no se completa
                MessageBox.Show("Ingrese nombre de usuario y password", "Intento Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                txtNombreUsuario.Focus(); 
            }
            else // si se completo el nombre de usuario y la contraseña, ahora se validan que
                // coincidan con algun usuario registrado en la base de datos
            {
                
                bool resultado = false;
                resultado = usuSer.ValidarUsuario(txtNombreUsuario.Text, txtPassword.Text);//metodo que valida que el usuario exista en la base de datos

                

                if (resultado == true) // esto se realiza cuando el usuario fue encontrado en la base de datos
                {
                   
                    usuario = usuSer.CrearUsu(txtNombreUsuario.Text, txtPassword.Text);                                      
                    usuSer.crearPrincipal(usuario);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado es inexistente", "Intento fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
       


        //METODOS AUXILIARES
        //para limpiar campos

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void lblRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // cuando se selecciona "registrarme"

        {
            RegistrarUsuarioForm ventana = new RegistrarUsuarioForm();
            ventana.Show(); //abre el principal
            this.Hide();
        }

        
    }
}
