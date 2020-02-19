using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using api.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace api.Helpers
{
    public class RedisCache : IGetRedisCache, ISetRedisCache
    {
        private readonly IDistributedCache distributedCache;

        public RedisCache(IDistributedCache distributedCache)
        {
            this.distributedCache = distributedCache;
        }

        public async Task<List<T>> Get<T>(string key)
        {
            var encodedModel = await this.distributedCache.GetAsync(key);

            if (encodedModel != null)
            {
                var model = Encoding.UTF8.GetString(encodedModel);
                return JsonConvert.DeserializeObject<List<T>>(model);
            }

            return new List<T>();
        }


        public async Task<bool> Set(string key, object model)
        {
            try
            {
                var json = JsonConvert.SerializeObject(model);

                var encodedModel = Encoding.UTF8.GetBytes(json);

                await this.distributedCache.SetAsync(key, encodedModel);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}
