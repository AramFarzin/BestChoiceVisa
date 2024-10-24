using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class EmailAddressException : ContactInfoException
{
    public EmailAddressException(): base("Invalid email address: Please check your input and ensure it follows the correct email format (e.g., example@domain.com).")
    {
    }
}