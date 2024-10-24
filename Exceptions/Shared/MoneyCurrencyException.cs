using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class MoneyCurrencyException : MoneyException
{
    public MoneyCurrencyException(): base("The selected currency is not recognized. Please select a currency from the available list.")
    {
    }
}