using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class MoneyAmountException : MoneyException
{
    public MoneyAmountException(): base("The amount must be a valid number in the correct format (e.g., 123.45).")
    {
    }
}