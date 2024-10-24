using System.Text.RegularExpressions;
using Domain.Exceptions;
namespace Domain.ValueObjects;
public record Currency
{
    public string CurrencyName { get; init;}
   
    public Currency(string currencyName)
    {
        if (string.IsNullOrWhiteSpace(currencyName))
        {
            throw new  CurrencyNameException();
        }
        this.CurrencyName = currencyName.Trim();
    }
    
    public static implicit operator string(Currency str) => str.CurrencyName;
    public static implicit operator Currency(string str) => new(str);
}