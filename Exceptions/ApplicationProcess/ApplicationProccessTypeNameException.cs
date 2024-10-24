using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessTypeNameException : ApplicationProccessException
{
    public ApplicationProccessTypeNameException(): base("ApplicationProcessTypeName can not be null or empty")
    {

    }
}