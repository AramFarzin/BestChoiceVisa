using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public interface IVisaApplicationCenterFactory
{      
    public VisaApplicationCenter Create(ProcessingCenterId id,
                                                ProcessingCenterName name,
                                                Address address,
                                                ContactInfo contactInfo,
                                                LinkedList<Country> countryList);
}