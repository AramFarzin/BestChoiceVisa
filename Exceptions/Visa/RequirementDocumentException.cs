using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequirementDocumentException : VisaException
{
    public RequirementDocumentException(): base("The selected document is not recognized. Please select a ducument from the available list.")
    {

    }
}