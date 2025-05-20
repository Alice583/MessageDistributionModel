using Itmo.ObjectOrientedProgramming.Lab3.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

public interface IDisplayDriver
{
    void SetToDisplay(Message message);

    void ClearDisplay();

    void ChangeTextColor(Func<string, string> colorText);

    void ChangeDisplay(IDisplay display);

    void TakeMessage(Message message);
}