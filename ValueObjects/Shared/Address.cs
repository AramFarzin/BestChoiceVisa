using Domain.Entities;
using Domain.Exceptions;

namespace Domain.ValueObjects;
// TODO: Add StronglyTypedvalues
public record Address
{ 
    public string Street { get; init;} = string.Empty;
    public string City { get; init;} = string.Empty;
    public string State { get; init;} = string.Empty;
    public PostalCode PostalCode { get; init;} = string.Empty;
    public Country Country { get; init;}
    public string Description { get; init;} = string.Empty;

    internal Address(string street,
                     string city,
                     string state,
                     PostalCode postalCode,
                     Country country,
                     string description)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
        Description = description;
    }
}