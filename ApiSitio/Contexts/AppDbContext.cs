using ApiSitio.Entities;
using ApiSitio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario1> Usuario1 { get; set; }
        public DbSet<Correo> Correo { get; set; }
        public DbSet<Report_Offer> Report_Offer { get; set; }
        public DbSet<Offer_Job> Offer_Job { get; set; }
        public DbSet<Offer_Job_Model> Offer_Job_Model { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
