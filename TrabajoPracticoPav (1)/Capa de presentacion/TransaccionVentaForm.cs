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
    public partial class TransaccionVentaForm : Form
    {
        private TransaccionServicios TranSer;
        private DataTable TablaUltima;
        private string nombreUltimo;
        private CopiaPrendaStock copia;
        private List<CopiaPrendaStock> listaDetalle;
        private string PrendaEliminar;
        private float contadorSubtotal;
        private int contadorCantidad;
        private Usuario usu;

        public TransaccionVentaForm( Usuario usuariologin)
        {
            InitializeComponent();
            TranSer = new TransaccionServicios(); 
            DataTable TablaUltima = new DataTable();
            nombreUltimo = "";
            listaDetalle = new List<CopiaPrendaStock>();
            PrendaEliminar = "";
            contadorCantidad = 0;
            contadorSubtotal = 0;
            usu = usuariologin;

        }

        private void btnBuscarPrenda_Click(object sender, EventArgs e)
        {
            gdrPrendaTrans.Rows.Clear();
            try
            {
                TablaUltima = buscarPrendaFiltradaFinal(int.Parse(txtFiltroCodigoTrans.Text));
                if (TablaUltima.Rows.Count == 0)
                {
                    MessageBox.Show("No existe esa prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                int tipo = int.Parse(TablaUltima.Rows[0][1].ToString());
                nombreUltimo = buscarNombreTipoFinal(tipo);
                TranSer.CargarGrillaPrendaTransFinal(gdrPrendaTrans, TablaUltima, nombreUltimo);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El código ingresado es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFiltroCodigoTrans.Text = "";
                txtFiltroCodigoTrans.Focus();
            }

        }

        private DataTable buscarPrendaFiltradaFinal (int codigo)
        {

            DataTable tabla = new DataTable();
            tabla = TranSer.buscarPrendaFiltrada(codigo);
            return tabla;

        }
        private string buscarNombreTipoFinal(int tipo)
        {
            string nombre = TranSer.buscarNombreTipo(tipo);
            return nombre;
        }
       

        private void btnAgregarADetalleTrans_Click(object sender, EventArgs e)
        {
            CopiaPrendaStock copia = CrearObjetoCopia();
            (contadorCantidad, contadorSubtotal)=TranSer.agregarPrendaALista(listaDetalle, copia);
            TranSer.CargarGrillaPrendaTranConLista(listaDetalle, gdrAgregadoADetalleTrans);
            txtCantPrendasTran.Text = contadorCantidad.ToString();
            txtSubtotalTran.Text = contadorSubtotal.ToString();

        }

        private CopiaPrendaStock CrearObjetoCopia()
        {  
            int codigoPrenda = int.Parse(TablaUltima.Rows[0][0].ToString());
            int Tipo = int.Parse(TablaUltima.Rows[0][1].ToString());
            string Desc = TablaUltima.Rows[0][2].ToString();
            string nombre = TablaUltima.Rows[0][3].ToString();
            float precio = float.Parse(TablaUltima.Rows[0][4].ToString());
            int cant = int.Parse(TablaUltima.Rows[0][5].ToString());
            string color = TablaUltima.Rows[0][6].ToString();
            string marca = TablaUltima.Rows[0][7].ToString();
            int talle = int.Parse(TablaUltima.Rows[0][10].ToString());
            CopiaPrendaStock copia = new CopiaPrendaStock(codigoPrenda, nombre, Desc, marca, color, precio, Tipo, cant, talle);
            return copia;
        }

        private void btnEliminarPrendaDetalleTran_Click(object sender, EventArgs e)
        {
            if (gdrAgregadoADetalleTrans.Rows.Count != 0 && PrendaEliminar != "")
            {
                (contadorCantidad, contadorSubtotal) = TranSer.EliminarPrendaLista(int.Parse(PrendaEliminar), listaDetalle);
                MessageBox.Show("La prenda se eliminó con éxito", "Eliminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TranSer.CargarGrillaPrendaTranConLista(listaDetalle, gdrAgregadoADetalleTrans);
                txtCantPrendasTran.Text = contadorCantidad.ToString();
                txtSubtotalTran.Text = contadorSubtotal.ToString();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar una prenda", "Eliminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


}

        private void gdrAgregadoADetalleTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrAgregadoADetalleTrans.Rows[indice];
            PrendaEliminar = filaSeleccionada.Cells["CodigoPrenda"].Value.ToString();
        }

 

        private void btnContinuarVentaTran_Click(object sender, EventArgs e)
        {
            if (gdrAgregadoADetalleTrans.Rows.Count != 0)
            {
                TransaccionVentaContinuaciónForm ventana = new TransaccionVentaContinuaciónForm(listaDetalle, float.Parse(txtSubtotalTran.Text), int.Parse(txtCantPrendasTran.Text), usu);
                ventana.ShowDialog(); //abre 
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay prendas cargadas", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
