using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Consulate : ProcessingCenter
{
    //Each consulate is related to an embassy
    [Required]
    private ProcessingCenterId _embassyId;

    internal Consulate(ProcessingCenterId id,
                     ProcessingCenterName name,
                     Address address,
                     ContactInfo contactInfo,
                     ProcessingCenterId embassyId) : base(id, name, address, contactInfo)
    {
        _embassyId = embassyId;
    }    
}