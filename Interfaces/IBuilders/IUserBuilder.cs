using Itmo.ObjectOrientedProgramming.Lab3.Objects.Endpoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces.IBuilders;

public interface IUserBuilder
{
    IUserBuilder SetName(string name);

    IUserBuilder SetGender(string gender);

    IUserBuilder SetAge(int age);

    User Build();
}