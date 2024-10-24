using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ProccessingCenterNameException : ApplicationProccessException
{
    public ProccessingCenterNameException(): base("ProccessingCenterName can not be null or empty")
    {
    }
}