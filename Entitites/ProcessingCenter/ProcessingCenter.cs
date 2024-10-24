using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public abstract class ProcessingCenter : AggregateRoot<ProcessingCenterId>
{
    [Required]
    protected ProcessingCenterName Name = string.Empty;
    
    [Required]
    protected Address Address;
    
    [Required]
    protected ContactInfo ContactInfo;
    
    protected ProcessingCenter(ProcessingCenterId id,
                                ProcessingCenterName name,
                                Address address,
                                ContactInfo contactInfo) 
    {
        Id = id;
        Name = name;
        Address = address;
        ContactInfo = contactInfo;
    }
    
    public void Edit(ProcessingCenterName name,
                     Address address,
                     ContactInfo contactInfo)
    {
        Name = name;
        Address = address;
        ContactInfo = contactInfo;
    }
}