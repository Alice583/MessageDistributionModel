using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Recipients;

public class GroupRecipient : IGroupRecipient
{
    public int Importance { get; }

    private List<IRecipient> ListRecipients { get; } = new List<IRecipient>();

    public GroupRecipient(int importance)
    {
        Importance = importance;
    }

    public void Send(Message message)
    {
        foreach (IRecipient recipient in ListRecipients)
        {
            recipient.Send(message);
        }
    }

    public void AddRecipient(IRecipient recipient)
    {
        ListRecipients.Add(recipient);
    }
}