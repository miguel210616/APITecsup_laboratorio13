using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup_laboratorio13.Models.Response
{
    public class ProductResponse
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double IGV { get; set; }
    }
}