using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.DAL
{
    class DataBaseConnection
    {
        MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        private DataBaseConnection() { }

        private static DataBaseConnection _instance = null;
        public static DataBaseConnection Instance()
        {
            if (_instance == null)
                _instance = new DataBaseConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                //if (String.IsNullOrEmpty(databaseName))
                //    result = false;
                //string connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", databaseName);

                string add = "Server=243b8f54-a2a4-4bc5-bbc4-0368ed6aacf2.parkpnp-4699.mysql.dbs.scalingo.com;";
                string port = "Port=31244;";
                string user_name = "Uid=parkpnp_4699;";
                string pw = "Pwd=YT1QP7Ult2t2tCOeTIol;";
                connection = new MySqlConnection(add + port + "Database = parkpnp_4699;" + user_name + pw);
                connection.Open();
                result = true;
            }

            return result;
        }


        public void Close()
        {
            this.connection.Close();
        }
    }
}
