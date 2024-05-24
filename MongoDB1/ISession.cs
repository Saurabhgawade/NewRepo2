using MongoDB1.Models;

namespace MongoDB1
{
    public interface ISession
    {
        List<Session> getSessions();
        Session getSessionById(string id);
        
    }
}
