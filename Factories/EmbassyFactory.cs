using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class EmbassyFactory : IEmbassyFactory
{      
    public Embassy Create(ProcessingCenterId id,
                                 ProcessingCenterName name,
                                 Address address,
                                 ContactInfo contactInfo,
                                 Country country)
    {
        return new Embassy(id,
                            name, 
                            address,
                            contactInfo, 
                            country);
   }
}
