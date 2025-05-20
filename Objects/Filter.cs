using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects;

public class Filter : IRecipient
{
    private readonly IRecipient _recipient;

    private readonly int _importance;

    public Filter(IRecipient recipient, int importance)
    {
        _recipient = recipient;
        this._importance = importance;
    }

    public void Send(Message message)
    {
        if (message.Level >= _importance)
        {
            _recipient.Send(message);
        }
    }
}