using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jobayer_alam_24_ICTBD_MVC_Project_2.Controllers
{
   
    public class TeachersController : Controller
    {
        private readonly ILogger<TeachersController> _logger;

        public TeachersController(ILogger<TeachersController> logger)
        {
            _logger = logger;
        }

        public IActionResult TeachersInfo()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}