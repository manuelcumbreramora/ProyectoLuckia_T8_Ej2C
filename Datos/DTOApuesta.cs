using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class DTOApuesta
    {
        public int Id { get; set; }

        public int Jugador { get; set; }

        public DateTime Fecha { get; set; }

        public double Cantidad { get; set; }

        public int IdJuego { get; set; }
    }
}
