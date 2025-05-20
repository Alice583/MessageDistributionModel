namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

public interface IDisplay
{
    void ChangeColor(Func<string, string> colorText);

    void Show(string text);

    void Clear();
}