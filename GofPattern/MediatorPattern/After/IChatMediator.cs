
namespace MediatorPattern.After
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddPerson(User user);
    }
}
