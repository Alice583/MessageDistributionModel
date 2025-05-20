using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

public interface IUserRecipient : IRecipient
{
    void ChangeUser(User user);
}