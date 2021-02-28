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
    public class Usuario1 : RequestProperties, IPost, IPut, IDelete
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="No puede dejar el campo de nombre vacio !")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de apellido vacio !")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de clave vacio !")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de email vacio !")]
        [EmailAddress(ErrorMessage = "No es una direccion de correo valido !")]
        public string Email { get; set; }
        public string Rol { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de telefono vacio !")]
        public string Telefono { get; set; }
        public string Url { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de email empresarial vacio !")]
        [EmailAddress(ErrorMessage = "No es una direccion de correo valido !")]
        public string Email_emp { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo de username vacio !")]
        public string Username { get; set; }
        
        public Usuario1()
        {
            DIRECTORIO_API = "Usuario1";
        }

        public async Task<string> Post()
        {
            RESPUESTA_HTTP = await PETICION_HTTP.PostAsync(URL + DIRECTORIO_API, ContenidoHttp(this));
            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(true, "Te has registrado con exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }   

        public async Task<string> Put()
        {
            RESPUESTA_HTTP = await
                PETICION_HTTP.PutAsync(URL + DIRECTORIO_API + "/"+ ID, ContenidoHttp(this));

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(true, "Informacion de Usuario Actualizado con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                     new Tuple<bool, string>(false, REQUEST_ISSUES));
        }

        public async Task<IEnumerable<Usuario1>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Usuario1>>(json);
            return Listado;
        }

        public async Task<string> Delete()
        {           
            RESPUESTA_HTTP = await PETICION_HTTP.DeleteAsync(URL + DIRECTORIO_API + "/" + ID);

            if (RESPUESTA_HTTP.IsSuccessStatusCode)
                return Interaccion.DevolverNotificacion(
                                   new Tuple<bool, string>(true, "Usuario Eliminado con Exito !"));
            else
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(false, REQUEST_ISSUES));            
        }

        public async Task<string> TryLogin()
        {
            var lst = await Get();

            int idUsuario = lst.ToList().
                Where(x => x.Username == Username && x.Contraseña == Contraseña).
                Select(x => x.ID).FirstOrDefault();
                
            if(idUsuario != 0 && idUsuario.ToString() != null)
                return Interaccion.Redireccion("PosterDashboard", idUsuario);
            else
                return Interaccion.DevolverNotificacion(
                    new Tuple<bool, string>(false, "Username o Contraseña Incorrecta"));
        }

    }
}
