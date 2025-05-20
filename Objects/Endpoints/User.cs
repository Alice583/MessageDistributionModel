using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IBuilders;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IEndpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

public class User : IUser
{
    private readonly string _name;

    private readonly int _age;

    private readonly string _gender;

    private Dictionary<Message, bool> Messages { get; set; } = new Dictionary<Message, bool>();

    private User(string name, int age, string gender)
    {
        _name = name;
        _age = age;
        _gender = gender;
    }

    public bool ReadMessage(Message message)
    {
        if (!Messages[message])
        {
            Messages[message] = true;
            return true;
        }

        return false;
    }

    public bool IsMessageRead(Message message)
    {
        return Messages[message];
    }

    public void TakeMessage(Message message)
    {
        Messages.Add(message, false);
    }

    public string WriteInfo()
    {
        return _name + " " + _age + " " + _gender;
    }

    public static UserBuilder Builder => new User.UserBuilder();

    public class UserBuilder : IUserBuilder
    {
        private string? name;

        private int? age;

        private string? gender;

        public IUserBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public IUserBuilder SetGender(string gender)
        {
            this.gender = gender;
            return this;
        }

        public IUserBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public User Build()
        {
            var user = new User(
            name ?? throw new ArgumentNullException(),
            age ?? throw new ArgumentNullException(),
            gender ?? throw new ArgumentNullException());
            return user;
        }
    }
}