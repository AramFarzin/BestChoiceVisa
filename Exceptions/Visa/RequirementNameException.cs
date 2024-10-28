using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequirementNameException : VisaException
{
    public RequirementNameException(): base("A name for the document must be provided. Please enter a valid name.")
    {

    }
}