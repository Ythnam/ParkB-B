using MySql.Data.MySqlClient;
using ParkB_B.Model;
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
                //var reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    string someStringFromColumnZero = reader.GetString(0);
                //    string someStringFromColumnUn = reader.GetString(1);
                //    Console.WriteLine(someStringFromColumnZero + " : " + someStringFromColumnUn);
                //}
            }
        }

        //Exemple de query avec Insert ==> utile pour créer les contrats
        public void Insert(Company company)
        {
            MySqlCommand comm = db.Connection.CreateCommand();
            comm.CommandText = "INSERT INTO Company(company_name) VALUES(@name)";
            comm.Parameters.AddWithValue("@name", company.Name);
            comm.ExecuteNonQuery();
        }

        public void Close()
        {
            db.Close();
        }
    }
}
