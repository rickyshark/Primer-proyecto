using MVC_Proyect.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Proyect.Recursos.Interface;
using Newtonsoft.Json;

namespace MVC_Proyect.Models
{
    public class Categoria : RequestProperties, IPost, IPut, IDelete
    {
        public int Id { get; set; }
        public string nombreCategoria { get; set; }

        public Categoria()
        {
            DIRECTORIO_API = "Categoria";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PostAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Categoria de puesto de Trabajo Creada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

        public async Task<string> Put()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PutAsync(URL + DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Categoria de puesto de Trabajo Actualizada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

        public async Task<IEnumerable<Categoria>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return Listado;
        }

        public async Task<string> Delete(int id)
        {
            RESPUESTA_HTTP = await PETICION_HTTP.DeleteAsync(URL + DIRECTORIO_API + "/" + id);

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Categoria de puesto de Trabajo Eliminada con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(false, REQUEST_ISSUES));
        }



    }
}
