using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;
using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Recipients;

public class MessengerRecipient : IMessengerRecipient
{
    public int Importance { get; }

    private IMessenger messenger;

    public MessengerRecipient(int importance, IMessenger messenger)
    {
        Importance = importance;
        this.messenger = messenger;
    }

    public void Send(Message message)
    {
        messenger.Transfer(message);
    }

    public void ChangeMessenger(Messenger messenger)
    {
        this.messenger = messenger;
    }
}