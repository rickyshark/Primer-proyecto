using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using MVC_Proyect.Recursos;
using MVC_Proyect.Recursos.Interface;

namespace MVC_Proyect.Models
{
    public class Usuario1 : RequestProperties, IPost, IPut, IGet, IDelete
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public int Telefono { get; set; }
        public string Email_emp { get; set; }
        public string Username { get; set; }
        
        public Usuario1()
        {
            DIRECTORIO_API = "Usuario1";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await
               PETICION_HTTP.PostAsync(URL+ DIRECTORIO_API, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return null;
            else
                return MoldeNotificaciones.DevolverNotificacion(
                     new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));
        }

        public async Task<string> Put()
        {
            RESPUESTA_HTTP = await
                PETICION_HTTP.PutAsync(URL + DIRECTORIO_API + "/"+ ID, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return MoldeNotificaciones.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Informacion de Usuario Actualizado con Exito !"));
            else
                return MoldeNotificaciones.DevolverNotificacion(
                     new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));
        }

        public async Task<IEnumerable<Object>> Get()
        {
            var json = await
                           PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Usuario1>>(json);
            return Listado;
        }

        public async Task<string> Delete()
        {           
            RESPUESTA_HTTP = await
                            PETICION_HTTP.DeleteAsync(URL + DIRECTORIO_API + "/" + ID);

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return MoldeNotificaciones.DevolverNotificacion(
                                   new Tuple<bool, string>(true, "Usuario Eliminado con Exito !"));
            else
                return MoldeNotificaciones.DevolverNotificacion(
                    new Tuple<bool, string>(false, RESPUESTA_HTTP.RequestMessage.ToString()));            
        }
                    
    }
}
