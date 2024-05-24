using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using redisPractisw.Interface;
using StackExchange.Redis;

namespace redisPractisw.Service
{
    public class RedisService:IRedisCache
    {
        private readonly IDatabase _database;
        public RedisService(IConnectionMultiplexer multiplexer)
        {
            _database = multiplexer.GetDatabase();
        }

        public async Task<object> deleteData(string key)
        {
            var result = await _database.KeyExistsAsync(key);
            if (result)
            {
                return await _database.KeyDeleteAsync(key); 
            }
            return false;

        }

        public async Task<T> getCacheData<T>(string key)
        {
           var result=await _database.StringGetAsync(key);
            if (!string.IsNullOrEmpty(result))
            {
                 return JsonConvert.DeserializeObject<T>(result);
            }
            return default;
        }

        public async Task<bool> setData<T>(string key, T value, DateTimeOffset exp_time)
        {
            TimeSpan curr = exp_time.DateTime.Subtract(DateTime.Now);
            return await _database.StringSetAsync(key,JsonConvert.SerializeObject(value), curr);
        }
    }
}
