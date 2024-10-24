using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class FaxException : ContactInfoException
{
    public FaxException(): base("Invalid fax number: Please check your input and ensure it follows the correct format.")
    {
    }
}