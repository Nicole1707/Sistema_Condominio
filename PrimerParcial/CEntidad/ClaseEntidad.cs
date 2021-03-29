using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CEntidad
{
   public class ClaseEntidad
    {
        public string Nombre { get; set; }
        public string cedula { get; set; }
        public int Manzana { get; set; }
        public int Edificio { get; set; }
        public int Apartamento { get; set; }
    }
    public class EntidadConfi
    {
        public string Manzana { get; set; }
        public string Edificio { get; set; }
        public string Apartamento { get; set; }
        public string Mensaje { get; set; }

    }
}
