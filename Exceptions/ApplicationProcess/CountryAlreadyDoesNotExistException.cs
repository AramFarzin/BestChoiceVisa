using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CountryAlreadyDoesNotExistException : ApplicationProccessException
{
    public CountryAlreadyDoesNotExistException(string countryName, string visaApplicationCenter): base($"{countryName} already does not exist in this list of {visaApplicationCenter}.")
    {

    }
}