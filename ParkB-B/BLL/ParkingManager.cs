using ParkB_B.DAL;
using ParkB_B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.BLL
{
    public static class ParkingManager
    {
        public static List<Parking> GetParkingList()
        {
            ParkingDAO dao = new ParkingDAO();
            return dao.GetParkings();
        }
    }
}
