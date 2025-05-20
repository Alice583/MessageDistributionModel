using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;
using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Recipients;

public class UserRecipient : IUserRecipient
{
    public int Importance { get; }

    private IUser user;

    public UserRecipient(int importance, IUser user)
    {
        Importance = importance;
        this.user = user;
    }

    public void Send(Message message)
    {
        user.TakeMessage(message);
    }

    public void ChangeUser(User user)
    {
        this.user = user;
    }
}