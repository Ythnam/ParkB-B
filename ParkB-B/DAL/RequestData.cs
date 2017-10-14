using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.DAL
{
    class RequestData
    {
        DataBaseConnection db = DataBaseConnection.Instance();

        public void test()
        {
            if (db.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM Company";
                var cmd = new MySqlCommand(query, db.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnUn = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + " : " + someStringFromColumnUn);
                }
            }
            db.Close();
        }
    }
}
