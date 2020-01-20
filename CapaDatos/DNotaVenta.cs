using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DNotaVenta
    {
        #region Atributos
        private int _NVNroComprobante;
        private DateTime _NVFecha;
        private string _NVCliente;
        private decimal _NVImporteTotal;
        #endregion

        #region Encapsulado
        public int NVNroComprobante
        {
            get
            {
                return _NVNroComprobante;
            }

            set
            {
                _NVNroComprobante = value;
            }
        }

        public DateTime NVFecha
        {
            get
            {
                return _NVFecha;
            }

            set
            {
                _NVFecha = value;
            }
        }

        public string NVCliente
        {
            get
            {
                return _NVCliente;
            }

            set
            {
                _NVCliente = value;
            }
        }

        public decimal NVImporteTotal
        {
            get
            {
                return _NVImporteTotal;
            }

            set
            {
                _NVImporteTotal = value;
            }
        }
        #endregion

        #region Constructores

        public DNotaVenta() { }

        public DNotaVenta(DateTime nvFecha, string nvCliente, decimal nvImporteTotal)
        {
            this.NVFecha = nvFecha;
            this.NVCliente = nvCliente;
            this.NVImporteTotal = nvImporteTotal;
        }
        #endregion

        #region DECLARACION DE METODOS

        #region  Método Insertar
        public string Insertar(DNotaVenta NotaVenta, List<DDetVenta> DetVenta)
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
                SqlCmd.CommandText = "spInsertar_notaVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Declaramos los parametros que recibira el procedimiento almacenado 
                SqlParameter ParNVNroComprobante = new SqlParameter();
                ParNVNroComprobante.ParameterName = "@NVNroComprobante";
                ParNVNroComprobante.SqlDbType = SqlDbType.Int;
                ParNVNroComprobante.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParNVNroComprobante);

                SqlParameter ParNVFecha = new SqlParameter();
                ParNVFecha.ParameterName = "@NVFecha";
                ParNVFecha.SqlDbType = SqlDbType.Date;
                ParNVFecha.Value = NotaVenta.NVFecha;
                SqlCmd.Parameters.Add(ParNVFecha);

                SqlParameter ParNVCliente = new SqlParameter();
                ParNVCliente.ParameterName = "@NVCliente";
                ParNVCliente.SqlDbType = SqlDbType.VarChar;
                ParNVCliente.Size = (50);
                ParNVCliente.Value = NotaVenta.NVCliente;
                SqlCmd.Parameters.Add(ParNVCliente);

                SqlParameter ParNVImporteTotal = new SqlParameter();
                ParNVImporteTotal.ParameterName = "@NVImporteTotal";
                ParNVImporteTotal.SqlDbType = SqlDbType.Money;
                ParNVImporteTotal.Value = NotaVenta.NVImporteTotal;
                SqlCmd.Parameters.Add(ParNVImporteTotal);

                //Ejecutamos el comando, a rpta se asigna el el comando y pregunta

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso la Nota de Compra";

                // Obtener el codigo de ingreso (Nota de compra???)

                if (rpta.Equals("OK")) // si se insertó 
                {
                    // Obtener el código del ingreso generado
                    this.NVNroComprobante = Convert.ToInt32(SqlCmd.Parameters["@NVNroComprobante"].Value);

                    foreach (DDetVenta det in DetVenta) // es un iterador, recorre todos los elementos que existen en una estructura de datos, luego ejecutamos una  
                    {                                     // acción con ellos y finaliza cuando la coleccion ya no tiene más elementos que entregar.

                        det.NVDnroComprobante = this.NVNroComprobante;

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
            DataTable DtResultados = new DataTable("NotaVenta");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_NotaVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y rellenar 
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultados);
            }
            catch (Exception ex) 
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion

        #region Método Buscar Fecha 
        public DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {

            DataTable DtResultados = new DataTable("NotaVenta");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscar_Venta_Fecha";
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
            catch (Exception ex) 
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion

        #region Método Buscar Detalle
        public DataTable BuscarDetalle(int Textobuscar)
        {

            DataTable DtResultados = new DataTable("DetalleNotaVenta");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_DetVenta";
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
            catch (Exception ex) 
            {
                DtResultados = null;
            }
            return DtResultados;
        }
        #endregion
    }
    #endregion
}
