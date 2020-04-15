using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.DAO
{
    public class JuegoDAO : AbstractDAO, IDAOJuego
    {
        public JuegoDAO() { }

        public List<DTOJuego> ListarTodosJuegos()
        {
            string queryString = "SELECT id, nombre, tipo FROM juegos ORDER BY id ASC;";

            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                List<DTOJuego> juegosList = new List<DTOJuego>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);

                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _Id = reader.GetInt32(0);
                        string _Nombre = reader.GetString(1);
                        string _Tipo = reader.GetString(2);

                        juegosList.Add(new DTOJuego
                        {
                            Id = _Id,
                            Nombre = _Nombre,
                            Tipo = _Tipo
                        });
                    }
                }
            }

            return juegoList;
        }
    }
}
