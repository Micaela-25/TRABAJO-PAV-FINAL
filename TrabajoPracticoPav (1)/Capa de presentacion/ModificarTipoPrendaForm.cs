using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Capa_de_negocio;
using TrabajoPractico.Entidades;

namespace TrabajoPractico.Capa_de_presentacion
{
    public partial class ModificarTipoPrendaForm : Form
    {
        private Usuario usu;
        private TipoPrendaServicios TipoPrendaSer;
        private string TipoPrendaAModificar;

        public ModificarTipoPrendaForm(Usuario usuLogin)
        {
            InitializeComponent();
            TipoPrendaSer = new TipoPrendaServicios();
            usu = usuLogin;
            CargarGrillaTipoPrendaFinal();
        }

        private void btnVolverActualizarTipo_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void btnModificarTipoPrenda_Click(object sender, EventArgs e)
        {
            modificarTipoPrendaFinal(txtActualizarNombreTipo.Text, txtActualizarDescripciónTipo.Text, int.Parse(TipoPrendaAModificar));
            CargarGrillaTipoPrendaFinal();
        }

        private void modificarTipoPrendaFinal(string nombre, string descripcion, int TipoPrenda)
        {
            TipoPrendaSer.modificarTipoPrenda(nombre, descripcion, TipoPrenda);

        }

        private void CargarCamposFinal(int tipoModificar)
        {
                DataTable tabla = TipoPrendaSer.CargarCamposNombre(tipoModificar);
                lblModificaciónDescrTipo.Enabled = true;
                lblModificaciónNombreTipo.Enabled = true;
                txtActualizarDescripciónTipo.Enabled = true;
                txtActualizarNombreTipo.Enabled = true;
                txtActualizarNombreTipo.Text = tabla.Rows[0][1].ToString();
                txtActualizarDescripciónTipo.Text = tabla.Rows[0][2].ToString();
                txtActualizarNombreTipo.Focus();
                btnModificarTipoPrenda.Enabled = true;


        }
        private void limpiarCampos()
        {
            txtActualizarNombreTipo.Text = "";
            txtActualizarDescripciónTipo.Text = "";

        }

        private void CargarGrillaTipoPrendaFinal()

        {
            DataTable tabla = new DataTable();
                tabla = TipoPrendaSer.CargarGrillaTipoPrenda();
                gdrConsultaTipoPrenda.DataSource = tabla;
                gdrConsultaTipoPrenda.Visible = true;

        }

        private void gdrConsultaTipoPrenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrConsultaTipoPrenda.Rows[indice];
            TipoPrendaAModificar = filaSeleccionada.Cells["IdTipoPrenda"].Value.ToString();
            CargarCamposFinal(int.Parse(TipoPrendaAModificar));
            
        }

    }        
}
