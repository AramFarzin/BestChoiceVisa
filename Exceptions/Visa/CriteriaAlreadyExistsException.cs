using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CriteriaAlreadyExistsException : ApplicationProccessException
{
    public CriteriaAlreadyExistsException(string description): base($"{description} as a criteria already exists.")
    {

    }
}