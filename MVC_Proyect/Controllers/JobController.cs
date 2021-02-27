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
            var lista = await Job.Get();
            ViewData["Ciudades"] = lista.Select(x => x.Ciudad).ToList();
            ViewData["Jobs"] = lista;


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SearchJob()
        {
            Offer_Job Job = new Offer_Job();
            var resultado = await Job.Get();
            ViewData["Ciudades"] = resultado.Select(x => x.Ciudad).ToList();
            ViewData["Jobs"] = resultado;


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SearchJob(Offer_Job job)
        {

            Offer_Job Job = new Offer_Job();
            var listado = await Job.Get();
            ViewData["Ciudades"] = listado.Select(x => x.Ciudad).ToList();

            if (job.Posicion != null)
                listado = listado.Where(x => x.Posicion == job.Posicion).ToList();

            if (job.Ciudad != "0")
                listado = listado.Where(x => x.Ciudad == job.Ciudad).ToList();

            ViewData["Jobs"] = listado;

            return View();

        }

    }
}