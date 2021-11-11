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
    public partial class ConsultaPrenda : Form
    {
        private string PrendaAEliminar;
        private Usuario usu;
        private PrendaServicios prendaSer;

        public ConsultaPrenda(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            prendaSer = new PrendaServicios();
            CargarGrillaPrendaFinal();
            PrendaAEliminar = "";
        }

        private void CargarGrillaPrendaFinal()
        {
                prendaSer.CargarGrillaPrenda(gdrConsultaPrenda);
                gdrConsultaPrenda.Visible = true;
            
        }

        private void EliminarPrendaFinal(int codigo)
        {         
                prendaSer.EliminarPrenda(codigo);      
        }

      

        private void btnEliminarPrenda_Click(object sender, EventArgs e)

        {
            if (PrendaAEliminar != "")
            {
                EliminarPrendaFinal(int.Parse(PrendaAEliminar));

                CargarGrillaPrendaFinal();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar una prenda", "Eliminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolverConsultaPrenda_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void gdrConsultaPrenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrConsultaPrenda.Rows[indice];
            PrendaAEliminar = filaSeleccionada.Cells["CodigoPrenda"].Value.ToString();
        }

        
    }
}
