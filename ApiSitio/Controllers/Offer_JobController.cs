using ApiSitio.Contexts;
using ApiSitio.Entities;
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
        public IEnumerable<dynamic> Get()
        {
            var Oferta_With_User_Information = context.Offer_Job.Join(context.Usuario1, Offer => Offer.Id_Usuario, User => User.ID, (Offer, User) => new { Offer, User.Email_emp, User.URL, User.Telefono, User.Email }).ToList();

            List<dynamic> dynamics = new List<dynamic>();
            dynamics.Add(Oferta_With_User_Information);

            return dynamics;
        }
        // GET api/<Offer_JobController>/5
        [HttpGet("{ID}")]
        public Offer_Job Get(int ID)
        {
            var offerJob = context.Offer_Job.FirstOrDefault(x => x.Id == ID);
            return offerJob;
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
