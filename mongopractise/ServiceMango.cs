using Microsoft.Extensions.Options;
using MongoDB.Driver;
using mongopractise.Models;

namespace mongopractise
{
    public class ServiceMango : InterfaceMongo
    {
        private readonly IMongoCollection<Session> _sesions;
        public ServiceMango(IOptions<Mongo>setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _sesions = db.GetCollection<Session>(setting.Value.Collection);

        }

        public List<Session> getAllSessions()
        {
            return _sesions.Find(x => true).ToList();
        }

      
    }
}
