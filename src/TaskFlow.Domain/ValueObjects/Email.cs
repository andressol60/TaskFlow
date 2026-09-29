using System.Net.Mail;
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
            try
            {
                var email = new MailAddress(value);
            }
            catch
            {
                throw new DomainException("Invalid Email format");
            }

            Value = value;
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Email other)
                return false;

            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
