using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CountryAlreadyExistsException : ApplicationProccessException
{
    public CountryAlreadyExistsException(string countryName, string visaApplicationCenter): base($"{countryName} already exists in this list of {visaApplicationCenter}.")
    {

    }
}