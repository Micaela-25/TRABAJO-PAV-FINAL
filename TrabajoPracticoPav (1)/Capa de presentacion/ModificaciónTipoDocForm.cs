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
    public partial class ModificaciónTipoDocForm : Form
    {

        private Usuario usu;
        private TipoDocServicios TipoDocSer;
        private string TipoDocAModificar;
        private string NombreViejo;
        public ModificaciónTipoDocForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            TipoDocSer = new TipoDocServicios();
            CargarGrillaTipoDocFinal(gdrConsultaTipoDoc, TipoDocSer.RecuperarTodosTipoDoc());
            NombreViejo = "";
        }

        private void btnModificarTipoDoc_Click(object sender, EventArgs e)
        {
            
                ModificarTipoDocFinal(txtActualizarNombreTipoDoc.Text, txtActualizarDescripciónTipoDoc.Text, int.Parse(TipoDocAModificar), NombreViejo);
                CargarGrillaTipoDocFinal(gdrConsultaTipoDoc, TipoDocSer.RecuperarTodosTipoDoc());
                MessageBox.Show("La modificación se realizó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void ModificarTipoDocFinal(string nom, string des, int id, string nomViejo)
        {
            TipoDocSer.ModificarTipoDoc(nom, des, id, nomViejo);
        }

        private void CargarGrillaTipoDocFinal(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                    grilla.Rows.Add(tabla.Rows[i]["Id_Tipo_Doc"],
                                    tabla.Rows[i]["Nombre"],
                                    tabla.Rows[i]["Descripción"]);

        }

        private void btnVolverActualizarTipoDoc_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void gdrConsultaTipoDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrConsultaTipoDoc.Rows[indice];
            TipoDocAModificar = filaSeleccionada.Cells["Código"].Value.ToString();
            CargarCamposFinal(int.Parse(TipoDocAModificar));
            NombreViejo = TipoDocSer.BuscarNombreAntesCambio(int.Parse(TipoDocAModificar));
        }

        private void CargarCamposFinal(int codigo)
        {
            DataTable tabla = new DataTable();

                tabla = TipoDocSer.CargarCamposTipoDoc(codigo);
                lblModificaciónDescrTipoDoc.Enabled = true;
                lblModificaciónNombreTipoDoc.Enabled = true;
                txtActualizarNombreTipoDoc.Enabled = true;
                txtActualizarDescripciónTipoDoc.Enabled = true;
                txtActualizarNombreTipoDoc.Text = tabla.Rows[0][1].ToString();
                txtActualizarDescripciónTipoDoc.Text = tabla.Rows[0][2].ToString();
                
                btnModificarTipoDoc.Enabled = true;

        }

        private void LimpiarCampos()
        {
            txtActualizarDescripciónTipoDoc.Text = "";
            txtActualizarNombreTipoDoc.Text = "";
        }
    }
}
