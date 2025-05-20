using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using static Crayon.Output;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

public class DisplayDriver : IDisplayDriver
{
    private Func<string, string> colorText = White;

    public IDisplay Display { get; private set; }

    public IMessage? Message { get; private set; }

    public DisplayDriver(IDisplay display)
    {
        Display = display;
    }

    public void TakeMessage(Message message)
    {
        Message = message;
    }

    public void SetToDisplay(Message message)
    {
        Display.Show(message.ToString());
    }

    public void ClearDisplay()
    {
        Message = null;
        colorText = White;
        Display.Clear();
    }

    public void ChangeTextColor(Func<string, string> colorText)
    {
        this.colorText = colorText;
        Display.ChangeColor(this.colorText);
    }

    public void ChangeDisplay(IDisplay display)
    {
        Display = display;
    }
}