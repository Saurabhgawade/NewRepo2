namespace DemoEntity.Interface
{
    public interface IRedisCache
    {
       Task<T> GetCacheData<T>(string key);

       Task<object> RemoveData(string key);

        Task<bool> SetCacheData<T>(string key, T value, DateTimeOffset expiry_date);
    }
}
