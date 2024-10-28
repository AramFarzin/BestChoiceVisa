using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class DocumentTypeIdException : VisaException
{
    public DocumentTypeIdException(): base("Document type Id can not be null or empty")
    {

    }
}