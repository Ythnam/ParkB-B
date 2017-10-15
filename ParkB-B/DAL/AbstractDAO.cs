using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.DAL
{
    public class AbstractDAO
    {
        public string ConnectionString
        {
            get
            {
                return "Server=243b8f54-a2a4-4bc5-bbc4-0368ed6aacf2.parkpnp-4699.mysql.dbs.scalingo.com;Port=31244;Uid=parkpnp_4699;Pwd=YT1QP7Ult2t2tCOeTIol;Database = parkpnp_4699;";
            }
        }
    }
}
