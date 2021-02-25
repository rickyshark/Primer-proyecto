using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Proyect.Recursos
{
    public static class MoldeNotificaciones
    {
         public static string DevolverNotificacion(Tuple<bool, string> tuple)
        {
            return
              "<script>" +
              $"swal(\"{tuple.Item2}\", \"{(tuple.Item1 ? "Afortunadamente" : "Algo salio mal")}\", \"{(tuple.Item1 ? "success" : "warning")}\")  " +
              "</script>";
            
        }
    }
}
