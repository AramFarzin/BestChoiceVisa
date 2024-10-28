using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Domain.Exceptions;
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

    public Country? FindCountry(Country country)
    {
        var existingCountry = _countryList.SingleOrDefault(i => i.CountryName == country.CountryName);
        return existingCountry;
    }

    public void Add(Country country)
    {
        var existingCountry = FindCountry(country);

        if(existingCountry != null)
        {
            throw new CountryAlreadyExistsException(country.CountryName, Name);
        }

        _countryList.AddLast(country);
    }
    
    public void Add(List<Country> countries)
    {
        foreach (var country in countries)
        {
            Add(country);
        } 
    }

    public void Remove(Country country)
    {
        var existingCountry = FindCountry(country);

        if(existingCountry == null)
        {
            throw new CountryAlreadyDoesNotExistException(country.CountryName, Name);
        }
        _countryList.Remove(existingCountry);
    }

    public void Remove(List<Country> countries)
    {
        foreach (var country in countries)
        {
            Remove(country);
        } 
    }
}