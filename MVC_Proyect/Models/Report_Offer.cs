using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Proyect.Recursos;
using Newtonsoft.Json;
using MVC_Proyect.Recursos.Interface;


namespace MVC_Proyect.Models
{
    public class Report_Offer : RequestProperties, IPost, IPut, IGet
    {
        public int Id { get; set; }
        public int Offer_Jobid { get; set; }
        public string Email { get; set; }
        public string Motivo { get; set; }


        public Report_Offer()
        {
            DIRECTORIO_API = "Report_Offer";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PostAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return MoldeNotificaciones.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Reporte enviado con Exito !"));
            else
                return MoldeNotificaciones.DevolverNotificacion(
                     new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));
        }

        public async Task<string> Put()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PutAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return MoldeNotificaciones.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Reporte actualizado con Exito !"));
            else
                return MoldeNotificaciones.DevolverNotificacion(
                     new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));
        }

        public async Task<IEnumerable<Object>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Offer_Job>>(json);
            return Listado;
        }

        public async Task<string> Delete()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.DeleteAsync(URL + DIRECTORIO_API + "/" + Id);

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return MoldeNotificaciones.DevolverNotificacion(
                                   new Tuple<bool, string>(true, "Reporte Eliminado con Exito !"));
            else
                return MoldeNotificaciones.DevolverNotificacion(
                    new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));
        }
     
    }
}
