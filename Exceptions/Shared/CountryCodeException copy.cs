using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class  TimeZoneException: AddressException
{
    public TimeZoneException(): base("The Timezone can not be null or empty. Please verify the country and try again.")
    {
    }
}