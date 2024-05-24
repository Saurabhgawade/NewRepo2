using MongoDB2.Models;

namespace MongoDB2.Interface
{
    public interface IUser
    {
        List<User> getAllUser();
        User getUserById(string id);

        User addUser(User user);

    }
}
