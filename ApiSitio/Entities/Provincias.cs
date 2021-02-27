using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Provincias
    {
        [Key]
        public int ProvinciaID { get; set; }
        public string Nombre { get; set; }
    }
}
