using Itmo.ObjectOrientedProgramming.Lab3.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IBuilders;

public interface IMessageBuilder
{
    IMessageBuilder SetTitle(string title);

    IMessageBuilder SetBody(string body);

    IMessageBuilder SetLevel(int level);

    Message Build();
}