using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequirementAlreadyDoesNotExistException : ApplicationProccessException
{
    public RequirementAlreadyDoesNotExistException(string description): base($"{description} as a visa requirement already does not exist.")
    {

    }
}