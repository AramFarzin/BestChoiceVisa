using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class Consulate : ProcessingCenter
{
    [Required]
    public ProcessingCenterId EmbassyId { get; private set; }

    private Consulate(ProcessingCenterId id,
                     string name,
                     Address address,
                     ContactInfo contactInfo,
                     ProcessingCenterId embassyId) : base(id, name, address, contactInfo)
    {
        EmbassyId = embassyId;
    }

    public static Consulate Create(ProcessingCenterId id,
                                   string name,
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