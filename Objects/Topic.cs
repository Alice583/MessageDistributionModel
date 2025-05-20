using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects;

public class Topic : ITopic
{
    public string Name { get; }

    private List<IRecipient> Recipients { get; } = new List<IRecipient>();

    public Topic(string name)
    {
        Name = name;
    }

    public void Send(Message message)
    {
        foreach (IRecipient recipient in Recipients)
        {
            recipient.Send(message);
        }
    }

    public void AddRecipient(IRecipient recipient)
    {
        Recipients.Add(recipient);
    }
}