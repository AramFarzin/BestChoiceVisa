using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class VisaApplicationCenterFactory : IVisaApplicationCenterFactory
{
    public VisaApplicationCenter Create(ProcessingCenterId id,
                                                ProcessingCenterName name,
                                                Address address,
                                                ContactInfo contactInfo,
                                                LinkedList<Country> countryList)
    {
        return new VisaApplicationCenter(id,
                                        name,
                                        address,
                                        contactInfo,
                                        countryList);

    }
}
