using Microsoft.Reporting.WinForms;
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
    public partial class ReporteTipoPrendaForm : Form
    {
        private TipoPrendaServicios tipoSer = new TipoPrendaServicios();
        private Usuario usu;
        public ReporteTipoPrendaForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
        }

        private void ReporteTipoPrendaForm_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesdeTipo.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHastaTipo.Value = DateTime.Today;
            //this.reportViewer1.RefreshReport();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            if (txtCant1.Text == "" || txtCant2.Text == "")
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int cant1 = int.Parse(txtCant1.Text);
                int cant2 = int.Parse(txtCant2.Text);
                DataTable tabla = new DataTable();
                tabla = tipoSer.ReportesTipoPrenda(cant1, cant2, dtpFechaDesdeTipo.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpFechaHastaTipo.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
                reportViewer1.LocalReport.DataSources.Add(ds);
            }


            //this.dsTipoPrendaBindingSource.DataSource = tipoSer.ReportesTipoPrenda();
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

