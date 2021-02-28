using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Proyect.Recursos;
using Newtonsoft.Json;

namespace MVC_Proyect.Models
{
    public class Provincia : RequestProperties
    {
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }

        public Provincia()
        {
            DIRECTORIO_API = "Provincias";
        }

        public async Task<IEnumerable<Provincia>> Get()
        {
            var json = await PETICION_HTTP.GetStringAsync(URL + DIRECTORIO_API);

            var Listado = JsonConvert.DeserializeObject<List<Provincia>>(json);
            return Listado;
        }

    }
}
