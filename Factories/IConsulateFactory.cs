using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public interface IConsulateFactory
{      
    public Consulate Create(ProcessingCenterId id,
                                   ProcessingCenterName name,
                                   Address address,
                                   ContactInfo contactInfo,
                                   ProcessingCenterId embassyId);
}
