using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MVC_Proyect.Recursos
{
    public abstract class RequestProperties
    {
        protected string URL { get;} = "https://webapi-prog3.azurewebsites.net/api/";
        protected string REQUEST_ISSUES { get; } = "Request Issues";
        protected string DIRECTORIO_API { get; set; }
        protected HttpClient PETICION_HTTP { get; set;} = new HttpClient();
        protected HttpResponseMessage RESPUESTA_HTTP { get; set; } = new HttpResponseMessage();

        protected HttpContent ContenidoHttp(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return new StringContent(json,
                              System.Text.Encoding.UTF8, "application/json");
        }

    }
}
