using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Conexion
    {// esta @ hace algo para que no me tome como error la \ en la cadena de texto
        public static string Cn = @"Data Source=DESKTOP-RO27LM8\SQLSERVER; Initial Catalog=stock; Integrated Security=true";
    }
}
