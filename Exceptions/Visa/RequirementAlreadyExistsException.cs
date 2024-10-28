using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequirementAlreadyExistsException : ApplicationProccessException
{
    public RequirementAlreadyExistsException(string description): base($"{description} as a visa requirement already exists.")
    {

    }
}