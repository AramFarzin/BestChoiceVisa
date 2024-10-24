using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ProccessingCenterIdException : ProccessingCenterException
{
    public ProccessingCenterIdException(): base("ProccessingCenterId can not be null or empty")
    {

    }
}