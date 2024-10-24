using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class VisaApplicationCenter : ProcessingCenter
{
    [Required]
    private readonly LinkedList<Country> _countryList = new();

    private VisaApplicationCenter(ProcessingCenterId id,
                                 ProcessingCenterName name,
                                 Address address,
                                 ContactInfo contactInfo) : base(id, name, address, contactInfo)
    {
    }

    private VisaApplicationCenter(ProcessingCenterId id,
                                 ProcessingCenterName name,
                                 Address address,
                                 ContactInfo contactInfo,
                                 LinkedList<Country> countryList) : base(id, name, address, contactInfo)
    {
        _countryList = countryList;
    }

    public static VisaApplicationCenter Create(ProcessingCenterId id,
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

    public void Add(Country country)
    {
        _countryList.AddLast(country);
    }
    
    public void Remove(Country country)
    {
        _countryList.Remove(country);
    }
}