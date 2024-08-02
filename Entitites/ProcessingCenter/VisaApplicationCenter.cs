using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public sealed class VisaApplicationCenter : ProcessingCenter
{
    [Required]
    private HashSet<Country> CountryList  { get; init; } = new();

    private VisaApplicationCenter(Guid id,
                                 string name,
                                 Address address,
                                 ContactInfo contactInfo) : base(id, name, address, contactInfo)
    {
    }

    public static VisaApplicationCenter Create(string name,
                                                Address address,
                                                ContactInfo contactInfo)
    {
        return new VisaApplicationCenter(new Guid(),
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