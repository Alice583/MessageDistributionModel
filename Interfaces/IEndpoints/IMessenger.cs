using Itmo.ObjectOrientedProgramming.Lab3.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

public interface IMessenger
{
    void Transfer(Message message);
}