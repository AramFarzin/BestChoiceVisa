using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CurrencyNameException : AddressException
{
    public CurrencyNameException(): base("Currency name cannot be null or empty.")
    {
    }
}