using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using static Crayon.Output;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

public class DisplayConsole : IDisplay
{
    private Func<string, string> colorText = White;

    private string? text;

    public void ChangeColor(Func<string, string> colorText)
    {
        this.colorText = colorText;
    }

    public void Show(string text)
    {
        this.text = text;
        Console.WriteLine(colorText(this.text));
    }

    public void Clear()
    {
        text = null;
        colorText = White;
        Console.Clear();
    }
}