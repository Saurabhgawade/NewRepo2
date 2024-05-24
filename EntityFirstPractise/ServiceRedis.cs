using Newtonsoft.Json;
using StackExchange.Redis;

namespace EntityFirstPractise
{
    public class ServiceRedis:InterfaceRedis
    {
        private readonly IDatabase _database;
        public ServiceRedis(IConnectionMultiplexer mul)
        {
            _database = mul.GetDatabase();
        }

        public async Task<T> getRedisData<T>(string key)
        {
            var result = await _database.StringGetAsync(key);
            if (!string.IsNullOrEmpty(result)){
                return JsonConvert.DeserializeObject<T>(result);
            }
            return default;
        }

        public async Task<object> removeRedisData(string key)
        {
            var result = await _database.KeyExistsAsync(key);
            if (result)
            {
                return await _database.KeyDeleteAsync(key);
            }
            return false;
        }

        public async Task<bool> setRedisData<T>(string key, T Value)
        {
            return await _database.StringSetAsync(key, JsonConvert.SerializeObject(Value));
        }
    }
}
