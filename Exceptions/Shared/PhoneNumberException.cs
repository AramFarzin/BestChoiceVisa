using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class PhoneNumberException : ContactInfoException
{
    public PhoneNumberException(): base("The phone numbers you provided are not valid. Ensure each number is formatted correctly and separate multiple numbers with /, ;, or - (e.g., +1234567890; +9876543210).")
    {
    }
}