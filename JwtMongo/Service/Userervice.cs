using JwtMongo.Interface;
using JwtMongo.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace JwtMongo.Service
{
    public class Userervice : IUser
    {
        private readonly IMongoCollection<User> _users;
        public Userervice(IOptions<MongoConnection>setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _users = db.GetCollection<User>(setting.Value.Collection);

        }
        public List<User> AllUser()
        {
           return _users.Find(x => true).ToList();
        }

        public User getById(string id)
        {
            return _users.Find(x => x.Id == id).FirstOrDefault();
        }
    }
}
