using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Proyect.Recursos.Interface
{
    interface IPost
    {
        Task<string> Post();
    }
}
