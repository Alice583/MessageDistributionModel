namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces;

public interface IMessage
{
    string Title { get; }

    string Body { get; }

    int Level { get; }
}