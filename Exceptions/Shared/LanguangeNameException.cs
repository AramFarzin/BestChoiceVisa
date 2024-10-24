using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class LanguageNameException : AddressException
{
    public LanguageNameException(): base("Language name cannot be null or empty.")
    {
    }
}