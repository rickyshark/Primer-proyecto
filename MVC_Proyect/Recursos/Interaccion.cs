using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Proyect.Recursos
{
    public static class Interaccion
    {
         public static string DevolverNotificacion(Tuple<bool, string> tuple)
         {
            return
              "<script>" +
              $"swal(\"{tuple.Item2}\", \"{(tuple.Item1 ? "Afortunadamente" : "Algo salio mal")}\", \"{(tuple.Item1 ? "success" : "warning")}\")  " +
              "</script>";            
         }

         public static string Redireccion(string actionName)
         {
            return
            "<script>" +
            $"window.location.href= '{actionName}'" +
            "</script>";
         }
         
         public static string Redireccion(string actionName, int id)
         {
              return
            "<script>" +            
            $"window.location.href= '{actionName}/{id}'" +
            "</script>";
        }

    }
}
