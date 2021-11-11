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
using TrabajoPractico.Capa_de_presentacion;
using TrabajoPractico.Entidades;

namespace TrabajoPractico
{
    public partial class PrincipalForm : Form
    {
        private Usuario usuariologin;

        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            usuariologin = usu;
            string nombre = usu.NombreUsuario.ToString();
            lblBienvenidousu.Text = ("Bienvenido/a " + nombre);

        }
  

        public Usuario obtenerRetornar(Usuario usu)
        {
            return usu;
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDatosForm ventana = new ConsultaDatosForm(usuariologin) ;
            ventana.Show(); //abre el principal
            this.Hide(); //esconde esta ventana

        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuarioForm ventana = new ModificarUsuarioForm(usuariologin);
            ventana.Show(); //abre el principal
            this.Hide(); //esconde esta ventana
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm salirSesion = new LoginForm();
            salirSesion.Show();
            this.Hide();

        }

        private void ConsultaPrendasPrinc_Click(object sender, EventArgs e)
        {
            ConsultaPrenda ventana = new ConsultaPrenda(usuariologin);
            ventana.Show();
            this.Hide();

        }

        private void AgregarPrendasPrincp_Click(object sender, EventArgs e)
        {
            AltaPrenda ventana = new AltaPrenda(usuariologin); //ESTO LO QUE HACE ES LLEVAR AL USUARIO A LA VENTANA DE LA ALTA DE PRENDAS                    
            ventana.Show(); //abre 
            this.Hide(); //esconde esta ventana

        }

        private void modificarPrendaPrinc_Click(object sender, EventArgs e)
        {
           ModificarPrendasForm ventana = new ModificarPrendasForm(usuariologin); //ESTO LO QUE HACE ES LLEVAR AL USUARIO A LA VENTANA DE LA ALTA DE PRENDAS                    
            ventana.Show(); //abre 
            this.Hide();
            
        }

        private void agregarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTipoPrendaForm ventana = new AltaTipoPrendaForm(usuariologin); //ESTO LO QUE HACE ES LLEVAR AL USUARIO A LA VENTANA DE LA ALTA DE TIPO PRENDAS                    
            ventana.Show(); //abre 
            this.Hide();
        }

        private void verTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTipoPrendaForm ventana = new ConsultaTipoPrendaForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void modificarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarTipoPrendaForm ventana = new ModificarTipoPrendaForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTipoDocForm ventana = new AltaTipoDocForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void verMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTipoDocForm ventana = new ConsultaTipoDocForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();

        }

        private void modificarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaciónTipoDocForm ventana = new ModificaciónTipoDocForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaccionVentaForm ventana = new TransaccionVentaForm (usuariologin);
            ventana.Show(); //abre 
            this.Hide();
            
        }

        
        private void listadoDePrendasMasVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteTipoPrendaForm ventana = new ReporteTipoPrendaForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void listadoDeVentasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentas ventana = new ReporteVentas(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        private void listadoDeVentasPorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEmpleadosForm ventana = new ReporteEmpleadosForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTransaccionForm ventana = new EliminarTransaccionForm(usuariologin);
            ventana.Show(); //abre 
            this.Hide();
        }

        
    }


}
