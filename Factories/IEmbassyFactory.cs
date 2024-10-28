using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public interface IEmbassyFactory
{      
    public Embassy Create(ProcessingCenterId id,
                                 ProcessingCenterName name,
                                 Address address,
                                 ContactInfo contactInfo,
                                 Country country);
}