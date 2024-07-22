using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class VisaApplicationCenter : ProcessingCenter
{
    [Required]
    public List<Guid> EmbassyIds  { get; private set; }

    public VisaApplicationCenter(Guid id,
                                 string name,
                                 Address address,
                                 ContactInfo contactInfo,
                                 List<Guid> embessyIds) : base(id, name, address, contactInfo)
    {
        EmbassyIds = embessyIds;
    }

    public void AddEmbassy(Guid embessyId)
    {
        EmbassyIds.Add(embessyId) ;
    }
    
    public void RemoveEmbassy(Guid embessyId)
    {
        EmbassyIds.Remove(embessyId) ;
    }
}