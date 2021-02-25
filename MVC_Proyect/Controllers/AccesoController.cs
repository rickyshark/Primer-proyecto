using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Proyect.Models;

namespace MVC_Proyect.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Form(Offer_Job offer_Job)
        {
            return View(offer_Job);
        }

        [HttpPost]
        public IActionResult PostJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = offer_Job.Post();
            }

            return RedirectToAction("Form", offer_Job);
        }

        public IActionResult PutJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = offer_Job.Put();
            }

            return RedirectToAction("Form", offer_Job);
        }


    }
}
