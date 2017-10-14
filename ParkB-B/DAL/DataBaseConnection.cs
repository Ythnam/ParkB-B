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
        public void Connect()
        {
            string add = "datasource=243b8f54-a2a4-4bc5-bbc4-0368ed6aacf2.parkpnp-4699.mysql.dbs.scalingo.com;";
            string port = "port=31244;";
            string user_name = "username=parkpnp_4699";
            string pw = "password=YT1QP7Ult2t2tCOeTIol";
            MySqlConnection connection = new MySqlConnection(add+port+"Initial Catalog='test';"+user_name+pw);

        }
    }
}
