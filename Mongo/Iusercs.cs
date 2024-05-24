using Mongo.Model;

namespace Mongo
{
    public interface Iusercs
    {
        List<User> GetAllUser();
        User GetUserById(string id);
    }
}
