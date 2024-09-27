using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using jobayer_alam_24_ICTBD_MVC_Project_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jobayer_alam_24_ICTBD_MVC_Project_2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

        public IActionResult StudentsInfo()
        {
            
            ViewBag.ID_one = 1;
            ViewData["name1"] = "Sheikh Jobayer Alam";
            ViewBag.Age_one = 13;
            ViewBag.Roll_one = 2;
            ViewData["department1"] = "IT Support & IOT";
            ViewData["grade1"] = 5.00;
            ViewData["captain2"] = false;

            ViewBag.ID_two = 2;
            ViewData["name2"] = "Raisa Sultana";
            ViewData["department2"] = "Electronics";
            ViewBag.Roll_two = 1;
            ViewBag.Age_two = 11;
            ViewBag.IsClassCaptain = true;
            ViewData["grade2"] = 5.00;

            ViewBag.ID_three = 3;
            ViewData["name3"] = "Tasnim Karim";
            ViewBag.Age_three = 13;
            ViewBag.Roll_three = 3;
            ViewData["department3"] = "Electronics";
            ViewBag.Grade3 = 5.00;
            ViewData["angryMode"] = "Furious";

            Address addresses = new Address()
            {
                City = "Dhaka",
                Region = "Mirpur 10",
                PostalCode = "4442",
                Country = "Bangladesh"
            };
            ViewData["addressObject"] = addresses;

            BookLists bookLists = new BookLists();
            ViewData["bookLists"] = bookLists;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}