using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Proyect.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MVC_Proyect.Controllers
{
    public class JobController : Controller
    {
        public async Task<IActionResult> ScreenPrincipalView()
        {            
            Offer_Job Job = new Offer_Job();
            var listado = await Job.Get();
            
            return View(listado);
        }

        [HttpGet]
        public async Task<IActionResult> SearchJob()
        {
            Offer_Job Job = new Offer_Job();
            var listado = await Job.Get();
            
            return View(listado);
        }
       
    }
}