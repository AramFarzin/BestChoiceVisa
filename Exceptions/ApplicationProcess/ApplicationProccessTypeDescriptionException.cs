using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessTypeDescriptionException : ApplicationProccessException
{
    public ApplicationProccessTypeDescriptionException(): base("ApplicationProccessTypeDescription can not be null or empty")
    {

    }
}