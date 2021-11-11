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
    public partial class AltaTipoPrendaForm : Form
    {
        private Usuario usu;
        private TipoPrendaServicios TipoPrendaSer;
        public AltaTipoPrendaForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            
        }

        private void btnAltaNuevoTipo_Click(object sender, EventArgs e)
        {
            TipoPrendaSer = new TipoPrendaServicios(txtNombreNuevoTipo.Text, txtDescrpciónNuevoTipo.Text);

                bool resultado = TipoPrendaSer.InsertarTipoPrenda();
               
                if (resultado == true)
                {
                    MessageBox.Show("Tipo de prenda registrado con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    LimpiarCampos();
                }
        }

        private void btnLimpiarCamposNuevoTipo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDescrpciónNuevoTipo.Text = "";
            txtNombreNuevoTipo.Text = "";
        }

        private void btnVolverNuevoTipo_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

       
      
    }


}
