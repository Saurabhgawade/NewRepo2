namespace RedisCache.Interface
{
    public interface IRedisCache
    {
        Task<T> GetCacheData<T>(string key);
        Task<object> RemoveCacheData(string key);

        Task<bool> SetData<T>(string key, T value, DateTimeOffset expiryTime);
    }
}
