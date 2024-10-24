using System;
using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record EmailAddress
{
    public string Value { get; init;}

    public EmailAddress(string value)
    {

        if (!IsValidEmail(value))
        {
            throw new EmailAddressException();
        }

        Value = new string(value);
    }

    private static bool IsValidEmail(string email)
    {
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.Compiled);
        return emailRegex.IsMatch(email);
    }

    
    public static implicit operator string(EmailAddress str) => str.Value;
    public static implicit operator EmailAddress(string str) => new(str);
}
