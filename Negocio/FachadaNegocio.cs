using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FachadaNegocio
    {
        private IDAOApuesta daoApuestas = new IDAOApuestasImpl();
        public List<Apuesta> ListarApuestas()
        {
            List<Apuesta> listaApuestas = new List<Apuesta>();
            daoApuestas.ListarTodasApuestas().ForEach(delegate(DTOApuesta dtoA)
            {

                listaApuestas.Add(new Apuesta()
                {
                    Id: dtoA.Id,

                    /*
                     * public int Id { get; set; }

        public String Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public int IdJuego { get; set; }
                    */

                });
            }
        }
    }
}
