using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Datos
{
    public class ApuestasDAO : AbstractDAO, IDAOApuesta
    {
        public ApuestasDAO() { }

        public List<DTOApuesta> ListarTodasApuestas()
        {
            string queryString = "SELECT id, jugador, fecha, cantidad, id_juego FROM apuestas ORDER BY id ASC;";

            List<DTOApuesta> apuestasList;

            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                dbConnection.Open();
                apuestasList = new List<DTOApuesta>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _Id = reader.GetInt32(0);
                        int _Jugador = reader.GetInt32(1);
                        DateTime _Fecha = reader.GetDateTime(2);
                        double _Cantidad = reader.GetDouble(2);
                        int _IdJuego = reader.GetInt32(3);

                        apuestasList.Add(new DTOApuesta()
                        {
                            Id = _Id,
                            IdUsuario = _Jugador,
                            Fecha = _Fecha,
                            Importe = (float)_Cantidad,
                            IdJuego = _IdJuego
                        });
                    }
                }
            }

            return apuestasList;
        }
/*
        public int InsertarApuesta(DTOApuesta apuesta)
        {
            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO apuestas (jugador, fecha, cantidad, id_juego) " +
                    "VALUES (@jugador, @fecha, @cantidad, @id_juego);";

                SqlParameter _jugadorParam = new SqlParameter("@jugador", SqlDbType.Int, 0);
                SqlParameter _fechaParam = new SqlParameter("@fecha", SqlDbType.DateTime, 0);
                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Double, 0);
                SqlParameter _cantidad = new SqlParameter("@id_juego", SqlDbType.Int, 0);

            }


            // Create and prepare an SQL statement.
            command.CommandText =
                "INSERT INTO Region (RegionID, RegionDescription) " +
                "VALUES (@id, @desc)";
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0);
            SqlParameter descParam =
                new SqlParameter("@desc", SqlDbType.Text, 100);
            idParam.Value = 20;
            descParam.Value = "First Region";
            command.Parameters.Add(idParam);
            command.Parameters.Add(descParam);


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
*/
    }
}