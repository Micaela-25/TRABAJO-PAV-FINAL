using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Base_de_datos;

namespace TrabajoPractico.Capa_de_negocio
{
    class TipoPrendaServicios
    {
        private BD BaseDatos;
        private TipoPrendaRopa tipoPrenda;

        public TipoPrendaServicios(string NombreTipo, string DescripcionTipo)
        {
            tipoPrenda = new TipoPrendaRopa(NombreTipo, DescripcionTipo);
            BaseDatos = new BD();

        }

        public TipoPrendaServicios()
        {
            BaseDatos = new BD();
        }

        //------------------------------------------------ALTA TIPO PRENDA----------------------------------------------

        public bool InsertarTipoPrenda() //este método se realiza para insertar el usuario a la base de datos
        {
            string nom = tipoPrenda.nombre;
            bool resultadoValidacion = ValidarNombreTipo(nom);
            bool resultado = false;
            try
            {
                if (resultadoValidacion)
                {
                    resultado = BaseDatos.InsertarTipoPrendaBD(tipoPrenda);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar un tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        public bool ValidarNombreTipo(string nombreNuevo)
        {
            bool resultado = false;
            try
            {
                if (BaseDatos.ValidarNombreTipoBD(nombreNuevo) == false)
                {
                    MessageBox.Show("Error, ya existe el tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return resultado;
        }

        // -------------------------------------------CONSULTA TIPO PRENDA----------------------------------------------

        public DataTable CargarGrillaTipoPrenda()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarGrillaTipoPrendaBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de los tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }


        //-----------------------------------------BAJA TIPO PRENDA----------------------------------------------------

        public void eliminarTipoPrenda(int Codigo)
        {
            try
            {
                BaseDatos.eliminarTipoPrendaBD(Codigo);
                MessageBox.Show("El tipo de prenda se eliminó con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------MODIFICACIÓN TIPO PRENDA---------------------------------------------

        public DataTable CargarCamposNombre(int tipoAModificar)
        {
            DataTable tabla = new DataTable();
            //TipoPrendaRopa tipoPrenda = new TipoPrendaRopa();
            try
            {
                tabla = BaseDatos.cargarCamposBDNombre(tipoAModificar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar campos del tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        public void modificarTipoPrenda(string nombre, string descripcion, int Idtipo)
        {
            try
            {
                if (ValidarNombreTipo(nombre))
                {
                    BaseDatos.modificarTipoPrendaBD(nombre, descripcion, Idtipo);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar campos del tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //--------------------------------------------REPORTE TIPO PRENDA---------------------------------------------
        public DataTable ReportesTipoPrenda (int cant1, int cant2, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.ReportesTipoTablaBD(cant1, cant2, fechaDesde, fechaHasta);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar informe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

    }
}
