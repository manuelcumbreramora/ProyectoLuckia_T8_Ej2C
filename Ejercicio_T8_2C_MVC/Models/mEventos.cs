using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.Models
{
    public class mEventos
    {
      
            public int ID { get; set; }
            public string nombre { get; set; }
            public double? cuota { get; set; }
            public DateTime? fecha { get; set; }
            public int? idJuego { get; set; }


    }
}