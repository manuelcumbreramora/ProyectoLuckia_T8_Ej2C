using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    //
    public class Apuesta
    {
        public int Id { get; set; }

        public String Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public int IdJuego { get; set; }
    }
}
