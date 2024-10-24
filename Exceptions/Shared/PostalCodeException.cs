using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class PostalCodeException : ContactInfoException
{
    public PostalCodeException(): base("The postal code is required and must follow the correct format. Please enter a valid postal code.")
    {
    }
}