using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        public string NombreCategoria { get; set; }
    }
}
