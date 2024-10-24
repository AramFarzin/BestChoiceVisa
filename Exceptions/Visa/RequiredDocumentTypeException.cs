using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class RequiredDocumentTypeException : VisaException
{
    public RequiredDocumentTypeException(): base("The selected document type is not recognized. Please select a ducument type from the available list.")
    {

    }
}