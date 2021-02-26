using ApiSitio.Contexts;
using ApiSitio.Entities;
using ApiSitio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Offer_JobController : ControllerBase
    {
        private readonly AppDbContext context;
        public Offer_JobController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<Offer_JobController>
        [HttpGet]
        public List<Offer_Job_Model> Get()
        {
            var ofertas = context.Offer_Job.Join(context.Usuario1,
                Ofert => Ofert.Id_Usuario,
                user => user.ID,
                (Ofert, user) => new { Ofert, user })

                .Join(context.Categoria,
                Ofer_Job => Ofer_Job.Ofert.Id_Categoria,
                Categ => Categ.id,
                (Offer_Job, Categ) => new { Offer_Job, Categ })

                .Select(oferta_join => new Offer_Job_Model
                (
                    oferta_join.Offer_Job.Ofert.Id,
                    oferta_join.Offer_Job.Ofert.Posicion,
                    oferta_join.Offer_Job.Ofert.Tipo,
                    oferta_join.Categ.NombreCategoria,
                    oferta_join.Offer_Job.Ofert.Descripcion,
                    oferta_join.Offer_Job.Ofert.Requisitos,
                    oferta_join.Offer_Job.Ofert.Compañia,
                    oferta_join.Offer_Job.Ofert.Fecha,
                    oferta_join.Offer_Job.Ofert.Logo,
                    oferta_join.Offer_Job.Ofert.Ciudad,
                    oferta_join.Offer_Job.user.Nombre,
                    oferta_join.Offer_Job.user.Apellido,
                    oferta_join.Offer_Job.user.Telefono,
                    oferta_join.Offer_Job.user.URL,
                    oferta_join.Offer_Job.user.Email_emp,
                    oferta_join.Offer_Job.user.Email
                )).ToList();
            return ofertas;
        }
        // GET api/<Offer_JobController>/5
        [HttpGet("{ID}")]
        public Offer_Job_Model Get(int ID)
        {
            var ofertas = context.Offer_Job.Join(context.Usuario1,
                Ofert => Ofert.Id_Usuario,
                user => user.ID,
                (Ofert, user) => new { Ofert, user })

                .Join(context.Categoria,
                Ofer_Job => Ofer_Job.Ofert.Id_Categoria,
                Categ => Categ.id,
                (Offer_Job, Categ) => new { Offer_Job, Categ })

                .Select(oferta_join => new Offer_Job_Model
                (
                    oferta_join.Offer_Job.Ofert.Id,
                    oferta_join.Offer_Job.Ofert.Posicion,
                    oferta_join.Offer_Job.Ofert.Tipo,
                    oferta_join.Categ.NombreCategoria,
                    oferta_join.Offer_Job.Ofert.Descripcion,
                    oferta_join.Offer_Job.Ofert.Requisitos,
                    oferta_join.Offer_Job.Ofert.Compañia,
                    oferta_join.Offer_Job.Ofert.Fecha,
                    oferta_join.Offer_Job.Ofert.Logo,
                    oferta_join.Offer_Job.Ofert.Ciudad,
                    oferta_join.Offer_Job.user.Nombre,
                    oferta_join.Offer_Job.user.Apellido,
                    oferta_join.Offer_Job.user.Telefono,
                    oferta_join.Offer_Job.user.URL,
                    oferta_join.Offer_Job.user.Email_emp,
                    oferta_join.Offer_Job.user.Email
                )).ToList().FirstOrDefault(x => x.Id == ID);

            return ofertas;
        }
        // POST api/<Offer_JobController>
        [HttpPost]
        public ActionResult Post([FromBody] Offer_Job offerJob)
        {
            try
            {
                context.Offer_Job.Add(offerJob);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        // PUT api/<Offer_JobController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int ID, [FromBody] Offer_Job offerJob)
        {
            try
            {
                if (offerJob.Id == ID)
                {
                    context.Entry(offerJob).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        // DELETE api/<Offer_JobController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int ID)
        {
            try
            {
                var offerJob = context.Offer_Job.FirstOrDefault(x => x.Id == ID);
                if (offerJob != null)
                {
                    context.Offer_Job.Remove(offerJob);
                    context.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
