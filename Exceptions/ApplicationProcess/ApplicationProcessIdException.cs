using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessIdException : ApplicationProccessException
{
    public ApplicationProccessIdException(): base("Application process Id can not be null or empty")
    {

    }
}