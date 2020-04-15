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
        private IDAOApuesta DAOApuestas = new DAOApuestasImpl();
        public List<Apuesta> ListarApuestas()
        {
            List<Apuesta> listaApuestas = new List<Apuesta>();
            DAOApuestas.ListarTodasApuestas().ForEach(delegate (DTOApuesta dtoA)
            {
                listaApuestas.Add(new Apuesta
                {
                    Id = dtoA.Id,
                    Usuario = dtoA.Usuario,
                    Fecha = dtoA.Fecha,
                    IdJuego = dtoA.IdJuego
                });
            });
            return listaApuestas;
        }

        private IDAOEvento DAOEventos = new DAOEventosImpl();
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

        private IDAOJuego DAOJuegos = new DAOJuegosImpl();
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
    }
}
