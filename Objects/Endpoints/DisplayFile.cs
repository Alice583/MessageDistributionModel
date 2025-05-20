using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;
using static Crayon.Output;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

public class DisplayFile : IDisplay
{
    private Func<string, string> colorText = Black;

    private string? text;

    private string filePath;

    public DisplayFile(string filePath)
    {
        this.filePath = filePath;
    }

    public void ChangeFilePath(string filePath)
    {
        this.filePath = filePath;
    }

    public void ChangeColor(Func<string, string> colorText)
    {
        this.colorText = colorText;
    }

    public void Show(string text)
    {
        this.text = text;
        File.WriteAllText(filePath, colorText(this.text));
    }

    public void Clear()
    {
        text = null;
        colorText = Black;
        File.Delete(filePath);
    }
}