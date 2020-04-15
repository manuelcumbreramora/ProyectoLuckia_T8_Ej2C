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
        private IDAOApuesta DAOApuestas = new ApuestasDAO();
        public List<Apuesta> ListarApuestas()
        {
            List<Apuesta> listaApuestas = new List<Apuesta>();
            DAOApuestas.ListarTodasApuestas().ForEach(delegate (DTOApuesta dtoA)
            {
                listaApuestas.Add(new Apuesta
                {
                    Id = dtoA.Id,
                    IdUsuario = dtoA.IdUsuario,
                    Fecha = dtoA.Fecha,
                    IdJuego = dtoA.IdJuego
                });
            });
            return listaApuestas;
        }

        private IDAOEvento DAOEventos = new EventosDAO();
        public List<Evento> ListarEventos()
        {
            List<Evento> listaEventos = new List<Evento>();
            DAOEventos.ListarTodosEventos().ForEach(delegate (DTOEvento dtoE)
            {
                listaEventos.Add(new Evento
                {
                    Id = dtoE.Id,
                    Nombre = dtoE.Nombre,
                    Fecha= dtoE.Fecha,
                    Cuota = dtoE.Cuota,
                    Mercado = dtoE.Mercado,
                    IdJuego = dtoE.IdJuego,
                }) ;
            });
            return listaEventos;
        }

        private IDAOJuego DAOJuegos = new JuegoDAO();
        public List<Juego> ListarJuegos()
        {
            List<Juego> listaJuegos = new List<Juego>();
            DAOJuegos.ListarTodosJuegos().ForEach(delegate (DTOJuego dtoE)
            {
                listaJuegos.Add(new Juego
                {
                    Id = dtoE.Id,
                    Nombre = dtoE.Nombre,
                    Tipo = dtoE.Tipo,
                });
            });
            return listaJuegos;
        }

        /*
         * Este es el método que se debería llamar desde Casino 
         */
        public void RegistrarApuestas(int idJugador, List<Tuple<int, float>> apuestas)
        {
            List<int> idsApuestas = new List<int>();

            apuestas.ForEach(delegate (Tuple<int, float> tupla)
            {
                DTOApuesta apuesta=new DTOApuesta();
                apuesta.Id = 0;
                apuesta.IdJuego = tupla.Item1;
                apuesta.Importe = tupla.Item2;
                apuesta.IdUsuario = idJugador;

                DAOApuestas.Insertar(apuesta);
            });
        }
    }
}
