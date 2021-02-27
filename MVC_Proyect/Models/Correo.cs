using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MVC_Proyect.Recursos;
using MVC_Proyect.Recursos.Interface;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Net.Http;


namespace MVC_Proyect.Models
{
    public class Correo : RequestProperties, IPost
    {
        [Key]
        public int ID { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public int ID_User { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }

        public Correo()
        {
            DIRECTORIO_API = "Correo";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PostAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return null;
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));

        }
       
        public async Task<IEnumerable<Correo>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado =  JsonConvert.DeserializeObject<List<Correo>>(json);
            return Listado;
        }

 
    }
}
