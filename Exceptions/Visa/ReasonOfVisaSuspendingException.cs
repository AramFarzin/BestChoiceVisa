using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ReasonOfVisaSuspendingException : VisaException
{
    public ReasonOfVisaSuspendingException(): base("A reason for suspending the visa is required and cannot be null. Please provide a valid reason.")
    {

    }
}