using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone{PhoneID = 7864533, PhoneName = "A50", Manufacturer = "Samsung", MSRP = 400, ScreenSize = 6 ,DateReleased = new DateTime(2019,07,23)}
            };
            return View(phoneList);
        }
    }
}