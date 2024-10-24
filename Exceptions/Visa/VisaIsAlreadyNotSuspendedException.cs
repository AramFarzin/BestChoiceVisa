using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaIsAlreadyNotSuspendedException : VisaException
{
    public VisaIsAlreadyNotSuspendedException(): base("The action cannot be completed because the visa is already not suspended. Please check the visa status.")
    {

    }
}