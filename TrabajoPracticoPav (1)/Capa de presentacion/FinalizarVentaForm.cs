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
    public partial class FinalizarVentaForm : Form
    {

        private List<CopiaPrendaStock> listaDetalle;
        private Cliente cliente;
        private float Total;
        private int Cant;
        private Usuario usu;
        private TransaccionServicios tranSer;
        private string fecha;
        private int id_forma_pago;
        private int id_tipo;

        public FinalizarVentaForm(List<CopiaPrendaStock> lista, Cliente comprador, float total, int cantidad, int id_forma, int id_tipo_doc, Usuario usuLogin)
        {
            InitializeComponent();
            listaDetalle = new List<CopiaPrendaStock>();
            cliente = new Cliente();
            listaDetalle = lista;
            cliente = comprador;
            Cant = cantidad;
            Total = total;
            id_forma_pago = id_forma;
            id_tipo = id_tipo_doc;
            tranSer = new TransaccionServicios();
            usu = usuLogin;
            txtTotalVentalTranFinal.Enabled = false;
            txtCantPrendasVentaFinal.Enabled = false;
            txtTotalVentalTranFinal.Text = total.ToString();
            txtCantPrendasVentaFinal.Text = cantidad.ToString();
            fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblFechaVentaFinal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            CargarComboFormaPagoFinal();
            cmbFormaDePagoFinal.SelectedValue = int.Parse(id_forma.ToString());
            cmbFormaDePagoFinal.Enabled = false;
            

            CargarGrillaDetalleFinal();
            CargarCamposClientesFinal();
        }

        private void CargarComboTipoDocFinal()
        {
            DataTable tabla = new DataTable();

                tabla = tranSer.CargarComboTipoDoc();
                cmbTipoDocFinal.DataSource = tabla;
                cmbTipoDocFinal.DisplayMember = "Nombre";
                cmbTipoDocFinal.ValueMember = "Id_Tipo_Doc";
                cmbTipoDocFinal.SelectedIndex = -1;

        }


        private void CargarComboFormaPagoFinal()
        {
            DataTable tabla = new DataTable();

                tabla = tranSer.CargarComboFormaPago();
                cmbFormaDePagoFinal.DataSource = tabla;
                cmbFormaDePagoFinal.DisplayMember = "Nombre";
                cmbFormaDePagoFinal.ValueMember = "Id_Forma";
                cmbFormaDePagoFinal.SelectedIndex = -1;
            

        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
           bool resultado = tranSer.TransaccionVenta(usu.Id, fecha, Total, cliente, listaDetalle, id_forma_pago);
           if (resultado)
           {
                MessageBox.Show("La venta se registró con éxito", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            PrincipalForm ventana = new PrincipalForm(usu);
            ventana.Show();
            this.Close();
        }

        private void CargarGrillaDetalleFinal()
        {
            tranSer.CargarGrillaPrendaTranConLista(listaDetalle, gdrDatosPrendasVentaFinal);
        }

        private void CargarCamposClientesFinal()
        {
            txtNomClieTranFinal.Text = cliente.nombre;
            txtApeClieTranFinal.Text = cliente.apellido;
            txtNroDocClieTrnFinal.Text = cliente.nroDocu.ToString();
            txtNroTelClieTranFinal.Text = cliente.nroTele.ToString();
            txtMailClieTranFinal.Text = cliente.email;
            CargarComboTipoDocFinal();
            cmbTipoDocFinal.SelectedValue = int.Parse(id_tipo.ToString());

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            PrincipalForm ventana = new PrincipalForm(usu);
            ventana.Show();
            this.Close();
        }
    }
}
