using Microsoft.Extensions.Options;
using Mongo.Model;
using MongoDB.Driver;

namespace Mongo
{
    public class UserService:Iusercs
    {
        private readonly IMongoCollection<User> _user;
        public UserService(IOptions<MongoDbConnection> setting,IMongoClient client)
        {
            var db = client.GetDatabase(setting.Value.Database);

            _user = db.GetCollection<User>(setting.Value.Collection);

        }

        public List<User> GetAllUser()
        {
            var result = _user.Find(x=> true).ToList();
            return result;
        }

        public User GetUserById(string id)
        {
            return _user.Find(x => x.Id == id).FirstOrDefault();

        }
    }
}
