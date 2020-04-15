using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.Models
{
    public class mEventos
    {

        public int Id;
        public String Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public float Cuota { get; set; }

        public String Mercado { get; set; }

        public int IdJuego { get; set; }


    }
}