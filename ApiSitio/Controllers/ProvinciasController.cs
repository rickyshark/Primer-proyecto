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
    public class ProvinciasController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProvinciasController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<Report_OfferController>
        [HttpGet]
        public IEnumerable<Provincias> Get()
        {
            return context.Provincias.ToList();
        }

        // GET api/<Report_OfferController>/5
        [HttpGet("{id}")]
        public Provincias Get(int id)
        {
            var report = context.Provincias.FirstOrDefault(x => x.ProvinciaID == id);
            return report;
        }
    }
}
