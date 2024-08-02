using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class Embassy : ProcessingCenter
{
    [Required]
    public Country Country { get; private set; }
    public bool IsSuspended { get; private set; } = false;
    public string ReasonOfSuspending { get; private set; } = string.Empty;

    private Embassy(Guid id,
                   string name,
                   Address address,
                   ContactInfo contactInfo,
                   Country country) : base(id, name, address, contactInfo)
    {
        Country = country;
    }

    public static Embassy Create(string name,
                   Address address,
                   ContactInfo contactInfo,
                   Country country)
    {
        return new Embassy(new Guid(),
                            name, 
                            address,
                            contactInfo, 
                            country);
   }

    public void GetSuspended(string reason)
    {
        if(!IsSuspended)
        {
            ReasonOfSuspending = reason;
            IsSuspended = true;
        }
    }
    
    public void GetOpened()
    {
        if(IsSuspended)
        {
            ReasonOfSuspending = string.Empty;
            IsSuspended = false;
        }
    }
}