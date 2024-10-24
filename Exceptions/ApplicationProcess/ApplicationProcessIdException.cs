using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessIdException : ApplicationProccessException
{
    public ApplicationProccessIdException(): base("ApplicationProcessId can not be null or empty")
    {

    }
}