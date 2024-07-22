using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class Consulate : ProcessingCenter
{
    [Required]
    public Guid EmbassyId { get; private set; }

    public Consulate(Guid id,
                     string name,
                     Address address,
                     ContactInfo contactInfo,
                     Guid embassyId) : base(id, name, address, contactInfo)
    {
        EmbassyId = embassyId;
    }
}