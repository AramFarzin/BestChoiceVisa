using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CountryNameException : AddressException
{
    public CountryNameException(): base("Country name cannot be null or empty.")
    {
    }
}