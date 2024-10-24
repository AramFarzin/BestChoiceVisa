using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class CountryFactory
    {
        internal Country Create(string name, string dialingCode, Currency currency, TimeZoneInfo timeZone, List<Language> languageList )
        {
            return new Country(name, dialingCode: dialingCode, currency, timeZone, languageList);
        }
    }
}
