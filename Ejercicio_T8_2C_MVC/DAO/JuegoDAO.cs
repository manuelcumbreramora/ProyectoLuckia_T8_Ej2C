using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_T8_2C_MVC.DAO
{
    public class JuegoDAO : AbstractDAO
    {
        public JuegoDAO() { }

        public List<MJuegos> getJuegos()
        {
            string queryString = "SELECT ID, nombre, tipo FROM juegos ORDER BY id ASC;";

            using (SqlConnection dbConnection = new SqlConnection(AbstractDAO.DB_CONNECTION_STRING))
            {
                List<MJuegos> juegosList = new List<MJuegos>();

                SqlCommand command = new SqlCommand(queryString, dbConnection);

                dbConnection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string _ID = reader.GetInt32(0);
                        string _nombre = reader.GetString(1);
                        int _tipo = reader.GetInt32(2);

                        juegosList.Add(new mJuegos
                        {
                            ID = _ID,
                            nombre = _nombre,
                            tipo = _tipo
                        });
                    }
                }
            }

            return juegoList;
        }
    }
}
