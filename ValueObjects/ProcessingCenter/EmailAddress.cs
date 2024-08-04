using System;
using System.Text.RegularExpressions;

namespace Domain.ValueObjects;
public record EmailAddress
{
    public RequiredString Value { get; init;}

    public EmailAddress(string value)
    {

        if (!IsValidEmail(value))
        {
            throw new ArgumentException("Invalid email address format.", nameof(value));
        }

        Value = new RequiredString(value);
    }

    private static bool IsValidEmail(string email)
    {
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        return emailRegex.IsMatch(email);
    }
}
