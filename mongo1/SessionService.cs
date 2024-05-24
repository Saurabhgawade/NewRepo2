using Microsoft.Extensions.Options;
using mongo1.Model;
using MongoDB.Driver;

namespace mongo1
{
    public class SessionService
    {
        private readonly IMongoCollection<Session> _session;
        public SessionService(IOptions<MongoDbConnection> setting, IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _session = db.GetCollection<Session>(setting.Value.Collection);

        }

        public List<Session> GetSessions()
        {
            return _session.Find(x => true).ToList();
        }
        public Session GetSessionById(string id)
        {
            return _session.Find(x => x.Id == id).FirstOrDefault();
        }
    }
}
