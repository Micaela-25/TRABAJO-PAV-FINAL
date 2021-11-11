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
    public partial class EliminarTransaccionForm : Form
    {
        private TransaccionServicios transSer;
        private int VentaEliminar;
        private Usuario usu;
        public EliminarTransaccionForm(Usuario usuLogin)
        {            
            InitializeComponent();
            transSer = new TransaccionServicios();
            VentaEliminar = -1;
            usu = usuLogin;
        }

        private void btnConsultarEliminar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesdeEliminar.Value > dtpFechaHastaEliminar.Value)
            {
                MessageBox.Show("Fechas erroneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = transSer.RecuperarVentasEliminar(dtpFechaDesdeEliminar.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpFechaHastaEliminar.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                CargarGrillaVentasFiltradas(tabla);
            }
        }

        private void CargarGrillaVentasFiltradas (DataTable tabla)
        {
            gdrEliminarVentas.Rows.Clear();

                for (int i = 0; i < tabla.Rows.Count; i++)
                    gdrEliminarVentas.Rows.Add(tabla.Rows[i]["NroTicket"],
                                                tabla.Rows[i]["NombreUsuario"],
                                                tabla.Rows[i]["Fecha"],
                                                tabla.Rows[i]["Nombre"],
                                                tabla.Rows[i]["NombreForma"]);
        }

        private void gdrEliminarVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrEliminarVentas.Rows[indice];
            VentaEliminar = int.Parse(filaSeleccionada.Cells["NroTicket"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (gdrEliminarVentas.Rows.Count != 0 || VentaEliminar != -1)
            {
                tabla = transSer.BuscarStocksParaPrendas(VentaEliminar);
                transSer.AnularVenta(VentaEliminar, tabla);
                MessageBox.Show("Venta anulada con éxito", "Anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabla = transSer.RecuperarVentasEliminar(dtpFechaDesdeEliminar.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpFechaHastaEliminar.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                CargarGrillaVentasFiltradas(tabla);
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar una prenda", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void EliminarTransaccionForm_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesdeEliminar.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHastaEliminar.Value = DateTime.Today;
        }
    }
}
