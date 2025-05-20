namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

public interface IGroupRecipient : IRecipient
{
    void AddRecipient(IRecipient recipient);
}