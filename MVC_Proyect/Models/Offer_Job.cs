﻿    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MVC_Proyect.Recursos;
using Newtonsoft.Json;
using System.Net.Http;
using MVC_Proyect.Recursos.Interface;

namespace MVC_Proyect.Models
{
    public class Offer_Job : RequestProperties, IPost, IPut, IDelete
    {
        [Key]
        public int id { get; set; }
        public int Id_Usuario { get; set; }
        [Required(ErrorMessage = "*")]
        public int Id_Categoria { get; set; }
        [Required(ErrorMessage = "*")]
        public string Compania { get; set; }
        [Required(ErrorMessage = "*")]
        public string Tipo { get; set; }
        public string Logo { get; set; }
        [Required(ErrorMessage = "*")]
        public string Posicion { get; set; }
        [Required(ErrorMessage = "*")]
        public string Ciudad { get; set; }
        public string Url { get; set; }
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "*")]
        public string Requisitos { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }

        public Offer_Job()
        {
            DIRECTORIO_API = "Offer_Job";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PostAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Oferta de trabajo posteada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

        public async Task<string> Put()
        {            
            RESPUESTA_HTTP = await PETICION_HTTP.PutAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Oferta de trabajo Actualizada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

        public async Task<IEnumerable<Offer_Job>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Offer_Job>>(json);
            return Listado;
        }

        public async Task<string> Delete()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.DeleteAsync(URL + DIRECTORIO_API + "/" + id);

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                                   new Tuple<bool, string>(true, "Oferta de trabajo Eliminada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

    }
}
