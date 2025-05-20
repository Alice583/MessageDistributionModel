using Itmo.ObjectOrientedProgramming.Lab3.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

public interface IUser
{
    bool ReadMessage(Message message);

    bool IsMessageRead(Message message);

    void TakeMessage(Message message);

    string WriteInfo();
}