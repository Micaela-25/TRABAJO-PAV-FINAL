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
    class TipoDocServicios
    {
        private BD BaseDatos;
        private TipoDoc tipoDoc;


        public TipoDocServicios (string NombreTipo, string DescTipo)
        {
            tipoDoc = new TipoDoc(NombreTipo, DescTipo);
            BaseDatos = new BD();

        }
        public TipoDocServicios()
        {
            BaseDatos = new BD();
        }

        //-----------------------------------------------------ALTA TIPO DOC---------------------------------

        public bool ValidarNombreTipoDoc( string Nombre)
        {
            bool resultado = false;

            try
            {
               resultado = BaseDatos.ValidarNombreTipoDocBD(Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido validar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        public bool InsertarTipoDoc(string Nombre, string Descr)
        {
            bool resultado = true;

            try
            {
                resultado = BaseDatos.InsertarTipoDocBD(Nombre, Descr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido insertar el tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        //------------------------------------------CONSULTA TIPO DOC--------------------------------------

        public DataTable CargarComboTipoDoc()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarComboTipoDocBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar el combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public DataTable RecuperarTodosTipoDoc()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.RecuperarTodosTipoDocBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
      

        public List<TipoDoc> consultarTiposDoc(List<Parametro> filtros)
        {
            List<TipoDoc> listaResultados = new List<TipoDoc>(); 
            listaResultados = BaseDatos.consultarTiposDocBD(filtros); //le pido a la BD los resultados que hayan pasado los filtros, por eso le paso la lista filtros
          
            return listaResultados;
        }

        //------------------------------------------------BAJA TIPO DOC-----------------------------------------------------------

        public void EliminarTipoDoc(int id)
        {
            try
            {
                BaseDatos.EliminarTipoDocBD(id);
                MessageBox.Show("El tipo de prenda se eliminó con éxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el tipo de prenda de la base de datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------MODIFICACIÓN TIPO DOC----------------------------------------------------
        public DataTable CargarCamposTipoDoc(int tipoAModificar)
        {
            DataTable tabla = new DataTable();
            
            try
            {
                tabla = BaseDatos.cargarCamposTipoDocBD(tipoAModificar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar campos del tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        public string BuscarNombreAntesCambio(int id)
        {
            string nombre = "";

            try
            {
                nombre = BaseDatos.BuscarNombreViejoBD(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido validar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombre;
        }

        public void ModificarTipoDoc(string nom, string des, int id, string nomViejo)
        {
            try
            {
                bool resultado = ValidarNombreTipoDoc(nom);
                if (nom == nomViejo)
                {
                    BaseDatos.ModificarTipoDocBD(nom, des, id);
                }
                else
                {
                    if (resultado)
                    {
                        MessageBox.Show("El nombre ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BaseDatos.ModificarTipoDocBD(nom, des, id);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al modificar el tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

    }
}
