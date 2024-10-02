using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using jobayer_alam_24_ICTBD_MVC_Project_2.Models;
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
        //Attributes: adds validation
        [HttpPost]
        public IActionResult CheckForm(TeachersData teachersData)
        {
            if(ModelState.IsValid)
            {
                TempData["name"] = teachersData.FullName;
                TempData["email"] = teachersData.Email;
                TempData["phone"] = teachersData.PhoneNumber;
                TempData["subject"] = teachersData.SpecialSubject;
                ViewData["ex"] = teachersData.ExperienceYear;

                return RedirectToAction("TeachersInfoData");
            }
            else
            {
                return View("TeachersInfo");
            }
        } 
        

        public IActionResult TeachersInfo()
        {
            return View();
        }
        public IActionResult TeachersInfoData()
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