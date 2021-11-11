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
    public partial class AltaTipoDocForm : Form

    {
        private Usuario usu;
        private TipoDocServicios tipoDocSer;
        public AltaTipoDocForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            tipoDocSer = new TipoDocServicios();
        }

        private void btnVolverNuevoTipoDoc_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void LimpiarCampos()
        {
            txtDescrpciónNuevoTipoDoc.Text = "";
            txtNombreNuevoTipoDoc.Text = "";

        }

        private void btnLimpiarCamposNuevoTipoDoc_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAltaNuevoTipoDoc_Click(object sender, EventArgs e)
        {
                bool resultado = InsertarTipoDocFinal(txtNombreNuevoTipoDoc.Text, txtDescrpciónNuevoTipoDoc.Text);
                if (resultado == true)
                {
                    MessageBox.Show("Tipo de documento registrado con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private bool InsertarTipoDocFinal(string Nombre, string Descr)
        {
            bool resultado = true;
            bool resultadoValidar = tipoDocSer.ValidarNombreTipoDoc(Nombre);

            if (resultadoValidar == true)
            {
                resultado = tipoDocSer.InsertarTipoDoc(Nombre, Descr);
                
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ya existe ese tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }

            return resultado;

        }
    }
}
