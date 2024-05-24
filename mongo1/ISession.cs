using mongo1.Model;

namespace mongo1
{
    public interface ISession
    {
        List<Session> GetSession();

        Session GetSessionById(string id);
    }
}
