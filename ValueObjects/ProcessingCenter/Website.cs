using System.Text.RegularExpressions;
using Domain.ValueObjects;

public record Website
{
    public RequiredString Value { get; init;}

    public Website(string value)
    {
        if (!IsValidWebsite(value))
        {
            throw new ArgumentException("Invalid website URL format.", nameof(value));
        }

        Value = new RequiredString(value);
    }

    private static bool IsValidWebsite(string url)
    {
        var websiteRegex = new Regex(@"^(http|https):\/\/[^\s$.?#].[^\s]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return websiteRegex.IsMatch(url);
    }
}
