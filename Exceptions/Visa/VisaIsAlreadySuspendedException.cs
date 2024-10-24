using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaIsAlreadySuspendedException : VisaException
{
    public VisaIsAlreadySuspendedException(): base("The action cannot be completed because the visa is already suspended. Please check the visa status.")
    {

    }
}