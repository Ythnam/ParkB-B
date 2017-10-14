using MySql.Data.MySqlClient;
using ParkB_B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.DAL
{
    public class ParkingDAO : AbstractDAO
    {

        public List<Parking> GetParkings()
        {
            List<Parking> list = new List<Parking>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT parking_name FROM Parking";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Parking() {
                        Name = (string)reader["parking_name"]
                    });
                }
                return list;
            }
        }

    }
}
