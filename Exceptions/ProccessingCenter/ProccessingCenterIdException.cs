using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ProccessingCenterIdException : ProccessingCenterException
{
    public ProccessingCenterIdException(): base("Proccessing center Id can not be null or empty")
    {

    }
}