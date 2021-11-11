using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Base_de_datos;
using TrabajoPractico.Entidades;

namespace TrabajoPractico.Capa_de_negocio
{
    class PrendaServicios
    {
        private BD BaseDatos;
        private PrendaRopa prenda;

        public PrendaServicios ()
        {
            BaseDatos = new BD();
        }

        //-----------------------------------------------ALTA PRENDA -----------------------------------------------------------

        public bool InsertarPrenda(PrendaRopa prenda)
        {
            bool resultado = false;

            try
            {
                resultado = BaseDatos.InsertarPrendaBD(prenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        public DataTable CargarCombo()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarComboBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public DataTable CargarComboTalle()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarComboTalleBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }


        //------------------------------------------------CONSULTA PRENDA -------------------------------------------------------------

       

        public void CargarGrillaPrenda(DataGridView grilla)
        {

            DataTable tabla = new DataTable();
            tabla = BaseDatos.BuscarDatosPrendaBD();
            string nombreTipo = "";
            string nomTalle = "";
            grilla.Rows.Clear();
            int cantFilas = tabla.Rows.Count;
            try
            {
                for (int i = 0; i < cantFilas; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["Nombre"],
                                    tabla.Rows[i]["CodigoPrenda"],
                                    tabla.Rows[i]["Descripción"],
                                    nombreTipo = BaseDatos.buscarNombreTipoBD(int.Parse(tabla.Rows[i][3].ToString())),
                                    tabla.Rows[i]["PrecioUnitario"],
                                    tabla.Rows[i]["CantidadStock"],
                                    tabla.Rows[i]["Color"],
                                    tabla.Rows[i]["Marca"],
                                    nomTalle = BaseDatos.buscarNombreTalleBD(int.Parse(tabla.Rows[i][8].ToString())));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------------------ELIMINAR PRENDA--------------------------------------------------------------

        public void EliminarPrenda(int codigo)
        {

            try
            {
                BaseDatos.EliminarPrendaBD(codigo);
                MessageBox.Show("La prenda se eliminó con éxito", "Eliminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // --------------------------------------------- MODIFICAR PRENDA-----------------------------------------------------------
        public DataTable ObtenerPrenda(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {
               tabla = BaseDatos.ObtenerPrendaBD(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;

        }

        public string BuscarNombreTalle(int id)
        {
            string nombre = "";
            try
            {
                nombre = BaseDatos.BuscarNombreTalleBD(id);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar el talle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombre;
        }

        public void modificacionEnBaseDatos(string NombrePrenda, string DescripcionPrenda, string ColorPrenda, string MarcaPrenda,float PrecioUnitarioPrenda, int CantidadPrenda, int TipoPrenda, int id)
        {
            try
            {
                BaseDatos.modificacionEnBaseDatosBD(NombrePrenda, DescripcionPrenda, ColorPrenda, MarcaPrenda, PrecioUnitarioPrenda, CantidadPrenda , TipoPrenda, id);
                MessageBox.Show("La prenda se modificó con éxito", "Eliminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
