using System.Collections.Generic;
using MyCities.Models;

using Microsoft.AspNetCore.Mvc;

namespace MyCities.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LocationLists model = new LocationLists();
            var locations = new List<Location>()
            {
                 new Location(1, "Bhubaneswar","Bhubaneswar, Odisha", 48.85341, 2.3488),
                 new Location(2, "Hyderabad","Hyderabad, Telengana", 17.387140, 78.491684),
                 new Location(3, "Bengaluru","Bengaluru, Karnataka", 12.972442, 77.580643)
            };

            model.LocationList = locations;

            return View(model);


        }
    }
}