using DemoEntity.Interface;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace DemoEntity.Service
{
    public class RedisCache : IRedisCache
    {
        private readonly IDatabase _database;
        public RedisCache(IConnectionMultiplexer connectionMultiplexer)
        {
            _database = connectionMultiplexer.GetDatabase();
            
        }
        public async Task<T> GetCacheData<T>(string key)
        {
           var value=await _database.StringGetAsync(key);
            if (!string.IsNullOrEmpty(value))
            {

                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }

        public async Task<object> RemoveData(string key)
        {
           bool isexist=await _database.KeyExistsAsync(key);
            if (isexist)
            {
                return await _database.KeyDeleteAsync(key);
            }
            return false;
        }

        public async Task<bool> SetCacheData<T>(string key, T value, DateTimeOffset expiry_date)
        {
            TimeSpan time = expiry_date.DateTime.Subtract(DateTime.Now);

            return await _database.StringSetAsync(key, JsonConvert.SerializeObject(value), time);
        }
    }
}
