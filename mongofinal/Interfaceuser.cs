using mongofinal.Models;

namespace mongofinal
{
    public interface Interfaceuser
    {
        Users getUserById(string Id);
        List<Users> getAllUsers();
    }

}
