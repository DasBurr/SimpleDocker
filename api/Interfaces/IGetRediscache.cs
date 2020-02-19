using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface IGetRedisCache
    {
        Task<List<T>> Get<T>(string key);
    }
}
