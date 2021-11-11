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
    public partial class ReporteEmpleadosForm : Form
    {
        private TransaccionServicios transSer;
        private Usuario usu;
        public ReporteEmpleadosForm(Usuario usuLogin)
        {
            InitializeComponent();
            transSer = new TransaccionServicios();
            usu = usuLogin;
       
        }

        private void ReporteEmpleadosForm_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesdeEmpleados.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHastaEmpleados.Value = DateTime.Today;
            //this.reportViewer1.RefreshReport();
        }

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesdeEmpleados.Value > dtpFechaHastaEmpleados.Value)
            {
                MessageBox.Show("Fechas erroneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.dsEmpleadosVentasBindingSource.DataSource = transSer.RecuperarVentasEmpleados(dtpFechaDesdeEmpleados.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpFechaHastaEmpleados.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            this.reportViewer1.RefreshReport();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }
    }
}
