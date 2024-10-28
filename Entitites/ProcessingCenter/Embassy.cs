using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Embassy : ProcessingCenter
{
    [Required]
    private Country _country ;

    [Required]
    private EmbassyIsSuspended _isSuspended;

    internal Embassy(ProcessingCenterId id,
                    ProcessingCenterName name,
                    Address address,
                    ContactInfo contactInfo,
                    Country country) : base(id, name, address, contactInfo)
    {
        _country = country;
    }
    
    public void SuspendEmbassy(string reason)
    {
        //// By seting the reason, the status will automatically change to IsSuspended.
        _isSuspended = reason;
    }
    
    public void ReinstateEmbassy()
    {
        //// By removing the reason, the status will automatically change to .
        _isSuspended = string.Empty;
    }
}