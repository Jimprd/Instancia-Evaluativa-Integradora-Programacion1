using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetCompra
    {
        #region Atributos
        private int _NCDNroComprobante;
        private int _NCDNroRenglon;
        private int _NCDCodigoArticulo;
        private int _NCDCantUnidades;
        private decimal _NCDPrecioCompra;
        private decimal _NCDPrecioVenta;

        #endregion

        #region Encapsulado
        public int NCDNroComprobante
        {
            get
            {
                return _NCDNroComprobante;
            }

            set
            {
                _NCDNroComprobante = value;
            }
        }

        public int NCDNroRenglon
        {
            get
            {
                return _NCDNroRenglon;
            }

            set
            {
                _NCDNroRenglon = value;
            }
        }

        public int NCDCodigoArticulo
        {
            get
            {
                return _NCDCodigoArticulo;
            }

            set
            {
                _NCDCodigoArticulo = value;
            }
        }

        public int NCDCantUnidades
        {
            get
            {
                return _NCDCantUnidades;
            }

            set
            {
                _NCDCantUnidades = value;
            }
        }

        public decimal NCDPrecioCompra
        {
            get
            {
                return _NCDPrecioCompra;
            }

            set
            {
                _NCDPrecioCompra = value;
            }
        }

        public decimal NCDPrecioVenta
        {
            get
            {
                return _NCDPrecioVenta;
            }

            set
            {
                _NCDPrecioVenta = value;
            }
        }

        // public int Stock_Ini
        //{
        //    get
        //    {
        //        return stock_Ini;
        //    }

        //    set
        //    {
        //        stock_Ini = value;
        //    }
        //}

        // public int Stock_Act
        //{
        //    get
        //    {
        //        return stock_Act;
        //    }

        //    set
        //    {
        //        stock_Act = value;
        //    }
        //}

        #endregion

        #region Constructores

        public DDetCompra() { }

        public DDetCompra(int ncdnumcomprobante, int ncdcodigoarticulo, int ncdNroRenglon, int ncdCantUnidades, decimal ncdPrecioCompra, decimal ncdPrecioVenta)
        {// int stock_Ini, int stock_Act

            this.NCDNroComprobante = ncdnumcomprobante;
            this.NCDCodigoArticulo = ncdcodigoarticulo;
            this.NCDNroRenglon = ncdNroRenglon;
            this.NCDCantUnidades = ncdCantUnidades;
            this.NCDPrecioCompra = ncdPrecioCompra;
            this.NCDPrecioVenta = ncdPrecioVenta;
            //Stock_Ini = stock_Ini;
            // Stock_Act = stock_Act; 
        }
        #endregion

        #region DECLARACION DE METODOS 

        #region  Metodo Insertar
        public string Insertar(DDetCompra DetCompra, ref SqlConnection SqlCon, ref SqlTransaction SqlTran) // parametros de referencia???? va a Nota  de Compra???
        {
            string rpta = "";

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.Transaction = SqlTran;
            SqlCmd.CommandText = "spInsertar_DetCompra";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            //capturador de errores
            try
            {
             //   SqlCon.ConnectionString = Conexion.Cn;
             //   SqlCon.Open();

                SqlParameter ParNCDNroComprobante = new SqlParameter();
                ParNCDNroComprobante.ParameterName = "@NCDNroComprobante";
                ParNCDNroComprobante.SqlDbType = SqlDbType.Int;
                ParNCDNroComprobante.Value = DetCompra.NCDNroComprobante;
                SqlCmd.Parameters.Add(ParNCDNroComprobante);

                SqlParameter ParNCDNroRenglon = new SqlParameter();
                ParNCDNroRenglon.ParameterName = "@NCDNroRenglon";
                ParNCDNroRenglon.SqlDbType = SqlDbType.Int;
                ParNCDNroRenglon.Value = DetCompra.NCDNroRenglon;
                SqlCmd.Parameters.Add(ParNCDNroRenglon);

                SqlParameter ParNCDCodigoArticulo = new SqlParameter();
                ParNCDCodigoArticulo.ParameterName = "@NCDCodigoArticulo";
                ParNCDCodigoArticulo.SqlDbType = SqlDbType.Int;
                ParNCDCodigoArticulo.Value = DetCompra.NCDCodigoArticulo; 
                SqlCmd.Parameters.Add(ParNCDCodigoArticulo);

                SqlParameter ParNCDCantUnidades = new SqlParameter();
                ParNCDCantUnidades.ParameterName = "@NCDCantUnidades";
                ParNCDCantUnidades.SqlDbType = SqlDbType.Int;
                ParNCDCantUnidades.Value = DetCompra.NCDCantUnidades;
                SqlCmd.Parameters.Add(ParNCDCantUnidades);

                SqlParameter ParNCDPrecioCompra = new SqlParameter();
                ParNCDPrecioCompra.ParameterName = "@NCDPrecioCompra";
                ParNCDPrecioCompra.SqlDbType = SqlDbType.Money;
                ParNCDPrecioCompra.Value = DetCompra.NCDPrecioCompra;
                SqlCmd.Parameters.Add(ParNCDPrecioCompra);

                SqlParameter ParNCDPrecioVenta = new SqlParameter();
                ParNCDPrecioVenta.ParameterName = "@NCDPrecioVenta";
                ParNCDPrecioVenta.SqlDbType = SqlDbType.Money;
                ParNCDPrecioVenta.Value = DetCompra.NCDPrecioVenta;
                SqlCmd.Parameters.Add(ParNCDPrecioVenta);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex) { rpta = ex.Message; }
            // acá no cerramos la conexion mediante el finally porque la conexion va a seguir abierta ya que una nota de compra puede tener uno o varios detalles
            return rpta;
        }
        #endregion
    }
    #endregion
}
