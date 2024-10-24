using System;
using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record PostalCode
{
    public string Value { get; init;}

    public PostalCode(string value)
    {

        if (!IsValidPostalCode(value))
        {
            throw new PostalCodeException();
        }

        Value = new string(value);
    }

    private static bool IsValidPostalCode(string postalCode)
    {
        var PostalCodeRegex = new Regex(@"|^\d{5}(\s?\d{4})?$", RegexOptions.Compiled);
        return PostalCodeRegex.IsMatch(postalCode);
    }
    
    public static implicit operator string(PostalCode str) => str.Value;
    public static implicit operator PostalCode(string str) => new(str);
}
