
namespace Domain.ValueObjects;
public record NoneNegativeDecimalNumber
{
    public decimal Value { get; init;}

    public NoneNegativeDecimalNumber(int value)
    {
        if (value >= 0)
        {
            throw new ArgumentException("The property cannot be Negetive.", nameof(value));
        }

        Value = value;
    }
}
