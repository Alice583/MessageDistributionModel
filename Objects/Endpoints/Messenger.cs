using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

public class Messenger : IMessenger
{
    public void Transfer(Message message)
    {
        Console.WriteLine(message.ToString());
    }
}