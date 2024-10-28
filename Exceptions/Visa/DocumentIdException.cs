using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class DocumentIdException : VisaException
{
    public DocumentIdException(): base("Document Id can not be null or empty")
    {

    }
}