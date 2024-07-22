using System.ComponentModel.DataAnnotations;
using Domain.Primitives;

namespace Domain.Entities;
public abstract class ProcessingCenter: Entity
{

    [Required]
    public string Name { get; private  set; }
    
    [Required]
    public Address Address { get; private set; }
    
    [Required]
    public ContactInfo ContactInfo { get; private set; }
    
    public ProcessingCenter(Guid id,
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