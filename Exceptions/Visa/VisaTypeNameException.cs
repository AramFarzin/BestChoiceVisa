using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class VisaTypeNameException : VisaException
{
    public VisaTypeNameException(): base("The selected visa type is not recognized. Please select a visa type from the available list.")
    {

    }
}