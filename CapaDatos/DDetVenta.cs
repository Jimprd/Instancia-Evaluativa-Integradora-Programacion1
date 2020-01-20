using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetVenta
    {
        #region Atributos

        private int _NVDnroComprobante;
        private int _NVDnroRenglon;
        private int _NVDCodigoArticulo;
        private int _NVDCantUnidades;
        private decimal _NVDPrecioVenta;
        private int _TextoBuscar;
        #endregion

        #region Encapsulado
        public int NVDnroComprobante
        {
            get
            {
                return _NVDnroComprobante;
            }

            set
            {
                _NVDnroComprobante = value;
            }
        }

        public int NVDnroRenglon
        {
            get
            {
                return _NVDnroRenglon;
            }

            set
            {
                _NVDnroRenglon = value;
            }
        }

        public int NVDCodigoArticulo
        {
            get
            {
                return _NVDCodigoArticulo;
            }

            set
            {
                _NVDCodigoArticulo = value;
            }
        }

        public int NVDCantUnidades
        {
            get
            {
                return _NVDCantUnidades;
            }

            set
            {
                _NVDCantUnidades = value;
            }
        }

        public decimal NVDPrecioVenta
        {
            get
            {
                return _NVDPrecioVenta;
            }

            set
            {
                _NVDPrecioVenta = value;
            }
        }

        public int TextoBuscar
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
        public DDetVenta() { }

        public DDetVenta(int nvdnroComprobante, int nvdnroRenglon, int nvdnroCodigoarticulo, int nvdCantunidades, decimal nvdPrecioventa)
        {
            this.NVDnroComprobante = nvdnroComprobante;
            this.NVDnroRenglon = nvdnroRenglon;
            this.NVDCodigoArticulo = nvdnroCodigoarticulo;
            this.NVDCantUnidades = nvdCantunidades;
            this.NVDPrecioVenta = nvdPrecioventa;
        }

        #endregion

        #region DECLARACION DE METODOS

        #region Metodo Insertar
        public string Insertar(DDetVenta DetVenta, ref SqlConnection SqlCon, ref SqlTransaction SqlTran)
        {
            string rpta = "";

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.Transaction = SqlTran;
            SqlCmd.CommandText = "spInsertar_DetVenta";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            //capturador de errores
            try
            {
                SqlParameter ParNVDnroComprobante = new SqlParameter();
                ParNVDnroComprobante.ParameterName = "@NVDNroComprobante";
                ParNVDnroComprobante.SqlDbType = SqlDbType.Int;
                ParNVDnroComprobante.Value = DetVenta.NVDnroComprobante;
                SqlCmd.Parameters.Add(ParNVDnroComprobante);

                SqlParameter ParNVDnroRenglon = new SqlParameter();
                ParNVDnroRenglon.ParameterName = "@NVDNroRenglon";
                ParNVDnroRenglon.SqlDbType = SqlDbType.Int;
                ParNVDnroRenglon.Value = DetVenta.NVDnroRenglon;
                SqlCmd.Parameters.Add(ParNVDnroRenglon);

                SqlParameter ParNVDCodigoArticulo = new SqlParameter();
                ParNVDCodigoArticulo.ParameterName = "@NVDCodigoArticulo";
                ParNVDCodigoArticulo.SqlDbType = SqlDbType.Int;
                ParNVDCodigoArticulo.Value = DetVenta.NVDCodigoArticulo; 
                SqlCmd.Parameters.Add(ParNVDCodigoArticulo);

                SqlParameter ParNVDCantUnidades = new SqlParameter();
                ParNVDCantUnidades.ParameterName = "@NVDCantidadUnidades";
                ParNVDCantUnidades.SqlDbType = SqlDbType.Int;
                ParNVDCantUnidades.Value = DetVenta.NVDCantUnidades; // Este de algún modo deberia restar de la Tblarticulos?
                SqlCmd.Parameters.Add(ParNVDCantUnidades);

                SqlParameter ParNVDPrecioVenta = new SqlParameter();
                ParNVDPrecioVenta.ParameterName = "@NVDPrecioVenta";
                ParNVDPrecioVenta.SqlDbType = SqlDbType.Money;
                ParNVDPrecioVenta.Value = DetVenta.NVDPrecioVenta; 
                SqlCmd.Parameters.Add(ParNVDPrecioVenta);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex) { rpta = ex.Message; }

            return rpta;
        }
        #endregion
        #endregion
    }
}
