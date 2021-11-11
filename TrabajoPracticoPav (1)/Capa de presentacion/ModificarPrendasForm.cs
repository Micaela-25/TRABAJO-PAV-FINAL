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
    public partial class ModificarPrendasForm : Form
    {
        private Usuario usu;
        private string NombreAModificar;
        private PrendaServicios PrendaSer;

        public ModificarPrendasForm(Usuario usuLogin)
        {
            InitializeComponent();
            usu = usuLogin;
            PrendaSer = new PrendaServicios();
        }

        public DataTable ObtenerPrendaFinal(int codigo)
        {
            DataTable tabla = new DataTable();

            tabla = PrendaSer.ObtenerPrenda(codigo);
           
            return tabla;
        }
 
        private void limpiarCampos()
        {
            txtModificarNombrePrenda.Text = "";
            txtModificarDescripcionPrenda.Text = "";
            txtModificarColorPrenda.Text = "";
            txtModificarMarcaPrenda.Text = "";
            txtModificarPrecioUnitarioPrenda.Text = "";
            txtModificarCantidadPrendas.Text = "";
            cmbModificarTipoPrenda.SelectedValue = -1;
        }

        private void ModificarPrendasForm_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            CargarGrillaPrendaFinal();
            CargarComboFinal();
            CargarComboTalleFinal();


        }


        private void CargarComboFinal()
        {
            DataTable tabla = new DataTable();

                tabla = PrendaSer.CargarCombo();
                cmbModificarTipoPrenda.DataSource = tabla;
                cmbModificarTipoPrenda.DisplayMember = "Nombre";
                cmbModificarTipoPrenda.ValueMember = "IdTipoPrenda";
                cmbModificarTipoPrenda.SelectedIndex = -1;
        }
        private void CargarComboTalleFinal()
        {
            DataTable tabla = new DataTable();

            tabla = PrendaSer.CargarComboTalle();
            cmbTalle.DataSource = tabla;
            cmbTalle.DisplayMember = "Nombre";
            cmbTalle.ValueMember = "Id_Talle";
            cmbTalle.SelectedIndex = -1;
        }

        private void CargarGrillaPrendaFinal()
        {
          
                PrendaSer.CargarGrillaPrenda(gdrModificarPrenda);
      
                gdrModificarPrenda.Visible = true;
          


        }

        private void gdrModificarPrenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrModificarPrenda.Rows[indice];
            NombreAModificar = filaSeleccionada.Cells["CodigoPrenda"].Value.ToString();
            
            DataTable tabla = ObtenerPrendaFinal(int.Parse(NombreAModificar));
            limpiarCampos();
            if (tabla.Rows.Count !=0)
            {
                txtModificarNombrePrenda.Text = tabla.Rows[0][3].ToString();
                txtModificarDescripcionPrenda.Text = tabla.Rows[0][2].ToString();
                txtModificarMarcaPrenda.Text = tabla.Rows[0][7].ToString();
                txtModificarPrecioUnitarioPrenda.Text = tabla.Rows[0][4].ToString();
                cmbModificarTipoPrenda.SelectedValue = tabla.Rows[0][1].ToString();
                cmbTalle.SelectedValue = tabla.Rows[0][10].ToString();
                txtModificarCantidadPrendas.Text = tabla.Rows[0][5].ToString();
                txtModificarColorPrenda.Text = tabla.Rows[0][6].ToString();

            }
            
            //CargarCampos(prendaObtenida);

        }



        //public void modificacionEnBaseDatos (string nombre, string descripcion, string color, string marca, float precio, int cantidad, int tipo, int codigo)
        //{

        //}
        //{
        //    string cadenaConexión = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"]; //conexión con BD
        //    SqlConnection cn = new SqlConnection(cadenaConexión);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "UPDATE PrendasRopa SET IdTipoPrenda = @tipo , Descripción = @desc, Nombre = @nom, PrecioUnitario = @precio ,CantidadStock = @cant ,Color = @color ,Marca = @marca  WHERE CodigoPrenda like @cod";
        //        cmd.Parameters.AddWithValue("@tipo", tipo);
        //        cmd.Parameters.AddWithValue("@desc", descripcion);
        //        cmd.Parameters.AddWithValue("@nom", nombre);
        //        cmd.Parameters.AddWithValue("@precio", precio);
        //        cmd.Parameters.AddWithValue("@cant", cantidad);
        //        cmd.Parameters.AddWithValue("@color", color);
        //        cmd.Parameters.AddWithValue("@marca",marca );
        //        cmd.Parameters.AddWithValue("@cod", codigo);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;
        //        cn.Open();
        //        cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
        //        SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

        //        DataTable tabla = new DataTable();
        //        da.Fill(tabla);

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("La prenda no se modifico correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    finally
        //    {
        //        cn.Close();

        //    }

        //}
    

        private void btnVolverAltaPrenda_Click(object sender, EventArgs e)
        {
            PrincipalForm volverPrincipal = new PrincipalForm(usu);
            volverPrincipal.Show();
            this.Hide();
        }

        private void btnLimpiarCamposPrenda_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnModificarRegistrarPrenda_Click(object sender, EventArgs e)
        {
            string NombrePrenda = txtModificarNombrePrenda.Text;
            string DescripcionPrenda = txtModificarDescripcionPrenda.Text;
            string ColorPrenda = txtModificarColorPrenda.Text;
            string MarcaPrenda = txtModificarMarcaPrenda.Text;
            float PrecioUnitarioPrenda = float.Parse(txtModificarPrecioUnitarioPrenda.Text);
            int CantidadPrenda = int.Parse(txtModificarCantidadPrendas.Text);
            int TipoPrenda = int.Parse(cmbModificarTipoPrenda.SelectedValue.ToString());

            PrendaSer.modificacionEnBaseDatos(NombrePrenda, DescripcionPrenda, ColorPrenda, MarcaPrenda, PrecioUnitarioPrenda, CantidadPrenda, TipoPrenda, int.Parse(NombreAModificar));
            CargarGrillaPrendaFinal();
            
        }
    }

}
