using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ConditionAlreadyExistsException : ApplicationProccessException
{
    public ConditionAlreadyExistsException(string description): base($"{description} as a condition already exists.")
    {

    }
}