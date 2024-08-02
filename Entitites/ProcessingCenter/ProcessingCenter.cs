using System.ComponentModel.DataAnnotations;
using Domain.Primitives;

namespace Domain.Entities;
public abstract class ProcessingCenter: Entity
{

    [Required]
    protected string Name { get; private  set; } = string.Empty;
    
    [Required]
    protected Address Address { get; private set; }
    
    [Required]
    protected ContactInfo ContactInfo { get; private set; }
    
    protected ProcessingCenter(ProcessingCenterId id,
                                string name,
                                Address address,
                                ContactInfo contactInfo) : base(id)
    {
        Name = name;
        Address = address;
        ContactInfo = contactInfo;
    }
    
    public void Edit(string name, Address address, ContactInfo contactInfo)
    {
        Name = name;
        Address = address;
        ContactInfo = contactInfo;
    }
}