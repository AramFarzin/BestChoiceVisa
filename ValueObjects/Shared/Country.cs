using System.Text.RegularExpressions;
using Domain.Exceptions;
namespace Domain.ValueObjects;
public record Country
{
    public string CountryName { get; init;}
    public string DialingCode { get; init;}
    public Currency Currency { get; init;}
    public TimeZoneInfo TimeZone { get; init;}
    public List<Language> LanguageList { get; init;}

    public Country(string countryName,
                   string dialingCode,
                   Currency currency,
                   TimeZoneInfo timeZone,
                   List<Language> languageList)
    {
        if (string.IsNullOrWhiteSpace(countryName))
        {
            throw new CountryNameException();
        }
        
        if (!IsValidDialingCode(dialingCode))
        {
            throw new CountryCodeException();
        }
        if (languageList == null)
        {
            throw new LanguageListException();
        }

        CountryName = countryName.Trim();
        DialingCode = dialingCode.Trim();
        TimeZone = timeZone ?? throw new TimeZoneException();
        Currency = currency;
        LanguageList = languageList;
    }

    public static bool IsValidDialingCode(string code)
    {
        var codeRegex = new Regex(@"^\+?(1[0-9]{1,2}|[2-9][0-9]{0,2})$", RegexOptions.Compiled);
        return codeRegex.IsMatch(code);
    }


    public static implicit operator string(Country str) => str.CountryName;
}