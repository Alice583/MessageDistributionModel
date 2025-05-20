using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IRecipients;
using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Recipients;

public class DisplayRecipient : IDisplayRecipient
{
    public int Importance { get; private set; }

    private IDisplayDriver displayDriver;

    public DisplayRecipient(int importance, IDisplayDriver displayDriver)
    {
        Importance = importance;
        this.displayDriver = displayDriver;
    }

    public void Send(Message message)
    {
        displayDriver.SetToDisplay(message);
    }

    public void ChangeDisplayDriver(DisplayDriver displayDriver)
    {
        this.displayDriver = displayDriver;
    }
}