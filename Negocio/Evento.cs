using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
 //
    public class Evento
    {
        public int Id;
        public String Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public float Cuota { get; set; }

        public String Mercado { get; set; }

        public int IdJuego { get; set; }
    }
}
