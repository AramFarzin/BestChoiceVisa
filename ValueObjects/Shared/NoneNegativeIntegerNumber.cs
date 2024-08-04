
namespace Domain.ValueObjects;
public record NoneNegativeIntegerNumber
{
    public int Value { get; init;}

    public NoneNegativeIntegerNumber(int value)
    {
        if (value >= 0)
        {
            throw new ArgumentException("The property cannot be Negetive.", nameof(value));
        }

        Value = value;
    }
}
