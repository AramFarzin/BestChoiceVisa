using System.Text.RegularExpressions;
using Domain.Exceptions;
using Domain.ValueObjects;

namespace Domain.ValueObjects;
public record Website
{
    public string Value { get; init;}

    public Website(string value)
    {
        if (!IsValidWebsite(value))
        {
            throw new ProccessingCenterWebsiteException();
        }

        Value = new string(value);
    }

    private static bool IsValidWebsite(string url)
    {
        var websiteRegex = new Regex(@"^(http|https):\/\/[^\s$.?#].[^\s]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return websiteRegex.IsMatch(url);
    }
    
    public static implicit operator string(Website str) => str.Value;
    public static implicit operator Website(string str) => new(str);
}
