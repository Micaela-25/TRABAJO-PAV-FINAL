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
    public partial class ReporteVentas : Form
    {
        private TransaccionServicios transSer;
        private Usuario usu;
        public ReporteVentas(Usuario usuLogin)
        {        
            InitializeComponent();
            transSer = new TransaccionServicios();
            usu = usuLogin;
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;

            //this.reportViewer1.RefreshReport();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {           
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.dsVentasPorFechasBindingSource.DataSource = transSer.RecuperarVentasFechas(dtpFechaDesde.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpFechaHasta.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            this.reportViewer1.RefreshReport();
            //DateTime myDate = dtpFechaDesde.Value.Date + dtpFechaDesde.Value.TimeOfDay;
            //string fechaDesde = myDate.ToString("yyyy-MM-dd HH:mm:ss");

            //DateTime myDate1 = dtpFechaHasta.Value.Date + dtpFechaHasta.Value.TimeOfDay;
            //string fechaHasta = myDate1.ToString("yyyy-MM-dd HH:mm:ss");
            //transSer.RecuperarVentasFechas (fechaDesde, fechaHasta);
            //transSer.RecuperarVentasFechas (dtp, fechaHasta);
            //dsVentasPorFechasBindingSource
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }
    }
}
