using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DNotaCompra
    {
        #region Atributos
        private int _CprComprobante;
        private string _CprNroFactura;
        private DateTime _CprFecha;
        private string _CprProveedor;
        private decimal _CprImporteTotal;
        #endregion

        #region Encapsulado

        public int CprComprobante
        {
            get
            {
                return _CprComprobante;
            }

            set
            {
                _CprComprobante = value;
            }
        }

        public string CprNroFactura
        {
            get
            {
                return _CprNroFactura;
            }

            set
            {
                _CprNroFactura = value;
            }
        }

        public DateTime CprFecha
        {
            get
            {
                return _CprFecha;
            }

            set
            {
                _CprFecha = value;
            }
        }

        public string CprProveedor
        {
            get
            {
                return _CprProveedor;
            }

            set
            {
                _CprProveedor = value;
            }
        }

        public decimal CprImporteTotal
        {
            get
            {
                return _CprImporteTotal;
            }

            set
            {
                _CprImporteTotal = value;
            }
        }

        #endregion

        #region Constructores

        public DNotaCompra() { }

        public DNotaCompra(string cprNroFactura, DateTime cprFecha, string cprProveedor, decimal cprImporteTotal)
        {
         //   this.CprComprobante = cprComprobante;
            this.CprNroFactura = cprNroFactura;
            this.CprFecha = cprFecha;
            this.CprProveedor = cprProveedor;
            this.CprImporteTotal = cprImporteTotal;
        }
        #endregion

        #region DECLARACION DE METODOS

        #region  Método Insertar
        public string Insertar(DNotaCompra NotaCompra, List<DDetCompra> DetCompra)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            //Capturador de Errores
            try
            {
                // Establece Cadena de Conexión
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                // Establecer la Transacción 
                SqlTransaction SqlTran = SqlCon.BeginTransaction(); // Para que cada detalle de ingreso sea relacionado unicamente con un solo ingreso mediante SqlTran

                // Establecer el Comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTran; // que SqlCmd trabaje con la transaccion SqlTran
                SqlCmd.CommandText = "spInsertar_notaCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Declaramos los parametros que recibira el procedimiento almacenado 
                SqlParameter ParCprComprobante = new SqlParameter();
                ParCprComprobante.ParameterName = "@CprComprobante";
                ParCprComprobante.SqlDbType = SqlDbType.Int;
                ParCprComprobante.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCprComprobante);

                SqlParameter ParCprNroFactura = new SqlParameter();
                ParCprNroFactura.ParameterName = "@CprNroFactura";
                ParCprNroFactura.SqlDbType = SqlDbType.VarChar;
                ParCprNroFactura.Size = 13;
                ParCprNroFactura.Value = NotaCompra.CprNroFactura;
                SqlCmd.Parameters.Add(ParCprNroFactura);

                SqlParameter ParCprFecha = new SqlParameter();
                ParCprFecha.ParameterName = "@CprFecha";
                ParCprFecha.SqlDbType = SqlDbType.Date;
                ParCprFecha.Value = NotaCompra.CprFecha;
                SqlCmd.Parameters.Add(ParCprFecha);

                SqlParameter ParCprProveedor = new SqlParameter();
                ParCprProveedor.ParameterName = "@CprProveedor";
                ParCprProveedor.SqlDbType = SqlDbType.VarChar;
                ParCprProveedor.Size = (50);
                ParCprProveedor.Value = NotaCompra.CprProveedor;
                SqlCmd.Parameters.Add(ParCprProveedor);

                SqlParameter ParCprImporteTotal = new SqlParameter();
                ParCprImporteTotal.ParameterName = "@CprImporteTotal";
                ParCprImporteTotal.SqlDbType = SqlDbType.Money;
                ParCprImporteTotal.Value = NotaCompra.CprImporteTotal;
                SqlCmd.Parameters.Add(ParCprImporteTotal);

                //Ejecutamos el comando, a rpta se asigna el el comando y pregunta

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso la Nota de Compra";

                // Obtener el codigo de ingreso (Nota de compra???)

                if (rpta.Equals("OK")) // si se insertó 
                {
                    // Obtener el código del ingreso generado
                    this.CprComprobante = Convert.ToInt32(SqlCmd.Parameters["@CprComprobante"].Value);

                    foreach (DDetCompra det in DetCompra) // es un iterador, recorre todos los elementos que existen en una estructura de datos, luego ejecutamos una  
                    {                                     // acción con ellos y finaliza cuando la coleccion ya no tiene más elementos que entregar.

                        det.NCDNroComprobante = this.CprComprobante;

                        // LLama al Metodo Insertar de la clase DDetCompras

                        rpta = det.Insertar(det, ref SqlCon, ref SqlTran);

                        if (!rpta.Equals("OK")) // si NO se insertó, entonces ocurre un error, y entonces
                        {
                            break; // con esto salgo del bucle  
                        }
                    }
                }
                if (rpta.Equals("OK")) // si se insertó 
                {
                    SqlTran.Commit(); // SqlTran confirma la transaccion e ingresar la nota de compra con sus detalles
                }
                else
                {
                    SqlTran.Rollback(); // si no se insertó, se niega la transacción
                }
            }
            catch (Exception ex) { rpta = ex.Message; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
           // SqlCon.Close();
            return rpta;
        }
        #endregion

        #region Método Mostrar
        public DataTable Mostrar()
        {
            // Muestra todos los registros de la tabla Articulos. Devuelve un tipo datatable
            DataTable DtResultados = new DataTable("NotaCompra");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_NotaCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y rellenar 
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultados);
            }
            catch (Exception ex) // POR QUE QUEDA VACIA ESTA VARIABLE???
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion

        #region Método Buscar Fecha
        public DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {

            DataTable DtResultados = new DataTable("NotaCompra");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscar_Ingreso_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = textobuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                // Ejecutar el comando y rellenar 
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

        #region Método Buscar Detalle
        public DataTable BuscarDetalle(int Textobuscar)
        {

            DataTable DtResultados = new DataTable("DetalleNotaCompra");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_detalleCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                // Ejecutar el comando y rellenar 
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
