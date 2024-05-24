using Mongo2.Model;

namespace Mongo2
{
    public interface ISession
    {
        Session GetSessionById(string id);

        List<Session> AllSessions();
    }
}
