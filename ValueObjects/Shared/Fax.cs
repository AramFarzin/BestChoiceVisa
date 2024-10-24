using System;
using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Fax
{
    public string Value { get; init;}

    public Fax(string value)
    {

        if (!IsValidFax(value))
        {
            throw new FaxException();
        }

        Value = new string(value);
    }

    private static bool IsValidFax(string email)
    {
        var FaxRegex = new Regex(@"(\+|00)?\d{1,4}[\.-]?\d{1,4}[\.-]?\d{1,9}((,|;|\/)(\+|00)?\d{1,4}[\.-]?\d{1,4}[\.-]?\d{1,9})*", RegexOptions.Compiled);
        return FaxRegex.IsMatch(email);
    }

    public static implicit operator string(Fax str) => str.Value;
    public static implicit operator Fax(string str) => new(str);
}
