using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class EmbassyReasonOfSuspendingException : ApplicationProccessException
{
    public EmbassyReasonOfSuspendingException(): base("A valid reason for suspending the embassy is required. Please provide a reason for the suspension.")
    {
    }
}