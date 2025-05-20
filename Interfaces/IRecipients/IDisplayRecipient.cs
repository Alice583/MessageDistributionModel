using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;

public interface IDisplayRecipient : IRecipient
{
    void ChangeDisplayDriver(DisplayDriver displayDriver);
}