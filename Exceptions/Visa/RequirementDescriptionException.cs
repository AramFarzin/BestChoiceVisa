using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequirementDescriptionException : VisaException
{
    public RequirementDescriptionException(): base("A description for the requirement must be provided. Please enter a valid description.")
    {

    }
}