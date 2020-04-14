using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.Models
{
    public class mApuestas
    {
        public int ID { get; set; }
        public int? IDJugador { get; set; }

        public DateTime? fecha { get; set; }

        public double? cantidad { get; set; }
    }
}