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
    public partial class RegistrarUsuarioForm : Form
    {
        private UsuarioServicios usu;
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
            
        }

        private void btnLimpiarNuevoUsu_Click(object sender, EventArgs e)
        {
           LimpiarCampos(); 
        }

        private void btnConfirmarAlta_Click(object sender, EventArgs e)
        {
            if (txtNombreNuevoUsu.Text.Equals("")) // aca se corrobora que se haya ingresado algun nombre de usuario
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreNuevoUsu.Focus();
            }
            else
            { //una vez que se verifica que se ingresó un nombre, verificamos que las contraseñas ingresadas sean iguales 
                if (txtNuevaContraUsu.Text.Equals("") || txtRepetirNuevaContraUsu.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese contraseña y repitala porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraUsu.Text = "";
                    txtRepetirNuevaContraUsu.Text = "";
                    txtNuevaContraUsu.Focus();
                }
                else 
                {

                    if (txtNuevaContraUsu.Text.Equals(txtRepetirNuevaContraUsu.Text) && (txtNombreNuevoUsu.Text != ("") )) //verifica que las dos contraseñas son iguales y que no estan vacias
                    {

                        if ((rdbAdmin.Checked) || (rdbVendedor.Checked))
                        {
                            usu = new UsuarioServicios();
                            bool resultado = false;
                            resultado = usu.ValidarNombreUsuario(txtNombreNuevoUsu.Text);
                            if (resultado == true) // si el resultado da true es porque hay algun usuario registrado en la BD con ese nombre
                            {
                                MessageBox.Show("El nombre de usuario ingresado ya existe, por favor ingresar otro", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtNombreNuevoUsu.Text = "";
                                txtNombreNuevoUsu.Focus();
                            }
                            else
                            { // si el resultado da false es porque no existe ningún usuario registrado con ese nombre y se continua con el proceso
                                string rolChk = rdbVendedor.Text;
                                if (rdbAdmin.Checked)
                                {
                                    rolChk = rdbAdmin.Text;
                                }

                                usu = new UsuarioServicios();
                                bool Resultado = usu.InsertarUsuario(txtNombreNuevoUsu.Text, txtNuevaContraUsu.Text, rolChk);
                               

                                if (Resultado == true) // si el resultado del método insertar es true, es porque se pudo añadir un usuario nuevo
                                {
                                    MessageBox.Show("Usuario dado de alta con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpiarCampos();
                                    txtNombreNuevoUsu.Focus();
                                    LoginForm ventana = new LoginForm(); 
                                    ventana.Show(); 
                                    this.Hide(); 
                                }
                                else // si es false es que no se pudo añadir por algun motivo
                                {
                                    MessageBox.Show("No se pudo dar de alta el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("Tiene que seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    { // en el caso de que se hayan ingresado dos contrseñas distintas, se las tiene que volver a ingresar
                        MessageBox.Show("Las constraseñas ingresadas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNuevaContraUsu.Text = "";
                        txtRepetirNuevaContraUsu.Text = "";
                        txtNuevaContraUsu.Focus();


                    }
                }
            }


        }

        //MÉTODOS AUXILIARES
       
        private void LimpiarCampos()
        {
            txtNombreNuevoUsu.Text = "";
            txtNuevaContraUsu.Text = "";
            txtRepetirNuevaContraUsu.Text = "";
        }

        
    }

    
      
}
