using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class VisaApplicationCenter : ProcessingCenter
{
    [Required]
    private HashSet<Country> CountryList  { get; init; } = new();

    private VisaApplicationCenter(ProcessingCenterId id,
                                 string name,
                                 Address address,
                                 ContactInfo contactInfo) : base(id, name, address, contactInfo)
    {
    }

    public static VisaApplicationCenter Create(ProcessingCenterId id,
                                                string name,
                                                Address address,
                                                ContactInfo contactInfo)
    {
        return new VisaApplicationCenter(id,
                                        name,
                                        address,
                                        contactInfo);

    }

    public void Add(Country country)
    {
        CountryList.Add(country);
    }
    
    public void Remove(Country country)
    {
        CountryList.Remove(country);
    }
}