using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.Models
{
    public class mApuestas
    {
        public int Id { get; set; }

        public String Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public int IdJuego { get; set; }
    }
}