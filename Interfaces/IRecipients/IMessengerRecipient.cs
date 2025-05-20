using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

public interface IMessengerRecipient : IRecipient
{
    void ChangeMessenger(Messenger messenger);
}