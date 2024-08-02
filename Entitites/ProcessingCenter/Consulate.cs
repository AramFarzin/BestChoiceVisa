using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class Consulate : ProcessingCenter
{
    [Required]
    public Guid EmbassyId { get; private set; }

    private Consulate(Guid id,
                     string name,
                     Address address,
                     ContactInfo contactInfo,
                     Guid embassyId) : base(id, name, address, contactInfo)
    {
        EmbassyId = embassyId;
    }

    public static Consulate Create(string name,
                     Address address,
                     ContactInfo contactInfo,
                     Guid embassyId) 
    {
       return new Consulate(new Guid(),
                            name,
                            address,
                            contactInfo,
                            embassyId);
    }
}