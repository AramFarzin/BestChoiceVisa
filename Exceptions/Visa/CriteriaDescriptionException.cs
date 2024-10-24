using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class CriteriaDescriptionException : VisaException
{
    public CriteriaDescriptionException(): base("A description for the creteria must be provided. Please enter a valid description.")
    {

    }
}