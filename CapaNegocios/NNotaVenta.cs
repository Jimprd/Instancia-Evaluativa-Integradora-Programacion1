using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocios
{
    public class NNotaVenta
    {
        // Método insertar que llama al método insertar de la class DDetVentas de la Capa Dato

        public static string Insertar(DateTime nvFecha, string nvCliente, decimal nvImporteTotal, DataTable deDetalles)
        { // no ingresamos artcodigo porque es autonumerico??

            DNotaVenta Obj = new DNotaVenta();

            Obj.NVFecha = nvFecha;
            Obj.NVCliente = nvCliente;
            Obj.NVImporteTotal = nvImporteTotal;

            List<DDetVenta> detalles = new List<DDetVenta>();

            foreach (DataRow row in deDetalles.Rows)
            {
                DDetVenta detalle = new DDetVenta();

                //acá meter un contador para automatizar el numero de renglon  no cargarlo desde el textboxx

                detalle.NVDnroRenglon = Convert.ToInt32(row["Renglon"].ToString());
                detalle.NVDCodigoArticulo = Convert.ToInt32(row["ArtCodigo"].ToString());
                detalle.NVDPrecioVenta = Convert.ToDecimal(row["Precioventa"].ToString());
                detalle.NVDCantUnidades = Convert.ToInt32(row["Unidades"].ToString());

                detalles.Add(detalle);
            }

            return Obj.Insertar(Obj, detalles);
        }

        // Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DNotaVenta().Mostrar();
        }

// Metodo Buscar Fechas
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DNotaVenta Obj = new DNotaVenta();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(int textobuscar)
        {
            DNotaVenta Obj = new DNotaVenta();
            return Obj.BuscarDetalle(textobuscar);
        }

    }
}


