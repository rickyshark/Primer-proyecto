using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Models
{
    public class Offer_Job_Model
    {
        public Offer_Job_Model(int id, string posicion, string tipo, string categoria, string descripcion, string requisitos, string compañia, DateTime? fecha, string logo, string ciudad, string poster_Name, string poster_Apellido, string telefono, string uRL, string email_emp, string email)
        {
            Id = id;
            Posicion = posicion;
            Tipo = tipo;
            Categoria = categoria;
            Descripcion = descripcion;
            Requisitos = requisitos;
            Compañia = compañia;
            Fecha = fecha;
            Logo = logo;
            Ciudad = ciudad;
            Poster_Name = poster_Name;
            Poster_Apellido = poster_Apellido;
            Telefono = telefono;
            URL = uRL;
            Email_emp = email_emp;
            Email = email;
        }

        [Key]
        public int Id { get; set; }
        public string Posicion { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Requisitos { get; set; }
        public string Compañia { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }
        public string Logo { get; set; }
        public string Ciudad { get; set; }
        public string Poster_Name { get; set; }
        public string Poster_Apellido { get; set; }
        public string Telefono { get; set; }
        public string URL { get; set; }
        public string Email_emp { get; set; }
        public string Email { get; set; }

    }
}
