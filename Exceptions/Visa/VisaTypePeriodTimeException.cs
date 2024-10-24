using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaTypePeriodTimeException : VisaException
{
    public VisaTypePeriodTimeException(): base("The maximum duration for the visa type must exceed the minimum duration. Please adjust the values accordingly.")
    {

    }
}