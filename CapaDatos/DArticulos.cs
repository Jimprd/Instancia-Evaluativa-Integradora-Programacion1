using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DArticulos
    {
        #region Atributos
        private int _ArtCodigo;
        private string _ArtDescripcion;
        private decimal _ArtPrecio_Compra;
        private decimal _ArtPrecio_Venta;
        private int _ArtUnidades;
        private string _TextoBuscar;
        #endregion

        #region Encapsulado
        public int ArtCodigo
        {
            get
            {
                return _ArtCodigo;
            }

            set
            {
                _ArtCodigo = value;
            }
        }

        public string ArtDescripcion
        {
            get
            {
                return _ArtDescripcion;
            }

            set
            {
                _ArtDescripcion = value;
            }
        }

        public decimal ArtPrecio_Compra
        {
            get
            {
                return _ArtPrecio_Compra;
            }

            set
            {
                _ArtPrecio_Compra = value;
            }
        }

        public decimal ArtPrecio_Venta
        {
            get
            {
                return _ArtPrecio_Venta;
            }

            set
            {
                _ArtPrecio_Venta = value;
            }
        }

        public int ArtUnidades
        {
            get
            {
                return _ArtUnidades;
            }

            set
            {
                _ArtUnidades = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }
        #endregion

        #region Constructores
        //Constructor Vacio: 
        public DArticulos() { }

        // Constructor con parametros
        public DArticulos(int artCodigo, decimal artPrecio_Venta, int artUnidades)
        {
            this.ArtCodigo = artCodigo;
            this.ArtPrecio_Venta = artPrecio_Venta;
            this.ArtUnidades = artUnidades;
        }

        public DArticulos(int artCodigo, string artDescripcion, decimal artPrecio_Compra, decimal artPrecio_Venta, int artUnidades)
        {
            this.ArtCodigo = artCodigo;
            this.ArtDescripcion = artDescripcion;
            this.ArtPrecio_Compra = artPrecio_Compra;
            this.ArtPrecio_Venta = artPrecio_Venta;
            this.ArtUnidades = artUnidades; 
        }
        #endregion

        #region DECLARACION DE METODOS

        #region  Método Insertar
        public string Insertar(DArticulos Articulos)
        {
            string rpta = ""; // respuesta
            SqlConnection SqlCon = new SqlConnection();//para poder establecer luego la cadena de conexión.

            try
            {
                SqlCon.ConnectionString = Conexion.Cn; // establece la cadena de conexion = a la class Conexion y su variable Cn
                SqlCon.Open(); // como la conexion está cerrada entonces la abrimos con este metodo y estableceer una conexion con squlsrver

                //Establecer el comando // nos comunicamos con el procedimiento almacenado insertar en sqlserver
                SqlCommand SqlCmd = new SqlCommand(); // instancia de nombre SqlCmd: Cmd acronimo comando
                SqlCmd.Connection = SqlCon; // que se conecte utilizando la cadena de conexion SqlCon
                SqlCmd.CommandText = "spInsertar_Articulo";// indicamos nombre del procedimiento almacenado SQL
                SqlCmd.CommandType = CommandType.StoredProcedure; //indicamos que el tipo de objeto es un procedimiento almacenado en sql server

                // Declaramos los parametros que recibira el procedimiento almacenado spInsertar_Articulo
                SqlParameter ParArtCodigo = new SqlParameter(); // ParArtCodigo nueva "variable" u objeto del tipo SqlParameter, con esto pasamos los datos desde visual a sql   
                ParArtCodigo.ParameterName = "@ArtCodigo"; //nombre de la variable del procedimiento almacenado de SQL
                ParArtCodigo.SqlDbType = SqlDbType.Int; // establecer el tipo de datos
                ParArtCodigo.Direction = ParameterDirection.Output; // es un parametro de salida porque es autonumerico
                SqlCmd.Parameters.Add(ParArtCodigo); // // pasamos como parametro y agregamos el objeto que acabamos de crear

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@ArtDescripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 75;// asignamos el tamaño de la cadena de caracteres
                ParDescripcion.Value = Articulos.ArtDescripcion;// enviamos el valor de Articulos referenciando el metodo get y set de las propiedades del objeto
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@ArtPrecioCompra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Money;
                ParPrecio_Compra.Value = Articulos.ArtPrecio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@ArtPrecioVenta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Money;
                ParPrecio_Venta.Value = Articulos.ArtPrecio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParArtUnidades = new SqlParameter();
                ParArtUnidades.ParameterName = "@ArtUnidades";
                ParArtUnidades.SqlDbType = SqlDbType.Int;
                ParArtUnidades.Value = Articulos.ArtUnidades;
                SqlCmd.Parameters.Add(ParArtUnidades);

                //Ejecutamos el comando, a rpta se asigna el comando y pregunta: si se inserto un valor devolvera un OK y si no mostrara no se ingreso el registro
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {   // si aparece un posible error se almacena en la variable ex
                rpta = ex.Message;
            }   //entonces la respuesta va a ser igual a ex.Message (mostramos el error)

            finally // limpia todos los recursos que se asignan a un bloque, no depende del try por que se va a ejecutar si o si
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // si la cadena de concexion estabierta la cierro.
            }
            return rpta;
        }
        #endregion

        #region Método Editar
        public string Editar(DArticulos Articulos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try // El bloque try debe contener el código peligroso, o sea, el código que tiene algún riesgo de levantar la excepción y finalizar abruptamente el programa 
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spEditar_Articulos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Declaramos los parametros que recibira el procedimiento almacenado 
                SqlParameter ParArtCodigo = new SqlParameter();
                ParArtCodigo.ParameterName = "@ArtCodigo";
                ParArtCodigo.SqlDbType = SqlDbType.Int;
                ParArtCodigo.Value = Articulos.ArtCodigo; // aqui ya no es autonumerico sino que debemos enviarle un valor
                SqlCmd.Parameters.Add(ParArtCodigo);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@ArtDescripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 75;
                ParDescripcion.Value = Articulos.ArtDescripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@ArtPrecioCompra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Money;
                ParPrecio_Compra.Value = Articulos.ArtPrecio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@ArtPrecioVenta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Money;
                ParPrecio_Venta.Value = Articulos.ArtPrecio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParArtUnidades = new SqlParameter();
                ParArtUnidades.ParameterName = "@ArtUnidades";
                ParArtUnidades.SqlDbType = SqlDbType.Int;
                ParArtUnidades.Value = Articulos.ArtUnidades;
                SqlCmd.Parameters.Add(ParArtUnidades);

                //Ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizó el Registro";
            }
            catch (Exception ex) { rpta = ex.Message; } // si la excepción se levanta, el código dentro del catch evitará que se cierre el programa 
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); } // bloque opcional, finally se ejecuta siempre sin importar si hubo o no excepción, puede liberar recursos ocupados por try o catch
            return rpta;
        }
        #endregion

        #region Método Eliminar
        public string Eliminar(DArticulos Articulos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spEliminar_Articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Declaramos los parametros que recibira el procedimiento almacenado (en este caso solo recibe un parametro)
                SqlParameter ParArtCodigo = new SqlParameter();
                ParArtCodigo.ParameterName = "@ArtCodigo";
                ParArtCodigo.SqlDbType = SqlDbType.Int;
                ParArtCodigo.Value = Articulos.ArtCodigo;
                SqlCmd.Parameters.Add(ParArtCodigo);

                //Ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se eliminó el Registro";
            }
            catch (Exception ex) { rpta = ex.Message; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
            return rpta;
        }
        #endregion

        #region Método Mostrar
        public DataTable Mostrar()
        {
            // Muestra todos los registros de la tabla Articulos. Devuelve un tipo datatable
            DataTable DtResultados = new DataTable("TblArticulos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_Articulos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y rellenar 
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultados);// rellena con el parametro
            }
            catch (Exception ex) // POR QUE QUEDA VACIA ESTA VARIABLE???
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion

        #region Método Buscar
        public DataTable BuscarArticulo(DArticulos Articulo)
        {
            DataTable DtResultados = new DataTable("TblArticulos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_Articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.SqlValue = Articulo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                // Ejecutar el comando y rellenar datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultados);
            }
            catch (Exception ex) // POR QUE QUEDA VACIA ESTA VARIABLE, no se utiliza???
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion
    }    
#endregion
}

