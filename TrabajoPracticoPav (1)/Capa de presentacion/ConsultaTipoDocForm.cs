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
    public partial class ConsultaTipoDocForm : Form
    {
        private Usuario usu;
        private TipoDocServicios tipoDocSer;
        private string TipoDocAEliminar;
        public ConsultaTipoDocForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            tipoDocSer = new TipoDocServicios();
            TipoDocAEliminar = "";
        }

        private void btnEliminarTipoDoc_Click(object sender, EventArgs e)
        {

                EliminarTipoDocFinal(int.Parse(TipoDocAEliminar));
                
                CargarGrillaTipoDocFinal(gdrConsultaTipoDoc, tipoDocSer.RecuperarTodosTipoDoc());


        }
           


        private void btnVolverConsultaTipoDoc_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void LimpiarCampos()
        {
            txtNombreTipoDocConsulta.Text = "";          
            txtDescripcionTipoDocConsulta.Text = "";
        }

        private void ConsultaTipoDocForm_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void CargarGrillaTipoDocFinal(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                    grilla.Rows.Add(tabla.Rows[i]["Id_Tipo_Doc"],
                                    tabla.Rows[i]["Nombre"],
                                    tabla.Rows[i]["Descripción"]);

        }

        private void btnConsultarTipoDoc_Click(object sender, EventArgs e)
        {
            consultarTiposDocFinal(txtNombreTipoDocConsulta.Text, txtDescripcionTipoDocConsulta.Text, chkBaja.Checked);
            LimpiarCampos();
        }

        private void consultarTiposDocFinal (string nom, string desc,  bool chequedado)
        {
            List<Parametro> filtros = new List<Parametro>(); //crear la lista que va a contener los valores por los que se filtra
            
            
            //crear el objeto parametro para el Nombre, vendria a ser un filtro
            Parametro nombre = new Parametro();
            nombre.Nombre = "@nombre";
            object val1 = DBNull.Value;
            if (!String.IsNullOrEmpty(nom))
                val1 = nom;
            nombre.Valor = val1;

            //crear el objeto parametro para la descripcion, vendria a ser un filtro
            Parametro Descripcion = new Parametro();
            Descripcion.Nombre = "@descripcion";
            object val2 = DBNull.Value;
            if (!String.IsNullOrEmpty(desc))
                val2 = desc;
            Descripcion.Valor = val2;


            //crear el objeto parametro para la baja, vendria a ser un filtro
            Parametro Bajas = new Parametro();
            Bajas.Nombre = "@bajas";
            int conBaja = 0;
            if (chequedado)
                conBaja = 1;
            Bajas.Valor = conBaja;

            //Agregar a la lista filtros los parametros creados
            //filtros.Add(codigo);
            filtros.Add(nombre);
            filtros.Add(Descripcion);
            filtros.Add(Bajas);

            //hago otra lista con los resultados de los filtros devueltos por la base de datos
            List<TipoDoc> listaResultados = new List<TipoDoc>();
            listaResultados = tipoDocSer.consultarTiposDoc(filtros);
            filtros.Clear();

            gdrConsultaTipoDoc.Rows.Clear();
            if (listaResultados.Count != 0)
            {
                foreach (TipoDoc t in listaResultados)
                {
                    gdrConsultaTipoDoc.Rows.Add(new object[]
                    {
                    t.id, 
                    t.nombre,
                    t.descripcion,
                    t.borrado,                 
                    });
                }
            }
            else
            {
                MessageBox.Show("No hay tipos de documentos cargados", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listaResultados.Clear();
        }
        private void gdrConsultaTipoDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrConsultaTipoDoc.Rows[indice];
            TipoDocAEliminar= filaSeleccionada.Cells["Código"].Value.ToString();
        }

        private void EliminarTipoDocFinal(int id)
        {

                tipoDocSer.EliminarTipoDoc(id);
        }

        
    }
}
