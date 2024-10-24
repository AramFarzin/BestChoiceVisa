using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Embassy : ProcessingCenter
{
    [Required]
    private Country _country ;

    [Required]
    private EmbassyIsSuspended _isSuspended;

    private Embassy(ProcessingCenterId id,
                    ProcessingCenterName name,
                    Address address,
                    ContactInfo contactInfo,
                    Country country) : base(id, name, address, contactInfo)
    {
        _country = country;
    }

    public static Embassy Create(ProcessingCenterId id,
                                 ProcessingCenterName name,
                                 Address address,
                                 ContactInfo contactInfo,
                                 Country country)
    {
        return new Embassy(id,
                            name, 
                            address,
                            contactInfo, 
                            country);
   }

    public void SuspendEmbassy(string reason)
    {
        //// If you only set the reason, the status will automatically change to IsSuspended.
        _isSuspended = reason;
    }
    
    public void ReinstateEmbassy()
    {
        //// If you only remove the reason, the status will automatically change to Reinstated.
        _isSuspended = string.Empty;
    }
}