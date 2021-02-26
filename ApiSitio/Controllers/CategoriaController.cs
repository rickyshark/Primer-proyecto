using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSitio.Contexts;
using ApiSitio.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSitio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext context;

        public CategoriaController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<CorreoController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return context.Categoria.ToList();
        }

        // GET api/<CorreoController>/5
        [HttpGet("{ID}")]
        public Categoria Get(int ID)
        {
            var categoria = context.Categoria.FirstOrDefault(x => x.id == ID);
            return categoria;
        }

        // POST api/<CorreoController>
        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<CorreoController>/5
        [HttpPut("{ID}")]
        public ActionResult Put(int ID, [FromBody] Categoria categoria)
        {
            try
            {
                if (categoria.id == ID)
                {
                    context.Entry(categoria).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE api/<CorreoController>/5
        [HttpDelete("{ID}")]
        public ActionResult Delete(int ID)
        {
            try
            {
                var categoria = context.Categoria.FirstOrDefault(x => x.id == ID);
                if (categoria != null)
                {
                    context.Categoria.Remove(categoria);
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
