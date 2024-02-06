using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAR.Domain.Interfaces
{
    internal interface IDemoARRepositoryBase<T>
        where T : class
    {
        Task<T?> 
    }
}
