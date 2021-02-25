using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Proyect.Recursos.Interface
{
    public interface IGet
    {
        Task<IEnumerable<Object>> Get();
    }
}
