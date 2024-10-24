using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProcessingCenterException : ApplicationProccessException
{
    public ApplicationProcessingCenterException(): base("ApplicationProcessingCenterException can not be null or empty")
    {

    }
}