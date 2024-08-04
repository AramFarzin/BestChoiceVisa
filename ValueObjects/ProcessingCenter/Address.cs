using Domain.Entities;

namespace Domain.ValueObjects;
public record Address(RequiredString Street, RequiredString City, RequiredString State, string PostalCode, Country Country, string Description);
