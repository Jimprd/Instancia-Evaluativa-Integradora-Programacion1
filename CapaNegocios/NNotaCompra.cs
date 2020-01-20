using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NNotaCompra
    {
        public static string Insertar(string cprNroFactura, DateTime cprFecha, string cprProveedor, decimal cprImporteTotal, DataTable deDetalles)
        {

            DNotaCompra Obj = new DNotaCompra();
            Obj.CprNroFactura = cprNroFactura;
            Obj.CprFecha = cprFecha;
            Obj.CprProveedor = cprProveedor;
            Obj.CprImporteTotal = cprImporteTotal;

            List<DDetCompra> detalles = new List<DDetCompra>();

            foreach (DataRow row in deDetalles.Rows)
            {
                DDetCompra detalle = new DDetCompra();

                //acá meter un contador para automatizar el numero de renglon no cargarlo desde el textboxx

                detalle.NCDNroRenglon = Convert.ToInt32(row["Renglon"].ToString());
                detalle.NCDCodigoArticulo = Convert.ToInt32(row["ArtCodigo"].ToString());
                detalle.NCDPrecioCompra = Convert.ToDecimal(row["Preciocompra"].ToString());
                detalle.NCDPrecioVenta = Convert.ToDecimal(row["Precioventa"].ToString());
                detalle.NCDCantUnidades = Convert.ToInt32(row["Unidades"].ToString());

                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        //Método Mostrar que llama al método Mostrar de la clase DIngreso
        //de la CapaDatos

        public static DataTable Mostrar()
        {
            return new DNotaCompra().Mostrar();
        }

        //Método BuscarFecha que llama al método BuscarNombre
        //de la clase DIngreso de la CapaDatos

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DNotaCompra Obj = new DNotaCompra();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(int textobuscar)
        {
            DNotaCompra Obj = new DNotaCompra();
            return Obj.BuscarDetalle(textobuscar);
        }
    }
}
