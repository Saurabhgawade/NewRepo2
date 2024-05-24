using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB1.Models;

namespace MongoDB1
{
    public class SessionService:ISession
    {
        private readonly IMongoCollection<Session> _Session;
        public SessionService(IOptions<MongoDBConnection>setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _Session = db.GetCollection<Session>(setting.Value.CollectionName);
            


        }

        public Session getSessionById(string id)
        {
            return _Session.Find(x => x.Id == id).FirstOrDefault();
        }

        public List<Session> getSessions()
        {
            return _Session.Find(x =>true).ToList();
            
        }

        //public List<Session> getSessions()
        //{
        //    return _Session.Find(x => true).ToList();
        //}
    }
}
