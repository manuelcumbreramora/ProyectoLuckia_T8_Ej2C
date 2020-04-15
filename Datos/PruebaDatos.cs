using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    static class PruebaDatos
    {
        public static void Main()
        {
            IDAOApuesta apuestaDAO = new ApuestasDAO();

            List<DTOApuesta> lista = apuestaDAO.ListarTodasApuestas();

            Console.WriteLine("Apuestas:");
            /*
             * public int Id { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Fecha { get; set; }

        public int IdJuego { get; set; }

        public float Importe { get; set; }
             */
            lista.ForEach(delegate (DTOApuesta dto)
            {
                Console.WriteLine("id: {0}, IdUsuario: {1}, Fecha: {2}, IdJuego: {3}, Importe: {4}.",
                    dto.Id, dto.IdUsuario, dto.Fecha, dto.IdJuego, dto.Importe);
            });
        }
    }
}
