using JwtMongo.Model;

namespace JwtMongo.Interface
{
    public interface IUser
    {
        List<User> AllUser();

        User getById(string id);
    }
}
