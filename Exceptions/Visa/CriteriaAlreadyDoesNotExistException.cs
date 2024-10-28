using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CriteriaAlreadyDoesNotExistException : ApplicationProccessException
{
    public CriteriaAlreadyDoesNotExistException(string description): base($"{description} as a criteria already does not exist.")
    {

    }
}