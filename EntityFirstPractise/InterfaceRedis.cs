namespace EntityFirstPractise
{
    public interface InterfaceRedis
    {
        Task<T> getRedisData<T>(string key);
        Task<object> removeRedisData(string key);
        Task<bool> setRedisData<T>(string key, T Value);
    }
}
