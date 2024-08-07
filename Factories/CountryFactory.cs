using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class CountryFactory
    {
        internal Country Create(RequiredString name, int code)
        {
            return new Country(name, code);
        }
    }
}
