using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.DAO
{
    public class EventosDAO : AbstractDAO
    {
        public EventosDAO() { }

        public List<MJuegos> getEventos()
        {
            string queryString = "SELECT ID, nombre, cuota, mercado, fecha, (SELECT ID_juego FROM juegos_eventos WHERE ID_juego = evt.ID) FROM eventos AS evt ORDER BY id ASC;";

            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                List<MEventos> eventosList = new List<MEventos>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string _ID = reader.GetInt32(0);
                        string _nombre = reader.GetString(1);
                        double _quota = reader.GetDouble(2);
                        string _mercado = reader.GetString(3);
                        DateTime _fecha = reader.GetDateTime(4);

                        eventosList.Add(new mEventos
                        {
                            ID = _ID, 
                            nombre = _nombre, 
                            cuota = _cuota, 
                            _mercado = _mercado,
                            fecha = _fecha,
                            idJuego = null
                        });
                    }
                }
            }

            return juegoList;
        }
    }
}