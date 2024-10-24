using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ProccessingCenterWebsiteException : ApplicationProccessException
{
    public ProccessingCenterWebsiteException(): base("Invalid ProccessingCenterWebsite URL format.")
    {
    }
}