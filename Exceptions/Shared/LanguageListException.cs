using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class LanguageListException : AddressException
{
    public LanguageListException(): base("Language list cannot be null or empty. Add one or more languages please.")
    {
    }
}