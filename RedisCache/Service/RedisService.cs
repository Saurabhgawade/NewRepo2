using Newtonsoft.Json;
using RedisCache.Interface;
using StackExchange.Redis;

namespace RedisCache.Service
{
    public class RedisService:IRedisCache
    {
        private readonly IDatabase _database;
        public RedisService(IConnectionMultiplexer multiplexer)
        {
            _database = multiplexer.GetDatabase();
        }

        public async Task<T> GetCacheData<T>(string key)
        {
           var result= await _database.StringGetAsync(key);
            if (!string.IsNullOrEmpty(result))
            {
               return JsonConvert.DeserializeObject<T>(result);
            }
            return default;
        }

        public async Task<object> RemoveCacheData(string key)
        {
            var result = await _database.KeyExistsAsync(key);
            if (result)
            {
               return await _database.KeyDeleteAsync(key);
            }
            return false;
        }

        public async Task<bool> SetData<T>(string key, T value, DateTimeOffset expiryTime)
        {
            TimeSpan currtime = expiryTime.DateTime.Subtract(DateTime.Now);

            return await _database.StringSetAsync(key, JsonConvert.SerializeObject(value), currtime);
        }
    }
}
