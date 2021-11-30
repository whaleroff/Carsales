using Carsales.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Inter
{
    interface IGet 
    {
        T Get<T>(Guid id) where T: class;
        List<T> Get<T>(Func<bool> filter);
    }
}