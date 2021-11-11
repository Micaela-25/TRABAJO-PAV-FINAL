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
    public partial class ConsultaTipoPrendaForm : Form
    {
        private Usuario usu;
        private string TipoPrendaAEliminar;
        private TipoPrendaServicios TipoPrendaSer;

        public ConsultaTipoPrendaForm(Usuario usuLogin)
        {
            InitializeComponent();
            TipoPrendaSer = new TipoPrendaServicios();
            usu = usuLogin;
            CargarGrillaTipoPrendaFinal();

        }

        private void btnVolverConsultaTipoPrenda_Click(object sender, EventArgs e)
        {
            
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void btnEliminarTipoPrenda_Click(object sender, EventArgs e)
        {
                eliminarTipoPrendaFinal(int.Parse(TipoPrendaAEliminar));
                CargarGrillaTipoPrendaFinal();
        }

        private void eliminarTipoPrendaFinal(int Codigo)
        {
                TipoPrendaSer.eliminarTipoPrenda(Codigo);  
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
            TipoPrendaAEliminar = filaSeleccionada.Cells["IdTipoPrenda"].Value.ToString();
        }

    }
}


