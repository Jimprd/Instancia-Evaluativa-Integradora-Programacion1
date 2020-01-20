using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data; //para que es esta capa ?


namespace CapaNegocios
{
    public class NArticulo
    {

        // Método INSERTAR

        public static string Insertar(string artdescripcion, decimal artpreciocompra, decimal artprecioventa, int artunidades)
        {
            DArticulos Obj = new DArticulos();

            Obj.ArtDescripcion = artdescripcion;
            Obj.ArtPrecio_Compra = artpreciocompra;
            Obj.ArtPrecio_Venta = artprecioventa;
            Obj.ArtUnidades = artunidades;

            return Obj.Insertar(Obj);
        }

        // Método EDITAR
        public static string Editar(int artcodigo, decimal artprecioventa, int artunidades)
        {
            DArticulos Obj = new DArticulos();

            Obj.ArtCodigo = artcodigo;
            Obj.ArtPrecio_Venta = artprecioventa;
            Obj.ArtUnidades = artunidades;

            return Obj.Editar(Obj);
        }

        public static string Editar(int artcodigo, string artdescripcion, decimal artpreciocompra, decimal artprecioventa, int artunidades)
        {
            DArticulos Obj = new DArticulos();

            Obj.ArtCodigo = artcodigo;
            Obj.ArtDescripcion = artdescripcion;
            Obj.ArtPrecio_Compra = artpreciocompra;
            Obj.ArtPrecio_Venta = artprecioventa;
            Obj.ArtUnidades = artunidades;

            return Obj.Editar(Obj);
        }

        // Método ELIMINAR 

        public static string Eliminar(int artcodigo)
        {
            DArticulos Obj = new DArticulos();

            Obj.ArtCodigo = artcodigo;

            return Obj.Eliminar(Obj);
        }

        // Método MOSTRAR

        public static DataTable Mostar()
        {
            return new DArticulos().Mostrar();
        }

        // Método BUSCAR

        public static DataTable BuscarArticulo(string textobuscar)
        {
            DArticulos Obj = new DArticulos();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarArticulo(Obj);
        }
    }
}
