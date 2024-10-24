namespace Domain.ValueObjects;
using Domain.Exceptions;

public record ContactInfo
{
    public PhoneNumber PhoneNumber{ get; init; } = string.Empty;
    public EmailAddress EmailAddress{ get; init; } = string.Empty;
    public Website Website{ get; init; } = string.Empty;
    public Fax Fax{ get; init; } = string.Empty;
    
    public ContactInfo(PhoneNumber phoneNumber,
                       EmailAddress emailAddress,
                       Website website,
                       Fax fax)
    {
        phoneNumber = PhoneNumber;
        emailAddress = EmailAddress;
        website = Website;
        fax = Fax;
    }
}
