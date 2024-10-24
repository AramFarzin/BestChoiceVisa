using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaIdException : VisaException
{
    public VisaIdException(): base("VisaId can not be null or empty")
    {

    }
}