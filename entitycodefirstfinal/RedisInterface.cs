namespace entitycodefirstfinal
{
    public interface RedisInterface
    {
        Task<T> getCacheData<T>(string key);
        Task<object> removeCacheData(string key);

        Task<bool> setCacheData<T>(string key, T Value);

    }
}
