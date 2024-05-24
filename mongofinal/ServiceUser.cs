using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using mongofinal.Models;

namespace mongofinal
{
    public class ServiceUser : Interfaceuser
    {
        private readonly IMongoCollection<Users> _users;
        public ServiceUser(IOptions<MongoConnection>setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _users = db.GetCollection<Users>(setting.Value.Collection);
        }

        public List<Users> getAllUsers()
        {
            return  _users.Find(_=>true).ToList();
            
        }

        public Users getUserById(string Id)
        {
            return _users.Find(x => x.Id == Id).FirstOrDefault();
        }
    }
}
