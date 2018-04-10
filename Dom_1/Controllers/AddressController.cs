using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dom_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dom_1.Controllers
{
    public class AddressController : Controller
    {
        //GET Address
        public IActionResult Index()
        {
            Address adr = new Address
            {
                ID = 1,
                FirstName = "John",
                LastName = "Smith",
                Address1 = "23 NW 13th St",
                Address2 = "#134",
                City = "Miami",
                PostalCode = 22431
            };
            //ViewData["Message"] = adr;
            return View(adr);
        }
    }
}