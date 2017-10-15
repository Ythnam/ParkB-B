using ParkB_B.BLL;
using ParkB_B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Description résumée de GetAvailableSpot
/// </summary>
[WebService(Namespace = "http://his-2017/ParkBnb")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]
public class ParkBnbAPI : System.Web.Services.WebService
{

    public ParkBnbAPI()
    {
    }

    [WebMethod]
    public int GetAvailableSpot(int carParkId)
    {
        return ParkingManager.GetAvailableCount(carParkId);
    }

    [WebMethod]
    public User GetUserInfo(int UserId)
    {
        return new User("John", "Doe", "12FE1456");
    }

    [WebMethod]
    public List<Parking> GetParkingList()
    {
        List<Parking> list = ParkingManager.GetParkingList();
        return list;
    }

    [WebMethod]
    public List<Parking> GetParkingListByName(string name)
    {
        List<Parking> list = GetParkingList();
        return list.Where(p=>p.Name.ToLower().Contains(name.ToLower())).ToList();
    }


}
