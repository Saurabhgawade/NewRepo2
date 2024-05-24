using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB2.Interface;
using MongoDB2.Models;

namespace MongoDB2
{
    public class UserService:IUser
    {
        private readonly IMongoCollection<User> _User;
        public UserService(IOptions<MongoDBConnection> setting, IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);
            _User = db.GetCollection<User>(setting.Value.CollectionName);

        }

        public List<User> getAllUser()
        {
            return _User.Find(x => true).ToList();
        }

        public User getUserById(string id)
        {
            return _User.Find(x => x.Id == id).FirstOrDefault();
        }
        

    }
}
