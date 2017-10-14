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
        DataBaseConnection db;

        public RequestData()
        {
            this.db = DataBaseConnection.Instance();
        }

        public void Request(String query)
        {
            if (db.IsConnect())
            {
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
