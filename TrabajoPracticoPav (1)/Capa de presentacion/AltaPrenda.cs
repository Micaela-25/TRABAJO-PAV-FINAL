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
    public partial class AltaPrenda : Form
    {
        private Usuario usu;
        private PrendaServicios prendaSer;


        public AltaPrenda(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            prendaSer = new PrendaServicios();
            CargarComboTalleFinal();
            CargarComboFinal();

        }

        private void btnLimpiarCamposPrenda_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombreNuevaPrenda.Text = "";
            txtCantidadNuevasPrendas.Text = "";
            txtColorNuevaPrenda.Text = "";
            txtDescripcionNuevaPrenda.Text = "";
            txtMarcaNuevaPrenda.Text = "";
            txtPrecioUnitarioNuevaPrenda.Text = "";
            cmbTallePrenda.SelectedIndex = -1;
            cmbTipoNuevaPrenda.Text = "";
        }

        private void btnRegistrarNuevaPrenda_Click(object sender, EventArgs e)
        {
            PrendaRopa prenda = new PrendaRopa();
            prenda.nombre = txtNombreNuevaPrenda.Text; 
            prenda.descripcion = txtDescripcionNuevaPrenda.Text;
            prenda.cantidad = int.Parse(txtCantidadNuevasPrendas.Text);
            prenda.color = txtColorNuevaPrenda.Text;
            prenda.marca = txtMarcaNuevaPrenda.Text;
            prenda.precioUni =float.Parse(txtPrecioUnitarioNuevaPrenda.Text);
            prenda.tipo =(int)cmbTipoNuevaPrenda.SelectedValue;
            prenda.talle = (int)cmbTallePrenda.SelectedValue;



                bool resultado = prendaSer.InsertarPrenda(prenda);
                if (resultado == true)
                {
                    MessageBox.Show("Prenda registrada con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            
       
        }


        private void CargarComboFinal()
        {
            DataTable tabla = new DataTable();
                tabla = prendaSer.CargarCombo();
                cmbTipoNuevaPrenda.DataSource = tabla;
                cmbTipoNuevaPrenda.DisplayMember = "Nombre";
                cmbTipoNuevaPrenda.ValueMember = "IdTipoPrenda";
                cmbTipoNuevaPrenda.SelectedIndex = -1;
           
        }

        private void CargarComboTalleFinal()
        {
            DataTable tabla = new DataTable();

                tabla = prendaSer.CargarComboTalle();
                cmbTallePrenda.DataSource = tabla;
                cmbTallePrenda.DisplayMember = "Nombre";
                cmbTallePrenda.ValueMember = "Id_Talle";
                cmbTallePrenda.SelectedIndex = -1;

        }


        private void AltaPrenda_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            
            
        }

        private void btnVolverAltaPrenda_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
           
        }
    }
}
