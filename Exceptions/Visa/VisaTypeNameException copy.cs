using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class DocumentTypeNameException : VisaException
{
    public DocumentTypeNameException(): base("The selected document type is not recognized. Please select a document type from the available list.")
    {

    }
}