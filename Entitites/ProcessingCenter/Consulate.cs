using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Consulate : ProcessingCenter
{
    //The consulate is related to whic embassy
    [Required]
    private ProcessingCenterId _embassyId;

    private Consulate(ProcessingCenterId id,
                     ProcessingCenterName name,
                     Address address,
                     ContactInfo contactInfo,
                     ProcessingCenterId embassyId) : base(id, name, address, contactInfo)
    {
        _embassyId = embassyId;
    }

    public static Consulate Create(ProcessingCenterId id,
                                   ProcessingCenterName name,
                                   Address address,
                                   ContactInfo contactInfo,
                                   ProcessingCenterId embassyId) 
    {
       return new Consulate(id,
                            name,
                            address,
                            contactInfo,
                            embassyId);
    }
}