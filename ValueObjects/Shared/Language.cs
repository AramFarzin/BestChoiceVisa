using Domain.Exceptions;
namespace Domain.ValueObjects;
public record Language
{
    public string LanguageName { get; init;}
   
    public Language(string languageName)
    {
        if (string.IsNullOrWhiteSpace(languageName))
        {
            throw new  LanguageNameException();
        }
        LanguageName = languageName.Trim();
    }
    
    public static implicit operator string(Language str) => str.LanguageName;
    public static implicit operator Language(string str) => new(str);
}