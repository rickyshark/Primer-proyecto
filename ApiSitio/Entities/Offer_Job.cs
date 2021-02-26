using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Entities
{
    public class Offer_Job
    {
        [Key]
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Categoria { get; set; }
        public string Tipo { get; set; }
        public string Logo { get; set; }
        public string Posicion { get; set; }
        public string Ciudad { get; set; }
        public string Descripcion { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }
        public string Requisitos { get; set; }
        public string Compañia { get; set; }


    }
}
