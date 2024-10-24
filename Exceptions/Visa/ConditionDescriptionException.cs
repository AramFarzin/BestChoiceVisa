using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ConditionDescriptionException : VisaException
{
    public ConditionDescriptionException(): base("A description for the condition must be provided. Please enter a valid description.")
    {

    }
}