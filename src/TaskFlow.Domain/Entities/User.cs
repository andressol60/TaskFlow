namespace TaskFlow.Domain.Entities;

using TaskFlow.Domain.Exceptions;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    //invariante
    public User(Guid id, string name, string lastName, string email)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new DomainException("Name cannot be empty");
        }

        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
    }
}