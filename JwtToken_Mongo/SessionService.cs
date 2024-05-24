using Microsoft.Extensions.Options;
using Mongo2.Model;
using MongoDB.Driver;

namespace Mongo2
{
    public class SessionService:ISession
    {
        private readonly IMongoCollection<Session> _session;
        public SessionService(IOptions<MongoDbConnection>setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);

            _session = db.GetCollection<Session>(setting.Value.Collection);

        }
        public Session GetSessionById(string id)
        {
           return _session.Find(x => x.Id == id).FirstOrDefault();

        }
        public List<Session> AllSessions()
        {
            return _session.Find(x => true).ToList();
        }
    }
}
