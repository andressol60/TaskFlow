namespace TaskFlow.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    //invariante
    public User(Guid id, string name, string lastName, string email)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
    }
}