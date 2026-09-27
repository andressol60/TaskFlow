using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Exceptions;

namespace TaskFlow.Domain.ValueObjects
{
    public class Email
    {
        public string Value{ get; set; }
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
