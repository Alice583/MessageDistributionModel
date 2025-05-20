using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;
using Itmo.ObjectOrientedProgramming.Lab3.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces;

public interface ITopic
{
    string Name { get; }

    void Send(Message message);

    void AddRecipient(IRecipient recipient);
}