using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IBuilders;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects;

public class Message : IMessage, IEquatable<Message>
{
    public string Title { get; private set; }

    public string Body { get; private set; }

    public int Level { get; private set; }

    private Message(string title, string body, int level)
    {
        Title = title;
        Body = body;
        Level = level;
    }

    public bool Equals(Message? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Title == other.Title && Body == other.Body && Level == other.Level;
    }

    public override string ToString()
    {
        return Title + " " + Body;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Message)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Body, Level);
    }

    public static MessageBuilder Builder => new Message.MessageBuilder();

    public class MessageBuilder : IMessageBuilder
    {
        private string? title;

        private string? body;

        private int? level;

        public IMessageBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }

        public IMessageBuilder SetBody(string body)
        {
            this.body = body;
            return this;
        }

        public IMessageBuilder SetLevel(int level)
        {
            this.level = level;
            return this;
        }

        public Message Build()
        {
            var message = new Message(
                title ?? throw new ArgumentNullException(),
                body ?? throw new ArgumentNullException(),
                level ?? throw new ArgumentNullException());
            return message;
        }
    }
}