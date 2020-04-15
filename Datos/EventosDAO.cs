using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Datos
{
    public class EventosDAO : AbstractDAO, IDAOEvento
    {
        public EventosDAO() { }

        public List<DTOEvento> ListarTodosEventos()
        {
            string queryString = "SELECT Id, nombre, fecha, cuota, mercado, juego FROM eventos ORDER BY DATE ASC;";

            List<DTOEvento> eventosList;
            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                eventosList = new List<DTOEvento>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _Id = reader.GetInt32(0);
                        string _Nombre = reader.GetString(1);
                        DateTime _Fecha = reader.GetDateTime(2);
                        double _Cuota = reader.GetDouble(3);
                        string _Mercado = reader.GetString(4);
                        int _IdJuego = reader.GetInt32(5);

                        eventosList.Add(new DTOEvento
                        {
                            Id = _Id, 
                            Nombre = _Nombre,
                            Fecha = _Fecha,
                            Cuota = (float)_Cuota, 
                            Mercado = _Mercado,
                            IdJuego = _IdJuego
                        });
                    }
                }
            }

            return eventosList;
        }

        public DTOEvento ObtenerUltimoEvento(int idJuego)
        {
            string queryString = "SELECT Id, nombre, fecha, cuota, mercado, juego FROM eventos WHERE juego = idJuego ORDER BY DATE ASC;";

            List<DTOEvento> eventosList;
            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                eventosList = new List<DTOEvento>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _Id = reader.GetInt32(0);
                        string _Nombre = reader.GetString(1);
                        DateTime _Fecha = reader.GetDateTime(2);
                        double _Cuota = reader.GetDouble(3);
                        string _Mercado = reader.GetString(4);
                        int _IdJuego = reader.GetInt32(5);

                        eventosList.Add(new DTOEvento
                        {
                            Id = _Id,
                            Nombre = _Nombre,
                            Fecha = _Fecha,
                            Cuota = (float)_Cuota,
                            Mercado = _Mercado,
                            IdJuego = _IdJuego
                        });
                    }
                }
            }

            return (eventosList.Count > 0) ? eventosList.First() : null;
        }
    }
}