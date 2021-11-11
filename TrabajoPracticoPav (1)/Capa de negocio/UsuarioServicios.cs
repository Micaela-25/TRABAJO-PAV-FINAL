using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Base_de_datos;
using TrabajoPractico.Entidades;

namespace TrabajoPractico.Capa_de_negocio
{
    public class UsuarioServicios
    {
        private BD BaseDatos;
        private string NombreUsuario;
        private string PasswordUsuario;
        private string RolUsuario;
        private int id;
        private Usuario usuarioEnlogin;

       
        public UsuarioServicios ()
        {
            BaseDatos = new BD();
        }
        
        //public UsuarioServicios(string nombre, string password)
        //{
        //    NombreUsuario = nombre;
        //    PasswordUsuario = password;
        //    usuarioEnlogin = new Usuario(nombre, password);
        //    BaseDatos = new BD();

        //}
        //public UsuarioServicios(string nombre, string password, string rol, int idUsu)
        //{
        //    NombreUsuario = nombre;
        //    PasswordUsuario = password;
        //    RolUsuario = rol;
        //    id = idUsu;
        //    usuarioEnlogin = new Usuario(nombre, password, rol, idUsu);
        //    BaseDatos = new BD();
        //}

        //public UsuarioServicios(Usuario user)
        //{
        //    this.NombreUsuario = user.NombreUsuario;
        //    PasswordUsuario = user.password;
        //    RolUsuario = user.rol;
        //    usuarioEnlogin = user;
        //    BaseDatos = new BD();
        //}

        //public UsuarioServicios(string nombre, string password, string rol)
        //{
        //    NombreUsuario = nombre;
        //    PasswordUsuario = password;
        //    RolUsuario = rol;
        //    usuarioEnlogin = new Usuario(nombre, password, rol);
            
        //}


        //--------------------------------------------------INICIAR SESION----------------------------------------------------------------------------

        public Usuario CrearUsu(string nombre, string password)
        {
            string rol = BuscarRol(nombre);
            int id = BuscaridUsuario(nombre);
            Usuario usuario = new Usuario(nombre, password, rol, id);
            return usuario;
        }


        public bool ValidarUsuario(string NombreUsuario, string PasswordUsuario) //BUSCA QUE EL USUARIO INGRESADO EXISTA EN LA BD
        {
            bool resultado = false;
            try
            {

                resultado = BaseDatos.ValidarUsuarioBD(NombreUsuario, PasswordUsuario); //metodo  que valida que 
                                                                                 // el usuario exista en la base de datos                                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        public int BuscaridUsuario(string nombre)
        {
            int idUsu = -1;
            try
            {
                idUsu = BaseDatos.idUsuarioBD(nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idUsu;
        }

        public string BuscarRol(string nombre) //BUSCA EN LA BASE DE DATOS EL ROL DEL USUARIO EN SESIÓN
        {
            string resultadoRol = "";
            try
            {
                resultadoRol = BaseDatos.BuscarRolBD(nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultadoRol;

        }



        //--------------------------------------------------ALTA USUARIO----------------------------------------------------------------------------
        public bool ValidarNombreUsuario(string NombreUsu) // aca se valida que el usuario no exista previamente en la base de datos
        {
            bool resultado = false;
            try
            {

                resultado = BaseDatos.ValidarNombreUsuarioBD(NombreUsu);

            }
            catch (Exception ex)
            {
                MessageBox.Show("El nombre ingresado ya pertenece a otro usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        public void crearPrincipal(Usuario usu)
        {
            PrincipalForm ventana = new PrincipalForm(usu);
            ventana.Show(); //abre el principal
            
        }

        public bool InsertarUsuario(string nombre, string password, string rol) //este método se realiza para insertar el usuario a la base de datos
        {
            bool resultado = false;
            try
            {

                resultado = BaseDatos.InsertarUsuarioBD(nombre, password, rol);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        //--------------------------------------------------CONSULTA USUARIO----------------------------------------------------------------------------
        public DataTable CargarGrillaVendedor(int codigo)
        {
            DataTable resultado = new DataTable();
            try
            {
               resultado = BaseDatos.CargarGrillaVendedorBD(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return resultado;

        }
        public DataTable CargarGrillaAdministrador()
        {
            DataTable resultado = new DataTable();
            try
            {
                resultado = BaseDatos.CargarGrillaAdministradorBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;

        }
        //--------------------------------------------------BAJA USUARIO------------------------------------------------------------------------------------
        public void EliminarUsuario(string Nombreusu)
        {
            try
            {
                BaseDatos.EliminarUsuarioBD(Nombreusu);
                MessageBox.Show("Se ha eliminado el usuario correctamente", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------MODIFICACION USUARIO----------------------------------------------------------------------------
        public void modificacionNombre(string nombre, int id)
        {
            try
            {
                BaseDatos.modificacionNombreBD(nombre, id);
                MessageBox.Show("El usuario se modifico con éxito!", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificacionClave(string clave, int id)
        {
            try
            {
                BaseDatos.modificacionClaveBD(clave, id);
                MessageBox.Show("El usuario se modifico con éxito!", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarUsuarioModificar(string NombreUsuario)
        {
            bool resultado = false;
            try
            {
                resultado = BaseDatos.ValidarNombreNuevoBD(NombreUsuario);                                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("El nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
    }
}
