using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico.Entidades;

namespace TrabajoPractico.Base_de_datos
{
    class BD
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        public BD()
        {
            string cadenaConexión = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"]; //conexión con BD
            cn = new SqlConnection(cadenaConexión); // conexión con BD
            cmd = new SqlCommand();
            cn.Open(); // abre la conexión

        }

        //metodo del login

        //----------------------------------------------------------ABMC USUARIO-------------------------------------------------------------------------
        //..........................INICIAR SESION.....................................
        public bool ValidarUsuarioBD(string nombreDeUsuario, string password) //VALIDA EL USUARIO CUANDO INICIA SESIÓN
        {

            try
            {
                bool resultado = false;
                string consulta = " SELECT * FROM Usuarios WHERE NombreUsuario like @nombreUsuario AND Contraseña like @pass AND Borrado = 0";
                // se realiza esa consulta para validar si el usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1) // aca se verifica que se haya encontrado una fila en la base de datos
                                           // y si se encontró es porque el usuario si existe
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;
                }
                return resultado;

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public string BuscarRolBD(string nombreUsuarioBusqueda) //BUSCA EL ROL DEL USUARIO INGRESADO EN SESIÓN
        {
            string resultadoRol = "";

            try
            {
                string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario like @nombreUsuario AND Rol like 'Vendedor'";
                // se realiza esa consulta para validar si el usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuarioBusqueda);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1) // aca se verifica que se haya encontrado una fila en la base de datos
                                           // y si se encontró es porque el usuario si existe
                {
                    resultadoRol = "Vendedor";

                }
                else
                {
                    resultadoRol = "Administrador";
                }
                return resultadoRol;

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

       
        public int idUsuarioBD(string nombre)
        {
            int id = -1;
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT * FROM Usuarios WHERE NombreUsuario like @nombreNuevoUsuario";
               
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreNuevoUsuario", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                id = int.Parse(tabla.Rows[0][0].ToString());

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return id;
        }

        

        //..........................ALTA USUARIO.....................................
        public bool ValidarNombreUsuarioBD(string nombreNuevo) // aca se valida que el usuario no exista previamente en la base de datos
        {

            try
            {
                bool resultado = false;

                string consulta = " SELECT * FROM Usuarios WHERE NombreUsuario like @nombreNuevoUsuario";
                // se realiza esa consulta para validar si el nombre de usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreNuevoUsuario", nombreNuevo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1) // aca se verifica que se haya encontrado una fila en la base de datos
                                           // y si se encontró es porque el nombre de usuario si existe
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool InsertarUsuarioBD(string nombreNuevo, string contraseña, string rol) //este método se realiza para insertar el usuario a la base de datos
        {

            bool resultado = false;
            try
            {
                string consulta = " INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol, Borrado) VALUES(@nuevoNombreUsu, @nuevaPass, @rol, 0) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nuevoNombreUsu", nombreNuevo);
                cmd.Parameters.AddWithValue("@nuevaPass", contraseña);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        //..........................CONSULTA USUARIO.....................................
        public DataTable CargarGrillaVendedorBD(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = " SELECT Id_Usuario, NombreUsuario, Contraseña, Rol FROM Usuarios WHERE Id_Usuario like @cod AND Borrado = 0";
                // se realiza esa consulta para validar si el usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", codigo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                //Este es el momento en el cual se llena la grilla con los datos del usuario
                //grConsultaDatos.DataSource = tabla;
                //grpDatosUsuario.Visible = true;

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;

        }

        public DataTable CargarGrillaAdministradorBD()
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT Id_Usuario, NombreUsuario, Contraseña, Rol, Borrado FROM Usuarios ";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                //Este es el momento en el cual se llena la grilla con los datos del usuario
                //grConsultaDatos.DataSource = tabla;
                //grpDatosUsuario.Visible = true;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //..........................BAJA USUARIO.....................................
        public void EliminarUsuarioBD(string Nombreusu)
        {


            try
            {
                string consulta = "UPDATE Usuarios SET Borrado = 1 WHERE NombreUsuario like  @Nombreusu ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsu", Nombreusu);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable tabla = new DataTable();
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }

        }
        //..........................MODIFICACION USUARIO.....................................
        public void modificacionNombreBD(string nombre, int Id)
        {

            try
            {
                string consulta = "UPDATE Usuarios SET NombreUsuario = @nombre  WHERE Id_Usuario = @id";
                // se realiza esa consulta para modificar el nombre del usuario
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", Id);
    
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable tabla = new DataTable();
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }

        }

        public void modificacionClaveBD(string clave, int id)
        {
            try
            {

                string Consulta = "UPDATE Usuarios SET Contraseña = @clave WHERE Id_Usuario = @id ";
                // se realiza esa consulta para modificar la clave
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter Da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable Tabla = new DataTable();
                Da.Fill(Tabla);

            }

            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }

        }
        public bool ValidarNombreNuevoBD(string nombreDeUsuario)
        {

            try
            {
                bool Resultado = false;
                string CONSULTA = " SELECT * FROM Usuarios WHERE NombreUsuario like @nombreUsuario";
                // se realiza esa consulta para validar si el nombre de usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = CONSULTA;

                cmd.Connection = cn;

                DataTable TABLA = new DataTable();

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(TABLA);

                if (TABLA.Rows.Count == 1) // aca se verifica que se haya encontrado una fila en la base de datos
                                           // y si se encontró es porque el nombre de usuario si existe
                {
                    Resultado = true;

                }
                else
                {
                    Resultado = false;
                }
                return Resultado;
            }

            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        //----------------------------------------------------------ABMC PRENDA ROPA-------------------------------------------------------------------------
        //..................................ALTA PRENDA..............................................
        public bool InsertarPrendaBD(PrendaRopa prenda)
        {

            bool resultado = false;
            try
            {
                string consulta = " INSERT INTO PrendasRopa (IdTipoPrenda, Descripción, Nombre, PrecioUnitario, CantidadStock, Color, Marca, Borrado, StockActual, Id_Talle) VALUES(@id, @descripcion, @nombre, @precio, @cantidad, @color, @marca, 0, @cantidad, @talle) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", prenda.tipo);
                cmd.Parameters.AddWithValue("@descripcion", prenda.descripcion);
                cmd.Parameters.AddWithValue("@nombre", prenda.nombre);
                cmd.Parameters.AddWithValue("@precio", prenda.precioUni);
                cmd.Parameters.AddWithValue("@cantidad", prenda.cantidad);
                cmd.Parameters.AddWithValue("@color", prenda.color);
                cmd.Parameters.AddWithValue("@marca", prenda.marca);
                cmd.Parameters.AddWithValue("@talle", prenda.talle);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public DataTable CargarComboBD()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdTipoPrenda, Nombre FROM TipoPrenda WHERE Borrado = 0";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;

        }

        public DataTable CargarComboTalleBD()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Id_Talle, Nombre FROM Talle";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //---------------------------------------------------CONSULTA PRENDA -------------------------------------------------------------

        public DataTable BuscarDatosPrendaBD()
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT Nombre, CodigoPrenda, Descripción, IdTipoPrenda, PrecioUnitario, CantidadStock, Color, Marca, Id_Talle FROM PrendasRopa WHERE Borrado = 0 AND CantidadStock > 0";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //--------------------------------------------------BAJA PRENDA ------------------------------------------------------------------
        public void EliminarPrendaBD(int codigo)
        {
            try
            {
                string consulta = "UPDATE PrendasRopa SET Borrado = 1 WHERE CodigoPrenda like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", codigo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable tabla = new DataTable();
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }
        //--------------------------------------------------MODIFICACIÓN PRENDA -------------------------------------------------------

        public DataTable ObtenerPrendaBD(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT * FROM PrendasRopa WHERE CodigoPrenda = @cod";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            da.Fill(tabla);



            }
            catch (Exception ex)
            {
                throw;

            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        public void modificacionEnBaseDatosBD(string NombrePrenda, string DescripcionPrenda, string ColorPrenda, string MarcaPrenda, float PrecioUnitarioPrenda, int CantidadPrenda, int TipoPrenda, int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE PrendasRopa SET IdTipoPrenda = @tipo , Descripción = @desc, Nombre = @nom, PrecioUnitario = @precio ,CantidadStock = @cant ,Color = @color ,Marca = @marca  WHERE CodigoPrenda like @cod";
                cmd.Parameters.AddWithValue("@tipo", TipoPrenda);
                cmd.Parameters.AddWithValue("@desc", DescripcionPrenda);
                cmd.Parameters.AddWithValue("@nom", NombrePrenda);
                cmd.Parameters.AddWithValue("@precio", PrecioUnitarioPrenda);
                cmd.Parameters.AddWithValue("@cant", CantidadPrenda);
                cmd.Parameters.AddWithValue("@color", ColorPrenda);
                cmd.Parameters.AddWithValue("@marca", MarcaPrenda);
                cmd.Parameters.AddWithValue("@cod", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable tabla = new DataTable();
                da.Fill(tabla);
            }


            catch (Exception ex)
            {
                MessageBox.Show("La prenda no se modificó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cn.Close();

            }
        }


        public string BuscarNombreTalleBD(int Id)
        {
            string nombre = "";
            try
            {
                DataTable tabla = new DataTable();

                string consulta = " SELECT Nombre From Talle WHERE Id_Talle like @id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                nombre = tabla.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return nombre;
        }
        //------------------------------------------------AMBC TIPO PRENDA--------------------------------------------------------
        //----------------------------ALTA TIPO PRENDA------------------------------------

        public bool InsertarTipoPrendaBD(TipoPrendaRopa Tipoprenda)
        {

            bool resultado = false;
            try
            {


                string consulta = " INSERT INTO TipoPrenda ( Nombre,  Descripción, Borrado) VALUES( @nombre,@descripcion, @borrado) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Tipoprenda.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Tipoprenda.descripcion);
                cmd.Parameters.AddWithValue("@borrado", 0);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }


        //----------------------------------------CONSULTA TIPO PRENDA--------------------------------------------------------

        public DataTable CargarGrillaTipoPrendaBD()
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT IdTipoPrenda, Descripción, Nombre, Borrado FROM TipoPrenda WHERE Borrado = 0";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //------------------------------------------------BAJA TIPO PRENDA-----------------------------------------------------------------

        public void eliminarTipoPrendaBD(int Codigo)
        {

            try
            {

                string consulta = "UPDATE TipoPrenda SET Borrado = 1 WHERE IdTipoPrenda like @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Codigo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
               
                DataTable tabla = new DataTable();
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }

        }

        //-------------------------------------------MODIFICACIÓN TIPO PRENDA------------------------------------------------------------

        public DataTable cargarCamposBDNombre(int TipoAModificar)
        {
            //TipoPrendaRopa tipoPrenda = new TipoPrendaRopa();
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT * From TipoPrenda WHERE IdTipoPrenda like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", TipoAModificar);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;

        }

        public void modificarTipoPrendaBD(string nombre, string descripcion, int Idtipo)
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " UPDATE TipoPrenda SET Nombre = @nombre, Descripción = @descrip WHERE IdTipoPrenda like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descrip", descripcion);
                cmd.Parameters.AddWithValue("@id", Idtipo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }
        public bool ValidarNombreTipoBD(string nombreNuevo) // aca se valida que el usuario no exista previamente en la base de datos
        {
            
            try
            {
                bool resultado = true;

                string consulta = " SELECT * FROM TipoPrenda WHERE Nombre like @nomTipo AND Borrado = 0";
                // se realiza esa consulta para validar si el nombre de usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomTipo", nombreNuevo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                
                int cuenta = tabla.Rows.Count;
                if (cuenta ==1) // aca se verifica que se haya encontrado una fila en la base de datos
                                           // y si se encontró es porque el nombre de usuario si existe
                {
                    resultado = false;
                    
                }
                else
                {
                     resultado = true;
                   
                }
                return resultado;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            

        }

        //-------------------------------------------------------AMBC TIPO DOC----------------------------------------------------------------------

        //-----------------------------------------------------------ALTA TIPO DOC---------------------------------------------------------------------

         public bool ValidarNombreTipoDocBD(string Nombre)
        {
            try
            {
                bool resultado = false;

                string consulta = " SELECT Nombre FROM TipoDoc WHERE Nombre like @nomTipo AND Borrado = 0";
                // se realiza esa consulta para validar si el nombre de usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomTipo", Nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
               

                
                if (tabla.Rows.Count == 1) // aca se verifica que se haya encontrado una fila en la base de datos
                                 // y si se encontró es porque el nombre de usuario si existe
                {
                    resultado = true;

                }
                
                return resultado;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public string BuscarNombreViejoBD(int id)
        {
            try
            {
                string nombre = "";

                string consulta = " SELECT Nombre FROM TipoDoc WHERE Id_Tipo_Doc like @idd AND Borrado = 0";
                // se realiza esa consulta para validar si el nombre de usuario ingresado coincide con alguno registrado en la BD
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idd", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                nombre = tabla.Rows[0][0].ToString();

                

                return nombre;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public bool InsertarTipoDocBD(string Nombre, string Descr)
        {

            bool resultado = false;
            try
            {


                string consulta = " INSERT INTO TipoDoc ( Nombre,  Descripción, Borrado) VALUES( @nombre,@descripcion,0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@descripcion", Descr);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //------------------------------------------CONSULTA TIPO DOC-------------------------------------------

        public List<TipoDoc> consultarTiposDocBD(List<Parametro> filtros)
        {
            List<TipoDoc> listaResultados = new List<TipoDoc>();
            try
            {
                DataTable tabla = new DataTable();
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CONSULTAR_TIPODOC";
                cmd.Parameters.Clear();
                foreach (Parametro p in filtros)
                {
                    
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
               
                tabla.Load(cmd.ExecuteReader());
                
                //mapear los registros como objetos desmaterializar
                foreach (DataRow row in tabla.Rows)
                {
                    //por cada registro creamos un objeto del dominio
                    TipoDoc t = new TipoDoc();
                    t.id = int.Parse(row["Id_Tipo_Doc"].ToString());
                    t.descripcion = row["Descripción"].ToString();
                    t.nombre = row["Nombre"].ToString();
                    t.borrado = int.Parse(row["Borrado"].ToString());

                    //Añadir el objeto a la lista
                    listaResultados.Add(t);
                }
            }
            catch (SqlException)
            {
                listaResultados = null;
                MessageBox.Show("No se ha podido cargar la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
            return listaResultados;
        }


        public DataTable CargarComboTipoDocBD()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TipoDoc WHERE Borrado = 0";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;


        }

        public DataTable RecuperarTodosTipoDocBD()
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT Id_Tipo_Doc, Nombre, Descripción FROM TipoDoc WHERE Borrado = 0";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;

        }



        //-------------------------------------------------BAJA TIPO DOC----------------------------------------
        public void EliminarTipoDocBD(int id)
        {
            try
            {

                string consulta = "UPDATE TipoDoc SET Borrado = 1 WHERE Id_Tipo_Doc like @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn; //asigno a mi comand la conexion que ya esta abierta
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL

                DataTable tabla = new DataTable();
                da.Fill(tabla);

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }

        //--------------------------------------------------MODIFICACIÓN TIPO DOC-----------------------------------------------

        public DataTable cargarCamposTipoDocBD(int codigo)
        {
            
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT * From TipoDoc WHERE Id_Tipo_Doc like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", codigo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        public void ModificarTipoDocBD(string nom, string des, int id)
        {
            DataTable tabla = new DataTable();
            //try
            //{
                string consulta = "UPDATE TipoDoc SET Nombre = @nombre, Descripción = @descrip WHERE Id_Tipo_Doc like @id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@descrip", des);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);

            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            //finally
            //{
                cn.Close();
            //}
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // ----------------------------------------------------TRANSACCION VENTA--------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------FILTRADO--------------------------------------------------------------------------------------------------------------------------

        public DataTable buscarPrendaFiltradaBD(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = " SELECT * From PrendasRopa WHERE CodigoPrenda like @id AND Borrado = 0 AND CantidadStock > 0";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", codigo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        public string buscarNombreTipoBD(int tipo)
        {
            string nombre = "";
            try
            {
                DataTable tabla = new DataTable();

                string consulta = " SELECT Nombre From TipoPrenda WHERE IdTipoPrenda like @id AND Borrado = 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", tipo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                nombre = tabla.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return nombre;
        }

        public string buscarNombreTalleBD(int id)
        {
            string nombre = "";
            try
            {
                DataTable tabla = new DataTable();

                string consulta = "SELECT Nombre From Talle WHERE Id_Talle like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                nombre = tabla.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return nombre;
        }
        //************************************************ BUSQUEDA CLIENTE POR DOC***********************************

        public DataTable BuscarClientePorDocBD(int NroDoc)
        {
            DataTable tabla = new DataTable();

            try
            {
                string consulta = " SELECT * From Clientes WHERE NroDoc like @nroDoc AND Borrado = 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc",NroDoc);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        public string buscarNombreTipoDocBD(int tipo)
        {
            string nombre = "";
            try
            {
                DataTable tabla = new DataTable();

                string consulta = "SELECT Nombre From TipoDoc WHERE Id_Tipo_Doc like @id AND Borrado = 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", tipo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                //EJECUTA LA CONSULTA A LA BD
                SqlDataAdapter da = new SqlDataAdapter(cmd); //EJECUTA LA CONSULTA ES QUIEN CONOCE LA BD Y TODO ESO. FUNDAMENTAL
                da.Fill(tabla);
                nombre = tabla.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return nombre;
        }

        
        //---------------------------------------------------------TRANSACCION CON ROLLBACK----------------------------------------------------------

        public bool TransaccionVentaBD(int idUsuario, string fecha, float Total, Cliente cliente, List<CopiaPrendaStock> listaDetalle, int id_forma_pago)
        {
            bool resultado = false;
           
            SqlTransaction objTransaccion = null;
            try
            {
                cn.Open();
                objTransaccion = cn.BeginTransaction();
               

                SqlCommand cmd0 = new SqlCommand();
                string consulta0 = "SELECT Id_cliente FROM Clientes WHERE NroDoc = @nroDoc";
                cmd0.Parameters.Clear();
                cmd0.Parameters.AddWithValue("@nroDoc", cliente.nroDocu);
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = consulta0;
                cmd0.Connection = cn;
                cmd0.Transaction = objTransaccion;
                DataTable tabla0 = new DataTable();
                SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                da0.Fill(tabla0);
                if (tabla0.Rows.Count == 0) 
                {
                   
                    // ----------------------------------INSERT DE CLIENTE-------------------------------------
                    string consulta1 = "INSERT INTO Clientes (Nombre, Apellido, Id_Tipo_Doc, NroDoc, Mail, NroTelefono, Borrado) VALUES( @nombre,@apellido,@id, @nroDoc,@mail, @nroTel, 0) ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                    cmd.Parameters.AddWithValue("@id", cliente.tipoDocu);
                    cmd.Parameters.AddWithValue("@nroDoc", cliente.nroDocu);
                    cmd.Parameters.AddWithValue("@mail", cliente.email);
                    cmd.Parameters.AddWithValue("@nroTel", cliente.nroTele);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta1;
                    cmd.Connection = cn;
                    cmd.Transaction = objTransaccion;
                    DataTable tabla1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    da1.Fill(tabla1);
                }
                
   
            // ------------------------------------------- BUSCAR ID DE CLIENTE-------------------------------------
                SqlCommand cmd2 = new SqlCommand();
                int idCliente = 0;
                string consulta2 = " SELECT Id_cliente FROM Clientes  WHERE NroDoc = @nroDoc";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@nroDoc",cliente.nroDocu);
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = consulta2;
                cmd2.Connection = cn;
                cmd2.Transaction = objTransaccion;
                DataTable tabla2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(tabla2);
                idCliente = int.Parse(tabla2.Rows[0][0].ToString());

             ////--------------------------INSERT DE VENTA--------------------------------------------------------
                SqlCommand cmd3 = new SqlCommand();
                string consulta3 = " INSERT INTO Ventas (Id_usuario, Fecha, Total, Id_cliente, Id_Forma_Pago, Borrado) VALUES(@IdUsu, @fech, @Tot, @id_client, @id_forma_pago, 0) ";
                cmd3.Parameters.Clear();
                cmd3.Parameters.AddWithValue("@IdUsu", idUsuario);
                cmd3.Parameters.AddWithValue("@fech", fecha);
                cmd3.Parameters.AddWithValue("@Tot", Total);
                cmd3.Parameters.AddWithValue("@id_client", idCliente);
                cmd3.Parameters.AddWithValue("@id_forma_pago", id_forma_pago);
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = consulta3;
                cmd3.Connection = cn;
                cmd3.Transaction = objTransaccion;
                DataTable tabla3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(tabla3);

                //// ------------------------------BUSCAR NROTICKET ---------------------------------------------------------
                SqlCommand cmd4 = new SqlCommand();
                int Nro = 0;
                string consulta4 = "SELECT NroTicket FROM Ventas WHERE Fecha = @fech";
                cmd4.Parameters.Clear();
                cmd4.Parameters.AddWithValue("@fech", fecha);
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = consulta4;
                cmd4.Connection = cn;
                cmd4.Transaction = objTransaccion;
                DataTable tabla4 = new DataTable();
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(tabla4);
                Nro = int.Parse(tabla4.Rows[0][0].ToString());

                
                SqlCommand cmd5 = new SqlCommand();
                SqlCommand cmd31 = new SqlCommand();

                foreach (CopiaPrendaStock deti in listaDetalle)
                {
                    int stockk = deti.cantidad -  deti.stockActual;
                    float subTotal = deti.precioUni * (float)stockk;
                    string consulta5 = "Insert into DetalleVentas (NroTicket, CodigoPrenda, Subtotal, Cantidad) values (@idVenta, @codigoPrenda, @subtotal, @stock)";
                    cmd5.Parameters.Clear();
                    cmd5.Parameters.AddWithValue("@idVenta", Nro);
                    cmd5.Parameters.AddWithValue("@codigoPrenda", deti.codigo);
                    cmd5.Parameters.AddWithValue("@subtotal", subTotal);
                    cmd5.Parameters.AddWithValue("@stock", stockk);
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = consulta5;
                    cmd5.Connection = cn;
                    cmd5.Transaction = objTransaccion;
                    DataTable tabla5 = new DataTable();
                    SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                    da5.Fill(tabla5);

                    string consulta31 = "UPDATE PrendasRopa SET CantidadStock = @cantidad, StockActual = @cantidad WHERE CodigoPrenda = @id";
                    cmd31.Parameters.Clear();
                    cmd31.Parameters.AddWithValue("@cantidad", deti.stockActual);
                    cmd31.Parameters.AddWithValue("@id", deti.codigo);
                    cmd31.CommandType = CommandType.Text;
                    cmd31.CommandText = consulta31;
                    cmd31.Connection = cn;
                    cmd31.Transaction = objTransaccion;
                    DataTable tabla31 = new DataTable();
                    SqlDataAdapter da31 = new SqlDataAdapter(cmd31);
                    da31.Fill(tabla31);

                }
                objTransaccion.Commit();
                return true;
            }

            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false;
                throw;
                

            }
            finally
            {
                cn.Close();
            }
        }

        //-------------------------------------------------------------------SEGUNDA TRANSACCION, ELIMINAR LA VENTA-------------------------------------------------
        
              
        public DataTable RecuperarVentasEliminarBD(string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = "SELECT V.NroTicket, U.NombreUsuario, V.Fecha, C.Nombre, F.Nombre AS NombreForma"
                                   + " FROM Ventas V"
                                   + " JOIN Usuarios U ON(U.Id_Usuario = V.Id_usuario)"
                                   + " JOIN Clientes C ON(C.Id_cliente = V.Id_cliente)"
                                   + " JOIN Forma_Pago F ON(F.Id_Forma = V.Id_Forma_Pago)"
                                   + " WHERE V.Fecha BETWEEN @Desde AND @Hasta AND V.Anulado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Desde", fechaDesde);
                cmd.Parameters.AddWithValue("@Hasta", fechaHasta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;
        }

        public DataTable BuscarStocksParaPrendasBD(int NroTicket)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = "SELECT D.CodigoPrenda, D.Cantidad"
                                   + " FROM DetalleVentas D"
                                   + " JOIN Ventas V ON(D.NroTicket = V.NroTicket)"
                                   + " WHERE V.NroTicket = @Nro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nro", NroTicket);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;
        }


        public void AnularVentaBD (int VentaEliminar, DataTable tabla)
        {
            // primero se setea la venta que tiene un codigo igual al prendaeliminar en borrado =1 
            SqlTransaction objTransaccion = null;
            try
            {
                //cn.Open();
                objTransaccion = cn.BeginTransaction();


                SqlCommand cmd0 = new SqlCommand();
                string consulta0 = "UPDATE Ventas SET Anulado = 1 WHERE NroTicket = @Nro";
                cmd0.Parameters.Clear();
                cmd0.Parameters.AddWithValue("@Nro", VentaEliminar);
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = consulta0;
                cmd0.Connection = cn;
                cmd0.Transaction = objTransaccion;
                DataTable tabla0 = new DataTable();
                SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                da0.Fill(tabla0);

                //segundo se setea a todos los detalles cuyo nro de ticket sean igual al prenda Aeliminar en borrado =1
                SqlCommand cmd1 = new SqlCommand();
                string consulta1 = "UPDATE DetalleVentas SET Anulado = 1 WHERE NroTicket = @Nroticket";
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@Nroticket", VentaEliminar);
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = consulta1;
                cmd1.Connection = cn;
                cmd1.Transaction = objTransaccion;
                DataTable tabla1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(tabla1);

                //tercero se reccore la tabla para setean las prendas que tengan el codigo de la columna 0 de la tabla igual, actializando su cantidad con la de la columna 1 de la tabla
                SqlCommand cmd2 = new SqlCommand();
                int cant = 0;
                int cod = 0;
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    cant = int.Parse(tabla.Rows[i][1].ToString());
                    cod = int.Parse(tabla.Rows[i][0].ToString());

                   
                    string consulta2 = "UPDATE PrendasRopa SET CantidadStock = CantidadStock + @cantidad, StockActual = StockActual + @cantidad WHERE CodigoPrenda = @id";
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@cantidad", cant);
                    cmd2.Parameters.AddWithValue("@id", cod);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = consulta2;
                    cmd2.Connection = cn;
                    cmd2.Transaction = objTransaccion;
                    DataTable tabla2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(tabla2);

                }
                objTransaccion.Commit();

            }

            catch (Exception ex)
            {
                objTransaccion.Rollback();
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        //----------------------------------------------CARGAR COMBO FORMA DE PAGO-----------------------------------------------------------------------

            public DataTable CargarComboFormaPagoBD()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Forma_Pago";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return tabla;
        }

        //----------------------------------------------REPORTES-----------------------------------------------------------------------
        public DataTable ReportesTipoTablaBD(int cant1, int cant2, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = "SELECT TipoPrenda.Nombre, sum(Cantidad) AS Cantidad, TipoPrenda.Descripción FROM DetalleVentas, PrendasRopa P, TipoPrenda, Ventas V"
                                    +" WHERE DetalleVentas.CodigoPrenda = P.CodigoPrenda"
                                    +" AND P.IdTipoPrenda = TipoPrenda.IdTipoPrenda"
                                    +" AND V.NroTicket = DetalleVentas.NroTicket"
                                    +" AND V.Fecha BETWEEN @Desde AND @Hasta AND V.Anulado = 0"
                                    +" GROUP BY TipoPrenda.Nombre, TipoPrenda.Descripción"
                                    +" HAVING sum(Cantidad) BETWEEN @cantidad1 AND @cantidad2"
                                    +" ORDER BY Cantidad DESC";
                //string consulta = "SELECT CodigoPrenda, sum(Cantidad) AS Cantidad FROM DetalleVentas GROUP BY CodigoPrenda";
                //string consulta = "SELECT Ventas.Fecha, TipoPrenda.Nombre, DetalleVentas.Cantidad FROM DetalleVentas INNER JOIN"
                //                   + " PrendasRopa ON DetalleVentas.CodigoPrenda = PrendasRopa.CodigoPrenda INNER JOIN"
                //                   + " TipoPrenda ON PrendasRopa.IdTipoPrenda = TipoPrenda.IdTipoPrenda INNER JOIN"
                //                   + " Ventas ON DetalleVentas.NroTicket = Ventas.NroTicket";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidad1", cant1);
                cmd.Parameters.AddWithValue("@Desde", fechaDesde);
                cmd.Parameters.AddWithValue("@Hasta", fechaHasta);
                cmd.Parameters.AddWithValue("@cantidad2", cant2);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;

        }


        public DataTable RecuperarVentasFechasBD(string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = "SELECT V.NroTicket, U.NombreUsuario, V.Fecha, V.Total, C.NroDoc, FP.Nombre"
                                    + " FROM Ventas V"
                                    + " JOIN Usuarios U ON(V.Id_usuario = U.Id_Usuario)"
                                    + " JOIN Clientes C ON(V.Id_cliente = C.Id_cliente)"
                                    + " JOIN Forma_Pago FP ON(FP.Id_Forma = V.Id_Forma_Pago)"
                                    + " WHERE V.Fecha BETWEEN @Desde AND @Hasta AND V.Anulado = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Desde", fechaDesde);
                cmd.Parameters.AddWithValue("@Hasta", fechaHasta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;
        }
        public DataTable RecuperarVentasEmpleadosBD(string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            try
            {

                string consulta = "SELECT U.NombreUsuario, U.Rol, sum(V.Total) AS TotalVendido, count (U.NombreUsuario) AS Cantidad"
                                    + " FROM Usuarios U"
                                    + " JOIN Ventas V ON(V.Id_usuario = U.Id_Usuario)"
                                    + " WHERE V.Fecha BETWEEN @Desde AND @Hasta AND V.Anulado = 0"
                                    + " GROUP BY U.NombreUsuario, U.Rol";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Desde", fechaDesde);
                cmd.Parameters.AddWithValue("@Hasta", fechaHasta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw;
            }
            return tabla;
        }
    }

}





