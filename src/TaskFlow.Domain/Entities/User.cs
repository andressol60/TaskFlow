namespace TaskFlow.Domain.Entities;

using TaskFlow.Domain.Exceptions;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    //invariante = regla que siempre ddebe cumplirse ejem: name no puede estar vacio...
    public User(Guid id, string name, string lastName, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DomainException("Name cannot be empty");
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new DomainException("Last Name cannot be empty");
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new DomainException("Email cannot be empty");
        }

        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
    }
}