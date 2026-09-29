using TaskFlow.Domain.Exceptions;

namespace TaskFlow.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; }
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("Email cannot be empty.");
            }

            Value = value;
        }
    }
}
