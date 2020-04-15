using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.DAO
{
    public class ApuestasDAO : AbstractDAO, IDAOApuesta
    {
        public ApuestasDAO() { }
        // jugador, juego, fecha, cantidad
        public List<DTOApuesta> ListarTodasApuestas()
        {
            string queryString = "SELECT id, jugador, fecha, cantidad, id_juego FROM apuestas ORDER BY id ASC;";

            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                List<DTOApuesta> apuestasList = new List<DTOApuesta>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _Id = reader.GetInt32(0);
                        int _Jugador = reader.GetInt32(1);
                        DateTime _Fecha = reader.GetDateTime(2);
                        double _Cantidad = reader.GetDouble(2);
                        int _IdJuego = reader.GetInt32(3);

                        apuestasList.Add(new ApuestaDTO
                        {
                            Id = _Id,
                            Jugador = _Jugador,
                            Fecha = _Fecha,
                            Cantidad = _Cantidad,
                            IdJuego = _IdJuego
                        });
                    }
                }
            }

            return apuestasList;
        }
    }
}