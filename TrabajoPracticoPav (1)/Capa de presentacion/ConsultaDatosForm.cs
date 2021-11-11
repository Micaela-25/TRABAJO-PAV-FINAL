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
    public partial class ConsultaDatosForm : Form
    {
        private int UsuarioABuscar;
        private Usuario user;
        private string usuarioAEliminar;
        private UsuarioServicios userServicios;

        public ConsultaDatosForm(Usuario usuLogin)
        {
            InitializeComponent();
            userServicios = new UsuarioServicios();
            user = usuLogin;

            // esta es una variable que almacena el usuario en sesion y se usa para el boton volver
            UsuarioABuscar = user.Id; // esta es una varible que se utiliza para saber cargar los datos de que usuario esta en sesion utilizado tambien en el boton eliminar
            if (user.rol == "Vendedor")
            {   
                CargarGrillaVendedorFinal(UsuarioABuscar);
                btnEliminarDatos.Visible = false;
            }
            else 
            {
                CargarGrillaAdministradorFinal();
            }           
        }
        

        private void CargarGrillaVendedorFinal(int codigo)
        {
            DataTable tabla = new DataTable();
            tabla = userServicios.CargarGrillaVendedor(codigo);
            grConsultaDatos.DataSource = tabla;
            grpDatosUsuario.Visible = true;
            

        }

        public void CargarGrillaAdministradorFinal()
        {
            DataTable tabla = new DataTable();
            tabla = userServicios.CargarGrillaAdministrador();
            grConsultaDatos.DataSource = tabla;
            grpDatosUsuario.Visible = true;
           
        }
        

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta operacion es irreversible ¿Estas seguro que desea continuar", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                   userServicios.EliminarUsuario(usuarioAEliminar); //metodo declarado mas abajo que manda la consulta a la bd
                   
                   CargarGrillaAdministradorFinal();
               
            }
            
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(user);
            volverPrincipal.Show();
            this.Hide();
        }

        private void grConsultaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grConsultaDatos.Rows[indice];
            usuarioAEliminar = filaSeleccionada.Cells["NombreUsuario"].Value.ToString();
            
            
        }

    }
}
