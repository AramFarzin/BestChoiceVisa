using Domain.Exceptions;
using Shared.Abstraction.Primitives;

namespace Domain.ValueObjects;
public record Money
{
    public Currency Currency { get; init;}
    public decimal Amount { get; init;} = 0;

    public Money(Currency currency, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(currency.ToString()) && amount>0)
        {
            throw new MoneyCurrencyException();
        }
        
        if (amount < 0)
        {
            throw new MoneyAmountException();
        }

        Currency = currency;
        Amount = amount;
    }
}
