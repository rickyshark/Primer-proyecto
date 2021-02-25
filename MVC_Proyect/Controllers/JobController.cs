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
        public IActionResult ScreenPrincipalView()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult SearchJob()
        {
            return View();
        }
       
    }
}