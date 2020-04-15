using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTOEvento
    {
        public int Id;

        public string Nombre { get; set; }
        
        public DateTime Fecha { get; set; }

        public float Cuota { get; set; }

        public string Mercado { get; set; }

        public int IdJuego { get; set; }
    }
}