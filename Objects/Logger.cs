using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects;

public class Logger : IRecipient
{
    private readonly IRecipient _recipient;

    public Logger(IRecipient recipient)
    {
        _recipient = recipient;
    }

    public void Send(Message message)
    {
        Console.WriteLine($"Sending message: {message.ToString()}");
        _recipient.Send(message);
    }
}