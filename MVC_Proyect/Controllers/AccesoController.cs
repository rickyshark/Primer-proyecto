﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Proyect.Models;

namespace MVC_Proyect.Controllers
{
    public class AccesoController : Controller
    {


        public async Task<ActionResult> PosterDashboard(int id)
        {
            Offer_Job Job = new Offer_Job();
            Usuario1 user = new Usuario1();

            var users = await user.Get();
            var empleos = await Job.Get();



            var usuario = users.Where(x => x.ID == id).First();
            ViewData["Jobs"] = empleos.Where(x => x.Email == usuario.Email).ToList();
            ViewData["Poster"] = usuario;
            return View();
        }



        //Vista del Login para iniciar sesion
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // Metodo para comprobar si x usuario existe 
        [HttpPost]
        public async Task<IActionResult> Login(Usuario1 user)
        {
            // metodo para validar
            TempData["Notificacion"] = await user.TryLogin();

            return View();
        }

        // Vista para el registro 
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // Insertar registro
        [HttpPost]
        public async Task<ActionResult> Register(Usuario1 user)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = await user.Post();
                return View();
            }

            return View(user);
        }


        /*Vista del formulario para postear el trabajo*/
        [HttpGet]
        public async Task<ActionResult> PostJob()
        {
            ViewData["Listado_Categorias"] = await LoadResource.DropDownListCategorias();
            return View();
        }

        /*Postear oferta*/
        public async Task<IActionResult> PostJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = await offer_Job.Post();
                return View(); // donde corresponda
            }

            ViewData["Listado_Categorias"] = await LoadResource.DropDownListCategorias();
            return View(offer_Job);
        }

        /*Actualizar oferta*/
        public async Task<IActionResult> PutJob(Offer_Job offer_Job)
        {
            if (ModelState.IsValid)
            {
                TempData["Notificacion"] = offer_Job.Put();
                return RedirectToAction(""); //donde corresponda
            }

            return RedirectToAction("PostJob", offer_Job);
        }

        /*Eliminar oferta*/
        public async Task<IActionResult> DeleteJob(Offer_Job id_oferta)
        {
            TempData["Notificacion"] = id_oferta.Delete(id_oferta.id);
            return RedirectToAction(""); //donde corresponda
        }

    }

    public static class LoadResource
    {
        public static async Task<List<SelectListItem>> DropDownListCategorias()
        {
            var listadoCategorias = await new Categoria().Get();

            var dropdownListCategorias = listadoCategorias.ToList().ConvertAll(d =>
             new SelectListItem()
             {
                 Text = d.nombreCategoria,
                 Value = d.Id.ToString(),
                 Selected = false
             });

            return dropdownListCategorias;
        }
    }

}
