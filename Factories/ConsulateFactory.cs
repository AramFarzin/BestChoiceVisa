using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class ConsulateFactory : IConsulateFactory
{      
    public Consulate Create(ProcessingCenterId id,
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
