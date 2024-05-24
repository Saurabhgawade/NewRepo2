using Newtonsoft.Json;
using StackExchange.Redis;

namespace entitycodefirstfinal
{
    public class RedisService:RedisInterface
    {
        private readonly IDatabase _database;
        public RedisService(IConnectionMultiplexer mul)
        {
            _database = mul.GetDatabase();
        }

        public async Task<T> getCacheData<T>(string key)
        {
            var result = await _database.StringGetAsync(key);
            if (!String.IsNullOrEmpty(result))
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
            return default;
        }

        public async Task<object> removeCacheData(string key)
        {
            var result = await _database.KeyExistsAsync(key);
            if (result)
            {
                return await _database.KeyDeleteAsync(key);
            }
            return false;
        }

        public async Task<bool> setCacheData<T>(string key, T Value)
        {
            return await _database.StringSetAsync(key, JsonConvert.SerializeObject(Value));
        }
    }
}
