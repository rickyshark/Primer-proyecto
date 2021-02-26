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
        //Vista del Login para iniciar sesion
        public IActionResult Login(Usuario1 user)
        {
            return View(user);
        }

        // Metodo para comprobar si x usuario existe 
        public IActionResult TryLogin(Usuario1 user)
        {
            // metodo para validar

           return RedirectToAction("Login", user);
        }

        // Vista para el registro 
        public IActionResult Register(Usuario1 user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult TryRegister(Usuario1 user)
        {
            if (ModelState.IsValid)
            {
               return RedirectToAction(""); //donde corresponda
            }

            return RedirectToAction("Register", user); 
        }


        /*Vista del formulario para postear el trabajo*/
        public IActionResult Form(Offer_Job offer_Job)
        {
            return View(offer_Job);
        }

        /*POST*/
        [HttpPost]
        public IActionResult PostJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = offer_Job.Post();
                return RedirectToAction("");
            }

            return RedirectToAction("Form", offer_Job);
        }

        /*PUT*/
        public IActionResult PutJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = offer_Job.Put();
                return RedirectToAction(""); //donde corresponda
            }

            return RedirectToAction("Form", offer_Job);
        }

        /*DELETE*/
        public IActionResult DeleteJob(Offer_Job id_oferta)
        {
            TempData["Notificacion"] = id_oferta.Delete(id_oferta.Id);
            return RedirectToAction(""); //donde corresponda
        }

    }
 }
