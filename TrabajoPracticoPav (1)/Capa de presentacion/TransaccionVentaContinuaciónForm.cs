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
    public partial class TransaccionVentaContinuaciónForm : Form
    {

        private DataTable tablaConCliente;
        private TransaccionServicios TranSer;
        private List<CopiaPrendaStock> ListaDetalle;
        private Cliente client;
        private float Total;
        private int Cant;
        private Usuario usu;

        public TransaccionVentaContinuaciónForm(List<CopiaPrendaStock> listaDetalle, float total, int cantidad, Usuario usuEnLogin)
        {
            InitializeComponent();
            tablaConCliente = new DataTable();
            TranSer = new TransaccionServicios();
            CargarComboTipoDoc();
            CargarComboFormaPagoFinal();
            ListaDetalle = new List<CopiaPrendaStock>();
            ListaDetalle = listaDetalle;
            Cant = cantidad;
            Total = total;
            usu = usuEnLogin;

        }

        private void btnBuscarDocClieTran_Click(object sender, EventArgs e)
        {
           if ( txtDocFiltroCliente.Text != "")
            {
                tablaConCliente = TranSer.BuscarClientePorDoc(int.Parse(txtDocFiltroCliente.Text));

                if (tablaConCliente.Rows.Count != 0)
                {
                    txtNomClieTran.Text = tablaConCliente.Rows[0][1].ToString();
                    txtApeClieTran.Text = tablaConCliente.Rows[0][2].ToString();
                    cmbTipoDocClieTran.SelectedValue = int.Parse(tablaConCliente.Rows[0][3].ToString());
                    int codigo = int.Parse(tablaConCliente.Rows[0][3].ToString());
                    txtNroDocClieTrn.Text = tablaConCliente.Rows[0][4].ToString();
                    txtMailClieTran.Text = tablaConCliente.Rows[0][5].ToString();
                    txtNroTelClieTran.Text = tablaConCliente.Rows[0][6].ToString();
                    client = new Cliente(txtNomClieTran.Text, txtApeClieTran.Text, codigo , int.Parse(txtNroDocClieTrn.Text), txtMailClieTran.Text, long.Parse(txtNroTelClieTran.Text));
                    
                    DenegarCampos();
                }
                else
                {
                    HabilitarCampos();
                    LimpiarCampos();
                }
            }
           else
            {
                MessageBox.Show("Ingresar un numero de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CargarComboTipoDoc()
        {
            DataTable tabla = new DataTable();

                tabla = TranSer.CargarComboTipoDoc();
                cmbTipoDocClieTran.DataSource = tabla;
                cmbTipoDocClieTran.DisplayMember = "Nombre";
                cmbTipoDocClieTran.ValueMember = "Id_Tipo_Doc";
                cmbTipoDocClieTran.SelectedIndex = -1;
           

        }

        private void DenegarCampos()
        {
            txtNomClieTran.Enabled = false;
            txtApeClieTran.Enabled = false;
            
            txtMailClieTran.Enabled = false;
            txtNroDocClieTrn.Enabled = false;
            txtNroTelClieTran.Enabled = false;
            cmbTipoDocClieTran.Enabled = false;
            btnAgregarClienteTran.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNomClieTran.Enabled = true;
            txtApeClieTran.Enabled = true;
           
            txtMailClieTran.Enabled = true;
            txtNroDocClieTrn.Enabled = true;
            txtNroTelClieTran.Enabled = true;
            cmbTipoDocClieTran.Enabled = true;
            btnAgregarClienteTran.Enabled = true;
        }



        private void btnAgregarClienteTran_Click(object sender, EventArgs e)
        {

            if ((txtApeClieTran.Text == "") || (txtNomClieTran.Text == "") || (txtMailClieTran.Text == "" )|| (txtNroDocClieTrn.Text == "") || (txtNroTelClieTran.Text == "") || (cmbTipoDocClieTran.SelectedIndex == -1))
            {
                MessageBox.Show("Se deben cargar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
            else
            {
                string nom = txtNomClieTran.Text;
                string ape = txtApeClieTran.Text;
                int tipo = int.Parse(cmbTipoDocClieTran.SelectedValue.ToString());
                int nroDoc = int.Parse(txtNroDocClieTrn.Text);
                string mail = txtMailClieTran.Text;
                long nroTel = long.Parse(txtNroTelClieTran.Text);

                
                DataTable tabla = new DataTable();
                tabla = TranSer.BuscarClientePorDoc(int.Parse(txtNroDocClieTrn.Text));
                if (tabla.Rows.Count == 0)
                {
                    client = new Cliente(nom, ape, tipo, nroDoc, mail, nroTel);
                    DenegarCampos();
                    txtDocFiltroCliente.Enabled = false;
                    btnAgregarClienteTran.Enabled = false;

                }
                else
                {
                    MessageBox.Show("El documento ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroDocClieTrn.Text = "";
                    txtNroDocClieTrn.Focus();
                }
            }
            
            
        }

        private void LimpiarCampos()
        {
            txtApeClieTran.Text = "";
            txtNomClieTran.Text = "";
            txtMailClieTran.Text = "";
            txtNroDocClieTrn.Text = "";
            txtNroTelClieTran.Text = "";
            cmbTipoDocClieTran.SelectedIndex = -1;
        }

        private void CargarComboFormaPagoFinal()
        {
            DataTable tabla = new DataTable();
 
                tabla = TranSer.CargarComboFormaPago();
                cmbFormaDePago.DataSource = tabla;
                cmbFormaDePago.DisplayMember = "Nombre";
                cmbFormaDePago.ValueMember = "Id_Forma";
                cmbFormaDePago.SelectedIndex = -1;
            

        }

        private void btnContinuarVentaFinal_Click(object sender, EventArgs e)
        {
            if (btnAgregarClienteTran.Enabled == false && cmbFormaDePago.SelectedIndex != -1)
            {
                int id_forma_pago = int.Parse(cmbFormaDePago.SelectedValue.ToString());
                int id_tipo_doc = int.Parse(cmbTipoDocClieTran.SelectedValue.ToString());
                FinalizarVentaForm ventana = new FinalizarVentaForm(ListaDetalle, client, Total, Cant, id_forma_pago, id_tipo_doc, usu);
                ventana.ShowDialog(); //abre 
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se puede continuar hasta no tener todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
