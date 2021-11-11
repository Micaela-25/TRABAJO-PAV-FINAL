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
    class TransaccionServicios
    {
        private BD BaseDatos;
        private float contadorSubtotal;
        private int contadorCantidad;
        public TransaccionServicios ()
        {
            BaseDatos = new BD();
            contadorCantidad = 0;
            contadorSubtotal = 0;
        }

        //--------------------------------------------------DETALLE-----------------------------------------
        public DataTable buscarPrendaFiltrada (int codigo) // busca para ver si existe la prenda según su codigo
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.buscarPrendaFiltradaBD(codigo);

            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;
        }
        
        public string buscarNombreTipo(int tipo) // busca el nombre del tipo de la prenda para que en la grilla podamos ver directamente el nombre
        {
            string nombre = "";
            try
            {
                nombre = BaseDatos.buscarNombreTipoBD(tipo);

            }

            catch (Exception ex)
            {
                throw;
            }
            return nombre;
        }

        public void CargarGrillaPrendaTransFinal(DataGridView grilla, DataTable tabla, string nombre)
        {

            grilla.Rows.Clear();
            string nomTalle = BaseDatos.buscarNombreTalleBD(int.Parse(tabla.Rows[0][10].ToString()));
            try
            {
                grilla.Rows.Add(tabla.Rows[0]["Nombre"],
                                    tabla.Rows[0]["CodigoPrenda"],
                                    tabla.Rows[0]["PrecioUnitario"],
                                    tabla.Rows[0]["CantidadStock"],
                                    //tabla.Rows[0]["StockActual"],
                                    tabla.Rows[0]["Marca"],
                                    tabla.Rows[0]["Color"],
                                    nombre,
                                    tabla.Rows[0]["Descripción"],
                                    nomTalle
                                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public (int, float) agregarPrendaALista(List<CopiaPrendaStock> lista, CopiaPrendaStock copia)
        {
            bool resultado = false;
            //int cod = copia.codigo;
            if (lista.Count != 0)
            {
                foreach (CopiaPrendaStock c in lista)
                {
                    if (c.codigo == copia.codigo)
                    {
                        if (c.stockActual > 0)
                        {
                            int cant = c.stockActual;
                            c.stockActual = (cant - 1);
                            resultado = true;
                            contadorCantidad += 1;
                            contadorSubtotal += c.precioUni;

                            return (contadorCantidad, contadorSubtotal);

                        }
                        else
                        {
                            MessageBox.Show("No hay stock suficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = true;
                            break;
                        }
                    }
                    else
                    {
                        resultado = false;

                    }

                }
            }
            if ((lista.Count == 0) || (resultado == false && copia.stockActual>0))
            {
                lista.Add(copia);
                copia.stockActual = copia.stockActual - 1;
                contadorCantidad += 1;
                contadorSubtotal += copia.precioUni;
                
            }
            else
            {
                MessageBox.Show("No hay stock suficiente de dicha prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (contadorCantidad, contadorSubtotal);
            
        }

        public void CargarGrillaPrendaTranConLista(List<CopiaPrendaStock> lista, DataGridView grilla)
        { 
            grilla.Rows.Clear();
            if (lista.Count != 0)
            {
                foreach (CopiaPrendaStock c in lista)
                {
                    string nombre = buscarNombreTipo(c.tipo);
                    string nombreTalle = BaseDatos.buscarNombreTalleBD(c.talle);
                    grilla.Rows.Add(new object[]
                    {
                    c.nombre,
                    c.codigo,
                    c.precioUni,
                    c.cantidad,
                    c.stockActual,
                    c.marca,
                    c.color,
                    nombre,
                    c.descripcion,
                    nombreTalle,
                    });
                }
            }
            

        }

        public (int, float) EliminarPrendaLista(int cod, List<CopiaPrendaStock> lista)
        {

            if (lista.Count != 0)
            {
                foreach (CopiaPrendaStock c in lista)
                {
                    if (c.codigo == cod)
                    {
                        int cant = c.stockActual;
                        c.stockActual = (cant + 1);
                        contadorCantidad -= 1;
                        contadorSubtotal -= c.precioUni;
                        if (c.stockActual == c.cantidad)
                        {
                            lista.Remove(c);
                        }

                        break;

                    }

                }
            }
            return (contadorCantidad, contadorSubtotal);
        }

        //-----------------------------------------------CLIENTE---------------------------------------------

        public DataTable BuscarClientePorDoc(int nroDoc) // busca en la base de datos el cliente filtrando por numero de documento
        {
            DataTable tabla = new DataTable();

            try
            {
                tabla = BaseDatos.BuscarClientePorDocBD(nroDoc);
            }
            catch
            {
                throw;
            }
            return tabla;

        }

        public string BuscarNombreTipoDoc( int tipo) // busca los nombres de los distintos tipos de doc
        {
            string nombre = "";
            try
            {
                nombre = BaseDatos.buscarNombreTipoDocBD(tipo);

            }

            catch (Exception ex)
            {
                throw;
            }
            return nombre;
        }


        public DataTable CargarComboTipoDoc() // carga el combo del tipo de documento para cuando hay que agregar los datos del cliente
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarComboTipoDocBD();

        }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        //--------------------------------------------------BASE DE DATOS------------------------------------------------

        public bool TransaccionVenta( int cod, string fecha, float Total, Cliente cliente, List<CopiaPrendaStock> listaDetalle, int id_forma_pago)
        {
            bool resultado = false;
            try
            {
                resultado = BaseDatos.TransaccionVentaBD(cod, fecha, Total, cliente, listaDetalle, id_forma_pago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la venta ", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return resultado;
        }

        //----------------------------------------COMBO DE FORMA DE PAGO----------------------------------------

        public DataTable CargarComboFormaPago()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.CargarComboFormaPagoBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        //------------------------------------------REPORTES----------------------------------------------------
        public DataTable RecuperarVentasFechas(string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.RecuperarVentasFechasBD(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public DataTable RecuperarVentasEmpleados (string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.RecuperarVentasEmpleadosBD(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

       //-----------------------------------------------SEGUNDA TRANSACCION---------------------------------------------
        
        public DataTable RecuperarVentasEliminar(string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.RecuperarVentasEliminarBD(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        
        public void AnularVenta(int PrendaEliminar, DataTable table)
        {
            //try
            //{              
               BaseDatos.AnularVentaBD(PrendaEliminar, table);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al eliminar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        public DataTable BuscarStocksParaPrendas(int NroTicket)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = BaseDatos.BuscarStocksParaPrendasBD(NroTicket);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar stocks de detalles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }


    }
}
