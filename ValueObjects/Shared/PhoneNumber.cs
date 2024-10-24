using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record PhoneNumber
{
    public string Value { get; init;}

    public PhoneNumber(string value)
    {

        if (!IsValidPhoneNumber(value))
        {
           throw new PhoneNumberException();
        }

        Value = new string(value);
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        var phoneNumberRegex = new Regex(@"(\+|00)?\d{1,4}[\.-]?\d{1,4}[\.-]?\d{1,9}((,|;|\/)(\+|00)?\d{1,4}[\.-]?\d{1,4}[\.-]?\d{1,9})*", RegexOptions.Compiled);
        return phoneNumberRegex.IsMatch(phoneNumber);
    }
    
    public static implicit operator string(PhoneNumber str) => str.Value;
    public static implicit operator PhoneNumber(string str) => new(str);
}
