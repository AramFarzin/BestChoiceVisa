using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ConditionAlreadyDoesNotExistException : ApplicationProccessException
{
    public ConditionAlreadyDoesNotExistException(string description): base($"{description} as a condition already does not exist.")
    {

    }
}