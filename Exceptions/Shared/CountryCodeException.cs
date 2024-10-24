using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class  CountryCodeException: AddressException
{
    public CountryCodeException(): base("The dialing code does not match the selected country name. Please verify the country and try again.")
    {
    }
}