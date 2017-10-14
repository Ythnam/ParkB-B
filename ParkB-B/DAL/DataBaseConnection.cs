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
        #region Properties
        MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private string databaseName = string.Empty;
        private string pw;
        private string user_name;
        private string port;
        private string serverAdd;
        #endregion

        #region Constructor
        private DataBaseConnection() { }

        private static DataBaseConnection _instance = null;
        public static DataBaseConnection Instance()
        {
            if (_instance == null)
                _instance = new DataBaseConnection();
            return _instance;
        }
        #endregion



        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    result = false;

                serverAdd = "Server=243b8f54-a2a4-4bc5-bbc4-0368ed6aacf2.parkpnp-4699.mysql.dbs.scalingo.com;";
                port = "Port=31244;";
                user_name = "Uid=parkpnp_4699;";
                pw = "Pwd=YT1QP7Ult2t2tCOeTIol;";
                databaseName = "Database = parkpnp_4699;";
                connection = new MySqlConnection(serverAdd + port + databaseName + user_name + pw);
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
