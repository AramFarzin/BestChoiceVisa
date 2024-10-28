using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaIdException : VisaException
{
    public VisaIdException(): base("Visa Id can not be null or empty")
    {

    }
}