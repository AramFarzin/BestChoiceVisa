using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessDaysException : ApplicationProccessException
{
    public ApplicationProccessDaysException(): base("Maximum days can not be less than minimum days.")
    {

    }
}