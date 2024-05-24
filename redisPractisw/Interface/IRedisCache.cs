namespace redisPractisw.Interface
{
    public interface IRedisCache
    {
        Task<T> getCacheData<T>(string key);
        Task<object> deleteData(string key);
        Task<bool> setData<T>(string key, T value, DateTimeOffset exp_time);
    }
}
