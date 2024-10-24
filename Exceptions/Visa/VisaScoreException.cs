using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaScoreException : VisaException
{
    public VisaScoreException(): base("Visa score can not be null or negative.")
    {

    }
}